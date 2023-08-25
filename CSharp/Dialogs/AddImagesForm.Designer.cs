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
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance1 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance2 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance3 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance4 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance5 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            this.addFromFileButton = new System.Windows.Forms.Button();
            this.addFromScannerButton = new System.Windows.Forms.Button();
            this.ocrPreprocessingGroupBox = new System.Windows.Forms.GroupBox();
            this.halftoneRemovalCheckBox = new System.Windows.Forms.CheckBox();
            this.autoOrientationCheckBox = new System.Windows.Forms.CheckBox();
            this.holePunchRemovalCheckBox = new System.Windows.Forms.CheckBox();
            this.autoInvertCheckBox = new System.Windows.Forms.CheckBox();
            this.segmentationCheckBox = new System.Windows.Forms.CheckBox();
            this.allImagesProgressBar = new System.Windows.Forms.ProgressBar();
            this.currentImageProgressBar = new System.Windows.Forms.ProgressBar();
            this.deskewChekBox = new System.Windows.Forms.CheckBox();
            this.clearBorderCheckBox = new System.Windows.Forms.CheckBox();
            this.despeckleCheckBox = new System.Windows.Forms.CheckBox();
            this.ocrPreprocessingCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.processingGroupBox = new System.Windows.Forms.GroupBox();
            this.autoOrientationButton = new System.Windows.Forms.Button();
            this.autoTextInvertButton = new System.Windows.Forms.Button();
            this.removeTablesButton = new System.Windows.Forms.Button();
            this.allImagesRadioButton = new System.Windows.Forms.RadioButton();
            this.currentImageRadioButton = new System.Windows.Forms.RadioButton();
            this.thresholdComboBox = new System.Windows.Forms.ComboBox();
            this.thresholdBinarizeButton = new System.Windows.Forms.Button();
            this.globalBinarizeButton = new System.Windows.Forms.Button();
            this.adaptiveBinarizeButton = new System.Windows.Forms.Button();
            this.rotateAngleComboBox = new System.Windows.Forms.ComboBox();
            this.invertButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.thumbnailViewer1 = new Vintasoft.Imaging.UI.ThumbnailViewer();
            this.ocrPreprocessingGroupBox.SuspendLayout();
            this.processingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addFromFileButton
            // 
            this.addFromFileButton.Location = new System.Drawing.Point(12, 12);
            this.addFromFileButton.Name = "addFromFileButton";
            this.addFromFileButton.Size = new System.Drawing.Size(185, 23);
            this.addFromFileButton.TabIndex = 0;
            this.addFromFileButton.Text = "Add from File...";
            this.addFromFileButton.UseVisualStyleBackColor = true;
            this.addFromFileButton.Click += new System.EventHandler(this.addFromFileButton_Click);
            // 
            // addFromScannerButton
            // 
            this.addFromScannerButton.Location = new System.Drawing.Point(12, 41);
            this.addFromScannerButton.Name = "addFromScannerButton";
            this.addFromScannerButton.Size = new System.Drawing.Size(185, 23);
            this.addFromScannerButton.TabIndex = 1;
            this.addFromScannerButton.Text = "Scan...";
            this.addFromScannerButton.UseVisualStyleBackColor = true;
            this.addFromScannerButton.Click += new System.EventHandler(this.addFromScannerButton_Click);
            // 
            // ocrPreprocessingGroupBox
            // 
            this.ocrPreprocessingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ocrPreprocessingGroupBox.Controls.Add(this.halftoneRemovalCheckBox);
            this.ocrPreprocessingGroupBox.Controls.Add(this.autoOrientationCheckBox);
            this.ocrPreprocessingGroupBox.Controls.Add(this.holePunchRemovalCheckBox);
            this.ocrPreprocessingGroupBox.Controls.Add(this.autoInvertCheckBox);
            this.ocrPreprocessingGroupBox.Controls.Add(this.segmentationCheckBox);
            this.ocrPreprocessingGroupBox.Controls.Add(this.allImagesProgressBar);
            this.ocrPreprocessingGroupBox.Controls.Add(this.currentImageProgressBar);
            this.ocrPreprocessingGroupBox.Controls.Add(this.deskewChekBox);
            this.ocrPreprocessingGroupBox.Controls.Add(this.clearBorderCheckBox);
            this.ocrPreprocessingGroupBox.Controls.Add(this.despeckleCheckBox);
            this.ocrPreprocessingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ocrPreprocessingGroupBox.Location = new System.Drawing.Point(587, 278);
            this.ocrPreprocessingGroupBox.Name = "ocrPreprocessingGroupBox";
            this.ocrPreprocessingGroupBox.Size = new System.Drawing.Size(185, 199);
            this.ocrPreprocessingGroupBox.TabIndex = 4;
            this.ocrPreprocessingGroupBox.TabStop = false;
            // 
            // halftoneRemovalCheckBox
            // 
            this.halftoneRemovalCheckBox.AutoSize = true;
            this.halftoneRemovalCheckBox.Checked = true;
            this.halftoneRemovalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.halftoneRemovalCheckBox.Location = new System.Drawing.Point(8, 34);
            this.halftoneRemovalCheckBox.Name = "halftoneRemovalCheckBox";
            this.halftoneRemovalCheckBox.Size = new System.Drawing.Size(111, 17);
            this.halftoneRemovalCheckBox.TabIndex = 13;
            this.halftoneRemovalCheckBox.Text = "Halftone Removal";
            this.halftoneRemovalCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoOrientationCheckBox
            // 
            this.autoOrientationCheckBox.AutoSize = true;
            this.autoOrientationCheckBox.Location = new System.Drawing.Point(8, 114);
            this.autoOrientationCheckBox.Name = "autoOrientationCheckBox";
            this.autoOrientationCheckBox.Size = new System.Drawing.Size(99, 17);
            this.autoOrientationCheckBox.TabIndex = 12;
            this.autoOrientationCheckBox.Text = "Auto Orienation";
            this.autoOrientationCheckBox.UseVisualStyleBackColor = true;
            // 
            // holePunchRemovalCheckBox
            // 
            this.holePunchRemovalCheckBox.AutoSize = true;
            this.holePunchRemovalCheckBox.Checked = true;
            this.holePunchRemovalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.holePunchRemovalCheckBox.Location = new System.Drawing.Point(8, 66);
            this.holePunchRemovalCheckBox.Name = "holePunchRemovalCheckBox";
            this.holePunchRemovalCheckBox.Size = new System.Drawing.Size(127, 17);
            this.holePunchRemovalCheckBox.TabIndex = 11;
            this.holePunchRemovalCheckBox.Text = "Hole Punch Removal";
            this.holePunchRemovalCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoInvertCheckBox
            // 
            this.autoInvertCheckBox.AutoSize = true;
            this.autoInvertCheckBox.Checked = true;
            this.autoInvertCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoInvertCheckBox.Location = new System.Drawing.Point(8, 18);
            this.autoInvertCheckBox.Name = "autoInvertCheckBox";
            this.autoInvertCheckBox.Size = new System.Drawing.Size(78, 17);
            this.autoInvertCheckBox.TabIndex = 10;
            this.autoInvertCheckBox.Text = "Auto Invert";
            this.autoInvertCheckBox.UseVisualStyleBackColor = true;
            // 
            // segmentationCheckBox
            // 
            this.segmentationCheckBox.AutoSize = true;
            this.segmentationCheckBox.Location = new System.Drawing.Point(8, 130);
            this.segmentationCheckBox.Name = "segmentationCheckBox";
            this.segmentationCheckBox.Size = new System.Drawing.Size(91, 17);
            this.segmentationCheckBox.TabIndex = 9;
            this.segmentationCheckBox.Text = "Segmentation";
            this.segmentationCheckBox.UseVisualStyleBackColor = true;
            // 
            // allImagesProgressBar
            // 
            this.allImagesProgressBar.Location = new System.Drawing.Point(7, 172);
            this.allImagesProgressBar.Name = "allImagesProgressBar";
            this.allImagesProgressBar.Size = new System.Drawing.Size(171, 17);
            this.allImagesProgressBar.TabIndex = 8;
            // 
            // currentImageProgressBar
            // 
            this.currentImageProgressBar.Location = new System.Drawing.Point(7, 152);
            this.currentImageProgressBar.Name = "currentImageProgressBar";
            this.currentImageProgressBar.Size = new System.Drawing.Size(171, 17);
            this.currentImageProgressBar.TabIndex = 7;
            // 
            // deskewChekBox
            // 
            this.deskewChekBox.AutoSize = true;
            this.deskewChekBox.Checked = true;
            this.deskewChekBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deskewChekBox.Location = new System.Drawing.Point(8, 98);
            this.deskewChekBox.Name = "deskewChekBox";
            this.deskewChekBox.Size = new System.Drawing.Size(65, 17);
            this.deskewChekBox.TabIndex = 3;
            this.deskewChekBox.Text = "Deskew";
            this.deskewChekBox.UseVisualStyleBackColor = true;
            // 
            // clearBorderCheckBox
            // 
            this.clearBorderCheckBox.AutoSize = true;
            this.clearBorderCheckBox.Checked = true;
            this.clearBorderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearBorderCheckBox.Location = new System.Drawing.Point(8, 50);
            this.clearBorderCheckBox.Name = "clearBorderCheckBox";
            this.clearBorderCheckBox.Size = new System.Drawing.Size(84, 17);
            this.clearBorderCheckBox.TabIndex = 2;
            this.clearBorderCheckBox.Text = "Clear Border";
            this.clearBorderCheckBox.UseVisualStyleBackColor = true;
            // 
            // despeckleCheckBox
            // 
            this.despeckleCheckBox.AutoSize = true;
            this.despeckleCheckBox.Checked = true;
            this.despeckleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.despeckleCheckBox.Location = new System.Drawing.Point(8, 82);
            this.despeckleCheckBox.Name = "despeckleCheckBox";
            this.despeckleCheckBox.Size = new System.Drawing.Size(77, 17);
            this.despeckleCheckBox.TabIndex = 1;
            this.despeckleCheckBox.Text = "Despeckle";
            this.despeckleCheckBox.UseVisualStyleBackColor = true;
            // 
            // ocrPreprocessingCheckBox
            // 
            this.ocrPreprocessingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ocrPreprocessingCheckBox.AutoSize = true;
            this.ocrPreprocessingCheckBox.Checked = true;
            this.ocrPreprocessingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ocrPreprocessingCheckBox.Location = new System.Drawing.Point(595, 277);
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
            this.okButton.Location = new System.Drawing.Point(587, 486);
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
            this.buttonCancel.Location = new System.Drawing.Point(684, 486);
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
            this.processingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.processingGroupBox.Controls.Add(this.autoOrientationButton);
            this.processingGroupBox.Controls.Add(this.autoTextInvertButton);
            this.processingGroupBox.Controls.Add(this.removeTablesButton);
            this.processingGroupBox.Controls.Add(this.allImagesRadioButton);
            this.processingGroupBox.Controls.Add(this.currentImageRadioButton);
            this.processingGroupBox.Controls.Add(this.thresholdComboBox);
            this.processingGroupBox.Controls.Add(this.thresholdBinarizeButton);
            this.processingGroupBox.Controls.Add(this.globalBinarizeButton);
            this.processingGroupBox.Controls.Add(this.adaptiveBinarizeButton);
            this.processingGroupBox.Controls.Add(this.rotateAngleComboBox);
            this.processingGroupBox.Controls.Add(this.invertButton);
            this.processingGroupBox.Controls.Add(this.rotateButton);
            this.processingGroupBox.Location = new System.Drawing.Point(587, 5);
            this.processingGroupBox.Name = "processingGroupBox";
            this.processingGroupBox.Size = new System.Drawing.Size(185, 270);
            this.processingGroupBox.TabIndex = 8;
            this.processingGroupBox.TabStop = false;
            this.processingGroupBox.Text = "Processing";
            // 
            // autoOrientationButton
            // 
            this.autoOrientationButton.Location = new System.Drawing.Point(8, 238);
            this.autoOrientationButton.Name = "autoOrientationButton";
            this.autoOrientationButton.Size = new System.Drawing.Size(169, 23);
            this.autoOrientationButton.TabIndex = 11;
            this.autoOrientationButton.Text = "Auto Orientation";
            this.autoOrientationButton.UseVisualStyleBackColor = true;
            this.autoOrientationButton.Click += new System.EventHandler(this.autoOrientationButton_Click);
            // 
            // autoTextInvertButton
            // 
            this.autoTextInvertButton.Location = new System.Drawing.Point(8, 213);
            this.autoTextInvertButton.Name = "autoTextInvertButton";
            this.autoTextInvertButton.Size = new System.Drawing.Size(169, 23);
            this.autoTextInvertButton.TabIndex = 10;
            this.autoTextInvertButton.Text = "Auto Text Invert";
            this.autoTextInvertButton.UseVisualStyleBackColor = true;
            this.autoTextInvertButton.Click += new System.EventHandler(this.autoTextInvertButton_Click);
            // 
            // removeTablesButton
            // 
            this.removeTablesButton.Location = new System.Drawing.Point(8, 188);
            this.removeTablesButton.Name = "removeTablesButton";
            this.removeTablesButton.Size = new System.Drawing.Size(169, 23);
            this.removeTablesButton.TabIndex = 9;
            this.removeTablesButton.Text = "Remove Tables";
            this.removeTablesButton.UseVisualStyleBackColor = true;
            this.removeTablesButton.Click += new System.EventHandler(this.removeTablesButton_Click);
            // 
            // allImagesRadioButton
            // 
            this.allImagesRadioButton.AutoSize = true;
            this.allImagesRadioButton.Location = new System.Drawing.Point(106, 20);
            this.allImagesRadioButton.Name = "allImagesRadioButton";
            this.allImagesRadioButton.Size = new System.Drawing.Size(73, 17);
            this.allImagesRadioButton.TabIndex = 8;
            this.allImagesRadioButton.Text = "All Images";
            this.allImagesRadioButton.UseVisualStyleBackColor = true;
            // 
            // currentImageRadioButton
            // 
            this.currentImageRadioButton.AutoSize = true;
            this.currentImageRadioButton.Checked = true;
            this.currentImageRadioButton.Location = new System.Drawing.Point(7, 20);
            this.currentImageRadioButton.Name = "currentImageRadioButton";
            this.currentImageRadioButton.Size = new System.Drawing.Size(91, 17);
            this.currentImageRadioButton.TabIndex = 7;
            this.currentImageRadioButton.TabStop = true;
            this.currentImageRadioButton.Text = "Current Image";
            this.currentImageRadioButton.UseVisualStyleBackColor = true;
            // 
            // thresholdComboBox
            // 
            this.thresholdComboBox.FormattingEnabled = true;
            this.thresholdComboBox.Items.AddRange(new object[] {
            "250",
            "384",
            "500"});
            this.thresholdComboBox.Location = new System.Drawing.Point(124, 157);
            this.thresholdComboBox.Name = "thresholdComboBox";
            this.thresholdComboBox.Size = new System.Drawing.Size(53, 21);
            this.thresholdComboBox.TabIndex = 6;
            this.thresholdComboBox.Text = "384";
            // 
            // thresholdBinarizeButton
            // 
            this.thresholdBinarizeButton.Location = new System.Drawing.Point(8, 156);
            this.thresholdBinarizeButton.Name = "thresholdBinarizeButton";
            this.thresholdBinarizeButton.Size = new System.Drawing.Size(112, 23);
            this.thresholdBinarizeButton.TabIndex = 5;
            this.thresholdBinarizeButton.Text = "Threshold Binarize";
            this.thresholdBinarizeButton.UseVisualStyleBackColor = true;
            this.thresholdBinarizeButton.Click += new System.EventHandler(this.thresholdBinarizeButton_Click);
            // 
            // globalBinarizeButton
            // 
            this.globalBinarizeButton.Location = new System.Drawing.Point(8, 129);
            this.globalBinarizeButton.Name = "globalBinarizeButton";
            this.globalBinarizeButton.Size = new System.Drawing.Size(112, 23);
            this.globalBinarizeButton.TabIndex = 4;
            this.globalBinarizeButton.Text = "Global Binarize";
            this.globalBinarizeButton.UseVisualStyleBackColor = true;
            this.globalBinarizeButton.Click += new System.EventHandler(this.globalBinarizeButton_Click);
            // 
            // adaptiveBinarizeButton
            // 
            this.adaptiveBinarizeButton.Location = new System.Drawing.Point(8, 102);
            this.adaptiveBinarizeButton.Name = "adaptiveBinarizeButton";
            this.adaptiveBinarizeButton.Size = new System.Drawing.Size(112, 23);
            this.adaptiveBinarizeButton.TabIndex = 3;
            this.adaptiveBinarizeButton.Text = "Adaptive Binarize";
            this.adaptiveBinarizeButton.UseVisualStyleBackColor = true;
            this.adaptiveBinarizeButton.Click += new System.EventHandler(this.adaptiveBinarizeButton_Click);
            // 
            // rotateAngleComboBox
            // 
            this.rotateAngleComboBox.FormattingEnabled = true;
            this.rotateAngleComboBox.Items.AddRange(new object[] {
            "90",
            "180",
            "270"});
            this.rotateAngleComboBox.Location = new System.Drawing.Point(124, 49);
            this.rotateAngleComboBox.Name = "rotateAngleComboBox";
            this.rotateAngleComboBox.Size = new System.Drawing.Size(53, 21);
            this.rotateAngleComboBox.TabIndex = 2;
            this.rotateAngleComboBox.Text = "90";
            // 
            // invertButton
            // 
            this.invertButton.Location = new System.Drawing.Point(7, 75);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(113, 23);
            this.invertButton.TabIndex = 1;
            this.invertButton.Text = "Invert";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(7, 48);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(113, 23);
            this.rotateButton.TabIndex = 0;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // imageViewer1
            // 
            this.imageViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageViewer1.AutoScroll = true;
            this.imageViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer1.Location = new System.Drawing.Point(203, 12);
            this.imageViewer1.MasterViewer = this.thumbnailViewer1;
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.Size = new System.Drawing.Size(378, 465);
            this.imageViewer1.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.imageViewer1.TabIndex = 5;
            this.imageViewer1.Text = "imageViewer1";
            // 
            // thumbnailViewer1
            // 
            this.thumbnailViewer1.AllowDrop = true;
            this.thumbnailViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.thumbnailViewer1.AutoScroll = true;
            this.thumbnailViewer1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.thumbnailViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.thumbnailViewer1.Location = new System.Drawing.Point(12, 73);
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
            this.thumbnailViewer1.Size = new System.Drawing.Size(185, 404);
            this.thumbnailViewer1.TabIndex = 2;
            this.thumbnailViewer1.Text = "thumbnailViewer1";
            thumbnailAppearance5.BackColor = System.Drawing.Color.Transparent;
            thumbnailAppearance5.BorderColor = System.Drawing.Color.Transparent;
            thumbnailAppearance5.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance5.BorderWidth = 1;
            this.thumbnailViewer1.ThumbnailAppearance = thumbnailAppearance5;
            this.thumbnailViewer1.ThumbnailMargin = new System.Windows.Forms.Padding(3);
            this.thumbnailViewer1.ThumbnailSize = new System.Drawing.Size(100, 100);
            this.thumbnailViewer1.ThumbnailAdded += new System.EventHandler<Vintasoft.Imaging.UI.ThumbnailEventArgs>(this.thumbnailViewer1_ThumbnailAdded);
            this.thumbnailViewer1.ThumbnailRemoved += new System.EventHandler<Vintasoft.Imaging.UI.ThumbnailEventArgs>(this.thumbnailViewer1_ThumbnailRemoved);
            // 
            // AddImagesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(784, 518);
            this.Controls.Add(this.ocrPreprocessingCheckBox);
            this.Controls.Add(this.processingGroupBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.imageViewer1);
            this.Controls.Add(this.ocrPreprocessingGroupBox);
            this.Controls.Add(this.thumbnailViewer1);
            this.Controls.Add(this.addFromScannerButton);
            this.Controls.Add(this.addFromFileButton);
            this.MinimizeBox = false;
            this.Name = "AddImagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Images";
            this.Shown += new System.EventHandler(this.AddImagesForm_Shown);
            this.ocrPreprocessingGroupBox.ResumeLayout(false);
            this.ocrPreprocessingGroupBox.PerformLayout();
            this.processingGroupBox.ResumeLayout(false);
            this.processingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}