namespace MyLibrary
{
    partial class editBookForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.displayComboBox = new System.Windows.Forms.ComboBox();
            this.tbrComboBox = new System.Windows.Forms.ComboBox();
            this.spicinessComboBox = new System.Windows.Forms.ComboBox();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.subGenreTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.subGenreLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.tbrLabel = new System.Windows.Forms.Label();
            this.spicinessLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myLibrary1DataSet = new MyLibrary.MyLibrary1DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.myLibrary1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.BackColor = System.Drawing.Color.Linen;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(418, 608);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 41);
            this.cancelButton.TabIndex = 55;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.BackColor = System.Drawing.Color.Linen;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.updateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(276, 608);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(136, 41);
            this.updateButton.TabIndex = 54;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // displayComboBox
            // 
            this.displayComboBox.BackColor = System.Drawing.Color.Linen;
            this.displayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayComboBox.FormattingEnabled = true;
            this.displayComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.displayComboBox.Location = new System.Drawing.Point(170, 498);
            this.displayComboBox.Name = "displayComboBox";
            this.displayComboBox.Size = new System.Drawing.Size(384, 37);
            this.displayComboBox.TabIndex = 52;
            this.displayComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // tbrComboBox
            // 
            this.tbrComboBox.BackColor = System.Drawing.Color.Linen;
            this.tbrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbrComboBox.FormattingEnabled = true;
            this.tbrComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.tbrComboBox.Location = new System.Drawing.Point(170, 548);
            this.tbrComboBox.Name = "tbrComboBox";
            this.tbrComboBox.Size = new System.Drawing.Size(384, 37);
            this.tbrComboBox.TabIndex = 53;
            this.tbrComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // spicinessComboBox
            // 
            this.spicinessComboBox.BackColor = System.Drawing.Color.Linen;
            this.spicinessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spicinessComboBox.FormattingEnabled = true;
            this.spicinessComboBox.Items.AddRange(new object[] {
            "♥",
            "♥♥",
            "♥♥♥",
            "♥♥♥♥",
            "♥♥♥♥♥"});
            this.spicinessComboBox.Location = new System.Drawing.Point(170, 447);
            this.spicinessComboBox.Name = "spicinessComboBox";
            this.spicinessComboBox.Size = new System.Drawing.Size(384, 37);
            this.spicinessComboBox.TabIndex = 51;
            this.spicinessComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.BackColor = System.Drawing.Color.Linen;
            this.ratingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★",
            "★★★★★"});
            this.ratingComboBox.Location = new System.Drawing.Point(170, 396);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(384, 37);
            this.ratingComboBox.TabIndex = 50;
            this.ratingComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // titleTextBox
            // 
            this.titleTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.titleTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.titleTextBox.BackColor = System.Drawing.Color.Linen;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.titleTextBox.Location = new System.Drawing.Point(170, 125);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(384, 32);
            this.titleTextBox.TabIndex = 44;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.BackColor = System.Drawing.Color.Linen;
            this.authorNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorNameTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.authorNameTextBox.Location = new System.Drawing.Point(170, 171);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(384, 32);
            this.authorNameTextBox.TabIndex = 45;
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.BackColor = System.Drawing.Color.Linen;
            this.seriesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seriesTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.seriesTextBox.Location = new System.Drawing.Point(170, 218);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(384, 32);
            this.seriesTextBox.TabIndex = 46;
            // 
            // subGenreTextBox
            // 
            this.subGenreTextBox.BackColor = System.Drawing.Color.Linen;
            this.subGenreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subGenreTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.subGenreTextBox.Location = new System.Drawing.Point(170, 308);
            this.subGenreTextBox.Name = "subGenreTextBox";
            this.subGenreTextBox.Size = new System.Drawing.Size(384, 32);
            this.subGenreTextBox.TabIndex = 48;
            // 
            // locationTextBox
            // 
            this.locationTextBox.BackColor = System.Drawing.Color.Linen;
            this.locationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.locationTextBox.Location = new System.Drawing.Point(170, 352);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(384, 32);
            this.locationTextBox.TabIndex = 49;
            // 
            // genreTextBox
            // 
            this.genreTextBox.BackColor = System.Drawing.Color.Linen;
            this.genreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.genreTextBox.Location = new System.Drawing.Point(170, 263);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(384, 32);
            this.genreTextBox.TabIndex = 47;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 125);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 31);
            this.titleLabel.TabIndex = 65;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.authorNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorNameLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorNameLabel.Location = new System.Drawing.Point(12, 172);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(152, 31);
            this.authorNameLabel.TabIndex = 64;
            this.authorNameLabel.Text = "Author Name:";
            this.authorNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seriesLabel
            // 
            this.seriesLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.seriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seriesLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesLabel.Location = new System.Drawing.Point(12, 218);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(152, 31);
            this.seriesLabel.TabIndex = 63;
            this.seriesLabel.Text = "Series Name:";
            this.seriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreLabel
            // 
            this.genreLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.genreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(12, 263);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(152, 31);
            this.genreLabel.TabIndex = 56;
            this.genreLabel.Text = "Genre: ";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subGenreLabel
            // 
            this.subGenreLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.subGenreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subGenreLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGenreLabel.Location = new System.Drawing.Point(12, 309);
            this.subGenreLabel.Name = "subGenreLabel";
            this.subGenreLabel.Size = new System.Drawing.Size(152, 31);
            this.subGenreLabel.TabIndex = 57;
            this.subGenreLabel.Text = "Sub Genres: ";
            this.subGenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ratingLabel
            // 
            this.ratingLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.ratingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratingLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(12, 401);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(152, 31);
            this.ratingLabel.TabIndex = 58;
            this.ratingLabel.Text = "Rating:";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbrLabel
            // 
            this.tbrLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.tbrLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbrLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrLabel.Location = new System.Drawing.Point(12, 553);
            this.tbrLabel.Name = "tbrLabel";
            this.tbrLabel.Size = new System.Drawing.Size(152, 31);
            this.tbrLabel.TabIndex = 62;
            this.tbrLabel.Text = "TBR:";
            this.tbrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spicinessLabel
            // 
            this.spicinessLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.spicinessLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spicinessLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spicinessLabel.Location = new System.Drawing.Point(12, 451);
            this.spicinessLabel.Name = "spicinessLabel";
            this.spicinessLabel.Size = new System.Drawing.Size(152, 31);
            this.spicinessLabel.TabIndex = 59;
            this.spicinessLabel.Text = "Spiciness:";
            this.spicinessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(12, 503);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(152, 31);
            this.displayLabel.TabIndex = 61;
            this.displayLabel.Text = "For Display?";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationLabel
            // 
            this.locationLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.locationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(12, 353);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(152, 31);
            this.locationLabel.TabIndex = 60;
            this.locationLabel.Text = "Location:";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Victorian LET", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 58);
            this.label1.TabIndex = 43;
            this.label1.Text = "Edit a book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myLibrary1DataSet
            // 
            this.myLibrary1DataSet.DataSetName = "MyLibrary1DataSet";
            this.myLibrary1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrary.Properties.Resources.bookshelfBlur;
            this.ClientSize = new System.Drawing.Size(566, 675);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.displayComboBox);
            this.Controls.Add(this.tbrComboBox);
            this.Controls.Add(this.spicinessComboBox);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.seriesTextBox);
            this.Controls.Add(this.subGenreTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.seriesLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.subGenreLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.tbrLabel);
            this.Controls.Add(this.spicinessLabel);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "editBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit a book";
            ((System.ComponentModel.ISupportInitialize)(this.myLibrary1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox displayComboBox;
        private System.Windows.Forms.ComboBox tbrComboBox;
        private System.Windows.Forms.ComboBox spicinessComboBox;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.TextBox subGenreTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label subGenreLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label tbrLabel;
        private System.Windows.Forms.Label spicinessLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label1;
        private MyLibrary1DataSet myLibrary1DataSet;
    }
}