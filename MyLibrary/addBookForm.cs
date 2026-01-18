using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class addBookForm : Form
    {
        private readonly mainForm Main;

        public string[] BookInfo {get; set;} = new string[10];

        public addBookForm(mainForm main, List<string>[] autoCompleteSource)
        {
            InitializeComponent();
            Main = main;

            // Set all comboboxes to be manually drawn
            ratingComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            spicinessComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            displayComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            tbrComboBox.DrawMode = DrawMode.OwnerDrawFixed;
    
            // Populate all auto complete sources
            genreTextBox.AutoCompleteCustomSource.AddRange(autoCompleteSource[0].ToArray());
            subGenreTextBox.AutoCompleteCustomSource.AddRange(autoCompleteSource[1].ToArray());
            locationTextBox.AutoCompleteCustomSource.AddRange(autoCompleteSource[2].ToArray());
            seriesTextBox.AutoCompleteCustomSource.AddRange(autoCompleteSource[3].ToArray());
            authorNameTextBox.AutoCompleteCustomSource.AddRange(autoCompleteSource[4].ToArray());
        }

        private void confirmButton_Click(object sender, System.EventArgs e)
        {
            string title = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titleTextBox.Text.ToLower());
            string author_name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(authorNameTextBox.Text.ToLower());
            string series_name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(seriesTextBox.Text.ToLower());
            string genre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(genreTextBox.Text.ToLower());
            string subGenre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(subGenreTextBox.Text.ToLower());
            string location = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(locationTextBox.Text.ToLower());
            string rating = ratingComboBox.SelectedItem.ToString();
            string spiciness = spicinessComboBox.SelectedItem.ToString();
            string display = displayComboBox.SelectedItem.ToString() == "Yes" ? "-1" : "0";
            string tbr = displayComboBox.SelectedItem.ToString() == "Yes" ? "-1" : "0";

            BookInfo = new string[] {title, author_name, series_name, genre, subGenre, location, rating, spiciness, display, tbr};

            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void DrawComboBox(object sender, DrawItemEventArgs e)
        {
            Main.DrawComboBox(sender, e);
        }
    }
}
