namespace DemosCommonCode.Ocr
{
    partial class AddImagesForm
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
            this.addFromFileButton = new System.Windows.Forms.Button();
            this.addFromScannerButton = new System.Windows.Forms.Button();
            this.ocrPreprocessingGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.autoInvertCheckBox = new System.Windows.Forms.CheckBox();
            this.allImagesProgressBar = new System.Windows.Forms.ProgressBar();
            this.segmentationCheckBox = new System.Windows.Forms.CheckBox();
            this.currentImageProgressBar = new System.Windows.Forms.ProgressBar();
            this.autoOrientationCheckBox = new System.Windows.Forms.CheckBox();
            this.halftoneRemovalCheckBox = new System.Windows.Forms.CheckBox();
            this.holePunchRemovalCheckBox = new System.Windows.Forms.CheckBox();
            this.clearBorderCheckBox = new System.Windows.Forms.CheckBox();
            this.despeckleCheckBox = new System.Windows.Forms.CheckBox();
            this.deskewChekBox = new System.Windows.Forms.CheckBox();
            this.ocrPreprocessingCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.processingGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.currentImageRadioButton = new System.Windows.Forms.RadioButton();
            this.allImagesRadioButton = new System.Windows.Forms.RadioButton();
            this.autoOrientationButton = new System.Windows.Forms.Button();
            this.removeTablesButton = new System.Windows.Forms.Button();
            this.autoTextInvertButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rotateButton = new System.Windows.Forms.Button();
            this.invertButton = new System.Windows.Forms.Button();
            this.adaptiveBinarizeButton = new System.Windows.Forms.Button();
            this.globalBinarizeButton = new System.Windows.Forms.Button();
            this.thresholdBinarizeButton = new System.Windows.Forms.Button();
            this.rotateAngleComboBox = new System.Windows.Forms.ComboBox();
            this.thresholdComboBox = new System.Windows.Forms.ComboBox();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.thumbnailViewer1 = new Vintasoft.Imaging.UI.ThumbnailViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.ocrPreprocessingGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.processingGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // addFromFileButton
            // 
            this.addFromFileButton.AutoSize = true;
            this.addFromFileButton.Location = new System.Drawing.Point(3, 3);
            this.addFromFileButton.MinimumSize = new System.Drawing.Size(185, 0);
            this.addFromFileButton.Name = "addFromFileButton";
            this.addFromFileButton.Size = new System.Drawing.Size(185, 23);
            this.addFromFileButton.TabIndex = 0;
            this.addFromFileButton.Text = "Add from File...";
            this.addFromFileButton.UseVisualStyleBackColor = true;
            this.addFromFileButton.Click += new System.EventHandler(this.addFromFileButton_Click);
            // 
            // addFromScannerButton
            // 
            this.addFromScannerButton.AutoSize = true;
            this.addFromScannerButton.Location = new System.Drawing.Point(3, 32);
            this.addFromScannerButton.MinimumSize = new System.Drawing.Size(185, 0);
            this.addFromScannerButton.Name = "addFromScannerButton";
            this.addFromScannerButton.Size = new System.Drawing.Size(185, 23);
            this.addFromScannerButton.TabIndex = 1;
            this.addFromScannerButton.Text = "Scan...";
            this.addFromScannerButton.UseVisualStyleBackColor = true;
            this.addFromScannerButton.Click += new System.EventHandler(this.addFromScannerButton_Click);
            // 
            // ocrPreprocessingGroupBox
            // 
            this.ocrPreprocessingGroupBox.AutoSize = true;
            this.ocrPreprocessingGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ocrPreprocessingGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.ocrPreprocessingGroupBox.Controls.Add(this.ocrPreprocessingCheckBox);
            this.ocrPreprocessingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ocrPreprocessingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ocrPreprocessingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ocrPreprocessingGroupBox.Name = "ocrPreprocessingGroupBox";
            this.ocrPreprocessingGroupBox.Size = new System.Drawing.Size(218, 252);
            this.ocrPreprocessingGroupBox.TabIndex = 4;
            this.ocrPreprocessingGroupBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.autoInvertCheckBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.allImagesProgressBar, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.segmentationCheckBox, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.currentImageProgressBar, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.autoOrientationCheckBox, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.halftoneRemovalCheckBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.holePunchRemovalCheckBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.clearBorderCheckBox, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.despeckleCheckBox, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.deskewChekBox, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 233);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // autoInvertCheckBox
            // 
            this.autoInvertCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.autoInvertCheckBox.AutoSize = true;
            this.autoInvertCheckBox.Checked = true;
            this.autoInvertCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoInvertCheckBox.Location = new System.Drawing.Point(3, 3);
            this.autoInvertCheckBox.Name = "autoInvertCheckBox";
            this.autoInvertCheckBox.Size = new System.Drawing.Size(78, 17);
            this.autoInvertCheckBox.TabIndex = 10;
            this.autoInvertCheckBox.Text = "Auto Invert";
            this.autoInvertCheckBox.UseVisualStyleBackColor = true;
            // 
            // allImagesProgressBar
            // 
            this.allImagesProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.allImagesProgressBar.Location = new System.Drawing.Point(3, 210);
            this.allImagesProgressBar.Name = "allImagesProgressBar";
            this.allImagesProgressBar.Size = new System.Drawing.Size(206, 17);
            this.allImagesProgressBar.TabIndex = 8;
            // 
            // segmentationCheckBox
            // 
            this.segmentationCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.segmentationCheckBox.AutoSize = true;
            this.segmentationCheckBox.Location = new System.Drawing.Point(3, 164);
            this.segmentationCheckBox.Name = "segmentationCheckBox";
            this.segmentationCheckBox.Size = new System.Drawing.Size(91, 17);
            this.segmentationCheckBox.TabIndex = 9;
            this.segmentationCheckBox.Text = "Segmentation";
            this.segmentationCheckBox.UseVisualStyleBackColor = true;
            // 
            // currentImageProgressBar
            // 
            this.currentImageProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.currentImageProgressBar.Location = new System.Drawing.Point(3, 187);
            this.currentImageProgressBar.Name = "currentImageProgressBar";
            this.currentImageProgressBar.Size = new System.Drawing.Size(206, 17);
            this.currentImageProgressBar.TabIndex = 7;
            // 
            // autoOrientationCheckBox
            // 
            this.autoOrientationCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.autoOrientationCheckBox.AutoSize = true;
            this.autoOrientationCheckBox.Location = new System.Drawing.Point(3, 141);
            this.autoOrientationCheckBox.Name = "autoOrientationCheckBox";
            this.autoOrientationCheckBox.Size = new System.Drawing.Size(99, 17);
            this.autoOrientationCheckBox.TabIndex = 12;
            this.autoOrientationCheckBox.Text = "Auto Orienation";
            this.autoOrientationCheckBox.UseVisualStyleBackColor = true;
            // 
            // halftoneRemovalCheckBox
            // 
            this.halftoneRemovalCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.halftoneRemovalCheckBox.AutoSize = true;
            this.halftoneRemovalCheckBox.Checked = true;
            this.halftoneRemovalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.halftoneRemovalCheckBox.Location = new System.Drawing.Point(3, 26);
            this.halftoneRemovalCheckBox.Name = "halftoneRemovalCheckBox";
            this.halftoneRemovalCheckBox.Size = new System.Drawing.Size(111, 17);
            this.halftoneRemovalCheckBox.TabIndex = 13;
            this.halftoneRemovalCheckBox.Text = "Halftone Removal";
            this.halftoneRemovalCheckBox.UseVisualStyleBackColor = true;
            // 
            // holePunchRemovalCheckBox
            // 
            this.holePunchRemovalCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.holePunchRemovalCheckBox.AutoSize = true;
            this.holePunchRemovalCheckBox.Checked = true;
            this.holePunchRemovalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.holePunchRemovalCheckBox.Location = new System.Drawing.Point(3, 72);
            this.holePunchRemovalCheckBox.Name = "holePunchRemovalCheckBox";
            this.holePunchRemovalCheckBox.Size = new System.Drawing.Size(127, 17);
            this.holePunchRemovalCheckBox.TabIndex = 11;
            this.holePunchRemovalCheckBox.Text = "Hole Punch Removal";
            this.holePunchRemovalCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearBorderCheckBox
            // 
            this.clearBorderCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clearBorderCheckBox.AutoSize = true;
            this.clearBorderCheckBox.Checked = true;
            this.clearBorderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearBorderCheckBox.Location = new System.Drawing.Point(3, 49);
            this.clearBorderCheckBox.Name = "clearBorderCheckBox";
            this.clearBorderCheckBox.Size = new System.Drawing.Size(84, 17);
            this.clearBorderCheckBox.TabIndex = 2;
            this.clearBorderCheckBox.Text = "Clear Border";
            this.clearBorderCheckBox.UseVisualStyleBackColor = true;
            // 
            // despeckleCheckBox
            // 
            this.despeckleCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.despeckleCheckBox.AutoSize = true;
            this.despeckleCheckBox.Checked = true;
            this.despeckleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.despeckleCheckBox.Location = new System.Drawing.Point(3, 95);
            this.despeckleCheckBox.Name = "despeckleCheckBox";
            this.despeckleCheckBox.Size = new System.Drawing.Size(77, 17);
            this.despeckleCheckBox.TabIndex = 1;
            this.despeckleCheckBox.Text = "Despeckle";
            this.despeckleCheckBox.UseVisualStyleBackColor = true;
            // 
            // deskewChekBox
            // 
            this.deskewChekBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deskewChekBox.AutoSize = true;
            this.deskewChekBox.Checked = true;
            this.deskewChekBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deskewChekBox.Location = new System.Drawing.Point(3, 118);
            this.deskewChekBox.Name = "deskewChekBox";
            this.deskewChekBox.Size = new System.Drawing.Size(65, 17);
            this.deskewChekBox.TabIndex = 3;
            this.deskewChekBox.Text = "Deskew";
            this.deskewChekBox.UseVisualStyleBackColor = true;
            // 
            // ocrPreprocessingCheckBox
            // 
            this.ocrPreprocessingCheckBox.AutoSize = true;
            this.ocrPreprocessingCheckBox.Checked = true;
            this.ocrPreprocessingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ocrPreprocessingCheckBox.Location = new System.Drawing.Point(6, 0);
            this.ocrPreprocessingCheckBox.Name = "ocrPreprocessingCheckBox";
            this.ocrPreprocessingCheckBox.Size = new System.Drawing.Size(119, 17);
            this.ocrPreprocessingCheckBox.TabIndex = 13;
            this.ocrPreprocessingCheckBox.Text = "OCR Preprocessing";
            this.ocrPreprocessingCheckBox.UseVisualStyleBackColor = true;
            this.ocrPreprocessingCheckBox.CheckedChanged += new System.EventHandler(this.ocrPreprocessingCheckBox_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(633, 544);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(91, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(730, 544);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.Multiselect = true;
            // 
            // processingGroupBox
            // 
            this.processingGroupBox.AutoSize = true;
            this.processingGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.processingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processingGroupBox.Location = new System.Drawing.Point(3, 3);
            this.processingGroupBox.Name = "processingGroupBox";
            this.processingGroupBox.Size = new System.Drawing.Size(212, 274);
            this.processingGroupBox.TabIndex = 8;
            this.processingGroupBox.TabStop = false;
            this.processingGroupBox.Text = "Processing";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.autoOrientationButton, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.removeTablesButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.autoTextInvertButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(206, 255);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.currentImageRadioButton, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.allImagesRadioButton, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(206, 23);
            this.tableLayoutPanel7.TabIndex = 18;
            // 
            // currentImageRadioButton
            // 
            this.currentImageRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentImageRadioButton.AutoSize = true;
            this.currentImageRadioButton.Checked = true;
            this.currentImageRadioButton.Location = new System.Drawing.Point(3, 3);
            this.currentImageRadioButton.Name = "currentImageRadioButton";
            this.currentImageRadioButton.Size = new System.Drawing.Size(91, 17);
            this.currentImageRadioButton.TabIndex = 7;
            this.currentImageRadioButton.TabStop = true;
            this.currentImageRadioButton.Text = "Current Image";
            this.currentImageRadioButton.UseVisualStyleBackColor = true;
            // 
            // allImagesRadioButton
            // 
            this.allImagesRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.allImagesRadioButton.AutoSize = true;
            this.allImagesRadioButton.Location = new System.Drawing.Point(100, 3);
            this.allImagesRadioButton.Name = "allImagesRadioButton";
            this.allImagesRadioButton.Size = new System.Drawing.Size(73, 17);
            this.allImagesRadioButton.TabIndex = 8;
            this.allImagesRadioButton.Text = "All Images";
            this.allImagesRadioButton.UseVisualStyleBackColor = true;
            // 
            // autoOrientationButton
            // 
            this.autoOrientationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoOrientationButton.AutoSize = true;
            this.autoOrientationButton.Location = new System.Drawing.Point(3, 229);
            this.autoOrientationButton.Name = "autoOrientationButton";
            this.autoOrientationButton.Size = new System.Drawing.Size(200, 23);
            this.autoOrientationButton.TabIndex = 11;
            this.autoOrientationButton.Text = "Auto Orientation";
            this.autoOrientationButton.UseVisualStyleBackColor = true;
            this.autoOrientationButton.Click += new System.EventHandler(this.autoOrientationButton_Click);
            // 
            // removeTablesButton
            // 
            this.removeTablesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.removeTablesButton.AutoSize = true;
            this.removeTablesButton.Location = new System.Drawing.Point(3, 171);
            this.removeTablesButton.Name = "removeTablesButton";
            this.removeTablesButton.Size = new System.Drawing.Size(200, 23);
            this.removeTablesButton.TabIndex = 9;
            this.removeTablesButton.Text = "Remove Tables";
            this.removeTablesButton.UseVisualStyleBackColor = true;
            this.removeTablesButton.Click += new System.EventHandler(this.removeTablesButton_Click);
            // 
            // autoTextInvertButton
            // 
            this.autoTextInvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoTextInvertButton.AutoSize = true;
            this.autoTextInvertButton.Location = new System.Drawing.Point(3, 200);
            this.autoTextInvertButton.Name = "autoTextInvertButton";
            this.autoTextInvertButton.Size = new System.Drawing.Size(200, 23);
            this.autoTextInvertButton.TabIndex = 10;
            this.autoTextInvertButton.Text = "Auto Text Invert";
            this.autoTextInvertButton.UseVisualStyleBackColor = true;
            this.autoTextInvertButton.Click += new System.EventHandler(this.autoTextInvertButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.rotateButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.invertButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.adaptiveBinarizeButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.globalBinarizeButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.thresholdBinarizeButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rotateAngleComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.thresholdComboBox, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 145);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // rotateButton
            // 
            this.rotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateButton.AutoSize = true;
            this.rotateButton.Location = new System.Drawing.Point(3, 3);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(112, 23);
            this.rotateButton.TabIndex = 0;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // invertButton
            // 
            this.invertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.invertButton.AutoSize = true;
            this.invertButton.Location = new System.Drawing.Point(3, 32);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(112, 23);
            this.invertButton.TabIndex = 1;
            this.invertButton.Text = "Invert";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // adaptiveBinarizeButton
            // 
            this.adaptiveBinarizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adaptiveBinarizeButton.AutoSize = true;
            this.adaptiveBinarizeButton.Location = new System.Drawing.Point(3, 61);
            this.adaptiveBinarizeButton.Name = "adaptiveBinarizeButton";
            this.adaptiveBinarizeButton.Size = new System.Drawing.Size(112, 23);
            this.adaptiveBinarizeButton.TabIndex = 3;
            this.adaptiveBinarizeButton.Text = "Adaptive Binarize";
            this.adaptiveBinarizeButton.UseVisualStyleBackColor = true;
            this.adaptiveBinarizeButton.Click += new System.EventHandler(this.adaptiveBinarizeButton_Click);
            // 
            // globalBinarizeButton
            // 
            this.globalBinarizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.globalBinarizeButton.AutoSize = true;
            this.globalBinarizeButton.Location = new System.Drawing.Point(3, 90);
            this.globalBinarizeButton.Name = "globalBinarizeButton";
            this.globalBinarizeButton.Size = new System.Drawing.Size(112, 23);
            this.globalBinarizeButton.TabIndex = 4;
            this.globalBinarizeButton.Text = "Global Binarize";
            this.globalBinarizeButton.UseVisualStyleBackColor = true;
            this.globalBinarizeButton.Click += new System.EventHandler(this.globalBinarizeButton_Click);
            // 
            // thresholdBinarizeButton
            // 
            this.thresholdBinarizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdBinarizeButton.AutoSize = true;
            this.thresholdBinarizeButton.Location = new System.Drawing.Point(3, 119);
            this.thresholdBinarizeButton.Name = "thresholdBinarizeButton";
            this.thresholdBinarizeButton.Size = new System.Drawing.Size(112, 23);
            this.thresholdBinarizeButton.TabIndex = 5;
            this.thresholdBinarizeButton.Text = "Threshold Binarize";
            this.thresholdBinarizeButton.UseVisualStyleBackColor = true;
            this.thresholdBinarizeButton.Click += new System.EventHandler(this.thresholdBinarizeButton_Click);
            // 
            // rotateAngleComboBox
            // 
            this.rotateAngleComboBox.FormattingEnabled = true;
            this.rotateAngleComboBox.Items.AddRange(new object[] {
            "90",
            "180",
            "270"});
            this.rotateAngleComboBox.Location = new System.Drawing.Point(121, 3);
            this.rotateAngleComboBox.MinimumSize = new System.Drawing.Size(50, 0);
            this.rotateAngleComboBox.Name = "rotateAngleComboBox";
            this.rotateAngleComboBox.Size = new System.Drawing.Size(50, 21);
            this.rotateAngleComboBox.TabIndex = 2;
            this.rotateAngleComboBox.Text = "90";
            // 
            // thresholdComboBox
            // 
            this.thresholdComboBox.FormattingEnabled = true;
            this.thresholdComboBox.Items.AddRange(new object[] {
            "250",
            "384",
            "500"});
            this.thresholdComboBox.Location = new System.Drawing.Point(121, 119);
            this.thresholdComboBox.MinimumSize = new System.Drawing.Size(50, 0);
            this.thresholdComboBox.Name = "thresholdComboBox";
            this.thresholdComboBox.Size = new System.Drawing.Size(50, 21);
            this.thresholdComboBox.TabIndex = 6;
            this.thresholdComboBox.Text = "384";
            // 
            // imageViewer1
            // 
            this.imageViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer1.Clipboard = winFormsSystemClipboard1;
            this.imageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer1.ImageRenderingSettings = renderingSettings1;
            this.imageViewer1.ImageRotationAngle = 0;
            this.imageViewer1.Location = new System.Drawing.Point(194, 3);
            this.imageViewer1.MasterViewer = this.thumbnailViewer1;
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.Size = new System.Drawing.Size(400, 526);
            this.imageViewer1.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.imageViewer1.TabIndex = 5;
            this.imageViewer1.Text = "imageViewer1";
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
            thumbnailAppearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            thumbnailAppearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            thumbnailAppearance2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance2.BorderWidth = 2;
            this.thumbnailViewer1.HoveredThumbnailAppearance = thumbnailAppearance2;
            this.thumbnailViewer1.ImageRotationAngle = 0;
            this.thumbnailViewer1.Location = new System.Drawing.Point(3, 61);
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
            this.thumbnailViewer1.Size = new System.Drawing.Size(185, 468);
            this.thumbnailViewer1.TabIndex = 2;
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
            this.thumbnailViewer1.ThumbnailSize = new System.Drawing.Size(100, 100);
            this.thumbnailViewer1.ThumbnailAdded += new System.EventHandler<Vintasoft.Imaging.UI.ThumbnailEventArgs>(this.thumbnailViewer1_ThumbnailAdded);
            this.thumbnailViewer1.ThumbnailRemoved += new System.EventHandler<Vintasoft.Imaging.UI.ThumbnailEventArgs>(this.thumbnailViewer1_ThumbnailRemoved);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.ocrPreprocessingGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 252);
            this.panel1.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.processingGroupBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(597, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(218, 532);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.addFromFileButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.addFromScannerButton, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.thumbnailViewer1, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(191, 532);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.imageViewer1, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(815, 532);
            this.tableLayoutPanel6.TabIndex = 17;
            // 
            // AddImagesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(830, 576);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 615);
            this.Name = "AddImagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Images";
            this.Shown += new System.EventHandler(this.AddImagesForm_Shown);
            this.ocrPreprocessingGroupBox.ResumeLayout(false);
            this.ocrPreprocessingGroupBox.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.processingGroupBox.ResumeLayout(false);
            this.processingGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addFromFileButton;
        private System.Windows.Forms.Button addFromScannerButton;
        private Vintasoft.Imaging.UI.ThumbnailViewer thumbnailViewer1;
        private System.Windows.Forms.GroupBox ocrPreprocessingGroupBox;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer1;
        private System.Windows.Forms.CheckBox clearBorderCheckBox;
        private System.Windows.Forms.CheckBox despeckleCheckBox;
        private System.Windows.Forms.CheckBox deskewChekBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar allImagesProgressBar;
        private System.Windows.Forms.ProgressBar currentImageProgressBar;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.GroupBox processingGroupBox;
        private System.Windows.Forms.ComboBox thresholdComboBox;
        private System.Windows.Forms.Button thresholdBinarizeButton;
        private System.Windows.Forms.Button globalBinarizeButton;
        private System.Windows.Forms.Button adaptiveBinarizeButton;
        private System.Windows.Forms.ComboBox rotateAngleComboBox;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.CheckBox segmentationCheckBox;
        private System.Windows.Forms.RadioButton allImagesRadioButton;
        private System.Windows.Forms.RadioButton currentImageRadioButton;
        private System.Windows.Forms.CheckBox autoInvertCheckBox;
        private System.Windows.Forms.CheckBox holePunchRemovalCheckBox;
        private System.Windows.Forms.Button removeTablesButton;
        private System.Windows.Forms.Button autoTextInvertButton;
        private System.Windows.Forms.CheckBox ocrPreprocessingCheckBox;
        private System.Windows.Forms.CheckBox autoOrientationCheckBox;
        private System.Windows.Forms.Button autoOrientationButton;
        private System.Windows.Forms.CheckBox halftoneRemovalCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    }
}