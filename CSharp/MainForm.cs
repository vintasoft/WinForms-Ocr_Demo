using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.Encoders;
using Vintasoft.Imaging.ImageProcessing;
using Vintasoft.Imaging.ImageProcessing.Info;
using Vintasoft.Imaging.Ocr;
using Vintasoft.Imaging.Ocr.Results;
using Vintasoft.Imaging.Ocr.Tesseract;
#if !REMOVE_PDF_PLUGIN
using Vintasoft.Imaging.Pdf;
using Vintasoft.Imaging.Pdf.Ocr;
using Vintasoft.Imaging.Pdf.Processing;
#endif
using Vintasoft.Imaging.Processing;
using Vintasoft.Imaging.UI;
using Vintasoft.Imaging.UI.VisualTools;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;


#if !REMOVE_PDF_PLUGIN
using DemosCommonCode.Pdf;
#endif
using DemosCommonCode.Ocr;


namespace OcrDemo
{
    /// <summary>
    /// The main form of OCR Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        #region OCR settings

        /// <summary>
        /// The settings of Tesseract OCR.
        /// </summary>
        TesseractOcrSettings _tesseractOcrSettings;

        /// <summary>
        /// The settings, which define how to split image regions during text recognition.
        /// </summary>
        OcrRecognitionRegionSplittingSettings _ocrRecognitionRegionSplittingSettings;

        /// <summary>
        /// The binarization mode for binarizing images before text recognition.
        /// </summary>
        OcrBinarizationMode _imageBinarizationMode = OcrBinarizationMode.Adaptive;

        /// <summary>
        /// A value indicating whether multiple threads must be used for text recognition.
        /// </summary>
        /// <value>
        /// <b>true</b> - <i>_maxThreads</i> threads must be used for text recognition;
        /// <b>false</b> - 1 thread must be used for text recognition.
        /// </value>
        bool _useMultithreading = true;

        /// <summary>
        /// The maximum count of threads, which can be used for text recognition.
        /// </summary>
        int _maxThreads = Environment.ProcessorCount;

        /// <summary>
        /// Previous OCR languages.
        /// </summary>
        OcrLanguage[] _previousOcrLanguages;

        #endregion


        #region Input: Text recognition regions on images

        /// <summary>
        /// Dictionary (VintasoftImage -> List&lt;RecognitionRegion&gt;),
        /// which contains information about the text recognition regions on images.
        /// </summary>
        Dictionary<VintasoftImage, List<RecognitionRegion>> _imagesToTextRecognitionRegions = new Dictionary<VintasoftImage, List<RecognitionRegion>>();

        /// <summary>
        /// A visual tool that allows to edit the text recognition regions on images
        /// in image viewer.
        /// </summary>
        RecognitionRegionEditorTool _textRecognitionRegionEditorTool = new RecognitionRegionEditorTool();

        /// <summary>
        /// A value indicating whether the recognition region editor tool is updating the focused region.
        /// </summary>
        bool _isFocusedTextRecognitionRegionUpdating = false;

        #endregion


        #region Output: Recognition results

        /// <summary>
        /// Dictionary (VintasoftImage -> OcrPage),
        /// which contains information about text recognition results for images. 
        /// </summary>
        Dictionary<VintasoftImage, OcrPage> _imagesToOcrPages = new Dictionary<VintasoftImage, OcrPage>();

        /// <summary>
        /// A visual tool that allows to edit the OCR result in image viewer.
        /// </summary>
        OcrResultEditorTool _ocrResultEditorTool = new OcrResultEditorTool();

        /// <summary>
        /// A value indicating whether the OCR result editor tool must highlight
        /// low-confidence words after recognition.
        /// </summary>
        bool _highlightLowConfidenceWordsAfterRecognition = true;

        #endregion


        #region Save the recognition results

#if !REMOVE_PDF_PLUGIN
        /// <summary>
        /// The PDF image compression.
        /// </summary>
        PdfCompression _pdfCompression = PdfCompression.Auto;

        /// <summary>
        /// The PDF image compression settings.
        /// </summary>
        PdfCompressionSettings _pdfCompressionSettings = new PdfCompressionSettings();

#if !REMOVE_DOCCLEANUP_PLUGIN
        /// <summary>
        /// The PDF MRC compression settings.
        /// </summary>
        PdfMrcCompressionSettings _pdfMrcCompressionSettings = null;
#endif
#endif

        #endregion


        /// <summary>
        /// Selected "View - Image scale mode" menu item.
        /// </summary>
        ToolStripMenuItem _imageScaleSelectedMenuItem;

        /// <summary>
        /// The settings, which define how to cleanup the OCR recognize results.
        /// </summary>
        OcrCleanupSettings _cleanupSettings = new OcrCleanupSettings();

#if !REMOVE_PDF_PLUGIN
        /// <summary>
        /// The settings, which define how to build searchable PDF document that contains text over image.
        /// </summary>
        OcrTextOverImageSettings _textOverImageSettings = new OcrTextOverImageSettings();
#endif

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            InitializeComponent();

#if !REMOVE_PDF_PLUGIN && !REMOVE_DOCCLEANUP_PLUGIN
            // init the PDF MRC compression settings
            _pdfMrcCompressionSettings = new PdfMrcCompressionSettings();
#endif

            Jbig2AssemblyLoader.Load();
            Jpeg2000AssemblyLoader.Load();

            this.Text = string.Format("VintaSoft OCR Demo v{0}", ImagingGlobalSettings.ProductVersion);

            CodecsFileFilters.SetOpenFileDialogFilter(openFileDialog1);

            // do not use the image rendering settings in image viewer
            imageViewer1.ImageRenderingSettings = null;


            // init the OCR settings

            _tesseractOcrSettings = new TesseractOcrSettings(OcrLanguage.English);
            _tesseractOcrSettings.RecognitionRegionType = RecognitionRegionType.RecognizePageWithPageSegmentationAndOrientationDetection;
            _tesseractOcrSettings.UseSymbolRegionsCorrection = true;


            _ocrRecognitionRegionSplittingSettings = new OcrRecognitionRegionSplittingSettings(16000, 16000, 3200);


            // init the recognition region editor tool

            _textRecognitionRegionEditorTool.FocusedRegionChanged += new EventHandler(textRecognitionRegionEditorTool_FocusedRegionChanged);
            _textRecognitionRegionEditorTool.FocusedRegionInteractionFinished += new PropertyChangedEventHandler<RecognitionRegion>(textRecognitionRegionEditorTool_FocusedRegionInteractionFinished);
            _textRecognitionRegionEditorTool.FocusedRegionLanguages = _tesseractOcrSettings.Languages;
            imageViewer1.VisualTool = _textRecognitionRegionEditorTool;


            // init the OCR result editor tool

            _ocrResultEditorTool.FocusedObjectChanged += new EventHandler(ocrResultsEditorTool_FocusedOcrObjectChanged);
            _ocrResultEditorTool.SelectedObjectsListBox = selectedObjectsListBox;
            _ocrResultEditorTool.FocusedObject = null;

            maxConfidenceFromDictTrackBar.Value = 60;
            maxConfidenceTrackBar.Value = 75;

#if !REMOVE_PDF_PLUGIN && !REMOVE_DOCCLEANUP_PLUGIN
            // disable PDF MRC compression
            _pdfMrcCompressionSettings.EnableMrcCompression = false;
#endif

            // init UI

            InitImageScaleMenu();
            InitOcrObjectTypeMenu();
            InitSelectedTextRecognitionRegionLanguagesListBox();
            InitSelectedTextRecognitionRegionTypeComboBox();

