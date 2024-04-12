using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Ocr.Results;

namespace OcrDemo
{
    /// <summary>
    /// A form that allows to specify settings, which define how to cleanup results of text recognition.
    /// </summary>
    public partial class OcrCleanupSettingsForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrCleanupSettingsForm"/> class.
        /// </summary>
        /// <param name="settings">The OCR cleanup settings.</param>
        public OcrCleanupSettingsForm()
        {
            InitializeComponent();

            OcrCleanupSettings defaultSettings = new OcrCleanupSettings();

            lineMinConfidenceValueEditorControl.DefaultValue = defaultSettings.LineMinConfidence;
            wordMinConfidenceValueEditorControl.DefaultValue = defaultSettings.WordMinConfidence;
            symbolMinConfidenceValueEditorControl.DefaultValue = defaultSettings.SymbolMinConfidence;

            Settings = defaultSettings;
        }

        #endregion



        #region Properties

        OcrCleanupSettings _settings;
        /// <summary>
        /// Gets or sets the OCR cleanup settings.
        /// </summary>
        public OcrCleanupSettings Settings
        {
            get
            {
                return _settings;
            }
            set
            {
                _settings = value;

                if (value == null)
                {
                    cleanupOcrPageBeforeProcessingCheckBox.Checked = false;
                }
                else
                {
                    cleanupOcrPageBeforeProcessingCheckBox.Checked = true;

                    lineMinConfidenceValueEditorControl.Value = value.LineMinConfidence;
                    wordMinConfidenceValueEditorControl.Value = value.WordMinConfidence;
                    symbolMinConfidenceValueEditorControl.Value = value.SymbolMinConfidence;
                }

                mainPanel.Enabled = cleanupOcrPageBeforeProcessingCheckBox.Checked;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Handles the Click event of okButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            if (cleanupOcrPageBeforeProcessingCheckBox.Checked)
            {
                if (_settings == null)
                    _settings = new OcrCleanupSettings();

                _settings.LineMinConfidence = lineMinConfidenceValueEditorControl.Value;
                _settings.WordMinConfidence = wordMinConfidenceValueEditorControl.Value;
                _settings.SymbolMinConfidence = symbolMinConfidenceValueEditorControl.Value;
            }
            else
            {
                _settings = null;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of cleanupOcrPageBeforeProcessingCheckBox object.
        /// </summary>
        private void cleanupOcrPageBeforeProcessingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mainPanel.Enabled = cleanupOcrPageBeforeProcessingCheckBox.Checked;
        }

        #endregion

    }
}
