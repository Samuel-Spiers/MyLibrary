namespace MyLibrary
{
    partial class debugForm
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
            this.logLabel = new System.Windows.Forms.Label();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.logLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logLabel.Font = new System.Drawing.Font("Victorian LET", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(13, 13);
            this.logLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(73, 39);
            this.logLabel.TabIndex = 0;
            this.logLabel.Text = "Log:";
            // 
            // logListBox
            // 
            this.logListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logListBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.logListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.logListBox.FormattingEnabled = true;
            this.logListBox.HorizontalScrollbar = true;
            this.logListBox.ItemHeight = 19;
            this.logListBox.Location = new System.Drawing.Point(13, 55);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(1042, 515);
            this.logListBox.TabIndex = 1;
            // 
            // debugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrary.Properties.Resources.bookshelf1;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.logLabel);
            this.Font = new System.Drawing.Font("Victorian LET", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "debugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DebugForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.ListBox logListBox;
    }
}