            // update the UI
            UpdateUI();
        }

        #endregion



        #region Properties

        string _tesseractOcrDllDirectory = null;
        /// <summary>
        /// Gets a directory where Tesseract5.Vintasoft.xXX.dll is located.
        /// </summary>
        public string TesseractOcrDllDirectory
        {
            get
            {
                if (_tesseractOcrDllDirectory == null)
                {
                    // Tesseract OCR dll filename
                    string dllFilename;
                    // if is 64-bit system then
                    if (IntPtr.Size == 8)
                        dllFilename = "Tesseract5.Vintasoft.x64.dll";
                    else
                        dllFilename = "Tesseract5.Vintasoft.x86.dll";

                    string currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName);

                    // search directories
                    string[] directories = new string[]
                    {
                        "",
                        @"TesseractOCR\",
                        @"Debug\net6.0-windows\TesseractOCR\",
                        @"Release\net6.0-windows\TesseractOCR\",
                        @"Debug\net7.0-windows\TesseractOCR\",
                        @"Release\net7.0-windows\TesseractOCR\",
                        @"Debug\net8.0-windows\TesseractOCR\",
                        @"Release\net8.0-windows\TesseractOCR\",
                    };

                    // search tesseract dll
                    foreach (string dir in directories)
                    {
                        string dllDirectory = Path.Combine(currentDirectory, dir);
                        if (File.Exists(Path.Combine(dllDirectory, dllFilename)))
                        {
                            _tesseractOcrDllDirectory = dllDirectory;
                            break;
                        }
                    }
                    if (_tesseractOcrDllDirectory == null)
                        _tesseractOcrDllDirectory = currentDirectory;
                    else
                        _tesseractOcrDllDirectory = Path.GetFullPath(_tesseractOcrDllDirectory);
                }
                return _tesseractOcrDllDirectory;
            }
        }

        OcrLanguage[] _supportedOcrLanguages;
        /// <summary>
        /// Gets the supported OCR languages.
        /// </summary>
        public OcrLanguage[] SupportedOcrLanguages
        {
            get
            {
                if (_supportedOcrLanguages == null)
                {
                    try
                    {
                        using (TesseractOcr tesseractEngine = new TesseractOcr(TesseractOcrDllDirectory))
                        {
                            _supportedOcrLanguages = tesseractEngine.SupportedLanguages;
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowTesseractOcrErrorMessage(ex);
                        _supportedOcrLanguages = new OcrLanguage[0];
                    }
                }

                return _supportedOcrLanguages;
            }
        }

        /// <summary>
        /// Gets or sets the current text recognition region of focused image.
        /// </summary>
        public RecognitionRegion CurrentTextRecognitionRegion
        {
            get
            {
                return _textRecognitionRegionEditorTool.FocusedRegion;
            }
            set
            {
                if (_isFocusedTextRecognitionRegionUpdating)
                    return;

                _textRecognitionRegionEditorTool.FocusedRegion = value;
                if (value == null)
                {
                    selectedTextRecognitionRegionRectangleLabel.Text = "";
                    selectedTextRecognitionRegionOcrLanguagesListBox.SelectedLanguages = null;
                    selectedTextRecognitionRegionTypeComboBox.SelectedItem = RecognitionRegionType.RecognizeSingleColumn;
                    selectedTextRecognitionRegionTextRotationComboBox.SelectedIndex = 0;

                    textRecognitionRegionsComboBox.SelectedIndex = -1;
                }
                else
                {
                    selectedTextRecognitionRegionRectangleLabel.Text = value.Rectangle.ToString();
                    selectedTextRecognitionRegionOcrLanguagesListBox.SelectedLanguages = value.Languages;
                    selectedTextRecognitionRegionTypeComboBox.SelectedItem = value.RegionType;
                    selectedTextRecognitionRegionTextRotationComboBox.SelectedIndex = value.TextRotation / 90;

                    // get the text recognition regions on image
                    List<RecognitionRegion> regions = GetTextRecognitionRegions(imageViewer1.Image);
                    int index = regions.IndexOf(CurrentTextRecognitionRegion);
                    if (index < 0)
                    {
                        // Add new region
                        regions.Add(value);
                        // highlight text recognition regions on image
                        HighlightTextRecognitionRegionsOnImage();
                    }
                    textRecognitionRegionsComboBox.SelectedIndex = regions.IndexOf(value);
                }

                // update the UI
                UpdateUI();
            }
        }

        bool _isFileLoading = false;
        /// <summary>
        /// Gets a value indicating whether the file is loading.
        /// </summary>
        bool IsFileLoading
        {
            get
            {
                return _isFileLoading;
            }
            set
            {
                _isFileLoading = value;
                UpdateUI();
            }
        }

        bool _isImageProcessing = false;
        /// <summary>
        /// Gets a value indicating whether the image is processing.
        /// </summary>
        bool IsImageProcessing
        {
            get
            {
                return _isImageProcessing;
            }
            set
            {
                _isImageProcessing = value;
                UpdateUI();
            }
        }

        /// <summary>
        /// Gets or sets the OCR result for the focused image.
        /// </summary>
        public OcrPage OcrResultForFocusedImage
        {
            get
            {
                if (imageViewer1.Image == null)
                    return null;
                if (_imagesToOcrPages.ContainsKey(imageViewer1.Image))
                    return _imagesToOcrPages[imageViewer1.Image];
                return null;
            }
            set
            {
                if (imageViewer1.Image == null)
                {
                    if (value != null)
                    {
                        throw new InvalidOperationException();
                    }
                    else
                    {
                        // update the UI
                        UpdateUI();
                        return;
                    }
                }
                if (value != null)
                {
                    _imagesToOcrPages[imageViewer1.Image] = value;
                    _ocrResultEditorTool.Page = value;
                }
                else
                {
                    if (_imagesToOcrPages.ContainsKey(imageViewer1.Image))
                        _imagesToOcrPages.Remove(imageViewer1.Image);
                    _ocrResultEditorTool.Page = null;
                    textRecognitionTab.SelectedTab = segmentationTabPage;
                }

                // update the UI
                UpdateUI();
            }
        }

        #endregion



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Processes a command key.
        /// </summary>
        /// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />,
        /// passed by reference, that represents the window message to process.</param>
        /// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values
        /// that represents the key to process.</param>
        /// <returns>
        /// <b>true</b> if the character was processed by the control; otherwise, <b>false</b>.
        /// </returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Shift | Keys.Control | Keys.Add))
            {
                RotateViewClockwise();
                return true;
            }

            if (keyData == (Keys.Shift | Keys.Control | Keys.Subtract))
            {
                RotateViewCounterClockwise();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion


        #region PRIVATE

        #region UI

        #region 'File' menu

        /// <summary>
        /// Handles the Click event of openToolStripMenuItem object.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsFileLoading = true;

            using (AddImagesForm addImagesForm = new AddImagesForm())
            {
                addImagesForm.OpenFileWhenShown = true;
                if (addImagesForm.ShowDialog() == DialogResult.OK)
                {
                    CloseImages();

                    AddNewImages(addImagesForm.Images, addImagesForm.SegmentationResults);
                }
            }

            IsFileLoading = false;
        }

        /// <summary>
        /// Handles the Click event of addToolStripMenuItem object.
        /// </summary>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsFileLoading = true;

            using (AddImagesForm addImagesForm = new AddImagesForm())
            {
                addImagesForm.OpenFileWhenShown = true;
                if (addImagesForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewImages(addImagesForm.Images, addImagesForm.SegmentationResults);
                }
            }

            IsFileLoading = false;
        }

        /// <summary>
        /// Handles the Click event of scanImagesToolStripMenuItem object.
        /// </summary>
        private void scanImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsFileLoading = true;

            using (AddImagesForm addImagesForm = new AddImagesForm())
            {
                // set an option to acquire image from scanner
                addImagesForm.ScanImageWhenShown = true;
                if (addImagesForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewImages(addImagesForm.Images, addImagesForm.SegmentationResults);
                }
            }

            IsFileLoading = false;
        }

        /// <summary>
        /// Handles the Click event of closeImagesToolStripMenuItem object.
        /// </summary>
        private void closeImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseImages();
        }

        /// <summary>
        /// Handles the Click event of saveOcrResultToPdfDocumentWithTextOnlyModeToolStripMenuItem object.
        /// </summary>
        private void saveOcrResultToPdfDocumentWithTextOnlyModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // saves OCR result (text only) to a PDF document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.Text, PdfDocumentConformance.Undefined);
#endif
        }


        /// <summary>
        /// Handles the Click event of saveOcrResultToPdfDocumentWithImageOverTextModeToolStripMenuItem object.
        /// </summary>
        private void saveOcrResultToPdfDocumentWithImageOverTextModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.ImageOverText, PdfDocumentConformance.Undefined);
#endif
        }

        /// <summary>
        /// Handles the Click event of pdfImageOverTextPDFA1aToolStripMenuItem object.
        /// </summary>
        private void pdfImageOverTextPDFA1aToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF/A-1a document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.ImageOverText, PdfDocumentConformance.PdfA_1a);
#endif
        }

        /// <summary>
        /// Handles the Click event of pdfImageOverTextPDFA1bToolStripMenuItem object.
        /// </summary>
        private void pdfImageOverTextPDFA1bToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF/A-1b document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.ImageOverText, PdfDocumentConformance.PdfA_1b);
#endif
        }


        /// <summary>
        /// Handles the Click event of pdfImageOverTextPDFA2aToolStripMenuItem object.
        /// </summary>
        private void pdfImageOverTextPDFA2aToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF/A-2a document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.ImageOverText, PdfDocumentConformance.PdfA_2a);
#endif
        }

        /// <summary>
        /// Handles the Click event of pdfImageOverTextPDFA2bToolStripMenuItem object.
        /// </summary>
        private void pdfImageOverTextPDFA2bToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF/A-2b document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.ImageOverText, PdfDocumentConformance.PdfA_2b);
#endif
        }

        /// <summary>
        /// Handles the Click event of pdfImageOverTextPDFA4ToolStripMenuItem object.
        /// </summary>
        private void pdfImageOverTextPDFA4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF/A-4 document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.ImageOverText, PdfDocumentConformance.PdfA_4);
#endif
        }


        /// <summary>
        /// Handles the Click event of saveOcrResultToPdfDocumentWithTextOverImageModeToolStripMenuItem object.
        /// </summary>
        private void saveOcrResultToPdfDocumentWithTextOverImageModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.TextOverImage, PdfDocumentConformance.Undefined);
#endif
        }

        /// <summary>
        /// Handles the Click event of pdfTextOverImagePDFA1aToolStripMenuItem object.
        /// </summary>
        private void pdfTextOverImagePDFA1aToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF/A-1a document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.TextOverImage, PdfDocumentConformance.PdfA_1a);
#endif
        }

        /// <summary>
        /// Handles the Click event of pdfTextOverImagePDFA1bToolStripMenuItem object.
        /// </summary>
        private void pdfTextOverImagePDFA1bToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF/A-1b document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.TextOverImage, PdfDocumentConformance.PdfA_1b);
#endif
        }


        /// <summary>
        /// Handles the Click event of pdfTextOverImagePDFA2aToolStripMenuItem object.
        /// </summary>
        private void pdfTextOverImagePDFA2aToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF/A-2a document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.TextOverImage, PdfDocumentConformance.PdfA_2a);
#endif
        }

        /// <summary>
        /// Handles the Click event of pdfTextOverImagePDFA2bToolStripMenuItem object.
        /// </summary>
        private void pdfTextOverImagePDFA2bToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF/A-2b document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.TextOverImage, PdfDocumentConformance.PdfA_2b);
#endif
        }

        /// <summary>
        /// Handles the Click event of pdfTextOverImagePDFA4ToolStripMenuItem object.
        /// </summary>
        private void pdfTextOverImagePDFA4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            // save OCR result (text and source images) to a PDF/A-4 document
            SaveOcrResultInPdfDocument(PdfPageCreationMode.TextOverImage, PdfDocumentConformance.PdfA_4);
#endif
        }

        /// <summary>
        /// Handles the Click event of pdfTextOverImageSettingsToolStripMenuItem object.
        /// </summary>
        private void pdfTextOverImageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            using (OcrTextOverImageSettingsForm dialog = new OcrTextOverImageSettingsForm(_textOverImageSettings))
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.Owner = this;
                dialog.ShowDialog();
            }
