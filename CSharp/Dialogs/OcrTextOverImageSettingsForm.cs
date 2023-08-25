using System;
using System.Windows.Forms;

#if !REMOVE_PDF_PLUGIN
using Vintasoft.Imaging.Pdf.Ocr;
#endif

namespace OcrDemo
{
    /// <summary>
    /// A form that allows to specify settings, which define how to build searchable PDF document that contains text over image.
    /// </summary>
    public partial class OcrTextOverImageSettingsForm : Form
    {

        #region Fields

#if !REMOVE_PDF_PLUGIN
        /// <summary>
        /// The settings, which define how to build searchable PDF document that contains text over image.
        /// </summary>
        OcrTextOverImageSettings _settings;
#endif

        #endregion



        #region Constructors

#if !REMOVE_PDF_PLUGIN
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrTextOverImageSettingsForm"/> class.
        /// </summary>
        /// <param name="settings">The settings, which define how to build searchable PDF document that contains text over image.</param>
        public OcrTextOverImageSettingsForm(OcrTextOverImageSettings settings)
        {
            InitializeComponent();

            _settings = settings;

            textQualityValueEditorControl.Value = settings.TextQuality * 100;
            textQualityValueEditorControl.DefaultValue = settings.TextQuality * 100;
        }
#endif

        #endregion



        #region Methods

        /// <summary>
        /// Handles the Click event of OkButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
#if !REMOVE_PDF_PLUGIN
            _settings.TextQuality = textQualityValueEditorControl.Value / 100f;
#endif
        }

        #endregion

    }
}
