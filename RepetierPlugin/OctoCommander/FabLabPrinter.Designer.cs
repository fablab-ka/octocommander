namespace OctoCommander
{
    partial class FabLabPrinter
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.printerSelectionBox = new System.Windows.Forms.ComboBox();
            this.openOctoPrintButton = new System.Windows.Forms.Button();
            this.printerControlBox = new System.Windows.Forms.GroupBox();
            this.pausedText = new System.Windows.Forms.Label();
            this.printingText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.printerStateLabel = new System.Windows.Forms.Label();
            this.printerStateLabelLabel = new System.Windows.Forms.Label();
            this.printerLabel = new System.Windows.Forms.Label();
            this.temperaturesBox = new System.Windows.Forms.GroupBox();
            this.extruderTempText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bedTempText = new System.Windows.Forms.Label();
            this.bedLabel = new System.Windows.Forms.Label();
            this.jobBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressText = new System.Windows.Forms.Label();
            this.jobProgressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jobFilename = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.printBox = new System.Windows.Forms.GroupBox();
            this.printButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.printerControlBox.SuspendLayout();
            this.temperaturesBox.SuspendLayout();
            this.jobBox.SuspendLayout();
            this.printBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // printerSelectionBox
            // 
            this.printerSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printerSelectionBox.DisplayMember = "Address";
            this.printerSelectionBox.FormattingEnabled = true;
            this.printerSelectionBox.Location = new System.Drawing.Point(49, 10);
            this.printerSelectionBox.Name = "printerSelectionBox";
            this.printerSelectionBox.Size = new System.Drawing.Size(186, 21);
            this.printerSelectionBox.TabIndex = 0;
            // 
            // openOctoPrintButton
            // 
            this.openOctoPrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openOctoPrintButton.Location = new System.Drawing.Point(322, 10);
            this.openOctoPrintButton.Name = "openOctoPrintButton";
            this.openOctoPrintButton.Size = new System.Drawing.Size(75, 23);
            this.openOctoPrintButton.TabIndex = 1;
            this.openOctoPrintButton.Text = "Octoprint";
            this.openOctoPrintButton.UseVisualStyleBackColor = true;
            this.openOctoPrintButton.Click += new System.EventHandler(this.openOctoPrintButton_Click);
            // 
            // printerControlBox
            // 
            this.printerControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printerControlBox.Controls.Add(this.pausedText);
            this.printerControlBox.Controls.Add(this.printingText);
            this.printerControlBox.Controls.Add(this.label1);
            this.printerControlBox.Controls.Add(this.label2);
            this.printerControlBox.Controls.Add(this.errorText);
            this.printerControlBox.Controls.Add(this.errorLabel);
            this.printerControlBox.Controls.Add(this.printerStateLabel);
            this.printerControlBox.Controls.Add(this.printerStateLabelLabel);
            this.printerControlBox.Enabled = false;
            this.printerControlBox.Location = new System.Drawing.Point(6, 37);
            this.printerControlBox.Name = "printerControlBox";
            this.printerControlBox.Size = new System.Drawing.Size(388, 78);
            this.printerControlBox.TabIndex = 2;
            this.printerControlBox.TabStop = false;
            this.printerControlBox.Text = "State";
            // 
            // pausedText
            // 
            this.pausedText.AutoSize = true;
            this.pausedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausedText.Location = new System.Drawing.Point(58, 48);
            this.pausedText.Name = "pausedText";
            this.pausedText.Size = new System.Drawing.Size(53, 13);
            this.pausedText.TabIndex = 8;
            this.pausedText.Text = "Unkown";
            // 
            // printingText
            // 
            this.printingText.AutoSize = true;
            this.printingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingText.Location = new System.Drawing.Point(180, 48);
            this.printingText.Name = "printingText";
            this.printingText.Size = new System.Drawing.Size(53, 13);
            this.printingText.TabIndex = 7;
            this.printingText.Text = "Unkown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Printing:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paused:";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.Location = new System.Drawing.Point(63, 35);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 13);
            this.errorText.TabIndex = 4;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(7, 34);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(32, 13);
            this.errorLabel.TabIndex = 2;
            this.errorLabel.Text = "Error:";
            // 
            // printerStateLabel
            // 
            this.printerStateLabel.AutoSize = true;
            this.printerStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerStateLabel.Location = new System.Drawing.Point(58, 20);
            this.printerStateLabel.Name = "printerStateLabel";
            this.printerStateLabel.Size = new System.Drawing.Size(53, 13);
            this.printerStateLabel.TabIndex = 1;
            this.printerStateLabel.Text = "Unkown";
            // 
            // printerStateLabelLabel
            // 
            this.printerStateLabelLabel.AutoSize = true;
            this.printerStateLabelLabel.Location = new System.Drawing.Point(7, 20);
            this.printerStateLabelLabel.Name = "printerStateLabelLabel";
            this.printerStateLabelLabel.Size = new System.Drawing.Size(35, 13);
            this.printerStateLabelLabel.TabIndex = 0;
            this.printerStateLabelLabel.Text = "State:";
            // 
            // printerLabel
            // 
            this.printerLabel.AutoSize = true;
            this.printerLabel.Location = new System.Drawing.Point(3, 13);
            this.printerLabel.Name = "printerLabel";
            this.printerLabel.Size = new System.Drawing.Size(40, 13);
            this.printerLabel.TabIndex = 3;
            this.printerLabel.Text = "Printer:";
            // 
            // temperaturesBox
            // 
            this.temperaturesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temperaturesBox.Controls.Add(this.extruderTempText);
            this.temperaturesBox.Controls.Add(this.label6);
            this.temperaturesBox.Controls.Add(this.label7);
            this.temperaturesBox.Controls.Add(this.bedTempText);
            this.temperaturesBox.Controls.Add(this.bedLabel);
            this.temperaturesBox.Enabled = false;
            this.temperaturesBox.Location = new System.Drawing.Point(6, 121);
            this.temperaturesBox.Name = "temperaturesBox";
            this.temperaturesBox.Size = new System.Drawing.Size(388, 60);
            this.temperaturesBox.TabIndex = 9;
            this.temperaturesBox.TabStop = false;
            this.temperaturesBox.Text = "Temperatures";
            // 
            // extruderTempText
            // 
            this.extruderTempText.AutoSize = true;
            this.extruderTempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extruderTempText.Location = new System.Drawing.Point(63, 33);
            this.extruderTempText.Name = "extruderTempText";
            this.extruderTempText.Size = new System.Drawing.Size(51, 13);
            this.extruderTempText.TabIndex = 12;
            this.extruderTempText.Text = "?   /   ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Extruder:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 4;
            // 
            // bedTempText
            // 
            this.bedTempText.AutoSize = true;
            this.bedTempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedTempText.Location = new System.Drawing.Point(63, 20);
            this.bedTempText.Name = "bedTempText";
            this.bedTempText.Size = new System.Drawing.Size(51, 13);
            this.bedTempText.TabIndex = 1;
            this.bedTempText.Text = "?   /   ?";
            // 
            // bedLabel
            // 
            this.bedLabel.AutoSize = true;
            this.bedLabel.Location = new System.Drawing.Point(7, 20);
            this.bedLabel.Name = "bedLabel";
            this.bedLabel.Size = new System.Drawing.Size(29, 13);
            this.bedLabel.TabIndex = 0;
            this.bedLabel.Text = "Bed:";
            // 
            // jobBox
            // 
            this.jobBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobBox.Controls.Add(this.label3);
            this.jobBox.Controls.Add(this.progressText);
            this.jobBox.Controls.Add(this.jobProgressBar);
            this.jobBox.Controls.Add(this.label4);
            this.jobBox.Controls.Add(this.label5);
            this.jobBox.Controls.Add(this.jobFilename);
            this.jobBox.Controls.Add(this.label9);
            this.jobBox.Enabled = false;
            this.jobBox.Location = new System.Drawing.Point(6, 187);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(388, 81);
            this.jobBox.TabIndex = 13;
            this.jobBox.TabStop = false;
            this.jobBox.Text = "Job";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ETA:";
            // 
            // progressText
            // 
            this.progressText.AutoSize = true;
            this.progressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressText.Location = new System.Drawing.Point(63, 59);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(0, 13);
            this.progressText.TabIndex = 15;
            // 
            // jobProgressBar
            // 
            this.jobProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobProgressBar.Location = new System.Drawing.Point(66, 36);
            this.jobProgressBar.Name = "jobProgressBar";
            this.jobProgressBar.Size = new System.Drawing.Size(316, 20);
            this.jobProgressBar.Step = 1;
            this.jobProgressBar.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Progress:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // jobFilename
            // 
            this.jobFilename.AutoSize = true;
            this.jobFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobFilename.Location = new System.Drawing.Point(63, 20);
            this.jobFilename.Name = "jobFilename";
            this.jobFilename.Size = new System.Drawing.Size(11, 13);
            this.jobFilename.TabIndex = 1;
            this.jobFilename.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Filename:";
            // 
            // printBox
            // 
            this.printBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printBox.Controls.Add(this.printButton);
            this.printBox.Enabled = false;
            this.printBox.Location = new System.Drawing.Point(6, 434);
            this.printBox.Name = "printBox";
            this.printBox.Size = new System.Drawing.Size(388, 81);
            this.printBox.TabIndex = 17;
            this.printBox.TabStop = false;
            this.printBox.Text = "Print";
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Location = new System.Drawing.Point(244, 19);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(138, 56);
            this.printButton.TabIndex = 0;
            this.printButton.Text = "PRINT";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(241, 10);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 18;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // FabLabPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.printBox);
            this.Controls.Add(this.jobBox);
            this.Controls.Add(this.temperaturesBox);
            this.Controls.Add(this.printerLabel);
            this.Controls.Add(this.printerControlBox);
            this.Controls.Add(this.openOctoPrintButton);
            this.Controls.Add(this.printerSelectionBox);
            this.Name = "FabLabPrinter";
            this.Size = new System.Drawing.Size(400, 524);
            this.printerControlBox.ResumeLayout(false);
            this.printerControlBox.PerformLayout();
            this.temperaturesBox.ResumeLayout(false);
            this.temperaturesBox.PerformLayout();
            this.jobBox.ResumeLayout(false);
            this.jobBox.PerformLayout();
            this.printBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox printerSelectionBox;
        private System.Windows.Forms.Button openOctoPrintButton;
        private System.Windows.Forms.GroupBox printerControlBox;
        private System.Windows.Forms.Label printerLabel;
        private System.Windows.Forms.Label printerStateLabel;
        private System.Windows.Forms.Label printerStateLabelLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Label pausedText;
        private System.Windows.Forms.Label printingText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox temperaturesBox;
        private System.Windows.Forms.Label extruderTempText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bedTempText;
        private System.Windows.Forms.Label bedLabel;
        private System.Windows.Forms.GroupBox jobBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label jobFilename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label progressText;
        private System.Windows.Forms.ProgressBar jobProgressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox printBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button connectButton;

    }
}
