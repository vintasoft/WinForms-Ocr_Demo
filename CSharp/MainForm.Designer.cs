namespace OcrDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Vintasoft.Imaging.Utils.WinFormsSystemClipboard winFormsSystemClipboard1 = new Vintasoft.Imaging.Utils.WinFormsSystemClipboard();
            Vintasoft.Imaging.Codecs.Decoders.RenderingSettings renderingSettings1 = new Vintasoft.Imaging.Codecs.Decoders.RenderingSettings();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance1 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance2 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance3 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance4 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance5 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailCaption thumbnailCaption1 = new Vintasoft.Imaging.UI.ThumbnailCaption();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsPdfDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageOverTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfImageOverTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfImageOverTextPDFA1aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfImageOverTextPDFA1bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfImageOverTextPDFA2aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfImageOverTextPDFA2bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfImageOverTextPDFA4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textOverImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfTextOverImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfTextOverImagePDFA1aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfTextOverImagePDFA1bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfTextOverImagePDFA2aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfTextOverImagePDFA2bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfTextOverImagePDFA4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.pdfTextOverImageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfTextOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cleanupSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFormattedTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thumbnailViewerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.imageScaleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelToPixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorZoomModes = new System.Windows.Forms.ToolStripSeparator();
            this.scale25ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale400ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.counterclockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageViewerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentCurrentPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentAllPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSegmentationResultForCurrentImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSegmentationResultsForAllImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recognizeTextInCurrentImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recognizeTextInAllImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.recognizeMICRInCurrentImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recognizeMRZInCurrenImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.detectPageOrientationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.removeRecognitionResultForCurrentImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRecognitionResultsForAllImagesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.loadRecognitionResultsFromDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRecognitionResultsFromHOCRFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecognitionResultsToHOCRFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToHocrForCurrentImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToHocrForAllImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.imageInfoStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveOcrResultsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ocrEngineManagerProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.imageInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ocrObjectOrientationLabel = new System.Windows.Forms.Label();
            this.orientationLabel = new System.Windows.Forms.Label();
            this.ocrObjectConfidenceLabel = new System.Windows.Forms.Label();
            this.confidenceLabel = new System.Windows.Forms.Label();
            this.ocrObjectRectLabel = new System.Windows.Forms.Label();
            this.ocrObjectTextBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.rectLabel = new System.Windows.Forms.Label();
            this.ocrObjectTypeLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.deselectSelectedOcrObjectButton = new System.Windows.Forms.Button();
            this.deselectAllSelectedOcrObjectsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteAllSelectedObjectsButton = new System.Windows.Forms.Button();
            this.deleteSelectedObjectButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxConfidenceFromDictLabel = new System.Windows.Forms.Label();
            this.maxConfidenceValueLabel = new System.Windows.Forms.Label();
            this.selectByConfidenceButton = new System.Windows.Forms.Button();
            this.maxConfidenceLabel = new System.Windows.Forms.Label();
            this.maxConfidenceFromDictionaryLabel = new System.Windows.Forms.Label();
            this.maxConfidenceFromDictTrackBar = new System.Windows.Forms.TrackBar();
            this.maxConfidenceTrackBar = new System.Windows.Forms.TrackBar();
            this.selectedObjectsListBox = new System.Windows.Forms.ListBox();
            this.ocrResultsEditorPanel = new System.Windows.Forms.Panel();
            this.ocrObjectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.objectTypeLabel = new System.Windows.Forms.Label();
            this.selectedTextRecognitionRegionGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.selectedTextRecognitionRegionOcrLanguagesListBox = new DemosCommonCode.Imaging.OcrLanguagesListBox();
            this.selectedTextRecognitionRegionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.recognitionRegionTypeLabel = new System.Windows.Forms.Label();
            this.selectedTextRecognitionRegionTextRotationComboBox = new System.Windows.Forms.ComboBox();
            this.textRotationLabel = new System.Windows.Forms.Label();
            this.selectedTextRecognitionRegionRectangleLabel = new System.Windows.Forms.Label();
            this.rectangleLabel = new System.Windows.Forms.Label();
            this.removeAllTextRecognitionRegionsButton = new System.Windows.Forms.Button();
            this.removeTextRecognitionRegionButton = new System.Windows.Forms.Button();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.thumbnailViewer1 = new Vintasoft.Imaging.UI.ThumbnailViewer();
            this.textRecognitionTab = new System.Windows.Forms.TabControl();
            this.segmentationTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addTextRecognitionRegionButton = new System.Windows.Forms.Button();
            this.textRecognitionRegionsPanel = new System.Windows.Forms.Panel();
            this.textRecognitionRegionsComboBox = new System.Windows.Forms.ComboBox();
            this.textRecognitionRegionsLabel = new System.Windows.Forms.Label();
            this.recognitionResultsTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.imageViewerToolStrip1 = new DemosCommonCode.Imaging.ImageViewerToolStrip();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxConfidenceFromDictTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxConfidenceTrackBar)).BeginInit();
            this.ocrResultsEditorPanel.SuspendLayout();
            this.selectedTextRecognitionRegionGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.textRecognitionTab.SuspendLayout();
            this.segmentationTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.textRecognitionRegionsPanel.SuspendLayout();
            this.recognitionResultsTabPage.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.segmentationToolStripMenuItem,
            this.oCRToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1041, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.addToolStripMenuItem,
            this.scanImagesToolStripMenuItem,
            this.closeImagesToolStripMenuItem,
            this.toolStripSeparator4,
            this.saveAsPdfDocumentToolStripMenuItem,
            this.saveAsTextToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openToolStripMenuItem.Text = "Open Image(s)...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.addToolStripMenuItem.Text = "Add Image(s)...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // scanImagesToolStripMenuItem
            // 
            this.scanImagesToolStripMenuItem.Name = "scanImagesToolStripMenuItem";
            this.scanImagesToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.scanImagesToolStripMenuItem.Text = "Scan and Add...";
            this.scanImagesToolStripMenuItem.Click += new System.EventHandler(this.scanImagesToolStripMenuItem_Click);
            // 
            // closeImagesToolStripMenuItem
            // 
            this.closeImagesToolStripMenuItem.Name = "closeImagesToolStripMenuItem";
            this.closeImagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeImagesToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.closeImagesToolStripMenuItem.Text = "Close";
            this.closeImagesToolStripMenuItem.Click += new System.EventHandler(this.closeImagesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(226, 6);
            // 
            // saveAsPdfDocumentToolStripMenuItem
            // 
            this.saveAsPdfDocumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageOverTextToolStripMenuItem,
            this.textOverImageToolStripMenuItem,
            this.pdfTextOnlyToolStripMenuItem,
            this.toolStripSeparator11,
            this.cleanupSettingsToolStripMenuItem});
            this.saveAsPdfDocumentToolStripMenuItem.Name = "saveAsPdfDocumentToolStripMenuItem";
            this.saveAsPdfDocumentToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.saveAsPdfDocumentToolStripMenuItem.Text = "Save As PDF Document";
            // 
            // imageOverTextToolStripMenuItem
            // 
            this.imageOverTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdfImageOverTextToolStripMenuItem,
            this.pdfImageOverTextPDFA1aToolStripMenuItem,
            this.pdfImageOverTextPDFA1bToolStripMenuItem,
            this.pdfImageOverTextPDFA2aToolStripMenuItem,
            this.pdfImageOverTextPDFA2bToolStripMenuItem,
            this.pdfImageOverTextPDFA4ToolStripMenuItem});
            this.imageOverTextToolStripMenuItem.Name = "imageOverTextToolStripMenuItem";
            this.imageOverTextToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.imageOverTextToolStripMenuItem.Text = "Image over text";
            // 
            // pdfImageOverTextToolStripMenuItem
            // 
            this.pdfImageOverTextToolStripMenuItem.Name = "pdfImageOverTextToolStripMenuItem";
            this.pdfImageOverTextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.pdfImageOverTextToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pdfImageOverTextToolStripMenuItem.Text = "PDF 1.6...";
            this.pdfImageOverTextToolStripMenuItem.Click += new System.EventHandler(this.saveOcrResultToPdfDocumentWithImageOverTextModeToolStripMenuItem_Click);
            // 
            // pdfImageOverTextPDFA1aToolStripMenuItem
            // 
            this.pdfImageOverTextPDFA1aToolStripMenuItem.Name = "pdfImageOverTextPDFA1aToolStripMenuItem";
            this.pdfImageOverTextPDFA1aToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pdfImageOverTextPDFA1aToolStripMenuItem.Text = "PDF/A-1a...";
            this.pdfImageOverTextPDFA1aToolStripMenuItem.Click += new System.EventHandler(this.pdfImageOverTextPDFA1aToolStripMenuItem_Click);
            // 
            // pdfImageOverTextPDFA1bToolStripMenuItem
            // 
            this.pdfImageOverTextPDFA1bToolStripMenuItem.Name = "pdfImageOverTextPDFA1bToolStripMenuItem";
            this.pdfImageOverTextPDFA1bToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pdfImageOverTextPDFA1bToolStripMenuItem.Text = "PDF/A-1b...";
            this.pdfImageOverTextPDFA1bToolStripMenuItem.Click += new System.EventHandler(this.pdfImageOverTextPDFA1bToolStripMenuItem_Click);
            // 
            // pdfImageOverTextPDFA2aToolStripMenuItem
            // 
            this.pdfImageOverTextPDFA2aToolStripMenuItem.Name = "pdfImageOverTextPDFA2aToolStripMenuItem";
            this.pdfImageOverTextPDFA2aToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pdfImageOverTextPDFA2aToolStripMenuItem.Text = "PDF/A-2a...";
            this.pdfImageOverTextPDFA2aToolStripMenuItem.Click += new System.EventHandler(this.pdfImageOverTextPDFA2aToolStripMenuItem_Click);
            // 
            // pdfImageOverTextPDFA2bToolStripMenuItem
            // 
            this.pdfImageOverTextPDFA2bToolStripMenuItem.Name = "pdfImageOverTextPDFA2bToolStripMenuItem";
            this.pdfImageOverTextPDFA2bToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pdfImageOverTextPDFA2bToolStripMenuItem.Text = "PDF/A-2b...";
            this.pdfImageOverTextPDFA2bToolStripMenuItem.Click += new System.EventHandler(this.pdfImageOverTextPDFA2bToolStripMenuItem_Click);
            // 
            // pdfImageOverTextPDFA4ToolStripMenuItem
            // 
            this.pdfImageOverTextPDFA4ToolStripMenuItem.Name = "pdfImageOverTextPDFA4ToolStripMenuItem";
            this.pdfImageOverTextPDFA4ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pdfImageOverTextPDFA4ToolStripMenuItem.Text = "PDF/A-4...";
            this.pdfImageOverTextPDFA4ToolStripMenuItem.Click += new System.EventHandler(this.pdfImageOverTextPDFA4ToolStripMenuItem_Click);
            // 
            // textOverImageToolStripMenuItem
            // 
            this.textOverImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdfTextOverImageToolStripMenuItem,
            this.pdfTextOverImagePDFA1aToolStripMenuItem,
            this.pdfTextOverImagePDFA1bToolStripMenuItem,
            this.pdfTextOverImagePDFA2aToolStripMenuItem,
            this.pdfTextOverImagePDFA2bToolStripMenuItem,
            this.pdfTextOverImagePDFA4ToolStripMenuItem,
            this.toolStripSeparator9,
            this.pdfTextOverImageSettingsToolStripMenuItem});
            this.textOverImageToolStripMenuItem.Name = "textOverImageToolStripMenuItem";
            this.textOverImageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.textOverImageToolStripMenuItem.Text = "Text over image";
            // 
            // pdfTextOverImageToolStripMenuItem
            // 
            this.pdfTextOverImageToolStripMenuItem.Name = "pdfTextOverImageToolStripMenuItem";
            this.pdfTextOverImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F9)));
            this.pdfTextOverImageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pdfTextOverImageToolStripMenuItem.Text = "PDF 1.6...";
            this.pdfTextOverImageToolStripMenuItem.Click += new System.EventHandler(this.saveOcrResultToPdfDocumentWithTextOverImageModeToolStripMenuItem_Click);
            // 
            // pdfTextOverImagePDFA1aToolStripMenuItem
            // 
            this.pdfTextOverImagePDFA1aToolStripMenuItem.Name = "pdfTextOverImagePDFA1aToolStripMenuItem";
            this.pdfTextOverImagePDFA1aToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pdfTextOverImagePDFA1aToolStripMenuItem.Text = "PDF/A-1a...";
            this.pdfTextOverImagePDFA1aToolStripMenuItem.Click += new System.EventHandler(this.pdfTextOverImagePDFA1aToolStripMenuItem_Click);
            // 
            // pdfTextOverImagePDFA1bToolStripMenuItem
            // 
            this.pdfTextOverImagePDFA1bToolStripMenuItem.Name = "pdfTextOverImagePDFA1bToolStripMenuItem";
            this.pdfTextOverImagePDFA1bToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pdfTextOverImagePDFA1bToolStripMenuItem.Text = "PDF/A-1b...";
            this.pdfTextOverImagePDFA1bToolStripMenuItem.Click += new System.EventHandler(this.pdfTextOverImagePDFA1bToolStripMenuItem_Click);
            // 
            // pdfTextOverImagePDFA2aToolStripMenuItem
            // 
            this.pdfTextOverImagePDFA2aToolStripMenuItem.Name = "pdfTextOverImagePDFA2aToolStripMenuItem";
            this.pdfTextOverImagePDFA2aToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pdfTextOverImagePDFA2aToolStripMenuItem.Text = "PDF/A-2a...";
            this.pdfTextOverImagePDFA2aToolStripMenuItem.Click += new System.EventHandler(this.pdfTextOverImagePDFA2aToolStripMenuItem_Click);
            // 
            // pdfTextOverImagePDFA2bToolStripMenuItem
            // 
            this.pdfTextOverImagePDFA2bToolStripMenuItem.Name = "pdfTextOverImagePDFA2bToolStripMenuItem";
            this.pdfTextOverImagePDFA2bToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pdfTextOverImagePDFA2bToolStripMenuItem.Text = "PDF/A-2b...";
            this.pdfTextOverImagePDFA2bToolStripMenuItem.Click += new System.EventHandler(this.pdfTextOverImagePDFA2bToolStripMenuItem_Click);
            // 
            // pdfTextOverImagePDFA4ToolStripMenuItem
            // 
            this.pdfTextOverImagePDFA4ToolStripMenuItem.Name = "pdfTextOverImagePDFA4ToolStripMenuItem";
            this.pdfTextOverImagePDFA4ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pdfTextOverImagePDFA4ToolStripMenuItem.Text = "PDF/A-4...";
            this.pdfTextOverImagePDFA4ToolStripMenuItem.Click += new System.EventHandler(this.pdfTextOverImagePDFA4ToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(161, 6);
            // 
            // pdfTextOverImageSettingsToolStripMenuItem
            // 
            this.pdfTextOverImageSettingsToolStripMenuItem.Name = "pdfTextOverImageSettingsToolStripMenuItem";
            this.pdfTextOverImageSettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pdfTextOverImageSettingsToolStripMenuItem.Text = "Settings...";
            this.pdfTextOverImageSettingsToolStripMenuItem.Click += new System.EventHandler(this.pdfTextOverImageSettingsToolStripMenuItem_Click);
            // 
            // pdfTextOnlyToolStripMenuItem
            // 
            this.pdfTextOnlyToolStripMenuItem.Name = "pdfTextOnlyToolStripMenuItem";
            this.pdfTextOnlyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F9)));
            this.pdfTextOnlyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pdfTextOnlyToolStripMenuItem.Text = "Text-only...";
            this.pdfTextOnlyToolStripMenuItem.Click += new System.EventHandler(this.saveOcrResultToPdfDocumentWithTextOnlyModeToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(180, 6);
            // 
            // cleanupSettingsToolStripMenuItem
            // 
            this.cleanupSettingsToolStripMenuItem.Name = "cleanupSettingsToolStripMenuItem";
            this.cleanupSettingsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cleanupSettingsToolStripMenuItem.Text = "Settings...";
            this.cleanupSettingsToolStripMenuItem.Click += new System.EventHandler(this.cleanupSettingsToolStripMenuItem_Click);
            // 
            // saveAsTextToolStripMenuItem
            // 
            this.saveAsTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsFormattedTextFileToolStripMenuItem,
            this.saveAsTextFileToolStripMenuItem});
            this.saveAsTextToolStripMenuItem.Name = "saveAsTextToolStripMenuItem";
            this.saveAsTextToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.saveAsTextToolStripMenuItem.Text = "Save As Text File";
            // 
            // saveAsFormattedTextFileToolStripMenuItem
            // 
            this.saveAsFormattedTextFileToolStripMenuItem.Name = "saveAsFormattedTextFileToolStripMenuItem";
            this.saveAsFormattedTextFileToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.saveAsFormattedTextFileToolStripMenuItem.Text = "Save As Formatted Text File...";
            this.saveAsFormattedTextFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsFormattedTextFileToolStripMenuItem_Click);
            // 
            // saveAsTextFileToolStripMenuItem
            // 
            this.saveAsTextFileToolStripMenuItem.Name = "saveAsTextFileToolStripMenuItem";
            this.saveAsTextFileToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.saveAsTextFileToolStripMenuItem.Text = "Save As Text File...";
            this.saveAsTextFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsTextFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thumbnailViewerSettingsToolStripMenuItem,
            this.toolStripSeparator7,
            this.imageScaleModeToolStripMenuItem,
            this.rotateViewToolStripMenuItem,
            this.centerImageToolStripMenuItem,
            this.imageViewerSettingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // thumbnailViewerSettingsToolStripMenuItem
            // 
            this.thumbnailViewerSettingsToolStripMenuItem.Name = "thumbnailViewerSettingsToolStripMenuItem";
            this.thumbnailViewerSettingsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.thumbnailViewerSettingsToolStripMenuItem.Text = "Thumbnail Viewer Settings...";
            this.thumbnailViewerSettingsToolStripMenuItem.Click += new System.EventHandler(this.thumbnailViewerSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(220, 6);
            // 
            // imageScaleModeToolStripMenuItem
            // 
            this.imageScaleModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalImageToolStripMenuItem,
            this.bestFitToolStripMenuItem,
            this.fitToWidthToolStripMenuItem,
            this.fitToHeightToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.pixelToPixelToolStripMenuItem,
            this.toolStripSeparatorZoomModes,
            this.scale25ToolStripMenuItem,
            this.scale50ToolStripMenuItem,
            this.scale100ToolStripMenuItem,
            this.scale200ToolStripMenuItem,
            this.scale400ToolStripMenuItem});
            this.imageScaleModeToolStripMenuItem.Name = "imageScaleModeToolStripMenuItem";
            this.imageScaleModeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.imageScaleModeToolStripMenuItem.Text = "Image Scale Mode";
            // 
            // normalImageToolStripMenuItem
            // 
            this.normalImageToolStripMenuItem.Name = "normalImageToolStripMenuItem";
            this.normalImageToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.normalImageToolStripMenuItem.Text = "Normal";
            this.normalImageToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // bestFitToolStripMenuItem
            // 
            this.bestFitToolStripMenuItem.Name = "bestFitToolStripMenuItem";
            this.bestFitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bestFitToolStripMenuItem.Text = "Best fit";
            this.bestFitToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // fitToWidthToolStripMenuItem
            // 
            this.fitToWidthToolStripMenuItem.Name = "fitToWidthToolStripMenuItem";
            this.fitToWidthToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fitToWidthToolStripMenuItem.Text = "Fit to width";
            this.fitToWidthToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // fitToHeightToolStripMenuItem
            // 
            this.fitToHeightToolStripMenuItem.Name = "fitToHeightToolStripMenuItem";
            this.fitToHeightToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fitToHeightToolStripMenuItem.Text = "Fit to height";
            this.fitToHeightToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scaleToolStripMenuItem.Text = "Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // pixelToPixelToolStripMenuItem
            // 
            this.pixelToPixelToolStripMenuItem.Name = "pixelToPixelToolStripMenuItem";
            this.pixelToPixelToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pixelToPixelToolStripMenuItem.Text = "Pixel to pixel";
            this.pixelToPixelToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // toolStripSeparatorZoomModes
            // 
            this.toolStripSeparatorZoomModes.Name = "toolStripSeparatorZoomModes";
            this.toolStripSeparatorZoomModes.Size = new System.Drawing.Size(138, 6);
            // 
            // scale25ToolStripMenuItem
            // 
            this.scale25ToolStripMenuItem.Name = "scale25ToolStripMenuItem";
            this.scale25ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scale25ToolStripMenuItem.Text = "25%";
            this.scale25ToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // scale50ToolStripMenuItem
            // 
            this.scale50ToolStripMenuItem.Name = "scale50ToolStripMenuItem";
            this.scale50ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scale50ToolStripMenuItem.Text = "50%";
            this.scale50ToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // scale100ToolStripMenuItem
            // 
            this.scale100ToolStripMenuItem.Name = "scale100ToolStripMenuItem";
            this.scale100ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scale100ToolStripMenuItem.Text = "100%";
            this.scale100ToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // scale200ToolStripMenuItem
            // 
            this.scale200ToolStripMenuItem.Name = "scale200ToolStripMenuItem";
            this.scale200ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scale200ToolStripMenuItem.Text = "200%";
            this.scale200ToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // scale400ToolStripMenuItem
            // 
            this.scale400ToolStripMenuItem.Name = "scale400ToolStripMenuItem";
            this.scale400ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scale400ToolStripMenuItem.Text = "400%";
            this.scale400ToolStripMenuItem.Click += new System.EventHandler(this.imageScaleModeMenuItem_Click);
            // 
            // rotateViewToolStripMenuItem
            // 
            this.rotateViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateClockwiseToolStripMenuItem,
            this.counterclockwiseToolStripMenuItem});
            this.rotateViewToolStripMenuItem.Name = "rotateViewToolStripMenuItem";
            this.rotateViewToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.rotateViewToolStripMenuItem.Text = "Rotate View";
            // 
            // rotateClockwiseToolStripMenuItem
            // 
            this.rotateClockwiseToolStripMenuItem.Name = "rotateClockwiseToolStripMenuItem";
            this.rotateClockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Ctrl+Plus";
            this.rotateClockwiseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Oemplus)));
            this.rotateClockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.rotateClockwiseToolStripMenuItem.Text = "Clockwise";
            this.rotateClockwiseToolStripMenuItem.Click += new System.EventHandler(this.rotateClockwiseToolStripMenuItem_Click);
            // 
            // counterclockwiseToolStripMenuItem
            // 
            this.counterclockwiseToolStripMenuItem.Name = "counterclockwiseToolStripMenuItem";
            this.counterclockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Ctrl+Minus";
            this.counterclockwiseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.OemMinus)));
            this.counterclockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.counterclockwiseToolStripMenuItem.Text = "Counterclockwise";
            this.counterclockwiseToolStripMenuItem.Click += new System.EventHandler(this.counterclockwiseToolStripMenuItem_Click);
            // 
            // centerImageToolStripMenuItem
            // 
            this.centerImageToolStripMenuItem.CheckOnClick = true;
            this.centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            this.centerImageToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.centerImageToolStripMenuItem.Text = "Center Image";
            this.centerImageToolStripMenuItem.Click += new System.EventHandler(this.centerImageToolStripMenuItem_Click);
            // 
            // imageViewerSettingsToolStripMenuItem
            // 
            this.imageViewerSettingsToolStripMenuItem.Name = "imageViewerSettingsToolStripMenuItem";
            this.imageViewerSettingsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.imageViewerSettingsToolStripMenuItem.Text = "Image Viewer Settings...";
            this.imageViewerSettingsToolStripMenuItem.Click += new System.EventHandler(this.imageViewerSettingsToolStripMenuItem_Click);
            // 
            // segmentationToolStripMenuItem
            // 
            this.segmentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segmentCurrentPageToolStripMenuItem,
            this.segmentAllPagesToolStripMenuItem,
            this.toolStripSeparator5,
            this.removeSegmentationResultForCurrentImageToolStripMenuItem,
            this.removeSegmentationResultsForAllImagesToolStripMenuItem});
            this.segmentationToolStripMenuItem.Name = "segmentationToolStripMenuItem";
            this.segmentationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.segmentationToolStripMenuItem.Text = "Segmentation";
            // 
            // segmentCurrentPageToolStripMenuItem
            // 
            this.segmentCurrentPageToolStripMenuItem.Name = "segmentCurrentPageToolStripMenuItem";
            this.segmentCurrentPageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.segmentCurrentPageToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.segmentCurrentPageToolStripMenuItem.Text = "Segment Current Page";
            this.segmentCurrentPageToolStripMenuItem.Click += new System.EventHandler(this.segmentCurrentImageToolStripMenuItem_Click);
            // 
            // segmentAllPagesToolStripMenuItem
            // 
            this.segmentAllPagesToolStripMenuItem.Name = "segmentAllPagesToolStripMenuItem";
            this.segmentAllPagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.segmentAllPagesToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.segmentAllPagesToolStripMenuItem.Text = "Segment All Pages";
            this.segmentAllPagesToolStripMenuItem.Click += new System.EventHandler(this.segmentAllImagesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(323, 6);
            // 
            // removeSegmentationResultForCurrentImageToolStripMenuItem
            // 
            this.removeSegmentationResultForCurrentImageToolStripMenuItem.Name = "removeSegmentationResultForCurrentImageToolStripMenuItem";
            this.removeSegmentationResultForCurrentImageToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.removeSegmentationResultForCurrentImageToolStripMenuItem.Text = "Remove Segmentation Result for Current Image";
            this.removeSegmentationResultForCurrentImageToolStripMenuItem.Click += new System.EventHandler(this.removeSegmentationResultForCurrentImageToolStripMenuItem_Click);
            // 
            // removeSegmentationResultsForAllImagesToolStripMenuItem
            // 
            this.removeSegmentationResultsForAllImagesToolStripMenuItem.Name = "removeSegmentationResultsForAllImagesToolStripMenuItem";
            this.removeSegmentationResultsForAllImagesToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.removeSegmentationResultsForAllImagesToolStripMenuItem.Text = "Remove Segmentation Results for All Images";
            this.removeSegmentationResultsForAllImagesToolStripMenuItem.Click += new System.EventHandler(this.removeSegmentationResultsForAllImagesToolStripMenuItem_Click);
            // 
            // oCRToolStripMenuItem
            // 
            this.oCRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.recognizeTextInCurrentImageToolStripMenuItem,
            this.recognizeTextInAllImagesToolStripMenuItem,
            this.toolStripSeparator8,
            this.recognizeMICRInCurrentImageToolStripMenuItem,
            this.recognizeMRZInCurrenImageToolStripMenuItem,
            this.toolStripSeparator3,
            this.detectPageOrientationToolStripMenuItem,
            this.analyzeLayoutToolStripMenuItem,
            this.toolStripSeparator10,
            this.removeRecognitionResultForCurrentImageToolStripMenuItem,
            this.removeRecognitionResultsForAllImagesToolStripMenuItem1,
            this.toolStripSeparator6,
            this.loadRecognitionResultsFromDocumentToolStripMenuItem,
            this.loadRecognitionResultsFromHOCRFileToolStripMenuItem,
            this.saveRecognitionResultsToHOCRFileToolStripMenuItem});
            this.oCRToolStripMenuItem.Name = "oCRToolStripMenuItem";
            this.oCRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.oCRToolStripMenuItem.Text = "OCR";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.ocrSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(370, 6);
            // 
            // recognizeTextInCurrentImageToolStripMenuItem
            // 
            this.recognizeTextInCurrentImageToolStripMenuItem.Name = "recognizeTextInCurrentImageToolStripMenuItem";
            this.recognizeTextInCurrentImageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.recognizeTextInCurrentImageToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.recognizeTextInCurrentImageToolStripMenuItem.Text = "Recognize Text in Current Image";
            this.recognizeTextInCurrentImageToolStripMenuItem.Click += new System.EventHandler(this.recognizeTextInCurrentImageToolStripMenuItem_Click);
            // 
            // recognizeTextInAllImagesToolStripMenuItem
            // 
            this.recognizeTextInAllImagesToolStripMenuItem.Name = "recognizeTextInAllImagesToolStripMenuItem";
            this.recognizeTextInAllImagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.recognizeTextInAllImagesToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.recognizeTextInAllImagesToolStripMenuItem.Text = "Recognize Text in All Images";
            this.recognizeTextInAllImagesToolStripMenuItem.Click += new System.EventHandler(this.recognizeTextInAllImagesToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(370, 6);
            // 
            // recognizeMICRInCurrentImageToolStripMenuItem
            // 
            this.recognizeMICRInCurrentImageToolStripMenuItem.Name = "recognizeMICRInCurrentImageToolStripMenuItem";
            this.recognizeMICRInCurrentImageToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.recognizeMICRInCurrentImageToolStripMenuItem.Text = "Recognize MICR in Current Image";
            this.recognizeMICRInCurrentImageToolStripMenuItem.Click += new System.EventHandler(this.recognizeMICRInCurrentImageToolStripMenuItem_Click);
            // 
            // recognizeMRZInCurrenImageToolStripMenuItem
            // 
            this.recognizeMRZInCurrenImageToolStripMenuItem.Name = "recognizeMRZInCurrenImageToolStripMenuItem";
            this.recognizeMRZInCurrenImageToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.recognizeMRZInCurrenImageToolStripMenuItem.Text = "Recognize MRZ in Curren Image";
            this.recognizeMRZInCurrenImageToolStripMenuItem.Click += new System.EventHandler(this.recognizeMRZInCurrenImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(370, 6);
            // 
            // detectPageOrientationToolStripMenuItem
            // 
            this.detectPageOrientationToolStripMenuItem.Name = "detectPageOrientationToolStripMenuItem";
            this.detectPageOrientationToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.detectPageOrientationToolStripMenuItem.Text = "Detect Page Orientation";
            this.detectPageOrientationToolStripMenuItem.Click += new System.EventHandler(this.detectPageOrientationToolStripMenuItem_Click);
            // 
            // analyzeLayoutToolStripMenuItem
            // 
            this.analyzeLayoutToolStripMenuItem.Name = "analyzeLayoutToolStripMenuItem";
            this.analyzeLayoutToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.analyzeLayoutToolStripMenuItem.Text = "Analyze Layout";
            this.analyzeLayoutToolStripMenuItem.Click += new System.EventHandler(this.analyzeLayoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(370, 6);
            // 
            // removeRecognitionResultForCurrentImageToolStripMenuItem
            // 
            this.removeRecognitionResultForCurrentImageToolStripMenuItem.Name = "removeRecognitionResultForCurrentImageToolStripMenuItem";
            this.removeRecognitionResultForCurrentImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.removeRecognitionResultForCurrentImageToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.removeRecognitionResultForCurrentImageToolStripMenuItem.Text = "Remove Recognition Result for Current Image";
            this.removeRecognitionResultForCurrentImageToolStripMenuItem.Click += new System.EventHandler(this.removeTextRecognitionResultForCurrentImageToolStripMenuItem_Click);
            // 
            // removeRecognitionResultsForAllImagesToolStripMenuItem1
            // 
            this.removeRecognitionResultsForAllImagesToolStripMenuItem1.Name = "removeRecognitionResultsForAllImagesToolStripMenuItem1";
            this.removeRecognitionResultsForAllImagesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.removeRecognitionResultsForAllImagesToolStripMenuItem1.Size = new System.Drawing.Size(373, 22);
            this.removeRecognitionResultsForAllImagesToolStripMenuItem1.Text = "Remove Recognition Results for All Images";
            this.removeRecognitionResultsForAllImagesToolStripMenuItem1.Click += new System.EventHandler(this.removeTextRecognitionResultsForAllImagesToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(370, 6);
            // 
            // loadRecognitionResultsFromDocumentToolStripMenuItem
            // 
            this.loadRecognitionResultsFromDocumentToolStripMenuItem.Name = "loadRecognitionResultsFromDocumentToolStripMenuItem";
            this.loadRecognitionResultsFromDocumentToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.loadRecognitionResultsFromDocumentToolStripMenuItem.Text = "Load Recognition Results from Document...";
            this.loadRecognitionResultsFromDocumentToolStripMenuItem.Click += new System.EventHandler(this.loadRecognitionResultsFromDocumentToolStripMenuItem_Click);
            // 
            // loadRecognitionResultsFromHOCRFileToolStripMenuItem
            // 
            this.loadRecognitionResultsFromHOCRFileToolStripMenuItem.Name = "loadRecognitionResultsFromHOCRFileToolStripMenuItem";
            this.loadRecognitionResultsFromHOCRFileToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.loadRecognitionResultsFromHOCRFileToolStripMenuItem.Text = "Load Recognition Results from HOCR File...";
            this.loadRecognitionResultsFromHOCRFileToolStripMenuItem.Click += new System.EventHandler(this.loadRecognitionResultsFromHOCRFileToolStripMenuItem_Click);
            // 
            // saveRecognitionResultsToHOCRFileToolStripMenuItem
            // 
            this.saveRecognitionResultsToHOCRFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToHocrForCurrentImageToolStripMenuItem,
            this.saveToHocrForAllImagesToolStripMenuItem});
            this.saveRecognitionResultsToHOCRFileToolStripMenuItem.Name = "saveRecognitionResultsToHOCRFileToolStripMenuItem";
            this.saveRecognitionResultsToHOCRFileToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.saveRecognitionResultsToHOCRFileToolStripMenuItem.Text = "Save Recognition Results to HOCR File";
            // 
            // saveToHocrForCurrentImageToolStripMenuItem
            // 
            this.saveToHocrForCurrentImageToolStripMenuItem.Name = "saveToHocrForCurrentImageToolStripMenuItem";
            this.saveToHocrForCurrentImageToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveToHocrForCurrentImageToolStripMenuItem.Text = "For Current Image...";
            this.saveToHocrForCurrentImageToolStripMenuItem.Click += new System.EventHandler(this.saveToHocrForCurrentImageToolStripMenuItem_Click);
            // 
            // saveToHocrForAllImagesToolStripMenuItem
            // 
            this.saveToHocrForAllImagesToolStripMenuItem.Name = "saveToHocrForAllImagesToolStripMenuItem";
            this.saveToHocrForAllImagesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveToHocrForAllImagesToolStripMenuItem.Text = "For All Images...";
            this.saveToHocrForAllImagesToolStripMenuItem.Click += new System.EventHandler(this.saveToHocrForAllImagesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageInfoStatusLabel,
            this.saveOcrResultsProgressBar,
            this.ocrEngineManagerProgressBar,
            this.imageInfoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 722);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1041, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // imageInfoStatusLabel
            // 
            this.imageInfoStatusLabel.Name = "imageInfoStatusLabel";
            this.imageInfoStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.imageInfoStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // saveOcrResultsProgressBar
            // 
            this.saveOcrResultsProgressBar.Name = "saveOcrResultsProgressBar";
            this.saveOcrResultsProgressBar.Size = new System.Drawing.Size(100, 16);
            this.saveOcrResultsProgressBar.Visible = false;
            // 
            // ocrEngineManagerProgressBar
            // 
            this.ocrEngineManagerProgressBar.Name = "ocrEngineManagerProgressBar";
            this.ocrEngineManagerProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ocrEngineManagerProgressBar.Visible = false;
            // 
            // imageInfoLabel
            // 
            this.imageInfoLabel.Name = "imageInfoLabel";
            this.imageInfoLabel.Size = new System.Drawing.Size(1026, 17);
            this.imageInfoLabel.Spring = true;
            this.imageInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ocrObjectOrientationLabel);
            this.groupBox1.Controls.Add(this.orientationLabel);
            this.groupBox1.Controls.Add(this.ocrObjectConfidenceLabel);
            this.groupBox1.Controls.Add(this.confidenceLabel);
            this.groupBox1.Controls.Add(this.ocrObjectRectLabel);
            this.groupBox1.Controls.Add(this.ocrObjectTextBox);
            this.groupBox1.Controls.Add(this.textLabel);
            this.groupBox1.Controls.Add(this.rectLabel);
            this.groupBox1.Controls.Add(this.ocrObjectTypeLabel);
            this.groupBox1.Controls.Add(this.typeLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current object";
            // 
            // ocrObjectOrientationLabel
            // 
            this.ocrObjectOrientationLabel.AutoSize = true;
            this.ocrObjectOrientationLabel.Location = new System.Drawing.Point(72, 71);
            this.ocrObjectOrientationLabel.Name = "ocrObjectOrientationLabel";
            this.ocrObjectOrientationLabel.Size = new System.Drawing.Size(13, 13);
            this.ocrObjectOrientationLabel.TabIndex = 9;
            this.ocrObjectOrientationLabel.Text = "0";
            // 
            // orientationLabel
            // 
            this.orientationLabel.AutoSize = true;
            this.orientationLabel.Location = new System.Drawing.Point(6, 71);
            this.orientationLabel.Name = "orientationLabel";
            this.orientationLabel.Size = new System.Drawing.Size(61, 13);
            this.orientationLabel.TabIndex = 8;
            this.orientationLabel.Text = "Orientation:";
            // 
            // ocrObjectConfidenceLabel
            // 
            this.ocrObjectConfidenceLabel.AutoSize = true;
            this.ocrObjectConfidenceLabel.Location = new System.Drawing.Point(72, 93);
            this.ocrObjectConfidenceLabel.Name = "ocrObjectConfidenceLabel";
            this.ocrObjectConfidenceLabel.Size = new System.Drawing.Size(13, 13);
            this.ocrObjectConfidenceLabel.TabIndex = 7;
            this.ocrObjectConfidenceLabel.Text = "0";
            // 
            // confidenceLabel
            // 
            this.confidenceLabel.AutoSize = true;
            this.confidenceLabel.Location = new System.Drawing.Point(6, 93);
            this.confidenceLabel.Name = "confidenceLabel";
            this.confidenceLabel.Size = new System.Drawing.Size(64, 13);
            this.confidenceLabel.TabIndex = 6;
            this.confidenceLabel.Text = "Confidence:";
            // 
            // ocrObjectRectLabel
            // 
            this.ocrObjectRectLabel.AutoSize = true;
            this.ocrObjectRectLabel.Location = new System.Drawing.Point(37, 48);
            this.ocrObjectRectLabel.Name = "ocrObjectRectLabel";
            this.ocrObjectRectLabel.Size = new System.Drawing.Size(102, 13);
            this.ocrObjectRectLabel.TabIndex = 5;
            this.ocrObjectRectLabel.Text = "ocrObjectRectLabel";
            // 
            // ocrObjectTextBox
            // 
            this.ocrObjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ocrObjectTextBox.Location = new System.Drawing.Point(9, 130);
            this.ocrObjectTextBox.Name = "ocrObjectTextBox";
            this.ocrObjectTextBox.Size = new System.Drawing.Size(231, 20);
            this.ocrObjectTextBox.TabIndex = 4;
            this.ocrObjectTextBox.TextChanged += new System.EventHandler(this.ocrObjectTextBox_TextChanged);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(6, 114);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(31, 13);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "Text:";
            // 
            // rectLabel
            // 
            this.rectLabel.AutoSize = true;
            this.rectLabel.Location = new System.Drawing.Point(6, 48);
            this.rectLabel.Name = "rectLabel";
            this.rectLabel.Size = new System.Drawing.Size(33, 13);
            this.rectLabel.TabIndex = 2;
            this.rectLabel.Text = "Rect:";
            // 
            // ocrObjectTypeLabel
            // 
            this.ocrObjectTypeLabel.AutoSize = true;
            this.ocrObjectTypeLabel.Location = new System.Drawing.Point(37, 25);
            this.ocrObjectTypeLabel.Name = "ocrObjectTypeLabel";
            this.ocrObjectTypeLabel.Size = new System.Drawing.Size(103, 13);
            this.ocrObjectTypeLabel.TabIndex = 1;
            this.ocrObjectTypeLabel.Text = "ocrObjectTypeLabel";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 25);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.selectedObjectsListBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 436);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected objects";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.deselectSelectedOcrObjectButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.deselectAllSelectedOcrObjectsButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 256);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(249, 32);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // deselectSelectedOcrObjectButton
            // 
            this.deselectSelectedOcrObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deselectSelectedOcrObjectButton.Location = new System.Drawing.Point(127, 3);
            this.deselectSelectedOcrObjectButton.Name = "deselectSelectedOcrObjectButton";
            this.deselectSelectedOcrObjectButton.Size = new System.Drawing.Size(119, 23);
            this.deselectSelectedOcrObjectButton.TabIndex = 2;
            this.deselectSelectedOcrObjectButton.Text = "Deselect selected";
            this.deselectSelectedOcrObjectButton.UseVisualStyleBackColor = true;
            this.deselectSelectedOcrObjectButton.Click += new System.EventHandler(this.deselectSelectedOcrObjectButton_Click);
            // 
            // deselectAllSelectedOcrObjectsButton
            // 
            this.deselectAllSelectedOcrObjectsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deselectAllSelectedOcrObjectsButton.Location = new System.Drawing.Point(3, 3);
            this.deselectAllSelectedOcrObjectsButton.Name = "deselectAllSelectedOcrObjectsButton";
            this.deselectAllSelectedOcrObjectsButton.Size = new System.Drawing.Size(118, 23);
            this.deselectAllSelectedOcrObjectsButton.TabIndex = 1;
            this.deselectAllSelectedOcrObjectsButton.Text = "Deselect all";
            this.deselectAllSelectedOcrObjectsButton.UseVisualStyleBackColor = true;
            this.deselectAllSelectedOcrObjectsButton.Click += new System.EventHandler(this.deselectSelectedOcrObjectsButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.deleteAllSelectedObjectsButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteSelectedObjectButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(249, 43);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // deleteAllSelectedObjectsButton
            // 
            this.deleteAllSelectedObjectsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAllSelectedObjectsButton.Location = new System.Drawing.Point(3, 3);
            this.deleteAllSelectedObjectsButton.Name = "deleteAllSelectedObjectsButton";
            this.deleteAllSelectedObjectsButton.Size = new System.Drawing.Size(118, 37);
            this.deleteAllSelectedObjectsButton.TabIndex = 4;
            this.deleteAllSelectedObjectsButton.Text = "Delete all selected objects";
            this.deleteAllSelectedObjectsButton.UseVisualStyleBackColor = true;
            this.deleteAllSelectedObjectsButton.Click += new System.EventHandler(this.deleteAllOcrObjectsFromOcrResultButton_Click);
            // 
            // deleteSelectedObjectButton
            // 
            this.deleteSelectedObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSelectedObjectButton.Location = new System.Drawing.Point(127, 3);
            this.deleteSelectedObjectButton.Name = "deleteSelectedObjectButton";
            this.deleteSelectedObjectButton.Size = new System.Drawing.Size(119, 37);
            this.deleteSelectedObjectButton.TabIndex = 3;
            this.deleteSelectedObjectButton.Text = "Delete selected object";
            this.deleteSelectedObjectButton.UseVisualStyleBackColor = true;
            this.deleteSelectedObjectButton.Click += new System.EventHandler(this.deleteSelectedOcrObjectFromOcrResultButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.maxConfidenceFromDictLabel);
            this.groupBox3.Controls.Add(this.maxConfidenceValueLabel);
            this.groupBox3.Controls.Add(this.selectByConfidenceButton);
            this.groupBox3.Controls.Add(this.maxConfidenceLabel);
            this.groupBox3.Controls.Add(this.maxConfidenceFromDictionaryLabel);
            this.groupBox3.Controls.Add(this.maxConfidenceFromDictTrackBar);
            this.groupBox3.Controls.Add(this.maxConfidenceTrackBar);
            this.groupBox3.Location = new System.Drawing.Point(3, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 136);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confidence-based Selection";
            // 
            // maxConfidenceFromDictLabel
            // 
            this.maxConfidenceFromDictLabel.AutoSize = true;
            this.maxConfidenceFromDictLabel.Location = new System.Drawing.Point(195, 73);
            this.maxConfidenceFromDictLabel.Name = "maxConfidenceFromDictLabel";
            this.maxConfidenceFromDictLabel.Size = new System.Drawing.Size(15, 13);
            this.maxConfidenceFromDictLabel.TabIndex = 6;
            this.maxConfidenceFromDictLabel.Text = "%";
            // 
            // maxConfidenceValueLabel
            // 
            this.maxConfidenceValueLabel.AutoSize = true;
            this.maxConfidenceValueLabel.Location = new System.Drawing.Point(90, 20);
            this.maxConfidenceValueLabel.Name = "maxConfidenceValueLabel";
            this.maxConfidenceValueLabel.Size = new System.Drawing.Size(15, 13);
            this.maxConfidenceValueLabel.TabIndex = 5;
            this.maxConfidenceValueLabel.Text = "%";
            // 
            // selectByConfidenceButton
            // 
            this.selectByConfidenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectByConfidenceButton.Location = new System.Drawing.Point(183, 13);
            this.selectByConfidenceButton.Name = "selectByConfidenceButton";
            this.selectByConfidenceButton.Size = new System.Drawing.Size(57, 23);
            this.selectByConfidenceButton.TabIndex = 4;
            this.selectByConfidenceButton.Text = "Select";
            this.selectByConfidenceButton.UseVisualStyleBackColor = true;
            this.selectByConfidenceButton.Click += new System.EventHandler(this.ocrResultsConfidenceTrackBar_ValueChanged);
            // 
            // maxConfidenceLabel
            // 
            this.maxConfidenceLabel.AutoSize = true;
            this.maxConfidenceLabel.Location = new System.Drawing.Point(3, 19);
            this.maxConfidenceLabel.Name = "maxConfidenceLabel";
            this.maxConfidenceLabel.Size = new System.Drawing.Size(84, 13);
            this.maxConfidenceLabel.TabIndex = 3;
            this.maxConfidenceLabel.Text = "Max Confidence";
            // 
            // maxConfidenceFromDictionaryLabel
            // 
            this.maxConfidenceFromDictionaryLabel.AutoSize = true;
            this.maxConfidenceFromDictionaryLabel.Location = new System.Drawing.Point(3, 73);
            this.maxConfidenceFromDictionaryLabel.Name = "maxConfidenceFromDictionaryLabel";
            this.maxConfidenceFromDictionaryLabel.Size = new System.Drawing.Size(194, 13);
            this.maxConfidenceFromDictionaryLabel.TabIndex = 2;
            this.maxConfidenceFromDictionaryLabel.Text = "Words Max Confidence From Dictionary";
            // 
            // maxConfidenceFromDictTrackBar
            // 
            this.maxConfidenceFromDictTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxConfidenceFromDictTrackBar.AutoSize = false;
            this.maxConfidenceFromDictTrackBar.Location = new System.Drawing.Point(2, 89);
            this.maxConfidenceFromDictTrackBar.Maximum = 100;
            this.maxConfidenceFromDictTrackBar.Name = "maxConfidenceFromDictTrackBar";
            this.maxConfidenceFromDictTrackBar.Size = new System.Drawing.Size(238, 32);
            this.maxConfidenceFromDictTrackBar.TabIndex = 0;
            this.maxConfidenceFromDictTrackBar.TickFrequency = 5;
            this.maxConfidenceFromDictTrackBar.ValueChanged += new System.EventHandler(this.ocrResultsConfidenceTrackBar_ValueChanged);
            // 
            // maxConfidenceTrackBar
            // 
            this.maxConfidenceTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxConfidenceTrackBar.AutoSize = false;
            this.maxConfidenceTrackBar.Location = new System.Drawing.Point(1, 36);
            this.maxConfidenceTrackBar.Maximum = 100;
            this.maxConfidenceTrackBar.Name = "maxConfidenceTrackBar";
            this.maxConfidenceTrackBar.Size = new System.Drawing.Size(239, 32);
            this.maxConfidenceTrackBar.TabIndex = 1;
            this.maxConfidenceTrackBar.TickFrequency = 5;
            this.maxConfidenceTrackBar.ValueChanged += new System.EventHandler(this.ocrResultsConfidenceTrackBar_ValueChanged);
            // 
            // selectedObjectsListBox
            // 
            this.selectedObjectsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedObjectsListBox.FormattingEnabled = true;
            this.selectedObjectsListBox.HorizontalScrollbar = true;
            this.selectedObjectsListBox.Location = new System.Drawing.Point(3, 64);
            this.selectedObjectsListBox.Name = "selectedObjectsListBox";
            this.selectedObjectsListBox.Size = new System.Drawing.Size(243, 186);
            this.selectedObjectsListBox.TabIndex = 0;
            this.selectedObjectsListBox.SelectedIndexChanged += new System.EventHandler(this.selectedObjectsListBox_SelectedIndexChanged);
            // 
            // ocrResultsEditorPanel
            // 
            this.ocrResultsEditorPanel.Controls.Add(this.ocrObjectTypeComboBox);
            this.ocrResultsEditorPanel.Controls.Add(this.objectTypeLabel);
            this.ocrResultsEditorPanel.Controls.Add(this.groupBox2);
            this.ocrResultsEditorPanel.Controls.Add(this.groupBox1);
            this.ocrResultsEditorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ocrResultsEditorPanel.Location = new System.Drawing.Point(3, 3);
            this.ocrResultsEditorPanel.Name = "ocrResultsEditorPanel";
            this.ocrResultsEditorPanel.Size = new System.Drawing.Size(263, 639);
            this.ocrResultsEditorPanel.TabIndex = 0;
            // 
            // ocrObjectTypeComboBox
            // 
            this.ocrObjectTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ocrObjectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ocrObjectTypeComboBox.FormattingEnabled = true;
            this.ocrObjectTypeComboBox.Location = new System.Drawing.Point(74, 6);
            this.ocrObjectTypeComboBox.Name = "ocrObjectTypeComboBox";
            this.ocrObjectTypeComboBox.Size = new System.Drawing.Size(178, 21);
            this.ocrObjectTypeComboBox.TabIndex = 9;
            this.ocrObjectTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ocrObjectTypeComboBox_SelectedIndexChanged);
            // 
            // objectTypeLabel
            // 
            this.objectTypeLabel.AutoSize = true;
            this.objectTypeLabel.Location = new System.Drawing.Point(4, 9);
            this.objectTypeLabel.Name = "objectTypeLabel";
            this.objectTypeLabel.Size = new System.Drawing.Size(55, 13);
            this.objectTypeLabel.TabIndex = 8;
            this.objectTypeLabel.Text = "Work with";
            // 
            // selectedTextRecognitionRegionGroupBox
            // 
            this.selectedTextRecognitionRegionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedTextRecognitionRegionGroupBox.Controls.Add(this.groupBox4);
            this.selectedTextRecognitionRegionGroupBox.Controls.Add(this.selectedTextRecognitionRegionTypeComboBox);
            this.selectedTextRecognitionRegionGroupBox.Controls.Add(this.recognitionRegionTypeLabel);
            this.selectedTextRecognitionRegionGroupBox.Controls.Add(this.selectedTextRecognitionRegionTextRotationComboBox);
            this.selectedTextRecognitionRegionGroupBox.Controls.Add(this.textRotationLabel);
            this.selectedTextRecognitionRegionGroupBox.Controls.Add(this.selectedTextRecognitionRegionRectangleLabel);
            this.selectedTextRecognitionRegionGroupBox.Controls.Add(this.rectangleLabel);
            this.selectedTextRecognitionRegionGroupBox.Location = new System.Drawing.Point(3, 78);
            this.selectedTextRecognitionRegionGroupBox.Name = "selectedTextRecognitionRegionGroupBox";
            this.selectedTextRecognitionRegionGroupBox.Size = new System.Drawing.Size(257, 558);
            this.selectedTextRecognitionRegionGroupBox.TabIndex = 4;
            this.selectedTextRecognitionRegionGroupBox.TabStop = false;
            this.selectedTextRecognitionRegionGroupBox.Text = "Selected text recognition region";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.selectedTextRecognitionRegionOcrLanguagesListBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 413);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Languages:";
            // 
            // selectedTextRecognitionRegionOcrLanguagesListBox
            // 
            this.selectedTextRecognitionRegionOcrLanguagesListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectedTextRecognitionRegionOcrLanguagesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedTextRecognitionRegionOcrLanguagesListBox.Location = new System.Drawing.Point(3, 16);
            this.selectedTextRecognitionRegionOcrLanguagesListBox.Margin = new System.Windows.Forms.Padding(0);
            this.selectedTextRecognitionRegionOcrLanguagesListBox.Name = "selectedTextRecognitionRegionOcrLanguagesListBox";
            this.selectedTextRecognitionRegionOcrLanguagesListBox.SelectedLanguages = new Vintasoft.Imaging.Ocr.OcrLanguage[0];
            this.selectedTextRecognitionRegionOcrLanguagesListBox.Size = new System.Drawing.Size(245, 394);
            this.selectedTextRecognitionRegionOcrLanguagesListBox.TabIndex = 0;
            this.selectedTextRecognitionRegionOcrLanguagesListBox.SelectedLanguagesChanged += new System.EventHandler(this.selectedTextRecognitionRegionOcrLanguagesListBox_SelectedLanguagesChanged);
            // 
            // selectedTextRecognitionRegionTypeComboBox
            // 
            this.selectedTextRecognitionRegionTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedTextRecognitionRegionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedTextRecognitionRegionTypeComboBox.FormattingEnabled = true;
            this.selectedTextRecognitionRegionTypeComboBox.Location = new System.Drawing.Point(9, 484);
            this.selectedTextRecognitionRegionTypeComboBox.Name = "selectedTextRecognitionRegionTypeComboBox";
            this.selectedTextRecognitionRegionTypeComboBox.Size = new System.Drawing.Size(243, 21);
            this.selectedTextRecognitionRegionTypeComboBox.TabIndex = 7;
            this.selectedTextRecognitionRegionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.recognitionRegionTypeComboBox_SelectedIndexChanged);
            // 
            // recognitionRegionTypeLabel
            // 
            this.recognitionRegionTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recognitionRegionTypeLabel.AutoSize = true;
            this.recognitionRegionTypeLabel.Location = new System.Drawing.Point(6, 466);
            this.recognitionRegionTypeLabel.Name = "recognitionRegionTypeLabel";
            this.recognitionRegionTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.recognitionRegionTypeLabel.TabIndex = 6;
            this.recognitionRegionTypeLabel.Text = "Region Type:";
            // 
            // selectedTextRecognitionRegionTextRotationComboBox
            // 
            this.selectedTextRecognitionRegionTextRotationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedTextRecognitionRegionTextRotationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedTextRecognitionRegionTextRotationComboBox.FormattingEnabled = true;
            this.selectedTextRecognitionRegionTextRotationComboBox.Items.AddRange(new object[] {
            "0",
            "90",
            "180",
            "270"});
            this.selectedTextRecognitionRegionTextRotationComboBox.Location = new System.Drawing.Point(9, 528);
            this.selectedTextRecognitionRegionTextRotationComboBox.Name = "selectedTextRecognitionRegionTextRotationComboBox";
            this.selectedTextRecognitionRegionTextRotationComboBox.Size = new System.Drawing.Size(243, 21);
            this.selectedTextRecognitionRegionTextRotationComboBox.TabIndex = 5;
            this.selectedTextRecognitionRegionTextRotationComboBox.SelectedIndexChanged += new System.EventHandler(this.selectedTextRecognitionRegionTextRotationComboBox_SelectedIndexChanged);
            // 
            // textRotationLabel
            // 
            this.textRotationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRotationLabel.AutoSize = true;
            this.textRotationLabel.Location = new System.Drawing.Point(6, 512);
            this.textRotationLabel.Name = "textRotationLabel";
            this.textRotationLabel.Size = new System.Drawing.Size(74, 13);
            this.textRotationLabel.TabIndex = 4;
            this.textRotationLabel.Text = "Text Rotation:";
            // 
            // selectedTextRecognitionRegionRectangleLabel
            // 
            this.selectedTextRecognitionRegionRectangleLabel.AutoSize = true;
            this.selectedTextRecognitionRegionRectangleLabel.Location = new System.Drawing.Point(6, 34);
            this.selectedTextRecognitionRegionRectangleLabel.Name = "selectedTextRecognitionRegionRectangleLabel";
            this.selectedTextRecognitionRegionRectangleLabel.Size = new System.Drawing.Size(48, 13);
            this.selectedTextRecognitionRegionRectangleLabel.TabIndex = 3;
            this.selectedTextRecognitionRegionRectangleLabel.Text = "{0,0,0,0}";
            // 
            // rectangleLabel
            // 
            this.rectangleLabel.AutoSize = true;
            this.rectangleLabel.Location = new System.Drawing.Point(6, 19);
            this.rectangleLabel.Name = "rectangleLabel";
            this.rectangleLabel.Size = new System.Drawing.Size(59, 13);
            this.rectangleLabel.TabIndex = 0;
            this.rectangleLabel.Text = "Rectangle:";
            // 
            // removeAllTextRecognitionRegionsButton
            // 
            this.removeAllTextRecognitionRegionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeAllTextRecognitionRegionsButton.Location = new System.Drawing.Point(175, 3);
            this.removeAllTextRecognitionRegionsButton.Name = "removeAllTextRecognitionRegionsButton";
            this.removeAllTextRecognitionRegionsButton.Size = new System.Drawing.Size(82, 23);
            this.removeAllTextRecognitionRegionsButton.TabIndex = 3;
            this.removeAllTextRecognitionRegionsButton.Text = "Remove All";
            this.removeAllTextRecognitionRegionsButton.UseVisualStyleBackColor = true;
            this.removeAllTextRecognitionRegionsButton.Click += new System.EventHandler(this.removeAllTextRecognitionRegionsButton_Click);
            // 
            // removeTextRecognitionRegionButton
            // 
            this.removeTextRecognitionRegionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeTextRecognitionRegionButton.Location = new System.Drawing.Point(89, 3);
            this.removeTextRecognitionRegionButton.Name = "removeTextRecognitionRegionButton";
            this.removeTextRecognitionRegionButton.Size = new System.Drawing.Size(80, 23);
            this.removeTextRecognitionRegionButton.TabIndex = 2;
            this.removeTextRecognitionRegionButton.Text = "Remove";
            this.removeTextRecognitionRegionButton.UseVisualStyleBackColor = true;
            this.removeTextRecognitionRegionButton.Click += new System.EventHandler(this.removeSelectedSegmentationRectButton_Click);
            // 
            // imageViewer1
            // 
            this.imageViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer1.Clipboard = winFormsSystemClipboard1;
            this.imageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer1.ImageRenderingSettings = renderingSettings1;
            this.imageViewer1.ImageRotationAngle = 0;
            this.imageViewer1.Location = new System.Drawing.Point(0, 0);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.Size = new System.Drawing.Size(559, 671);
            this.imageViewer1.TabIndex = 2;
            this.imageViewer1.Text = "imageViewer1";
            this.imageViewer1.FocusedIndexChanged += new System.EventHandler<Vintasoft.Imaging.UI.FocusedIndexChangedEventArgs>(this.imageViewer1_FocusedIndexChanged);
            this.imageViewer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imageViewer1_KeyDown);
            // 
            // thumbnailViewer1
            // 
            this.thumbnailViewer1.AllowDrop = true;
            this.thumbnailViewer1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.thumbnailViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbnailViewer1.Clipboard = winFormsSystemClipboard1;
            this.thumbnailViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            thumbnailAppearance1.BackColor = System.Drawing.Color.Transparent;
            thumbnailAppearance1.BorderColor = System.Drawing.Color.Gray;
            thumbnailAppearance1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            thumbnailAppearance1.BorderWidth = 1;
            this.thumbnailViewer1.FocusedThumbnailAppearance = thumbnailAppearance1;
            this.thumbnailViewer1.GenerateOnlyVisibleThumbnails = true;
            thumbnailAppearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            thumbnailAppearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            thumbnailAppearance2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance2.BorderWidth = 2;
            this.thumbnailViewer1.HoveredThumbnailAppearance = thumbnailAppearance2;
            this.thumbnailViewer1.ImageRotationAngle = 0;
            this.thumbnailViewer1.Location = new System.Drawing.Point(0, 0);
            this.thumbnailViewer1.MasterViewer = this.imageViewer1;
            this.thumbnailViewer1.Name = "thumbnailViewer1";
            thumbnailAppearance3.BackColor = System.Drawing.Color.Black;
            thumbnailAppearance3.BorderColor = System.Drawing.Color.Black;
            thumbnailAppearance3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance3.BorderWidth = 0;
            this.thumbnailViewer1.NotReadyThumbnailAppearance = thumbnailAppearance3;
            thumbnailAppearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            thumbnailAppearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(222)))), ((int)(((byte)(253)))));
            thumbnailAppearance4.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance4.BorderWidth = 1;
            this.thumbnailViewer1.SelectedThumbnailAppearance = thumbnailAppearance4;
            this.thumbnailViewer1.Size = new System.Drawing.Size(197, 671);
            this.thumbnailViewer1.TabIndex = 3;
            this.thumbnailViewer1.Text = "thumbnailViewer1";
            thumbnailAppearance5.BackColor = System.Drawing.Color.Transparent;
            thumbnailAppearance5.BorderColor = System.Drawing.Color.Transparent;
            thumbnailAppearance5.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance5.BorderWidth = 1;
            this.thumbnailViewer1.ThumbnailAppearance = thumbnailAppearance5;
            thumbnailCaption1.Padding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            thumbnailCaption1.TextColor = System.Drawing.Color.Black;
            this.thumbnailViewer1.ThumbnailCaption = thumbnailCaption1;
            this.thumbnailViewer1.ThumbnailControlPadding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            this.thumbnailViewer1.ThumbnailImagePadding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            this.thumbnailViewer1.ThumbnailMargin = new System.Windows.Forms.Padding(3);
            this.thumbnailViewer1.ThumbnailRenderingThreadCount = 4;
            this.thumbnailViewer1.ThumbnailSize = new System.Drawing.Size(100, 100);
            this.thumbnailViewer1.FocusedIndexChanged += new System.EventHandler<Vintasoft.Imaging.UI.FocusedIndexChangedEventArgs>(this.thumbnailViewer1_FocusedIndexChanged);
            // 
            // textRecognitionTab
            // 
            this.textRecognitionTab.Controls.Add(this.segmentationTabPage);
            this.textRecognitionTab.Controls.Add(this.recognitionResultsTabPage);
            this.textRecognitionTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textRecognitionTab.Location = new System.Drawing.Point(0, 0);
            this.textRecognitionTab.Name = "textRecognitionTab";
            this.textRecognitionTab.SelectedIndex = 0;
            this.textRecognitionTab.Size = new System.Drawing.Size(277, 671);
            this.textRecognitionTab.TabIndex = 0;
            this.textRecognitionTab.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // segmentationTabPage
            // 
            this.segmentationTabPage.Controls.Add(this.tableLayoutPanel1);
            this.segmentationTabPage.Controls.Add(this.textRecognitionRegionsPanel);
            this.segmentationTabPage.Location = new System.Drawing.Point(4, 22);
            this.segmentationTabPage.Name = "segmentationTabPage";
            this.segmentationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.segmentationTabPage.Size = new System.Drawing.Size(269, 645);
            this.segmentationTabPage.TabIndex = 0;
            this.segmentationTabPage.Text = "Text Recognition Regions";
            this.segmentationTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.addTextRecognitionRegionButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeTextRecognitionRegionButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeAllTextRecognitionRegionsButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 29);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // addTextRecognitionRegionButton
            // 
            this.addTextRecognitionRegionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTextRecognitionRegionButton.Location = new System.Drawing.Point(3, 3);
            this.addTextRecognitionRegionButton.Name = "addTextRecognitionRegionButton";
            this.addTextRecognitionRegionButton.Size = new System.Drawing.Size(80, 23);
            this.addTextRecognitionRegionButton.TabIndex = 5;
            this.addTextRecognitionRegionButton.Text = "Add";
            this.addTextRecognitionRegionButton.UseVisualStyleBackColor = true;
            this.addTextRecognitionRegionButton.Click += new System.EventHandler(this.addSegmentationRectButton_Click);
            // 
            // textRecognitionRegionsPanel
            // 
            this.textRecognitionRegionsPanel.Controls.Add(this.textRecognitionRegionsComboBox);
            this.textRecognitionRegionsPanel.Controls.Add(this.textRecognitionRegionsLabel);
            this.textRecognitionRegionsPanel.Controls.Add(this.selectedTextRecognitionRegionGroupBox);
            this.textRecognitionRegionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textRecognitionRegionsPanel.Location = new System.Drawing.Point(3, 3);
            this.textRecognitionRegionsPanel.Name = "textRecognitionRegionsPanel";
            this.textRecognitionRegionsPanel.Size = new System.Drawing.Size(263, 639);
            this.textRecognitionRegionsPanel.TabIndex = 0;
            // 
            // textRecognitionRegionsComboBox
            // 
            this.textRecognitionRegionsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRecognitionRegionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textRecognitionRegionsComboBox.FormattingEnabled = true;
            this.textRecognitionRegionsComboBox.Location = new System.Drawing.Point(6, 16);
            this.textRecognitionRegionsComboBox.Name = "textRecognitionRegionsComboBox";
            this.textRecognitionRegionsComboBox.Size = new System.Drawing.Size(254, 21);
            this.textRecognitionRegionsComboBox.TabIndex = 7;
            this.textRecognitionRegionsComboBox.SelectedIndexChanged += new System.EventHandler(this.textRecognitionRegionsComboBox_SelectedIndexChanged);
            this.textRecognitionRegionsComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.textRecognitionRegionsComboBox_Format);
            // 
            // textRecognitionRegionsLabel
            // 
            this.textRecognitionRegionsLabel.AutoSize = true;
            this.textRecognitionRegionsLabel.Location = new System.Drawing.Point(3, 0);
            this.textRecognitionRegionsLabel.Name = "textRecognitionRegionsLabel";
            this.textRecognitionRegionsLabel.Size = new System.Drawing.Size(123, 13);
            this.textRecognitionRegionsLabel.TabIndex = 6;
            this.textRecognitionRegionsLabel.Text = "Text recognition regions:";
            // 
            // recognitionResultsTabPage
            // 
            this.recognitionResultsTabPage.Controls.Add(this.ocrResultsEditorPanel);
            this.recognitionResultsTabPage.Location = new System.Drawing.Point(4, 22);
            this.recognitionResultsTabPage.Name = "recognitionResultsTabPage";
            this.recognitionResultsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recognitionResultsTabPage.Size = new System.Drawing.Size(269, 645);
            this.recognitionResultsTabPage.TabIndex = 1;
            this.recognitionResultsTabPage.Text = "Text Recognition Results";
            this.recognitionResultsTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.thumbnailViewer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1041, 671);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.imageViewer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textRecognitionTab);
            this.splitContainer2.Size = new System.Drawing.Size(840, 671);
            this.splitContainer2.SplitterDistance = 559;
            this.splitContainer2.TabIndex = 0;
            // 
            // imageViewerToolStrip1
            // 
            this.imageViewerToolStrip1.AssociatedZoomTrackBar = null;
            this.imageViewerToolStrip1.CanPrint = false;
            this.imageViewerToolStrip1.CanSaveFile = false;
            this.imageViewerToolStrip1.CanScan = true;
            this.imageViewerToolStrip1.ImageViewer = this.imageViewer1;
            this.imageViewerToolStrip1.ScanButtonEnabled = true;
            this.imageViewerToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.imageViewerToolStrip1.Name = "imageViewerToolStrip1";
            this.imageViewerToolStrip1.PageCount = 0;
            this.imageViewerToolStrip1.PrintButtonEnabled = true;
            this.imageViewerToolStrip1.SaveButtonEnabled = true;
            this.imageViewerToolStrip1.Size = new System.Drawing.Size(1041, 25);
            this.imageViewerToolStrip1.TabIndex = 6;
            this.imageViewerToolStrip1.Text = "imageViewerToolStrip1";
            this.imageViewerToolStrip1.UseImageViewerImages = true;
            this.imageViewerToolStrip1.OpenFile += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.imageViewerToolStrip1.Scan += new System.EventHandler(this.scanImagesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 744);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.imageViewerToolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VintaSoft OCR Demo";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxConfidenceFromDictTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxConfidenceTrackBar)).EndInit();
            this.ocrResultsEditorPanel.ResumeLayout(false);
            this.ocrResultsEditorPanel.PerformLayout();
            this.selectedTextRecognitionRegionGroupBox.ResumeLayout(false);
            this.selectedTextRecognitionRegionGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.textRecognitionTab.ResumeLayout(false);
            this.segmentationTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.textRecognitionRegionsPanel.ResumeLayout(false);
            this.textRecognitionRegionsPanel.PerformLayout();
            this.recognitionResultsTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer1;
        private System.Windows.Forms.ToolStripMenuItem recognizeTextInCurrentImageToolStripMenuItem;
        private Vintasoft.Imaging.UI.ThumbnailViewer thumbnailViewer1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thumbnailViewerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem imageScaleModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToHeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelToPixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorZoomModes;
        private System.Windows.Forms.ToolStripMenuItem scale25ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale400ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageViewerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel imageInfoStatusLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem saveAsTextToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ocrObjectRectLabel;
        private System.Windows.Forms.TextBox ocrObjectTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label rectLabel;
        private System.Windows.Forms.Label ocrObjectTypeLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox selectedObjectsListBox;
        private System.Windows.Forms.Label ocrObjectConfidenceLabel;
        private System.Windows.Forms.Label confidenceLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar maxConfidenceTrackBar;
        private System.Windows.Forms.TrackBar maxConfidenceFromDictTrackBar;
        private System.Windows.Forms.Label maxConfidenceLabel;
        private System.Windows.Forms.Label maxConfidenceFromDictionaryLabel;
        private System.Windows.Forms.Button selectByConfidenceButton;
        private System.Windows.Forms.Button deleteAllSelectedObjectsButton;
        private System.Windows.Forms.Button deleteSelectedObjectButton;
        private System.Windows.Forms.Button deselectSelectedOcrObjectButton;
        private System.Windows.Forms.Button deselectAllSelectedOcrObjectsButton;
        private System.Windows.Forms.Panel ocrResultsEditorPanel;
        private System.Windows.Forms.ComboBox ocrObjectTypeComboBox;
        private System.Windows.Forms.Label objectTypeLabel;
        private System.Windows.Forms.Label maxConfidenceValueLabel;
        private System.Windows.Forms.Label maxConfidenceFromDictLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recognizeTextInAllImagesToolStripMenuItem;
        private System.Windows.Forms.GroupBox selectedTextRecognitionRegionGroupBox;
        private System.Windows.Forms.Button removeAllTextRecognitionRegionsButton;
        private System.Windows.Forms.Button removeTextRecognitionRegionButton;
        private System.Windows.Forms.Label selectedTextRecognitionRegionRectangleLabel;
        private System.Windows.Forms.Label rectangleLabel;
        private System.Windows.Forms.ToolStripMenuItem segmentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentCurrentPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentAllPagesToolStripMenuItem;
        private System.Windows.Forms.TabControl textRecognitionTab;
        private System.Windows.Forms.TabPage segmentationTabPage;
        private System.Windows.Forms.TabPage recognitionResultsTabPage;
        private System.Windows.Forms.Panel textRecognitionRegionsPanel;
        private System.Windows.Forms.ToolStripMenuItem removeSegmentationResultForCurrentImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSegmentationResultsForAllImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem removeRecognitionResultForCurrentImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRecognitionResultsForAllImagesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripProgressBar ocrEngineManagerProgressBar;
        private System.Windows.Forms.ToolStripProgressBar saveOcrResultsProgressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsPdfDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfTextOnlyToolStripMenuItem;
        private DemosCommonCode.Imaging.ImageViewerToolStrip imageViewerToolStrip1;
        private System.Windows.Forms.Button addTextRecognitionRegionButton;
        private System.Windows.Forms.ComboBox textRecognitionRegionsComboBox;
        private System.Windows.Forms.Label textRecognitionRegionsLabel;
        private System.Windows.Forms.Label textRotationLabel;
        private System.Windows.Forms.ComboBox selectedTextRecognitionRegionTextRotationComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem loadRecognitionResultsFromHOCRFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRecognitionResultsToHOCRFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToHocrForCurrentImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToHocrForAllImagesToolStripMenuItem;
        private System.Windows.Forms.ComboBox selectedTextRecognitionRegionTypeComboBox;
        private System.Windows.Forms.Label recognitionRegionTypeLabel;
        private System.Windows.Forms.ToolStripStatusLabel imageInfoLabel;
        private System.Windows.Forms.ToolStripMenuItem saveAsFormattedTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsTextFileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private DemosCommonCode.Imaging.OcrLanguagesListBox selectedTextRecognitionRegionOcrLanguagesListBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem rotateViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem counterclockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRecognitionResultsFromDocumentToolStripMenuItem;
        private System.Windows.Forms.Label ocrObjectOrientationLabel;
        private System.Windows.Forms.Label orientationLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem recognizeMICRInCurrentImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recognizeMRZInCurrenImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem detectPageOrientationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageOverTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfImageOverTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfImageOverTextPDFA1aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfImageOverTextPDFA1bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfImageOverTextPDFA2aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfImageOverTextPDFA2bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textOverImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfTextOverImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfTextOverImagePDFA1aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfTextOverImagePDFA1bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfTextOverImagePDFA2aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfTextOverImagePDFA2bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfImageOverTextPDFA4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfTextOverImagePDFA4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem pdfTextOverImageSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem cleanupSettingsToolStripMenuItem;
    }
}