namespace MyLibrary
{
    partial class mainForm
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.librarySizeLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.subGenreComboBox = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.subGenreLabel = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.debugMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 156);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(359, 39);
            this.searchTextBox.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeLabel.Font = new System.Drawing.Font("Victorian LET", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(16, 42);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(422, 53);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to MyLibrary";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.searchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(12, 121);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(180, 31);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search for a book";
            // 
            // librarySizeLabel
            // 
            this.librarySizeLabel.AutoSize = true;
            this.librarySizeLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.librarySizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.librarySizeLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librarySizeLabel.Location = new System.Drawing.Point(449, 54);
            this.librarySizeLabel.Name = "librarySizeLabel";
            this.librarySizeLabel.Size = new System.Drawing.Size(320, 31);
            this.librarySizeLabel.TabIndex = 3;
            this.librarySizeLabel.Text = "You have 0 books in your library";
            // 
            // genreComboBox
            // 
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Any",
            "Fiction",
            "Non-Fiction"});
            this.genreComboBox.Location = new System.Drawing.Point(145, 200);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(226, 37);
            this.genreComboBox.TabIndex = 4;
            // 
            // subGenreComboBox
            // 
            this.subGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subGenreComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGenreComboBox.FormattingEnabled = true;
            this.subGenreComboBox.Items.AddRange(new object[] {
            "Any",
            "Mystery",
            "Romance",
            "Comedy",
            "Fantasy"});
            this.subGenreComboBox.Location = new System.Drawing.Point(145, 243);
            this.subGenreComboBox.Name = "subGenreComboBox";
            this.subGenreComboBox.Size = new System.Drawing.Size(226, 37);
            this.subGenreComboBox.TabIndex = 5;
            // 
            // genreLabel
            // 
            this.genreLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.genreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(12, 203);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(125, 31);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subGenreLabel
            // 
            this.subGenreLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.subGenreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subGenreLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGenreLabel.Location = new System.Drawing.Point(12, 246);
            this.subGenreLabel.Name = "subGenreLabel";
            this.subGenreLabel.Size = new System.Drawing.Size(125, 31);
            this.subGenreLabel.TabIndex = 7;
            this.subGenreLabel.Text = "Sub-Genre:";
            this.subGenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsListBox
            // 
            this.resultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsListBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.IntegralHeight = false;
            this.resultsListBox.ItemHeight = 29;
            this.resultsListBox.Location = new System.Drawing.Point(449, 106);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(670, 439);
            this.resultsListBox.TabIndex = 8;
            // 
            // authorComboBox
            // 
            this.authorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorComboBox.FormattingEnabled = true;
            this.authorComboBox.Items.AddRange(new object[] {
            "Any"});
            this.authorComboBox.Location = new System.Drawing.Point(145, 286);
            this.authorComboBox.Name = "authorComboBox";
            this.authorComboBox.Size = new System.Drawing.Size(226, 37);
            this.authorComboBox.TabIndex = 9;
            // 
            // authorLabel
            // 
            this.authorLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.authorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(12, 289);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(125, 31);
            this.authorLabel.TabIndex = 10;
            this.authorLabel.Text = "Author:";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // debugMenuItem
            // 
            this.debugMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.debugMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogMenuItem});
            this.debugMenuItem.Name = "debugMenuItem";
            this.debugMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugMenuItem.Text = "Debug";
            // 
            // openLogMenuItem
            // 
            this.openLogMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.openLogMenuItem.Name = "openLogMenuItem";
            this.openLogMenuItem.Size = new System.Drawing.Size(126, 22);
            this.openLogMenuItem.Text = "Open Log";
            this.openLogMenuItem.Click += new System.EventHandler(this.openLogMenuItem_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(268, 329);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 39);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrary.Properties.Resources.bookshelf1;
            this.ClientSize = new System.Drawing.Size(1148, 579);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.authorComboBox);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.subGenreLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.subGenreComboBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.librarySizeLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Victorian LET", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLibrary";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label librarySizeLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox subGenreComboBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label subGenreLabel;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.ComboBox authorComboBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem debugMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogMenuItem;
        private System.Windows.Forms.Button searchButton;
    }
}