#endif
        }

        /// <summary>
        /// Handles the Click event of cleanupSettingsToolStripMenuItem object.
        /// </summary>
        private void cleanupSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OcrCleanupSettingsForm dialog = new OcrCleanupSettingsForm())
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.Owner = this;

                dialog.Settings = _cleanupSettings;

                if (dialog.ShowDialog() == DialogResult.OK)
                    _cleanupSettings = dialog.Settings;
            }
        }

        /// <summary>
        /// Handles the Click event of saveAsFormattedTextFileToolStripMenuItem object.
        /// </summary>
        private void saveAsFormattedTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text documents (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // save OCR result as a formatted text file
                File.WriteAllText(saveFileDialog.FileName, OcrResultForFocusedImage.GetFormattedText(), Encoding.UTF8);
            }
        }

        /// <summary>
        /// Handles the Click event of saveAsTextFileToolStripMenuItem object.
        /// </summary>
        private void saveAsTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text documents (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // save OCR result as a text file
                File.WriteAllText(saveFileDialog.FileName, OcrResultForFocusedImage.GetText(), Encoding.UTF8);
            }
        }

        /// <summary>
        /// Handles the Click event of exitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        #region 'View' menu

        #region Thumbnail viewer

        /// <summary>
        /// Handles the Click event of thumbnailViewerSettingsToolStripMenuItem object.
        /// </summary>
        private void thumbnailViewerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ThumbnailViewerSettingsForm viewerSettingsDialog = new ThumbnailViewerSettingsForm(thumbnailViewer1))
            {
                viewerSettingsDialog.ShowDialog();
            }
        }

        #endregion


        #region Image viewer

        /// <summary>
        /// Handles the Click event of imageScaleModeMenuItem object.
        /// </summary>
        private void imageScaleModeMenuItem_Click(object sender, EventArgs e)
        {
            _imageScaleSelectedMenuItem.Checked = false;
            _imageScaleSelectedMenuItem = (ToolStripMenuItem)sender;
            if (_imageScaleSelectedMenuItem.Tag is ImageSizeMode)
            {
                imageViewer1.SizeMode = (ImageSizeMode)_imageScaleSelectedMenuItem.Tag;
                _imageScaleSelectedMenuItem.Checked = true;
            }
            else
            {
                int zoomValue = (int)_imageScaleSelectedMenuItem.Tag;
                imageViewer1.SizeMode = ImageSizeMode.Zoom;
                imageViewer1.Zoom = zoomValue;
            }
        }

        /// <summary>
        /// Handles the Click event of rotateClockwiseToolStripMenuItem object.
        /// </summary>
        private void rotateClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateViewClockwise();
        }

        /// <summary>
        /// Handles the Click event of counterclockwiseToolStripMenuItem object.
        /// </summary>
        private void counterclockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateViewCounterClockwise();
        }

        /// <summary>
        /// Handles the Click event of centerImageToolStripMenuItem object.
        /// </summary>
        private void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (centerImageToolStripMenuItem.Checked)
            {
                // enable centering of image in the image viewer
                imageViewer1.FocusPointAnchor = AnchorType.None;
                imageViewer1.IsFocusPointFixed = true;
                imageViewer1.ScrollToCenter();
            }
            else
            {
                // disable centering of image in the image viewer
                imageViewer1.FocusPointAnchor = AnchorType.Left | AnchorType.Top;
                imageViewer1.IsFocusPointFixed = true;
            }
        }

        /// <summary>
        /// Handles the Click event of imageViewerSettingsToolStripMenuItem object.
        /// </summary>
        private void imageViewerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ImageViewerSettingsForm viewerSettingsDialog = new ImageViewerSettingsForm(imageViewer1))
            {
                viewerSettingsDialog.ShowDialog();
            }
        }

        #endregion

        #endregion


        #region 'Segmentation' menu

        /// <summary>
        /// Handles the Click event of segmentCurrentImageToolStripMenuItem object.
        /// </summary>
        private void segmentCurrentImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsImageProcessing = true;

            // segment current image
            ExecuteSegmentation(imageViewer1.Image);
            // highlight text recognition regions on image
            HighlightTextRecognitionRegionsOnImage();

            IsImageProcessing = false;
        }

        /// <summary>
        /// Handles the Click event of segmentAllImagesToolStripMenuItem object.
        /// </summary>
        private void segmentAllImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsImageProcessing = true;

            // segment all images
            for (int i = 0; i < imageViewer1.Images.Count; i++)
                ExecuteSegmentation(imageViewer1.Images[i]);
            // highlight text recognition regions on image
            HighlightTextRecognitionRegionsOnImage();

            IsImageProcessing = false;
        }

        /// <summary>
        /// Handles the Click event of removeSegmentationResultForCurrentImageToolStripMenuItem object.
        /// </summary>
        private void removeSegmentationResultForCurrentImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get the text recognition regions on image
            List<RecognitionRegion> regions = GetTextRecognitionRegions(imageViewer1.Image);
            // remove segmentation result for current image
            regions.Clear();
            // highlight text recognition regions on image
            HighlightTextRecognitionRegionsOnImage();

            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of removeSegmentationResultsForAllImagesToolStripMenuItem object.
        /// </summary>
        private void removeSegmentationResultsForAllImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove segmentation results for all images
            _imagesToTextRecognitionRegions.Clear();
            // highlight text recognition regions on image
            HighlightTextRecognitionRegionsOnImage();

            UpdateUI();
        }

        #endregion


        #region 'OCR' menu

        /// <summary>
        /// Handles the Click event of ocrSettingsToolStripMenuItem object.
        /// </summary>
        private void ocrSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create the OCR settings form
            using (OcrSettingsForm ocrSettingsForm = new OcrSettingsForm(
                _tesseractOcrSettings,
                SupportedOcrLanguages,
                _imageBinarizationMode,
                _highlightLowConfidenceWordsAfterRecognition,
                _ocrRecognitionRegionSplittingSettings,
                _useMultithreading,
                _maxThreads))
            {
                // save previous OCR languages
                OcrLanguage[] previousOcrLanguages = _tesseractOcrSettings.Languages;

                // show the OCR settings form
                if (ocrSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    // if languages are changed and must be updated
                    if (!AreLanguagesEqual(previousOcrLanguages, _tesseractOcrSettings.Languages))
                    {
                        // set new language for each recognition region
                        foreach (VintasoftImage image in imageViewer1.Images)
                        {
                            // get text recognition regions on image
                            List<RecognitionRegion> regions = GetTextRecognitionRegions(image);
                            foreach (RecognitionRegion region in regions)
                            {
                                region.Languages = _tesseractOcrSettings.Languages;
                            }
                            // highlight text recognition regions on image
                            HighlightTextRecognitionRegionsOnImage();
                        }
                    }

                    _textRecognitionRegionEditorTool.FocusedRegionLanguages = _tesseractOcrSettings.Languages;

                    _imageBinarizationMode = ocrSettingsForm.ImageBinarizationMode;
                    _highlightLowConfidenceWordsAfterRecognition = ocrSettingsForm.HighlightLowConfidenceWordsAfterRecognition;

                    _useMultithreading = ocrSettingsForm.UseMultithreading;
                    _maxThreads = ocrSettingsForm.MaxThreads;
                }
            }
        }


        /// <summary>
        /// Handles the Click event of recognizeTextInCurrentImageToolStripMenuItem object.
        /// </summary>
        private void recognizeTextInCurrentImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // recognize text in current image
            RecognizeTextAsync(imageViewer1.Image);
        }

        /// <summary>
        /// Handles the Click event of recognizeTextInAllImagesToolStripMenuItem object.
        /// </summary>
        private void recognizeTextInAllImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // recognize text in all images
            RecognizeTextAsync(imageViewer1.Images.ToArray());
        }


        /// <summary>
        /// Handles the Click event of recognizeMICRInCurrentImageToolStripMenuItem object.
        /// </summary>
        private void recognizeMICRInCurrentImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save previous OCR languages
            _previousOcrLanguages = _tesseractOcrSettings.Languages;

            // specify that MICR text must be recognized
            _tesseractOcrSettings.Language = OcrLanguage.MICR;

            // recognize text in current image
            RecognizeTextAsync(imageViewer1.Image);
        }

        /// <summary>
        /// Handles the Click event of recognizeMRZInCurrenImageToolStripMenuItem object.
        /// </summary>
        private void recognizeMRZInCurrenImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save previous OCR languages
            _previousOcrLanguages = _tesseractOcrSettings.Languages;

            // specify that MRZ text must be recognized
            _tesseractOcrSettings.Language = OcrLanguage.MRZ;

            // recognize text in current image
            RecognizeTextAsync(imageViewer1.Image);
        }


        /// <summary>
        /// Handles the Click event of detectPageOrientationToolStripMenuItem object.
        /// </summary>
        private void detectPageOrientationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcrPage ocrPage = null;

            // create Tesseract OCR engine
            using (TesseractOcr tesseractOcr = CreateTesseractOcrEngine(OcrBinarizationMode.Adaptive))
            {
                // create copy of Tesseract OCR settings
                TesseractOcrSettings tesseractOcrSettings = (TesseractOcrSettings)_tesseractOcrSettings.Clone();
                // specify that page orientation must be detected
                tesseractOcrSettings.RecognitionRegionType = RecognitionRegionType.DetectPageOrientation;

                // initialize the Tesseract OCR engine
                tesseractOcr.Init(tesseractOcrSettings);

                // detect page orientation
                ocrPage = tesseractOcr.Recognize(imageViewer1.Image);

                // shutdown the Tesseract OCR engine
                tesseractOcr.Shutdown();
            }

            // set OCR page as OCR result for focused image
            this.OcrResultForFocusedImage = ocrPage;
            // select "Text recognition results" tab
            textRecognitionTab.SelectedTab = recognitionResultsTabPage;
            // specify that "Text recognition results" tab should show OCR result for text regions
            ocrObjectTypeComboBox.SelectedItem = OcrObjectType.TextRegion;
        }

        /// <summary>
        /// Handles the Click event of analyzeLayoutToolStripMenuItem object.
        /// </summary>
        private void analyzeLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcrPage ocrPage = null;

            // create Tesseract OCR engine
            using (TesseractOcr tesseractOcr = CreateTesseractOcrEngine(OcrBinarizationMode.Adaptive))
            {
                // initialize the Tesseract OCR engine
                tesseractOcr.Init(_tesseractOcrSettings);
                // set image for Tesseract OCR engine
                tesseractOcr.SetImage(imageViewer1.Image);

                // analyze layout
                ocrPage = tesseractOcr.AnalyzeLayout();

                // clear image in Tesseract OCR engine
                tesseractOcr.ClearImage();
                // shutdown the Tesseract OCR engine
                tesseractOcr.Shutdown();
            }

            // set OCR page as OCR result for focused image
            this.OcrResultForFocusedImage = ocrPage;
            // select "Text recognition results" tab
            textRecognitionTab.SelectedTab = recognitionResultsTabPage;
            // specify that "Text recognition results" tab should show OCR result for symbols
            ocrObjectTypeComboBox.SelectedItem = OcrObjectType.Symbol;
        }

        /// <summary>
        /// Handles the Click event of removeTextRecognitionResultForCurrentImageToolStripMenuItem object.
        /// </summary>
        private void removeTextRecognitionResultForCurrentImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove text recognition result for current image
            OcrResultForFocusedImage = null;
        }

        /// <summary>
        /// Handles the Click event of removeTextRecognitionResultsForAllImagesToolStripMenuItem1 object.
        /// </summary>
        private void removeTextRecognitionResultsForAllImagesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // remove text recognition results for all images
            OcrResultForFocusedImage = null;
            _imagesToOcrPages.Clear();

            UpdateUI();
        }


        /// <summary>
        /// Handles the Click event of loadRecognitionResultsFromDocumentToolStripMenuItem object.
        /// </summary>
        private void loadRecognitionResultsFromDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Supported Files|*.pdf;*.docx;*.doc|PDF files (*.pdf)|*.pdf|DOCX files (*.docx)|*.docx|DOC files (*.doc)|*.doc";
                DemosTools.SetTestFilesFolder(openFileDialog);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // create image collection for document images
                    using (ImageCollection documentImages = new ImageCollection())
                    {
                        try
                        {
                            // load document into image collection
                            documentImages.Add(openFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            DemosTools.ShowErrorMessage(ex);
                            return;
                        }

                        // create OCR document from document images
                        OcrDocument ocrDocument = OcrDocument.Create(documentImages, imageViewer1.Images);
                        // clear the document images collection
                        documentImages.ClearAndDisposeItems();

                        // get pages of OCR document
                        List<OcrPage> ocrPages = ocrDocument.Pages;
                        // if OCR document does not have pages
                        if (ocrPages.Count == 0)
                        {
                            DemosTools.ShowInfoMessage("Specified document does not contain text pages.");
                        }
                        // if OCR document has pages
                        else
                        {
                            // clear dictionary: image => OCR page
                            _imagesToOcrPages.Clear();

                            // get image collection of image viewer
                            ImageCollection images = imageViewer1.Images;
                            // OCR page count does not equal to the image collection count
                            if (ocrPages.Count != images.Count)
                            {
                                // save first OCR page as OCR result for focused image
                                SaveOcrResult(imageViewer1.Image, ocrPages[0]);
                            }
                            // OCR page count equals to the image collection count
                            else
                            {
                                // for each OCR page
                                for (int i = 0; i < ocrPages.Count; i++)
                                {
                                    // get image
                                    VintasoftImage image = images[i];
                                    // get OCR page
                                    OcrPage ocrPage = ocrPages[i];

                                    // save OCR page as OCR result for image
                                    SaveOcrResult(image, ocrPage);
                                }
                            }

                            UpdateUI();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of loadRecognitionResultsFromHOCRFileToolStripMenuItem object.
        /// </summary>
        private void loadRecognitionResultsFromHOCRFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "HOCR files (*.hocr;*.html)|*.hocr;*.html|All files (*.*)|*.*";
                DemosTools.SetTestFilesFolder(openFileDialog);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OcrDocument ocrDocument;
                    // open hOCR file
                    using (Stream stream = File.OpenRead(openFileDialog.FileName))
                    {
                        // create hOCR codec
                        HOcrCodec hOcrCodec = new HOcrCodec();
                        // import hOCR file from stream and create OCR document
                        ocrDocument = hOcrCodec.Import(stream);
                    }

                    // get pages of OCR document
                    List<OcrPage> ocrPages = ocrDocument.Pages;
                    // OCR page count does not equal to the image collection count
                    if (ocrPages.Count == 0)
                    {
                        DemosTools.ShowInfoMessage("Specified hOCR file does not contain pages or is not supported.");
                    }
                    // OCR page count equals to the image collection count
                    else
                    {
                        _imagesToOcrPages.Clear();

                        ImageCollection images = imageViewer1.Images;
                        if (ocrPages.Count != images.Count)
                        {
                            // save first OCR page as OCR result for focused image
                            SaveOcrResult(imageViewer1.Image, ocrPages[0]);
                        }
                        else
                        {
                            // for each OCR page
                            for (int i = 0; i < ocrPages.Count; i++)
                            {
                                // get image
                                VintasoftImage image = images[i];
                                // get OCR page
                                OcrPage ocrPage = ocrPages[i];

                                // save OCR page as OCR result for image
                                SaveOcrResult(image, ocrPage);
                            }
                        }

                        UpdateUI();
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of saveToHocrForCurrentImageToolStripMenuItem object.
        /// </summary>
        private void saveToHocrForCurrentImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "HOCR files (*.hocr)|*.hocr|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // create hOCR file
                    using (Stream stream = File.Create(saveFileDialog.FileName))
                    {
                        // get OCR page for focused image
                        OcrPage ocrPage = OcrResultForFocusedImage;

                        // create hOCR codec
                        HOcrCodec hOcrCodec = new HOcrCodec();
                        // export OCR page to hOCR file
                        hOcrCodec.Export(ocrPage, stream);
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of saveToHocrForAllImagesToolStripMenuItem object.
        /// </summary>
        private void saveToHocrForAllImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "HOCR files (*.hocr)|*.hocr|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // create hOCR file
                    using (Stream stream = File.Create(saveFileDialog.FileName))
                    {
                        // create new OCR document
                        OcrDocument ocrDocument = new OcrDocument();
                        // get image collection of image viewer
                        ImageCollection images = imageViewer1.Images;
                        // for each image
                        for (int i = 0; i < images.Count; i++)
                        {
                            // get image
                            VintasoftImage image = images[i];
                            OcrPage ocrPage = null;

                            // get OCR result for image
                            if (!_imagesToOcrPages.TryGetValue(image, out ocrPage))
                            {
                                ocrPage = null;
                            }
                            // add OCR page to the OCR document
                            ocrDocument.Pages.Add(ocrPage);
                        }

                        // create hOCR codec
                        HOcrCodec hOcrCodec = new HOcrCodec();
                        // export OCR document to hOCR file
                        hOcrCodec.Export(ocrDocument, stream);
                    }
                }
            }
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of aboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        #region 'Text Recognition Regions' tab

        /// <summary>
        /// Handles the Format event of textRecognitionRegionsComboBox object.
        /// </summary>
        private void textRecognitionRegionsComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            RecognitionRegion region = (RecognitionRegion)e.ListItem;

            string languageStr = string.Empty;
            foreach (OcrLanguage language in region.Languages)
                languageStr += string.Format("{0},", language);

            languageStr = languageStr.TrimEnd(',');

            // format region info
            e.Value = String.Format("{0}: {1}", languageStr, region.Rectangle.GetBoundingBox());
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of textRecognitionRegionsComboBox object.
        /// </summary>
        private void textRecognitionRegionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textRecognitionRegionsComboBox.SelectedIndex >= 0)
            {
                CurrentTextRecognitionRegion = (RecognitionRegion)textRecognitionRegionsComboBox.SelectedItem;
            }
            else
            {
                CurrentTextRecognitionRegion = null;
            }
        }

        /// <summary>
        /// Handles the Click event of addSegmentationRectButton object.
        /// </summary>
        private void addSegmentationRectButton_Click(object sender, EventArgs e)
        {
            // create new text recognition region
            RectangularSelection rect = new RectangularSelection();
            _textRecognitionRegionEditorTool.AddAndBuild(rect);
        }

        /// <summary>
        /// Handles the Click event of removeSelectedSegmentationRectButton object.
        /// </summary>
        private void removeSelectedSegmentationRectButton_Click(object sender, EventArgs e)
        {
            // remove selected text recognition region
            DeleteFocusedTextRecognitionRegion();

            // update the UI
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of removeAllTextRecognitionRegionsButton object.
        /// </summary>
        private void removeAllTextRecognitionRegionsButton_Click(object sender, EventArgs e)
        {
            // get text recognition regions on image
            List<RecognitionRegion> regions = GetTextRecognitionRegions(imageViewer1.Image);
            regions.Clear();

            // highlight text recognition regions on image
            HighlightTextRecognitionRegionsOnImage();
        }

        /// <summary>
        /// Handles the SelectedLanguagesChanged event of selectedTextRecognitionRegionOcrLanguagesListBox object.
        /// </summary>
        private void selectedTextRecognitionRegionOcrLanguagesListBox_SelectedLanguagesChanged(object sender, EventArgs e)
        {
            RecognitionRegion region = CurrentTextRecognitionRegion;

            if (region != null)
            {
                // if the language lists are different
                if (region.Languages != selectedTextRecognitionRegionOcrLanguagesListBox.SelectedLanguages)
                {
                    // set new language list
                    region.Languages = selectedTextRecognitionRegionOcrLanguagesListBox.SelectedLanguages;
                    // highlight text recognition regions on image
                    HighlightTextRecognitionRegionsOnImage(false);
                }
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of recognitionRegionTypeComboBox object.
        /// </summary>
        private void recognitionRegionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecognitionRegion region = CurrentTextRecognitionRegion;
            if (region != null)
            {
                // get selected region type
                RecognitionRegionType regionType = (RecognitionRegionType)selectedTextRecognitionRegionTypeComboBox.SelectedItem;
                // if the region type changed
                if (region.RegionType != regionType)
                {
                    region.RegionType = regionType;
                    // highlight text recognition regions on image
                    HighlightTextRecognitionRegionsOnImage(false);
                }
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of selectedTextRecognitionRegionTextRotationComboBox object.
        /// </summary>
        private void selectedTextRecognitionRegionTextRotationComboBox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (CurrentTextRecognitionRegion != null)
            {
                // get current region rotation
                int textRotation = selectedTextRecognitionRegionTextRotationComboBox.SelectedIndex * 90;
                RecognitionRegion region = CurrentTextRecognitionRegion;
                // if the region rotation angle changed
                if (region.TextRotation != textRotation)
                {
                    region.TextRotation = textRotation;
                    // highlight text recognition regions on image
                    HighlightTextRecognitionRegionsOnImage(false);
                }
            }
        }

        #endregion


        #region 'Text Recognition Results' tab

        /// <summary>
        /// Handles the SelectedIndexChanged event of ocrObjectTypeComboBox object.
        /// </summary>
        private void ocrObjectTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ocrResultEditorTool.ObjectsType = (OcrObjectType)ocrObjectTypeComboBox.SelectedItem;
        }

        /// <summary>
        /// Handles the TextChanged event of ocrObjectTextBox object.
        /// </summary>
        private void ocrObjectTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ocrObjectTextBox.ReadOnly && _ocrResultEditorTool.FocusedObject != null)
                _ocrResultEditorTool.SetFocusedObjectText(ocrObjectTextBox.Text);
        }

        /// <summary>
        /// Handles the Click event of deleteAllOcrObjectsFromOcrResultButton object.
        /// </summary>
        private void deleteAllOcrObjectsFromOcrResultButton_Click(object sender, EventArgs e)
        {
            // delete all OCR objects from OCR result
            DeleteAllSelectedOcrObjects();

            // update the UI
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of deleteSelectedOcrObjectFromOcrResultButton object.
        /// </summary>
        private void deleteSelectedOcrObjectFromOcrResultButton_Click(object sender, EventArgs e)
        {
            // delete selected OCR object from OCR result
            _ocrResultEditorTool.DeleteFocusedObject(selectedObjectsListBox.SelectedIndex);
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of selectedObjectsListBox object.
        /// </summary>
        private void selectedObjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update the UI
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of deselectSelectedOcrObjectsButton object.
        /// </summary>
        private void deselectSelectedOcrObjectsButton_Click(object sender, EventArgs e)
        {
            // remove all OCR objects from a list of selected OCR objects
            _ocrResultEditorTool.SetSelectedObjects(null);

            // update the UI
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of deselectSelectedOcrObjectButton object.
        /// </summary>
        private void deselectSelectedOcrObjectButton_Click(object sender, EventArgs e)
        {
            // remove selected OCR object from a list of selected OCR objects
            _ocrResultEditorTool.RemoveObjectFromSelectedObjects(selectedObjectsListBox.SelectedIndex);
        }


        /// <summary>
        /// Handles the ValueChanged event of ocrResultsConfidenceTrackBar object.
        /// </summary>
        private void ocrResultsConfidenceTrackBar_ValueChanged(object sender, EventArgs e)
        {
            maxConfidenceValueLabel.Text = string.Format("{0}%", maxConfidenceTrackBar.Value);
            maxConfidenceFromDictLabel.Text = string.Format("{0}%", maxConfidenceFromDictTrackBar.Value);

            // update highlighted resutls
            HighlightOcrResultsOnImage();
        }

        #endregion


        #region Viewers

        /// <summary>
        /// Handles the KeyDown event of imageViewer1 object.
        /// </summary>
        private void imageViewer1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                if (imageViewer1.VisualTool == _ocrResultEditorTool)
                    DeleteAllSelectedOcrObjects();
                else
                    DeleteFocusedTextRecognitionRegion();
            }
        }

        /// <summary>
        /// Handles the FocusedIndexChanged event of imageViewer1 object.
        /// </summary>
        private void imageViewer1_FocusedIndexChanged(object sender, FocusedIndexChangedEventArgs e)
        {
            if (OcrResultForFocusedImage != null)
                textRecognitionTab.SelectedTab = recognitionResultsTabPage;
            else
                textRecognitionTab.SelectedTab = segmentationTabPage;

            UpdateImageInfo();

            UpdateImageRecognizedResults();
            // update the UI
            UpdateUI();
        }

        /// <summary>
        /// Handles the FocusedIndexChanged event of thumbnailViewer1 object.
        /// </summary>
        private void thumbnailViewer1_FocusedIndexChanged(object sender, FocusedIndexChangedEventArgs e)
        {
            // update the UI
            UpdateUI();
        }

        #endregion


        /// <summary>
        /// Handles the SelectedIndexChanged event of tabControl1 object.
        /// </summary>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textRecognitionTab.SelectedTab == segmentationTabPage)
            {
                imageViewer1.VisualTool = _textRecognitionRegionEditorTool;
                HighlightTextRecognitionRegionsOnImage(true);
            }
            else
            {
                imageViewer1.VisualTool = _ocrResultEditorTool;
            }
        }

        #endregion


        #region Init

        /// <summary>
        /// Inits the image scale menu.
        /// </summary>
        private void InitImageScaleMenu()
        {
            normalImageToolStripMenuItem.Tag = ImageSizeMode.Normal;
            bestFitToolStripMenuItem.Tag = ImageSizeMode.BestFit;
            fitToWidthToolStripMenuItem.Tag = ImageSizeMode.FitToWidth;
            fitToHeightToolStripMenuItem.Tag = ImageSizeMode.FitToHeight;
            pixelToPixelToolStripMenuItem.Tag = ImageSizeMode.PixelToPixel;

            scaleToolStripMenuItem.Tag = ImageSizeMode.Zoom;
            scale25ToolStripMenuItem.Tag = 25;
            scale50ToolStripMenuItem.Tag = 50;
            scale100ToolStripMenuItem.Tag = 100;
            scale200ToolStripMenuItem.Tag = 200;
            scale400ToolStripMenuItem.Tag = 400;

            _imageScaleSelectedMenuItem = bestFitToolStripMenuItem;
            _imageScaleSelectedMenuItem.Checked = true;

            imageViewer1.SizeMode = ImageSizeMode.BestFit;
        }

        /// <summary>
        /// Inits the OCR object type menu.
        /// </summary>
        private void InitOcrObjectTypeMenu()
        {
            ocrObjectTypeComboBox.Items.Add(OcrObjectType.TextRegion);
            ocrObjectTypeComboBox.Items.Add(OcrObjectType.Paragraph);
            ocrObjectTypeComboBox.Items.Add(OcrObjectType.TextLine);
            ocrObjectTypeComboBox.Items.Add(OcrObjectType.Word);
            ocrObjectTypeComboBox.Items.Add(OcrObjectType.Symbol);
            ocrObjectTypeComboBox.SelectedItem = OcrObjectType.Word;
        }

        /// <summary>
        /// Inits the SelectedTextRecognitionRegionLanguage combo box.
        /// </summary>
        private void InitSelectedTextRecognitionRegionLanguagesListBox()
        {
            selectedTextRecognitionRegionOcrLanguagesListBox.SelectedLanguages = null;
        }

        /// <summary>
        /// Inits the SelectedTextRecognitionRegionType combo box.
        /// </summary>
        private void InitSelectedTextRecognitionRegionTypeComboBox()
        {
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizePageWithPageSegmentationAndOrientationDetection);
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizePageWithPageSegmentation);
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizeSingleColumn);
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizeSingleBlockOfVertText);
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizeSingleBlock);
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizeSingleLine);
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizeSingleWord);
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizeCircleWord);
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizeSingleChar);
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizeSparseTextWithPageOrientationDetection);
            selectedTextRecognitionRegionTypeComboBox.Items.Add(RecognitionRegionType.RecognizeSparseText);
            selectedTextRecognitionRegionTypeComboBox.SelectedItem = RecognitionRegionType.RecognizeSingleBlock;
        }

        #endregion


        #region UI State

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            if (InvokeRequired)
            {
                Invoke(new UpdateUIDelegate(UpdateUI));
                return;
            }

            if (IsImageProcessing)
            {
                // change mouse cursor to wait cursor
                Cursor = Cursors.WaitCursor;
            }
            else
            {
                // restore mouse cursor
                Cursor = Cursors.Default;
            }

            // get the current status of application
            bool isFileLoading = IsFileLoading;
            bool isFileLoaded = imageViewer1.Image != null;
            bool isFileEmpty = true;
            bool isProcessing = IsImageProcessing;
            bool isImagesRecognized = _imagesToOcrPages.Count > 0;
            bool isCurrentPageRecognized = OcrResultForFocusedImage != null;
            bool isCurrentRecognitionRegionEmpty = CurrentTextRecognitionRegion == null;
            bool isCurrentOcrResultEmpty = selectedObjectsListBox.SelectedIndex == -1;

            if (isFileLoaded)
            {
                isFileEmpty = imageViewer1.Images.Count <= 0;
            }

            // "File" menu
            fileToolStripMenuItem.Enabled = !isFileLoading && !isProcessing;
            closeImagesToolStripMenuItem.Enabled = isFileLoaded;
            saveAsPdfDocumentToolStripMenuItem.Enabled = isFileLoaded && isImagesRecognized;
            pdfImageOverTextToolStripMenuItem.Enabled = isFileLoaded && isImagesRecognized;
            pdfTextOnlyToolStripMenuItem.Enabled = isFileLoaded && isImagesRecognized;
            saveAsTextToolStripMenuItem.Enabled = isFileLoaded && isCurrentPageRecognized;

            // "Segmentation" menu
            segmentationToolStripMenuItem.Enabled = isFileLoaded && !isFileLoading && !isFileEmpty && !isProcessing;
            segmentCurrentPageToolStripMenuItem.Enabled = segmentationToolStripMenuItem.Enabled;
            segmentAllPagesToolStripMenuItem.Enabled = isFileLoaded;
            removeSegmentationResultForCurrentImageToolStripMenuItem.Enabled = isFileLoaded && textRecognitionRegionsComboBox.Items.Count != 0;
            removeSegmentationResultsForAllImagesToolStripMenuItem.Enabled = isFileLoaded;

            // "OCR" menu
            oCRToolStripMenuItem.Enabled = !isFileLoading && !isFileEmpty && !isProcessing;
            recognizeTextInCurrentImageToolStripMenuItem.Enabled = isFileLoaded && !isProcessing;
            recognizeTextInAllImagesToolStripMenuItem.Enabled = isFileLoaded && !isProcessing;
            removeRecognitionResultForCurrentImageToolStripMenuItem.Enabled = isFileLoaded && isCurrentPageRecognized && !isProcessing;
            removeRecognitionResultsForAllImagesToolStripMenuItem1.Enabled = isFileLoaded && isImagesRecognized && !isProcessing;
            loadRecognitionResultsFromHOCRFileToolStripMenuItem.Enabled = isFileLoaded && !isProcessing;
            loadRecognitionResultsFromDocumentToolStripMenuItem.Enabled = isFileLoaded && !isProcessing;
            saveToHocrForCurrentImageToolStripMenuItem.Enabled = isFileLoaded && isCurrentPageRecognized && !isProcessing;
            saveToHocrForAllImagesToolStripMenuItem.Enabled = isFileLoaded && isImagesRecognized && !isProcessing;

            // tab control
            textRecognitionTab.Enabled = isFileLoaded && !isProcessing;
            selectedTextRecognitionRegionGroupBox.Enabled = !isCurrentRecognitionRegionEmpty;
            ocrResultsEditorPanel.Enabled = isCurrentPageRecognized;
            textRecognitionRegionsPanel.Enabled = isFileLoaded;

            // segmentation tab page
            textRecognitionRegionsComboBox.Enabled = textRecognitionRegionsComboBox.Items.Count != 0;
            removeAllTextRecognitionRegionsButton.Enabled = textRecognitionRegionsComboBox.Items.Count != 0;
            removeTextRecognitionRegionButton.Enabled = !isCurrentRecognitionRegionEmpty;

            // recognition results tab page
            deleteSelectedObjectButton.Enabled = !isCurrentOcrResultEmpty;
            deselectSelectedOcrObjectButton.Enabled = !isCurrentOcrResultEmpty;

            // thumbnail viewer
            thumbnailViewer1.Enabled = !isProcessing;

            // image viewer
            imageViewer1.Enabled = !isProcessing;

            // image viewer tool strip
            imageViewerToolStrip1.Enabled = !isFileLoading && !isProcessing;
        }

        #endregion


        #region Image Manipulation

        /// <summary>
        /// Adds images to the viewer.
        /// </summary>
        /// <param name="images">Images to add.</param>
        /// <param name="segmentationResults">Images segmentation results.</param>
        private void AddNewImages(
            ImageCollection images,
            Dictionary<VintasoftImage,
            ReadOnlyCollection<ImageRegion>> segmentationResults)
        {
            thumbnailViewer1.Images.AddRange(images.ToArray());

            if (segmentationResults != null)
            {
                foreach (VintasoftImage image in segmentationResults.Keys)
                {
                    // get text recognition regions on image
                    List<RecognitionRegion> regions = GetTextRecognitionRegions(image);
                    // adds text regions from image segmentation results to the text recognition regions
                    AddSegmentationResultsToRecognitionRegions(regions, segmentationResults[image]);
                }

                // update highlight
                HighlightTextRecognitionRegionsOnImage();
            }
        }

        /// <summary>
        /// Closes all images (removes all images from image viewer).
        /// </summary>
        private void CloseImages()
        {
            thumbnailViewer1.Images.ClearAndDisposeItems();
            _imagesToOcrPages.Clear();
            _imagesToTextRecognitionRegions.Clear();
            _textRecognitionRegionEditorTool.SetRegions(null);
            OcrResultForFocusedImage = null;

            // update the UI
            UpdateUI();
        }

        #endregion


        #region Image segmentation

        /// <summary>
        /// Executes segmentation of specified image.
        /// </summary>
        /// <param name="image">The image.</param>
        private void ExecuteSegmentation(VintasoftImage image)
        {
#if !REMOVE_DOCCLEANUP_PLUGIN
            try
            {
                // create image processing command for image segmentation
                DocumentSegmentationCommand segmentationCommand = new DocumentSegmentationCommand();
                segmentationCommand.UniteTextRegions = true;
                segmentationCommand.BorderSize = 2;
                // segment image
                segmentationCommand.ExecuteInPlace(image);

                // get text recognition regions on image
                List<RecognitionRegion> regions = GetTextRecognitionRegions(image);
                // clear recognition regions
                regions.Clear();

                // add text regions from image segmentation results to the text recognition regions
                AddSegmentationResultsToRecognitionRegions(regions, segmentationCommand.Regions);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
#endif
        }

        /// <summary>
        /// Adds the text regions from image segmentation results to the text recognition regions.
        /// </summary>
        /// <param name="regions">Text recognition regions.</param>
        /// <param name="segmentationResults">Image segmentation result.</param>
        private void AddSegmentationResultsToRecognitionRegions(
            List<RecognitionRegion> regions,
            ReadOnlyCollection<ImageRegion> segmentationResults)
        {
            // for each image region returned by image segmentation command
            foreach (ImageRegion region in segmentationResults)
            {
                // if region may contain text
                if (region.Type == ImageRegionType.Text)
                {
                    // add region to the text recognition region
                    Rectangle rect = region.GetBoundingBox();
                    regions.Add(new RecognitionRegion(new RegionOfInterest(rect), _tesseractOcrSettings.Language));
                }
            }
        }

        #endregion


        #region Text Recognition Regions

        /// <summary>
        /// Returns the information about the text recognition regions on image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <returns>List of recognition regions.</returns>
        private List<RecognitionRegion> GetTextRecognitionRegions(VintasoftImage image)
        {
            List<RecognitionRegion> textRecognitionRegions = null;
            // get text recognition regions from cache
            _imagesToTextRecognitionRegions.TryGetValue(image, out textRecognitionRegions);
            // if text recognition regions are not found in cache
            if (textRecognitionRegions == null)
            {
                // create empty recognition region (region for text recognition on whole image)
                textRecognitionRegions = new List<RecognitionRegion>();
                // add new text recognition region to the cache
                _imagesToTextRecognitionRegions.Add(image, textRecognitionRegions);
            }
            // return text recognition regions
            return textRecognitionRegions;
        }

        /// <summary>
        /// Highlights the text recognition regions on focused image.
        /// </summary>
        private void HighlightTextRecognitionRegionsOnImage()
        {
            HighlightTextRecognitionRegionsOnImage(true);
        }

        /// <summary>
        /// Highlights the text recognition regions on focused image.
        /// </summary>
        /// <param name="resetFocusedTextRecognitionRegion">Indicates whether to reset the focused text recognition region.</param>
        private void HighlightTextRecognitionRegionsOnImage(bool resetFocusedTextRecognitionRegion)
        {
            if (imageViewer1.VisualTool != _textRecognitionRegionEditorTool)
                return;

            // get the text recognition regions on image
            List<RecognitionRegion> textRecognitionRegions = null;
            if (imageViewer1.Image != null)
                textRecognitionRegions = GetTextRecognitionRegions(imageViewer1.Image);

            textRecognitionRegionsComboBox.BeginUpdate();
            textRecognitionRegionsComboBox.Items.Clear();
            if (textRecognitionRegions != null)
            {
                foreach (RecognitionRegion region in textRecognitionRegions)
                    textRecognitionRegionsComboBox.Items.Add(region);
            }

            if (resetFocusedTextRecognitionRegion)
                CurrentTextRecognitionRegion = null;

            if (textRecognitionRegions != null)
                _textRecognitionRegionEditorTool.SetRegions(textRecognitionRegions.ToArray());

            textRecognitionRegionsComboBox.EndUpdate();
        }

        /// <summary>
        /// Handler of the RecognitionRegionEditorTool.FocusedRegionChanged event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textRecognitionRegionEditorTool_FocusedRegionChanged(object sender, EventArgs e)
        {
            CurrentTextRecognitionRegion = _textRecognitionRegionEditorTool.FocusedRegion;
        }

        /// <summary>
        /// Handler of the RecognitionRegionEditorTool.FocusedRegionInteractionFinished event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PropertyChangedEventArgs{RecognitionRegion}"/> instance containing the event data.</param>
        private void textRecognitionRegionEditorTool_FocusedRegionInteractionFinished(
            object sender,
            PropertyChangedEventArgs<RecognitionRegion> e)
        {
            // get the text recognition regions on image
            List<RecognitionRegion> textRecognitionRegions = GetTextRecognitionRegions(imageViewer1.Image);
            int index = textRecognitionRegions.IndexOf(e.OldValue);
            if (index != -1)
            {
                _isFocusedTextRecognitionRegionUpdating = true;
                textRecognitionRegions[index] = e.NewValue;
                selectedTextRecognitionRegionRectangleLabel.Text = e.NewValue.Rectangle.ToString();
                textRecognitionRegionsComboBox.Items[index] = e.NewValue;
                _isFocusedTextRecognitionRegionUpdating = false;
            }
        }

        /// <summary>
        /// Deletes the focused text recognition region.
        /// </summary>
        private void DeleteFocusedTextRecognitionRegion()
        {
            // if there is a focused text recognition region
            if (textRecognitionRegionsComboBox.SelectedIndex >= 0)
            {
                // get all text recognition regions
                List<RecognitionRegion> textRecognitionRegions = GetTextRecognitionRegions(imageViewer1.Image);

                int index = textRecognitionRegionsComboBox.SelectedIndex;
                int count = textRecognitionRegions.Count;
                textRecognitionRegions.RemoveAt(index);
                if (index == (count - 1))
                    index--;

                // highlight text recognition regions on image
                HighlightTextRecognitionRegionsOnImage();

                textRecognitionRegionsComboBox.SelectedIndex = index;
            }
        }

        #endregion


        #region Text Recognition

        /// <summary>
        /// Recognizes text in images asynchronously.
        /// </summary>
        /// <param name="images">Images to recognize.</param>
        private void RecognizeTextAsync(params VintasoftImage[] images)
        {
            if (images == null || images.Length == 0)
                return;

            IsImageProcessing = true;

            try
            {
                // create main Tesseract OCR engine
                TesseractOcr mainTesseractOcrEngine = CreateTesseractOcrEngine(_imageBinarizationMode);

                // an array with additional Tesseract OCR engines
                TesseractOcr[] additionalTesseractOcrEngines = null;
                // if text recognition must be executed in multiple threads
                if (_useMultithreading && _maxThreads > 1)
                {
                    // create additional Tesseract OCR engines
                    additionalTesseractOcrEngines = new TesseractOcr[_maxThreads - 1];
                    for (int i = 0; i < additionalTesseractOcrEngines.Length; i++)
                    {
                        // create an additional Tesseract OCR engine
                        TesseractOcr additionalTesseractOcrEngine = CreateTesseractOcrEngine(OcrBinarizationMode.None);

                        // if main Tesseract OCR engine will binarize image before text recognition
                        if (mainTesseractOcrEngine.Binarization != null)
                            // specify that additional Tesseract OCR engine also must binarize image before text recognition
                            additionalTesseractOcrEngine.Binarization = (ChangePixelFormatToBlackWhiteCommand)mainTesseractOcrEngine.Binarization.Clone();

                        // save information about additional Tesseract OCR engine
                        additionalTesseractOcrEngines[i] = additionalTesseractOcrEngine;
                    }
                }

                // an array with OCR recognition settings for each image
                ImageOcrRecognitionSettings[] imageOcrRecognitionSettings = new ImageOcrRecognitionSettings[images.Length];
                // for each image
                for (int i = 0; i < images.Length; i++)
                {
                    VintasoftImage image = images[i];
                    // get the text recognition regions on image
                    List<RecognitionRegion> textRecognitionRegions = GetTextRecognitionRegions(image);
                    // if recognition region splitting is required
                    if (textRecognitionRegions.Count == 0)
                    {
                        // specify that image must not be splitted into regions
                        textRecognitionRegions = null;
                    }

                    // create the OCR recognition settings for image
                    ImageOcrRecognitionSettings imageSettings = new ImageOcrRecognitionSettings(
                        image, _tesseractOcrSettings, textRecognitionRegions);
                    // save the OCR recognition settings for image
                    imageOcrRecognitionSettings[i] = imageSettings;
                }

                // create OCR engine manager
                OcrEngineManager engineManager = new OcrEngineManager(mainTesseractOcrEngine, additionalTesseractOcrEngines);
                // specify recognition region splitting settings
                engineManager.RecognitionRegionSplittingSettings = _ocrRecognitionRegionSplittingSettings;
                // subscribe to progress event
                engineManager.Progress += new EventHandler<ProgressEventArgs>(ocrEngineManager_Progress);

                // create text recognition thread 
                Thread textRecognitionThread = new Thread(TextRecognitionThread);
                // specify that the thread must be run in background
                textRecognitionThread.IsBackground = true;
                // create parameters for the thread
                object[] textRecognitionThreadParams = new object[] {
                    imageOcrRecognitionSettings,
                    engineManager,
                    mainTesseractOcrEngine,
                    additionalTesseractOcrEngines
                };
                // start the text recognition in a background thread
                textRecognitionThread.Start(textRecognitionThreadParams);
            }
            catch (Exception ex)
            {
                ShowTesseractOcrErrorMessage(ex);
                IsImageProcessing = false;
            }
        }

        /// <summary>
        /// Shows the Tesseract OCR error message.
        /// </summary>
        /// <param name="ex">The exeption.</param>
        private void ShowTesseractOcrErrorMessage(Exception ex)
        {
            if (ex.Message.Contains("ErrorCode=126"))
            {
                DemosTools.ShowErrorMessage(string.Format("{0}. Microsoft Visual C++ 2019 Redistributable Package must be installed on computer for correct work of Tesseract5.", ex.Message));
            }
            else
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Creates the Tesseract OCR engine.
        /// </summary>
        /// <param name="ocrBinarizationMode">OCR binarization mode.</param>
        /// <returns>The Tesseract OCR engine.</returns>
        private TesseractOcr CreateTesseractOcrEngine(OcrBinarizationMode ocrBinarizationMode)
        {
            // create the Tesseract OCR engine
            TesseractOcr tesseractOcrEngine = new TesseractOcr(TesseractOcrDllDirectory);
            tesseractOcrEngine.Initialized += new EventHandler(ocrEngine_Initialized);

            // create the binarization command, which will binarize images before text recognition
            ChangePixelFormatToBlackWhiteCommand binarizationCommand = null;
            switch (ocrBinarizationMode)
            {
                case OcrBinarizationMode.Global:
                    binarizationCommand = new ChangePixelFormatToBlackWhiteCommand(BinarizationMode.Global);
                    break;

                case OcrBinarizationMode.Adaptive:
                    binarizationCommand = new ChangePixelFormatToBlackWhiteCommand(BinarizationMode.Adaptive);
                    break;
            }
            // set the binarization command
            tesseractOcrEngine.Binarization = binarizationCommand;

            return tesseractOcrEngine;
        }

        /// <summary>
        /// The text recognition thread.
        /// </summary>
        /// <param name="recognitionParams">Text recognition parameters.</param>
        private void TextRecognitionThread(object recognitionParams)
        {
            // get the text recognition parameters

            object[] objArray = (object[])recognitionParams;
            ImageOcrRecognitionSettings[] imageOcrRecognitionSettings = (ImageOcrRecognitionSettings[])objArray.GetValue(0);
            OcrEngineManager engineManager = (OcrEngineManager)objArray.GetValue(1);
            TesseractOcr mainTesseractOcrEngine = (TesseractOcr)objArray.GetValue(2);
            TesseractOcr[] additionalTesseractOcrEngines = (TesseractOcr[])objArray.GetValue(3);

            try
            {
                // recognize text in images
                OcrPage[] pages = engineManager.Recognize(imageOcrRecognitionSettings);

                // save the OCR results
                Invoke(new SaveOcrResultDelegate(SaveOcrResults), imageOcrRecognitionSettings, pages);
            }
            catch (Exception exc)
            {
                DemosTools.ShowErrorMessage(exc);
            }
            finally
            {
                // dispose the main Tesseract OCR engine
                mainTesseractOcrEngine.Dispose();
                if (additionalTesseractOcrEngines != null)
                {
                    // dispose the additional Tesseract OCR engines

                    foreach (TesseractOcr additionalEngine in additionalTesseractOcrEngines)
                    {
                        additionalEngine.Dispose();
                    }
                }

                if (_previousOcrLanguages != null)
                {
                    // restore previously saved OCR languages
                    _tesseractOcrSettings.Languages = _previousOcrLanguages;
                    _previousOcrLanguages = null;
                }

                IsImageProcessing = false;
            }
        }

        /// <summary>
        /// Saves the OCR results for images.
        /// </summary>
        /// <param name="imageOcrRecognitionSettings">Information about images.</param>
        /// <param name="pages">The OCR results.</param>
        private void SaveOcrResults(
            ImageOcrRecognitionSettings[] imageOcrRecognitionSettings,
            OcrPage[] pages)
        {
            // for each image
            for (int i = 0; i < imageOcrRecognitionSettings.Length; i++)
            {
                SaveOcrResult(imageOcrRecognitionSettings[i].Image, pages[i]);
            }

            // update the OCR result for focused image
            UpdateImageRecognizedResults();
        }

        /// <summary>
        /// Saves the OCR result for specified image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="page">Image OCR result.</param>
        private void SaveOcrResult(VintasoftImage image, OcrPage page)
        {
            // replace non-standard symbols in results
            PostprocessOcrResults(page);

            // save OCR result of image
            _imagesToOcrPages[image] = page;

            // if image is focused in image viewer
            if (image == imageViewer1.Image)
            {
                // set the OCR result for focused image
                OcrResultForFocusedImage = page;

                // if words with low confidence must be highlighted
                if (_highlightLowConfidenceWordsAfterRecognition)
                {
                    // highlight OCR results for focused image
                    HighlightOcrResultsOnImage();
                }

                // acivate tab with OCR result
                textRecognitionTab.SelectedTab = recognitionResultsTabPage;
            }
        }

        /// <summary>
        /// Handler of the TesseractOcr.Initialized event.
        /// </summary>
        private void ocrEngine_Initialized(object sender, EventArgs e)
        {
            // here you can set Tesseract OCR variables
        }

        /// <summary>
        /// Handler of the OcrEngineManager.Progress event.
        /// </summary>
        private void ocrEngineManager_Progress(object sender, ProgressEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new ProgressDelegate(ocrEngineManager_Progress), sender, e);
            }
            else
            {
                bool isProgressIndicatorVisible = e.Progress != 100;

                ocrEngineManagerProgressBar.Visible = isProgressIndicatorVisible;
                ocrEngineManagerProgressBar.Value = e.Progress;
            }
        }

        #endregion


        #region Post-processing of text recognition (OCR) results

        /// <summary>
        /// Replaces non-standard symbols in OCR result page.
        /// </summary>
        /// <param name="page">The OCR page.</param>
        private void PostprocessOcrResults(OcrPage page)
        {
            if (_tesseractOcrSettings.Language == OcrLanguage.English)
            {
                // create an editor for OCR page
                OcrResultsEditor editor = new OcrResultsEditor(page);

                // create a map of symbols which must be replaced by another symbols
                Dictionary<char, string> symbolsMap = new Dictionary<char, string>();
                // replace symbol '|' to symbol 'I'
                symbolsMap.Add((char)124, "I");
                // replace symbols
                editor.ReplaceSymbols(symbolsMap);

                // validate OCR result
                editor.ValidateResults();
            }
        }

        #endregion


        #region Text Recognition (OCR) Results

        /// <summary>
        /// Highlights OCR results on focused image.
        /// </summary>
        private void HighlightOcrResultsOnImage()
        {
            if (OcrResultForFocusedImage == null)
                return;

            // get a type of objects (words, paragraphs, etc), which must be highlighted in image viewer
            OcrObjectType objectsType = _ocrResultEditorTool.ObjectsType;
            // get objects (words, paragraphs, etc)
            OcrObject[] objects = null;
            if (objectsType == OcrObjectType.Word)
                objects = OcrResultForFocusedImage.GetWords(maxConfidenceTrackBar.Value, maxConfidenceFromDictTrackBar.Value);
            else
                objects = OcrResultForFocusedImage.GetObjects(objectsType, maxConfidenceTrackBar.Value);

            // highlight objects (words, paragraphs, etc) in image viewer
            _ocrResultEditorTool.SetSelectedObjects(objects);

            // update the UI
            UpdateUI();
        }

        /// <summary>
        /// Handler of the OcrResultEditorTool.FocusedOcrObjectChanged event.
        /// </summary>
        private void ocrResultsEditorTool_FocusedOcrObjectChanged(object sender, EventArgs e)
        {
            OcrObject currentObject = _ocrResultEditorTool.FocusedObject;
            if (currentObject == null)
            {
                ocrObjectRectLabel.Text = "";
                ocrObjectTypeLabel.Text = "";
                ocrObjectTextBox.Text = "";
                ocrObjectOrientationLabel.Text = "";
                ocrObjectConfidenceLabel.Text = "";
                ocrObjectTextBox.ReadOnly = true;
            }
            else
            {
                ocrObjectRectLabel.Text = currentObject.GetBoundingBox().ToString();
                if (currentObject is OcrWord)
                {
                    OcrWord word = (OcrWord)currentObject;
                    if (word.IsNumeric)
                        ocrObjectTypeLabel.Text = string.Format("{0} (Number)", currentObject.Type);
                    else if (word.IsFromDictionary)
                        ocrObjectTypeLabel.Text = string.Format("{0} (from Dictionary)", currentObject.Type);
                    else
                        ocrObjectTypeLabel.Text = currentObject.Type.ToString();
                }
                else
                {
                    ocrObjectTypeLabel.Text = currentObject.Type.ToString();
                }
                ocrObjectOrientationLabel.Text = currentObject.Orientation.ToString();
                ocrObjectConfidenceLabel.Text = string.Format(CultureInfo.InvariantCulture, "{0}%", currentObject.Confidence);
                if (currentObject is IOcrTextObject)
                    ocrObjectTextBox.Text = ((IOcrTextObject)currentObject).Text;

                ocrObjectTextBox.ReadOnly = !(currentObject.Type == OcrObjectType.Symbol || currentObject.Type == OcrObjectType.Word);
            }

            // update the UI
            UpdateUI();
        }

        /// <summary>
        /// Deletes all selected OCR objects.
        /// </summary>
        private void DeleteAllSelectedOcrObjects()
        {
            OcrResultsEditor editor = new OcrResultsEditor(OcrResultForFocusedImage);

            OcrObject[] objects = new OcrObject[_ocrResultEditorTool.SelectedObjects.Count];
            _ocrResultEditorTool.SelectedObjects.CopyTo(objects, 0);
            editor.RemoveObjects(objects);
            editor.ValidateResults();

            _ocrResultEditorTool.Update();
        }

        #endregion


        #region Common

        /// <summary>
        /// Updates the information about focused image.
        /// </summary>
        private void UpdateImageInfo()
        {
            try
            {
                if (imageViewer1.FocusedIndex == -1)
                {
                    imageInfoLabel.Text = "";
                    return;
                }

                VintasoftImage image = imageViewer1.Image;

                // image size (megapixels or gigapixels)
                string sizeInfo;
                float mpx = (float)image.Width * image.Height / (1000f * 1000f);
                if (mpx < 0.01)
                    sizeInfo = (image.Width * image.Height).ToString() + "Px";
                else if (mpx < 10)
                    sizeInfo = mpx.ToString("F2", CultureInfo.InvariantCulture) + "MPx";
                else if (mpx < 1000)
                    sizeInfo = mpx.ToString("F1", CultureInfo.InvariantCulture) + "MPx";
                else
                    sizeInfo = (mpx / 1000f).ToString("F2", CultureInfo.InvariantCulture) + "GPx";

                // show information about the current image
                imageInfoLabel.Text = string.Format("Size={0}x{1} ({2}); Resolution={3}",
                    image.Width, image.Height, sizeInfo, image.Resolution);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Updates the text recognition regions and OCR results on focused image.
        /// </summary>
        private void UpdateImageRecognizedResults()
        {
            _ocrResultEditorTool.Page = OcrResultForFocusedImage;

            // specify that words should be highlighted in viewer
            ocrObjectTypeComboBox.SelectedItem = OcrObjectType.Word;

            // highlight the text recognition regions on focused image
            HighlightTextRecognitionRegionsOnImage();

            // highlight the OCR results on focused image
            HighlightOcrResultsOnImage();
        }

        /// <summary>
        /// Returns a value indicating whether 2 arrays contains the same languages.
        /// </summary>
        /// <param name="firstOcrLanguages">The first array with languages.</param>
        /// <param name="secondOcrLanguages">The second array with languages.</param>
        /// <returns><b>True</b> if 2 arrays contains the same languages; otherwise, <b>false</b>.</returns>
        private bool AreLanguagesEqual(OcrLanguage[] firstOcrLanguages, OcrLanguage[] secondOcrLanguages)
        {
            if (firstOcrLanguages.Length != secondOcrLanguages.Length)
                return false;

            for (int i = 0; i < firstOcrLanguages.Length; i++)
            {
                if (Array.IndexOf(secondOcrLanguages, firstOcrLanguages[i]) == -1)
                    return false;
            }

            return false;
        }

#if !REMOVE_PDF_PLUGIN
        /// <summary>
        /// Saves OCR result in a PDF document.
        /// </summary>
        /// <param name="creationMode">PDF page creation mode.</param>
        /// <param name="documentConformance">PDF document conformance.</param>
        private void SaveOcrResultInPdfDocument(PdfPageCreationMode creationMode, PdfDocumentConformance documentConformance)
        {
            try
            {
                saveFileDialog.Filter = "PDF Documents(*.pdf)|*.pdf";
                // show the save file dialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog.FileName;

                    // if OCR result must be saved as PDF document with "Image Over Text" mode
                    if (creationMode == PdfPageCreationMode.ImageOverText ||
                        creationMode == PdfPageCreationMode.TextOverImage)
                    {
                        // set PDF image compression settings
                        PdfImageCompressionSettingsForm compressionSettingsForm = new PdfImageCompressionSettingsForm();
                        compressionSettingsForm.Compression = _pdfCompression;
                        compressionSettingsForm.CompressionSettings = _pdfCompressionSettings;
#if !REMOVE_DOCCLEANUP_PLUGIN
                        compressionSettingsForm.MrcCompressionSettings = _pdfMrcCompressionSettings;
#endif
                        if (compressionSettingsForm.ShowDialog() != DialogResult.OK)
                            return;
                        _pdfCompression = compressionSettingsForm.Compression;
                        _pdfCompressionSettings = compressionSettingsForm.CompressionSettings;
#if !REMOVE_DOCCLEANUP_PLUGIN
                        _pdfMrcCompressionSettings = compressionSettingsForm.MrcCompressionSettings;
#endif
                    }

                    // create new PDF document
                    using (PdfDocument document = new PdfDocument(filename, System.IO.FileMode.Create, PdfFormat.Pdf_16))
                    {
                        // create a PDF document builder that helps to create searchable PDF document
                        PdfDocumentBuilder documentBuilder = new PdfDocumentBuilder(document);
                        documentBuilder.RestoreNormalPageOrientation = true;
                        documentBuilder.PageCreationMode = creationMode;
                        documentBuilder.CleanupSettings = _cleanupSettings;
                        documentBuilder.TextOverImageSettings = _textOverImageSettings;

                        // if result document conformance is PDF/A-1/2/3a 
                        if (documentConformance == PdfDocumentConformance.PdfA_1a ||
                            documentConformance == PdfDocumentConformance.PdfA_2a ||
                            documentConformance == PdfDocumentConformance.PdfA_3a)
                        {
                            // add marked content to PDF document
                            documentBuilder.AddMarkedContent = true;
                        }

#if !REMOVE_DOCCLEANUP_PLUGIN
                        PdfMrcEncoder mrcEncoder = null;
#endif
                        if (creationMode == PdfPageCreationMode.ImageOverText ||
                            creationMode == PdfPageCreationMode.TextOverImage)
                        {
                            // set compression settings
                            documentBuilder.ImageCompression = _pdfCompression;
                            documentBuilder.ImageCompressionSettings = _pdfCompressionSettings;
#if !REMOVE_DOCCLEANUP_PLUGIN
                            // if PDF MRC compression is enabled
                            if (_pdfMrcCompressionSettings.EnableMrcCompression)
                            {
                                // create PDF MRC encoder
                                mrcEncoder = new PdfMrcEncoder();
                                mrcEncoder.MrcCompressionSettings = _pdfMrcCompressionSettings;
                            }
#endif
                        }

                        // if OCR result must be saved as PDF document with "Image Over Text" mode
                        if (creationMode == PdfPageCreationMode.ImageOverText)
                        {
                            // use CID glyph less font
                            documentBuilder.Font = PdfDocumentBuilder.CreateGlyphLessFont(document);
                        }
                        else if (creationMode == PdfPageCreationMode.Text)
                        {
                            // show dialog for font selection
                            using (CreateFontForm dlg = new CreateFontForm(document))
                            {
                                if (dlg.ShowDialog() == DialogResult.OK)
                                {
                                    documentBuilder.Font = dlg.SelectedFont;
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }


                        // initialize the progress bar
                        saveOcrResultsProgressBar.Value = 0;
                        saveOcrResultsProgressBar.Maximum = imageViewer1.Images.Count;
                        // show the progress bar
                        saveOcrResultsProgressBar.Visible = true;

                        // for each image
                        for (int i = 0; i < imageViewer1.Images.Count; i++)
                        {
                            // increment progress
                            saveOcrResultsProgressBar.Value = i + 1;

                            // get reference to the image
                            VintasoftImage image = imageViewer1.Images[i];

                            // if OCR was performed for the image
                            if (_imagesToOcrPages.ContainsKey(image))
                            {
#if !REMOVE_DOCCLEANUP_PLUGIN
                                // if PDF MRC compression must be used
                                if (mrcEncoder != null)
                                {
                                    // encode image using MRC compression and add to document
                                    document.Pages.Add(mrcEncoder.EncodeImage(document, image, null));
                                    // set OCR page as background of image that was compressed using PDF MRC compression
                                    documentBuilder.SetAsBackground(i, _imagesToOcrPages[image]);
                                }
                                else
#endif
                                {
                                    // add PDF page with OCR result to the PDF document
                                    documentBuilder.AddPage(imageViewer1.Images[i], _imagesToOcrPages[image]);
                                }
                            }
                            // if OCR was NOT performed for the image
                            else
                            {
                                // add image to the PDF document
                                documentBuilder.AddPage(imageViewer1.Images[i], null);
                            }
                        }

                        // if PDF document conformance is specified
                        if (documentConformance != PdfDocumentConformance.Undefined)
                        {
                            // create PDF document converter
                            PdfDocumentConverter converter = PdfDocumentConverter.Create(documentConformance);
                            if (converter == null)
                                throw new NotImplementedException("PDF/A converter not found.");

                            // create processing state
                            using (ProcessingState processingState = new ProcessingState())
                            {
                                // convert PDF document
                                ConversionProfileResult result = converter.Convert(document, processingState);

                                // if PDF document is not converted
                                if (!result.IsSuccessful)
                                {
                                    // throw error
                                    throw result.CreateConversionException();
                                }
                            }
                        }
                        else
                        {
                            // save changes in PDF document
                            document.SaveChanges();
                        }

                        // hide progress bar
                        saveOcrResultsProgressBar.Visible = false;
                    }

                    // open PDF document using system-defined PDF viewer
                    ProcessStartInfo processInfo = new ProcessStartInfo(filename);
                    processInfo.UseShellExecute = true;
                    Process.Start(processInfo);
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }
#endif

        #endregion


        #region View Rotation

        /// <summary>
        /// Rotates images in both annotation viewer and thumbnail viewer by 90 degrees clockwise.
        /// </summary>
        private void RotateViewClockwise()
        {
            imageViewer1.RotateViewClockwise();
            thumbnailViewer1.RotateViewClockwise();
        }

        /// <summary>
        /// Rotates images in both annotation viewer and thumbnail viewer by 90 degrees counterclockwise.
        /// </summary>
        private void RotateViewCounterClockwise()
        {
            imageViewer1.RotateViewCounterClockwise();
            thumbnailViewer1.RotateViewCounterClockwise();
        }

        #endregion

        #endregion

        #endregion



        #region Delegates

        delegate void UpdateUIDelegate();

        delegate void ProgressDelegate(object sender, ProgressEventArgs e);

        delegate void SaveOcrResultDelegate(ImageOcrRecognitionSettings[] imageOcrRecognitionSettings, OcrPage[] pages);


        #endregion

    }
}
