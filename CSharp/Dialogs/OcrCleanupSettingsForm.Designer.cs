
namespace OcrDemo
{
    partial class OcrCleanupSettingsForm
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
            this.lineMinConfidenceValueEditorControl = new DemosCommonCode.CustomControls.ValueEditorControl();
            this.wordMinConfidenceValueEditorControl = new DemosCommonCode.CustomControls.ValueEditorControl();
            this.symbolMinConfidenceValueEditorControl = new DemosCommonCode.CustomControls.ValueEditorControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cleanupOcrPageBeforeProcessingCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineMinConfidenceValueEditorControl
            // 
            this.lineMinConfidenceValueEditorControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineMinConfidenceValueEditorControl.Location = new System.Drawing.Point(3, 3);
            this.lineMinConfidenceValueEditorControl.Name = "lineMinConfidenceValueEditorControl";
            this.lineMinConfidenceValueEditorControl.Size = new System.Drawing.Size(515, 76);
            this.lineMinConfidenceValueEditorControl.TabIndex = 0;
            this.lineMinConfidenceValueEditorControl.ValueName = "Line Minimum Confidence";
            this.lineMinConfidenceValueEditorControl.ValueUnitOfMeasure = "";
            // 
            // wordMinConfidenceValueEditorControl
            // 
            this.wordMinConfidenceValueEditorControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordMinConfidenceValueEditorControl.Location = new System.Drawing.Point(3, 85);
            this.wordMinConfidenceValueEditorControl.Name = "wordMinConfidenceValueEditorControl";
            this.wordMinConfidenceValueEditorControl.Size = new System.Drawing.Size(515, 76);
            this.wordMinConfidenceValueEditorControl.TabIndex = 1;
            this.wordMinConfidenceValueEditorControl.ValueName = "Word Minimum Confidence";
            this.wordMinConfidenceValueEditorControl.ValueUnitOfMeasure = "";
            // 
            // symbolMinConfidenceValueEditorControl
            // 
            this.symbolMinConfidenceValueEditorControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolMinConfidenceValueEditorControl.Location = new System.Drawing.Point(3, 167);
            this.symbolMinConfidenceValueEditorControl.Name = "symbolMinConfidenceValueEditorControl";
            this.symbolMinConfidenceValueEditorControl.Size = new System.Drawing.Size(515, 76);
            this.symbolMinConfidenceValueEditorControl.TabIndex = 2;
            this.symbolMinConfidenceValueEditorControl.ValueName = "Symbol Minimum Confidence";
            this.symbolMinConfidenceValueEditorControl.ValueUnitOfMeasure = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Location = new System.Drawing.Point(357, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 32);
            this.panel1.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(3, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(84, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.lineMinConfidenceValueEditorControl);
            this.mainPanel.Controls.Add(this.wordMinConfidenceValueEditorControl);
            this.mainPanel.Controls.Add(this.symbolMinConfidenceValueEditorControl);
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(521, 244);
            this.mainPanel.TabIndex = 5;
            // 
            // cleanupOcrPageBeforeProcessingCheckBox
            // 
            this.cleanupOcrPageBeforeProcessingCheckBox.AutoSize = true;
            this.cleanupOcrPageBeforeProcessingCheckBox.Location = new System.Drawing.Point(12, 12);
            this.cleanupOcrPageBeforeProcessingCheckBox.Name = "cleanupOcrPageBeforeProcessingCheckBox";
            this.cleanupOcrPageBeforeProcessingCheckBox.Size = new System.Drawing.Size(206, 17);
            this.cleanupOcrPageBeforeProcessingCheckBox.TabIndex = 6;
            this.cleanupOcrPageBeforeProcessingCheckBox.Text = "Cleanup OCR Page before processing";
            this.cleanupOcrPageBeforeProcessingCheckBox.UseVisualStyleBackColor = true;
            this.cleanupOcrPageBeforeProcessingCheckBox.CheckedChanged += new System.EventHandler(this.cleanupOcrPageBeforeProcessingCheckBox_CheckedChanged);
            // 
            // OcrCleanupSettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 319);
            this.Controls.Add(this.cleanupOcrPageBeforeProcessingCheckBox);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OcrCleanupSettingsForm";
            this.Text = "Cleanup Settings";
            this.panel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DemosCommonCode.CustomControls.ValueEditorControl lineMinConfidenceValueEditorControl;
        private DemosCommonCode.CustomControls.ValueEditorControl wordMinConfidenceValueEditorControl;
        private DemosCommonCode.CustomControls.ValueEditorControl symbolMinConfidenceValueEditorControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.CheckBox cleanupOcrPageBeforeProcessingCheckBox;
    }
}