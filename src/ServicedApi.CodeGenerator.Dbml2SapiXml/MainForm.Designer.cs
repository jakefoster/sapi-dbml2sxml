namespace org.ncore.ServicedApi.CodeGenerator.Dbml2SapiXml
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
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._generateButton = new System.Windows.Forms.Button();
            this._dbmlFileNameTextBox = new System.Windows.Forms.TextBox();
            this._dbmlFileNameLabel = new System.Windows.Forms.Label();
            this._openFileDialogButton = new System.Windows.Forms.Button();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._outputFileNameTextBox = new System.Windows.Forms.TextBox();
            this._outputFileLabel = new System.Windows.Forms.Label();
            this._saveFileDialogButton = new System.Windows.Forms.Button();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this._apiNamespaceLabel = new System.Windows.Forms.Label();
            this._apiNamespaceTextBox = new System.Windows.Forms.TextBox();
            this._traceDisplayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _generateButton
            // 
            this._generateButton.Location = new System.Drawing.Point(74, 66);
            this._generateButton.Name = "_generateButton";
            this._generateButton.Size = new System.Drawing.Size(60, 23);
            this._generateButton.TabIndex = 1;
            this._generateButton.Text = "Generate";
            this._generateButton.UseVisualStyleBackColor = true;
            this._generateButton.Click += new System.EventHandler(this._generateButton_Click);
            // 
            // _dbmlFileNameTextBox
            // 
            this._dbmlFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dbmlFileNameTextBox.Location = new System.Drawing.Point(74, 13);
            this._dbmlFileNameTextBox.Name = "_dbmlFileNameTextBox";
            this._dbmlFileNameTextBox.Size = new System.Drawing.Size(762, 20);
            this._dbmlFileNameTextBox.TabIndex = 2;
            // 
            // _dbmlFileNameLabel
            // 
            this._dbmlFileNameLabel.AutoSize = true;
            this._dbmlFileNameLabel.Location = new System.Drawing.Point(12, 16);
            this._dbmlFileNameLabel.Name = "_dbmlFileNameLabel";
            this._dbmlFileNameLabel.Size = new System.Drawing.Size(59, 13);
            this._dbmlFileNameLabel.TabIndex = 3;
            this._dbmlFileNameLabel.Text = "DBML File:";
            // 
            // _openFileDialogButton
            // 
            this._openFileDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._openFileDialogButton.Location = new System.Drawing.Point(842, 12);
            this._openFileDialogButton.Name = "_openFileDialogButton";
            this._openFileDialogButton.Size = new System.Drawing.Size(31, 20);
            this._openFileDialogButton.TabIndex = 4;
            this._openFileDialogButton.Text = "...";
            this._openFileDialogButton.UseVisualStyleBackColor = true;
            this._openFileDialogButton.Click += new System.EventHandler(this._openFileDialogButton_Click);
            // 
            // _openFileDialog
            // 
            this._openFileDialog.FileName = "openFileDialog1";
            this._openFileDialog.Filter = "DBML Files|*.dbml";
            this._openFileDialog.Title = "Select DBML File to Open";
            this._openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this._openFileDialog_FileOk);
            // 
            // _outputFileNameTextBox
            // 
            this._outputFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outputFileNameTextBox.Location = new System.Drawing.Point(74, 40);
            this._outputFileNameTextBox.Name = "_outputFileNameTextBox";
            this._outputFileNameTextBox.Size = new System.Drawing.Size(762, 20);
            this._outputFileNameTextBox.TabIndex = 5;
            // 
            // _outputFileLabel
            // 
            this._outputFileLabel.AutoSize = true;
            this._outputFileLabel.Location = new System.Drawing.Point(12, 43);
            this._outputFileLabel.Name = "_outputFileLabel";
            this._outputFileLabel.Size = new System.Drawing.Size(61, 13);
            this._outputFileLabel.TabIndex = 6;
            this._outputFileLabel.Text = "Output File:";
            // 
            // _saveFileDialogButton
            // 
            this._saveFileDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._saveFileDialogButton.Location = new System.Drawing.Point(842, 40);
            this._saveFileDialogButton.Name = "_saveFileDialogButton";
            this._saveFileDialogButton.Size = new System.Drawing.Size(31, 20);
            this._saveFileDialogButton.TabIndex = 7;
            this._saveFileDialogButton.Text = "...";
            this._saveFileDialogButton.UseVisualStyleBackColor = true;
            this._saveFileDialogButton.Click += new System.EventHandler(this._saveFileDialogButton_Click);
            // 
            // _saveFileDialog
            // 
            this._saveFileDialog.Title = "Save Output File To";
            this._saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this._saveFileDialog_FileOk);
            // 
            // _apiNamespaceLabel
            // 
            this._apiNamespaceLabel.AutoSize = true;
            this._apiNamespaceLabel.Location = new System.Drawing.Point(146, 71);
            this._apiNamespaceLabel.Name = "_apiNamespaceLabel";
            this._apiNamespaceLabel.Size = new System.Drawing.Size(87, 13);
            this._apiNamespaceLabel.TabIndex = 9;
            this._apiNamespaceLabel.Text = "API Namespace:";
            // 
            // _apiNamespaceTextBox
            // 
            this._apiNamespaceTextBox.Location = new System.Drawing.Point(235, 67);
            this._apiNamespaceTextBox.Name = "_apiNamespaceTextBox";
            this._apiNamespaceTextBox.Size = new System.Drawing.Size(601, 20);
            this._apiNamespaceTextBox.TabIndex = 10;
            // 
            // _traceDisplayRichTextBox
            // 
            this._traceDisplayRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._traceDisplayRichTextBox.Location = new System.Drawing.Point(15, 104);
            this._traceDisplayRichTextBox.Name = "_traceDisplayRichTextBox";
            this._traceDisplayRichTextBox.Size = new System.Drawing.Size(856, 368);
            this._traceDisplayRichTextBox.TabIndex = 11;
            this._traceDisplayRichTextBox.Text = "";
            this._traceDisplayRichTextBox.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 484);
            this.Controls.Add(this._traceDisplayRichTextBox);
            this.Controls.Add(this._apiNamespaceTextBox);
            this.Controls.Add(this._apiNamespaceLabel);
            this.Controls.Add(this._saveFileDialogButton);
            this.Controls.Add(this._outputFileLabel);
            this.Controls.Add(this._outputFileNameTextBox);
            this.Controls.Add(this._openFileDialogButton);
            this.Controls.Add(this._dbmlFileNameLabel);
            this.Controls.Add(this._dbmlFileNameTextBox);
            this.Controls.Add(this._generateButton);
            this.Name = "MainForm";
            this.Text = "Dbml2SapiXml";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _generateButton;
        private System.Windows.Forms.TextBox _dbmlFileNameTextBox;
        private System.Windows.Forms.Label _dbmlFileNameLabel;
        private System.Windows.Forms.Button _openFileDialogButton;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.TextBox _outputFileNameTextBox;
        private System.Windows.Forms.Label _outputFileLabel;
        private System.Windows.Forms.Button _saveFileDialogButton;
        private System.Windows.Forms.SaveFileDialog _saveFileDialog;
        private System.Windows.Forms.Label _apiNamespaceLabel;
        private System.Windows.Forms.TextBox _apiNamespaceTextBox;
        private System.Windows.Forms.RichTextBox _traceDisplayRichTextBox;
    }
}

