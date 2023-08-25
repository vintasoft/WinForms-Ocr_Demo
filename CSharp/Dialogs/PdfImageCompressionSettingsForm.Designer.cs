namespace OcrDemo
{
    partial class PdfImageCompressionSettingsForm
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
            this.pdfImageCompressionControl1 = new DemosCommonCode.Imaging.Codecs.Dialogs.PdfImageCompressionControl();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
#if !REMOVE_PDF_PLUGIN
            // 
            // pdfImageCompressionControl1
            // 
            this.pdfImageCompressionControl1.Compression = Vintasoft.Imaging.Pdf.PdfCompression.Auto;
            this.pdfImageCompressionControl1.CompressionSettings = null;
            this.pdfImageCompressionControl1.Location = new System.Drawing.Point(4, 4);
#if !REMOVE_DOCCLEANUP_PLUGIN
            this.pdfImageCompressionControl1.IsMrcCompressionOnly = false;
            this.pdfImageCompressionControl1.MrcCompressionSettings = null;
#endif
            this.pdfImageCompressionControl1.Name = "pdfImageCompressionControl1";
            this.pdfImageCompressionControl1.Size = new System.Drawing.Size(330, 202);
            this.pdfImageCompressionControl1.TabIndex = 0;
#endif
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(173, 212);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(254, 212);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PdfImageCompressionSettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(338, 245);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.pdfImageCompressionControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PdfImageCompressionSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDF Image Compression Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private DemosCommonCode.Imaging.Codecs.Dialogs.PdfImageCompressionControl pdfImageCompressionControl1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}