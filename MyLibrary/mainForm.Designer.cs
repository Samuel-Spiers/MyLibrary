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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.librarySizeLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.myLibrary1DataSet = new MyLibrary.MyLibrary1DataSet();
            this.subGenreComboBox = new System.Windows.Forms.ComboBox();
            this.genreFilterLabel = new System.Windows.Forms.Label();
            this.subGenreFilterLabel = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.debugMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.searchbyComboBox = new System.Windows.Forms.ComboBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortOrderComboBox = new System.Windows.Forms.ComboBox();
            this.ratingFilterLabel = new System.Windows.Forms.Label();
            this.locationFilterLabel = new System.Windows.Forms.Label();
            this.spicinessFilterLabel = new System.Windows.Forms.Label();
            this.displayFilterLabel = new System.Windows.Forms.Label();
            this.tbrFilterLabel = new System.Windows.Forms.Label();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.spicinessComboBox = new System.Windows.Forms.ComboBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.displayComboBox = new System.Windows.Forms.ComboBox();
            this.tbrComboBox = new System.Windows.Forms.ComboBox();
            this.sortbyLabel = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.tbrTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.spicinessTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.tbrLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.spicinessLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.subGenreLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.subGenreTextBox = new System.Windows.Forms.TextBox();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.showFiltersCheckBox = new System.Windows.Forms.CheckBox();
            this.filtersPanel = new System.Windows.Forms.Panel();
            this.seriesComboBox = new System.Windows.Forms.ComboBox();
            this.seriesFilterLabel = new System.Windows.Forms.Label();
            this.myLibraryPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myLibrary1DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.filtersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.Linen;
            this.searchTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 186);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(359, 39);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.searchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(12, 148);
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
            this.librarySizeLabel.Location = new System.Drawing.Point(12, 110);
            this.librarySizeLabel.Name = "librarySizeLabel";
            this.librarySizeLabel.Size = new System.Drawing.Size(320, 31);
            this.librarySizeLabel.TabIndex = 3;
            this.librarySizeLabel.Text = "You have 0 books in your library";
            // 
            // genreComboBox
            // 
            this.genreComboBox.BackColor = System.Drawing.Color.Linen;
            this.genreComboBox.DisplayMember = "genre";
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(159, 98);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(153, 37);
            this.genreComboBox.TabIndex = 4;
            this.genreComboBox.ValueMember = "genre";
            this.genreComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // myLibrary1DataSet
            // 
            this.myLibrary1DataSet.DataSetName = "MyLibrary1DataSet";
            this.myLibrary1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subGenreComboBox
            // 
            this.subGenreComboBox.BackColor = System.Drawing.Color.Linen;
            this.subGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subGenreComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGenreComboBox.FormattingEnabled = true;
            this.subGenreComboBox.Location = new System.Drawing.Point(159, 141);
            this.subGenreComboBox.Name = "subGenreComboBox";
            this.subGenreComboBox.Size = new System.Drawing.Size(153, 37);
            this.subGenreComboBox.TabIndex = 5;
            this.subGenreComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // genreFilterLabel
            // 
            this.genreFilterLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.genreFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreFilterLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreFilterLabel.Location = new System.Drawing.Point(3, 98);
            this.genreFilterLabel.Name = "genreFilterLabel";
            this.genreFilterLabel.Size = new System.Drawing.Size(142, 37);
            this.genreFilterLabel.TabIndex = 6;
            this.genreFilterLabel.Text = "Genre:";
            this.genreFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subGenreFilterLabel
            // 
            this.subGenreFilterLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.subGenreFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subGenreFilterLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGenreFilterLabel.Location = new System.Drawing.Point(3, 141);
            this.subGenreFilterLabel.Name = "subGenreFilterLabel";
            this.subGenreFilterLabel.Size = new System.Drawing.Size(142, 37);
            this.subGenreFilterLabel.TabIndex = 7;
            this.subGenreFilterLabel.Text = "Sub-Genre:";
            this.subGenreFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsListBox
            // 
            this.resultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsListBox.BackColor = System.Drawing.Color.Linen;
            this.resultsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsListBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.IntegralHeight = false;
            this.resultsListBox.ItemHeight = 29;
            this.resultsListBox.Location = new System.Drawing.Point(488, 71);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(711, 438);
            this.resultsListBox.TabIndex = 8;
            this.resultsListBox.SelectedIndexChanged += new System.EventHandler(this.resultsListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 24);
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
            this.searchButton.BackColor = System.Drawing.Color.Linen;
            this.searchButton.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(378, 186);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 39);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // filtersLabel
            // 
            this.filtersLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.filtersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filtersLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersLabel.Location = new System.Drawing.Point(82, 13);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(142, 35);
            this.filtersLabel.TabIndex = 13;
            this.filtersLabel.Text = "Filters";
            this.filtersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchbyComboBox
            // 
            this.searchbyComboBox.BackColor = System.Drawing.Color.Linen;
            this.searchbyComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchbyComboBox.DisplayMember = "genre";
            this.searchbyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchbyComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbyComboBox.FormattingEnabled = true;
            this.searchbyComboBox.Items.AddRange(new object[] {
            "Search By Title",
            "Search By Author",
            "Search By Series"});
            this.searchbyComboBox.Location = new System.Drawing.Point(168, 230);
            this.searchbyComboBox.Name = "searchbyComboBox";
            this.searchbyComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchbyComboBox.Size = new System.Drawing.Size(203, 37);
            this.searchbyComboBox.TabIndex = 15;
            this.searchbyComboBox.ValueMember = "genre";
            this.searchbyComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortComboBox.BackColor = System.Drawing.Color.Linen;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Series",
            "Genre",
            "Sub Genre",
            "Rating",
            "Spiciness",
            "Location",
            "Display",
            "TBR"});
            this.sortComboBox.Location = new System.Drawing.Point(922, 30);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(130, 37);
            this.sortComboBox.TabIndex = 16;
            this.sortComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // sortOrderComboBox
            // 
            this.sortOrderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortOrderComboBox.BackColor = System.Drawing.Color.Linen;
            this.sortOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortOrderComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOrderComboBox.FormattingEnabled = true;
            this.sortOrderComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortOrderComboBox.Location = new System.Drawing.Point(1058, 30);
            this.sortOrderComboBox.Name = "sortOrderComboBox";
            this.sortOrderComboBox.Size = new System.Drawing.Size(141, 37);
            this.sortOrderComboBox.TabIndex = 17;
            this.sortOrderComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // ratingFilterLabel
            // 
            this.ratingFilterLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.ratingFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratingFilterLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingFilterLabel.Location = new System.Drawing.Point(3, 184);
            this.ratingFilterLabel.Name = "ratingFilterLabel";
            this.ratingFilterLabel.Size = new System.Drawing.Size(142, 37);
            this.ratingFilterLabel.TabIndex = 32;
            this.ratingFilterLabel.Text = "Rating:";
            this.ratingFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationFilterLabel
            // 
            this.locationFilterLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.locationFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationFilterLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationFilterLabel.Location = new System.Drawing.Point(3, 272);
            this.locationFilterLabel.Name = "locationFilterLabel";
            this.locationFilterLabel.Size = new System.Drawing.Size(142, 37);
            this.locationFilterLabel.TabIndex = 33;
            this.locationFilterLabel.Text = "Location:";
            this.locationFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spicinessFilterLabel
            // 
            this.spicinessFilterLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.spicinessFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spicinessFilterLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spicinessFilterLabel.Location = new System.Drawing.Point(3, 228);
            this.spicinessFilterLabel.Name = "spicinessFilterLabel";
            this.spicinessFilterLabel.Size = new System.Drawing.Size(142, 37);
            this.spicinessFilterLabel.TabIndex = 34;
            this.spicinessFilterLabel.Text = "Spiciness:";
            this.spicinessFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayFilterLabel
            // 
            this.displayFilterLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.displayFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayFilterLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayFilterLabel.Location = new System.Drawing.Point(3, 316);
            this.displayFilterLabel.Name = "displayFilterLabel";
            this.displayFilterLabel.Size = new System.Drawing.Size(142, 37);
            this.displayFilterLabel.TabIndex = 35;
            this.displayFilterLabel.Text = "For Display?";
            this.displayFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbrFilterLabel
            // 
            this.tbrFilterLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.tbrFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbrFilterLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrFilterLabel.Location = new System.Drawing.Point(3, 360);
            this.tbrFilterLabel.Name = "tbrFilterLabel";
            this.tbrFilterLabel.Size = new System.Drawing.Size(142, 37);
            this.tbrFilterLabel.TabIndex = 36;
            this.tbrFilterLabel.Text = "TBR:";
            this.tbrFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.BackColor = System.Drawing.Color.Linen;
            this.ratingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(159, 184);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(153, 37);
            this.ratingComboBox.TabIndex = 37;
            this.ratingComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // spicinessComboBox
            // 
            this.spicinessComboBox.BackColor = System.Drawing.Color.Linen;
            this.spicinessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spicinessComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spicinessComboBox.FormattingEnabled = true;
            this.spicinessComboBox.Location = new System.Drawing.Point(159, 228);
            this.spicinessComboBox.Name = "spicinessComboBox";
            this.spicinessComboBox.Size = new System.Drawing.Size(153, 37);
            this.spicinessComboBox.TabIndex = 38;
            this.spicinessComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // locationComboBox
            // 
            this.locationComboBox.BackColor = System.Drawing.Color.Linen;
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(159, 272);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(153, 37);
            this.locationComboBox.TabIndex = 39;
            this.locationComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // displayComboBox
            // 
            this.displayComboBox.BackColor = System.Drawing.Color.Linen;
            this.displayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayComboBox.FormattingEnabled = true;
            this.displayComboBox.Items.AddRange(new object[] {
            "Any",
            "Yes",
            "No"});
            this.displayComboBox.Location = new System.Drawing.Point(159, 316);
            this.displayComboBox.Name = "displayComboBox";
            this.displayComboBox.Size = new System.Drawing.Size(153, 37);
            this.displayComboBox.TabIndex = 40;
            this.displayComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // tbrComboBox
            // 
            this.tbrComboBox.BackColor = System.Drawing.Color.Linen;
            this.tbrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbrComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrComboBox.FormattingEnabled = true;
            this.tbrComboBox.Items.AddRange(new object[] {
            "Any",
            "Yes",
            "No"});
            this.tbrComboBox.Location = new System.Drawing.Point(159, 360);
            this.tbrComboBox.Name = "tbrComboBox";
            this.tbrComboBox.Size = new System.Drawing.Size(153, 37);
            this.tbrComboBox.TabIndex = 41;
            this.tbrComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // sortbyLabel
            // 
            this.sortbyLabel.AutoSize = true;
            this.sortbyLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.sortbyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortbyLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortbyLabel.Location = new System.Drawing.Point(821, 33);
            this.sortbyLabel.Name = "sortbyLabel";
            this.sortbyLabel.Size = new System.Drawing.Size(95, 31);
            this.sortbyLabel.TabIndex = 42;
            this.sortbyLabel.Text = "Sort By:";
            // 
            // displayTextBox
            // 
            this.displayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.displayTextBox.BackColor = System.Drawing.Color.Linen;
            this.displayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.displayTextBox.Location = new System.Drawing.Point(550, 140);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(158, 32);
            this.displayTextBox.TabIndex = 30;
            // 
            // tbrTextBox
            // 
            this.tbrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbrTextBox.BackColor = System.Drawing.Color.Linen;
            this.tbrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbrTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.tbrTextBox.Location = new System.Drawing.Point(550, 186);
            this.tbrTextBox.Name = "tbrTextBox";
            this.tbrTextBox.ReadOnly = true;
            this.tbrTextBox.Size = new System.Drawing.Size(158, 32);
            this.tbrTextBox.TabIndex = 31;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTextBox.BackColor = System.Drawing.Color.Linen;
            this.locationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.locationTextBox.Location = new System.Drawing.Point(221, 187);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(158, 32);
            this.locationTextBox.TabIndex = 29;
            // 
            // spicinessTextBox
            // 
            this.spicinessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spicinessTextBox.BackColor = System.Drawing.Color.Linen;
            this.spicinessTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spicinessTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.spicinessTextBox.Location = new System.Drawing.Point(221, 140);
            this.spicinessTextBox.Name = "spicinessTextBox";
            this.spicinessTextBox.ReadOnly = true;
            this.spicinessTextBox.Size = new System.Drawing.Size(158, 32);
            this.spicinessTextBox.TabIndex = 28;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingTextBox.BackColor = System.Drawing.Color.Linen;
            this.ratingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratingTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.ratingTextBox.Location = new System.Drawing.Point(550, 48);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.ReadOnly = true;
            this.ratingTextBox.Size = new System.Drawing.Size(158, 32);
            this.ratingTextBox.TabIndex = 27;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.genreTextBox.BackColor = System.Drawing.Color.Linen;
            this.genreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.genreTextBox.Location = new System.Drawing.Point(221, 48);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.ReadOnly = true;
            this.genreTextBox.Size = new System.Drawing.Size(158, 32);
            this.genreTextBox.TabIndex = 26;
            // 
            // tbrLabel
            // 
            this.tbrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbrLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.tbrLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbrLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrLabel.Location = new System.Drawing.Point(402, 188);
            this.tbrLabel.Name = "tbrLabel";
            this.tbrLabel.Size = new System.Drawing.Size(142, 31);
            this.tbrLabel.TabIndex = 24;
            this.tbrLabel.Text = "TBR:";
            this.tbrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLabel
            // 
            this.displayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.displayLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(402, 141);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(142, 31);
            this.displayLabel.TabIndex = 23;
            this.displayLabel.Text = "For Display?";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.locationLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.locationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(73, 188);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(142, 31);
            this.locationLabel.TabIndex = 22;
            this.locationLabel.Text = "Location:";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spicinessLabel
            // 
            this.spicinessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spicinessLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.spicinessLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spicinessLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spicinessLabel.Location = new System.Drawing.Point(73, 141);
            this.spicinessLabel.Name = "spicinessLabel";
            this.spicinessLabel.Size = new System.Drawing.Size(142, 31);
            this.spicinessLabel.TabIndex = 21;
            this.spicinessLabel.Text = "Spiciness:";
            this.spicinessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ratingLabel
            // 
            this.ratingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.ratingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratingLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(402, 49);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(142, 31);
            this.ratingLabel.TabIndex = 20;
            this.ratingLabel.Text = "Rating:";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subGenreLabel
            // 
            this.subGenreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subGenreLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.subGenreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subGenreLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGenreLabel.Location = new System.Drawing.Point(73, 95);
            this.subGenreLabel.Name = "subGenreLabel";
            this.subGenreLabel.Size = new System.Drawing.Size(142, 31);
            this.subGenreLabel.TabIndex = 19;
            this.subGenreLabel.Text = "Sub Genres: ";
            this.subGenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreLabel
            // 
            this.genreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.genreLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.genreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(73, 49);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(142, 31);
            this.genreLabel.TabIndex = 18;
            this.genreLabel.Text = "Genre: ";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subGenreTextBox
            // 
            this.subGenreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subGenreTextBox.BackColor = System.Drawing.Color.Linen;
            this.subGenreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subGenreTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.subGenreTextBox.Location = new System.Drawing.Point(221, 94);
            this.subGenreTextBox.Name = "subGenreTextBox";
            this.subGenreTextBox.ReadOnly = true;
            this.subGenreTextBox.Size = new System.Drawing.Size(487, 32);
            this.subGenreTextBox.TabIndex = 25;
            // 
            // detailsPanel
            // 
            this.detailsPanel.BackColor = System.Drawing.Color.Transparent;
            this.detailsPanel.Controls.Add(this.seriesTextBox);
            this.detailsPanel.Controls.Add(this.seriesLabel);
            this.detailsPanel.Controls.Add(this.subGenreTextBox);
            this.detailsPanel.Controls.Add(this.displayTextBox);
            this.detailsPanel.Controls.Add(this.genreLabel);
            this.detailsPanel.Controls.Add(this.tbrTextBox);
            this.detailsPanel.Controls.Add(this.locationTextBox);
            this.detailsPanel.Controls.Add(this.subGenreLabel);
            this.detailsPanel.Controls.Add(this.spicinessTextBox);
            this.detailsPanel.Controls.Add(this.ratingTextBox);
            this.detailsPanel.Controls.Add(this.ratingLabel);
            this.detailsPanel.Controls.Add(this.genreTextBox);
            this.detailsPanel.Controls.Add(this.tbrLabel);
            this.detailsPanel.Controls.Add(this.spicinessLabel);
            this.detailsPanel.Controls.Add(this.displayLabel);
            this.detailsPanel.Controls.Add(this.locationLabel);
            this.detailsPanel.Location = new System.Drawing.Point(488, 511);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(711, 222);
            this.detailsPanel.TabIndex = 43;
            this.detailsPanel.Visible = false;
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.seriesTextBox.BackColor = System.Drawing.Color.Linen;
            this.seriesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seriesTextBox.Font = new System.Drawing.Font("Victorian LET", 20.25F);
            this.seriesTextBox.Location = new System.Drawing.Point(221, 4);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.ReadOnly = true;
            this.seriesTextBox.Size = new System.Drawing.Size(487, 32);
            this.seriesTextBox.TabIndex = 33;
            // 
            // seriesLabel
            // 
            this.seriesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.seriesLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.seriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seriesLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesLabel.Location = new System.Drawing.Point(73, 4);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(142, 31);
            this.seriesLabel.TabIndex = 32;
            this.seriesLabel.Text = "Series:";
            this.seriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showFiltersCheckBox
            // 
            this.showFiltersCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.showFiltersCheckBox.BackColor = System.Drawing.Color.BurlyWood;
            this.showFiltersCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showFiltersCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.showFiltersCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Peru;
            this.showFiltersCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showFiltersCheckBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFiltersCheckBox.Location = new System.Drawing.Point(12, 230);
            this.showFiltersCheckBox.Name = "showFiltersCheckBox";
            this.showFiltersCheckBox.Size = new System.Drawing.Size(153, 37);
            this.showFiltersCheckBox.TabIndex = 32;
            this.showFiltersCheckBox.Text = "Show Filters";
            this.showFiltersCheckBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showFiltersCheckBox.UseVisualStyleBackColor = false;
            this.showFiltersCheckBox.CheckedChanged += new System.EventHandler(this.showFiltersCheckBox_CheckedChanged);
            // 
            // filtersPanel
            // 
            this.filtersPanel.BackColor = System.Drawing.Color.Transparent;
            this.filtersPanel.Controls.Add(this.seriesComboBox);
            this.filtersPanel.Controls.Add(this.seriesFilterLabel);
            this.filtersPanel.Controls.Add(this.filtersLabel);
            this.filtersPanel.Controls.Add(this.genreComboBox);
            this.filtersPanel.Controls.Add(this.subGenreComboBox);
            this.filtersPanel.Controls.Add(this.genreFilterLabel);
            this.filtersPanel.Controls.Add(this.tbrComboBox);
            this.filtersPanel.Controls.Add(this.subGenreFilterLabel);
            this.filtersPanel.Controls.Add(this.displayComboBox);
            this.filtersPanel.Controls.Add(this.ratingFilterLabel);
            this.filtersPanel.Controls.Add(this.locationComboBox);
            this.filtersPanel.Controls.Add(this.locationFilterLabel);
            this.filtersPanel.Controls.Add(this.spicinessComboBox);
            this.filtersPanel.Controls.Add(this.spicinessFilterLabel);
            this.filtersPanel.Controls.Add(this.ratingComboBox);
            this.filtersPanel.Controls.Add(this.displayFilterLabel);
            this.filtersPanel.Controls.Add(this.tbrFilterLabel);
            this.filtersPanel.Location = new System.Drawing.Point(12, 269);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(469, 403);
            this.filtersPanel.TabIndex = 44;
            this.filtersPanel.Visible = false;
            // 
            // seriesComboBox
            // 
            this.seriesComboBox.BackColor = System.Drawing.Color.Linen;
            this.seriesComboBox.DisplayMember = "genre";
            this.seriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seriesComboBox.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesComboBox.FormattingEnabled = true;
            this.seriesComboBox.Location = new System.Drawing.Point(159, 54);
            this.seriesComboBox.Name = "seriesComboBox";
            this.seriesComboBox.Size = new System.Drawing.Size(307, 37);
            this.seriesComboBox.TabIndex = 43;
            this.seriesComboBox.ValueMember = "genre";
            this.seriesComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboBox);
            // 
            // seriesFilterLabel
            // 
            this.seriesFilterLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.seriesFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seriesFilterLabel.Font = new System.Drawing.Font("Victorian LET", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesFilterLabel.Location = new System.Drawing.Point(3, 54);
            this.seriesFilterLabel.Name = "seriesFilterLabel";
            this.seriesFilterLabel.Size = new System.Drawing.Size(142, 37);
            this.seriesFilterLabel.TabIndex = 42;
            this.seriesFilterLabel.Text = "Series:";
            this.seriesFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myLibraryPictureBox
            // 
            this.myLibraryPictureBox.BackColor = System.Drawing.Color.BurlyWood;
            this.myLibraryPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myLibraryPictureBox.Image = global::MyLibrary.Properties.Resources.MyLibrary_Text_Logo_Transparent;
            this.myLibraryPictureBox.Location = new System.Drawing.Point(12, 27);
            this.myLibraryPictureBox.Name = "myLibraryPictureBox";
            this.myLibraryPictureBox.Size = new System.Drawing.Size(320, 80);
            this.myLibraryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myLibraryPictureBox.TabIndex = 44;
            this.myLibraryPictureBox.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrary.Properties.Resources.bookshelf1;
            this.ClientSize = new System.Drawing.Size(1211, 735);
            this.Controls.Add(this.myLibraryPictureBox);
            this.Controls.Add(this.filtersPanel);
            this.Controls.Add(this.showFiltersCheckBox);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.sortbyLabel);
            this.Controls.Add(this.sortOrderComboBox);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchbyComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.librarySizeLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Victorian LET", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLibrary";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myLibrary1DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.filtersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label librarySizeLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox subGenreComboBox;
        private System.Windows.Forms.Label genreFilterLabel;
        private System.Windows.Forms.Label subGenreFilterLabel;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem debugMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogMenuItem;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label filtersLabel;
        private System.Windows.Forms.ComboBox searchbyComboBox;
        private MyLibrary1DataSet myLibrary1DataSet;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ComboBox sortOrderComboBox;
        private System.Windows.Forms.Label ratingFilterLabel;
        private System.Windows.Forms.Label locationFilterLabel;
        private System.Windows.Forms.Label spicinessFilterLabel;
        private System.Windows.Forms.Label displayFilterLabel;
        private System.Windows.Forms.Label tbrFilterLabel;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.ComboBox spicinessComboBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.ComboBox displayComboBox;
        private System.Windows.Forms.ComboBox tbrComboBox;
        private System.Windows.Forms.Label sortbyLabel;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.TextBox tbrTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox spicinessTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label tbrLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label spicinessLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label subGenreLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox subGenreTextBox;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.CheckBox showFiltersCheckBox;
        private System.Windows.Forms.Panel filtersPanel;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.ComboBox seriesComboBox;
        private System.Windows.Forms.Label seriesFilterLabel;
        private System.Windows.Forms.PictureBox myLibraryPictureBox;
    }
}

