using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Codecs.Encoders;
#if !REMOVE_PDF_PLUGIN
using Vintasoft.Imaging.Pdf;
#endif

namespace OcrDemo
{
    /// <summary>
    /// A form that allows to specify PDF image compression settings.
    /// </summary>
    public partial class PdfImageCompressionSettingsForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfImageCompressionSettingsForm"/> class.
        /// </summary>
        public PdfImageCompressionSettingsForm()
        {
            InitializeComponent();
        }

        #endregion



        #region Properties

#if !REMOVE_PDF_PLUGIN
        /// <summary>
        /// Gets or sets the PDF compression type.
        /// </summary>
        public PdfCompression Compression
        {
            get
            {
                return pdfImageCompressionControl1.Compression;
            }
            set
            {
                pdfImageCompressionControl1.Compression = value;
            }
        }

        /// <summary>
        /// Gets or sets the PDF compression settings.
        /// </summary>
        public PdfCompressionSettings CompressionSettings
        {
            get
            {
                return pdfImageCompressionControl1.CompressionSettings;
            }
            set
            {
                pdfImageCompressionControl1.CompressionSettings = value;
            }
        }

#if !REMOVE_DOCCLEANUP_PLUGIN
        /// <summary>
        /// Gets or sets the PDF MRC compression settings.
        /// </summary>
        public PdfMrcCompressionSettings MrcCompressionSettings
        {
            get
            {
                return pdfImageCompressionControl1.MrcCompressionSettings;
            }
            set
            {
                pdfImageCompressionControl1.MrcCompressionSettings = value;
            }
        }
#endif
#endif

#endregion



        #region Methods

        /// <summary>
        /// Handles the Click event of okButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of cancelButton object.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion

    }
}
