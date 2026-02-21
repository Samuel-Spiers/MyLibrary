using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class editBookForm : Form
    {
        private readonly mainForm Main;

        public string[] BookInfo {get; set;} = new string[10];

        public editBookForm(mainForm main, Book selectedBook)
        {
            InitializeComponent();
            Main = main;

            // Set all comboboxes to be manually drawn
            ratingComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            spicinessComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            displayComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            tbrComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            // Populate all current book data
            titleTextBox.Text = selectedBook.Title;
            Author author = Main.GetAuthor(selectedBook);
            authorNameTextBox.Text = author.FirstName + " " + author.LastName;
            Series series = Main.GetSeries(selectedBook);
            seriesTextBox.Text = series.Name;
            genreTextBox.Text = selectedBook.Genre;
            subGenreTextBox.Text = selectedBook.SubGenre;
            locationTextBox.Text = selectedBook.Location;
            ratingComboBox.SelectedIndex = selectedBook.Rating.ToString().Length - 1;
            spicinessComboBox.SelectedIndex = selectedBook.Spiciness.ToString().Length - 1;
            displayComboBox.SelectedIndex = selectedBook.IsDisplay == true ? 0 : 1;
            tbrComboBox.SelectedIndex = selectedBook.ToBeRead == true ? 0 : 1;
        }

        private void updateButton_Click(object sender, EventArgs e)
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

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DrawComboBox(object sender, DrawItemEventArgs e)
        {
            Main.DrawComboBox(sender, e);
        }
    }
}
