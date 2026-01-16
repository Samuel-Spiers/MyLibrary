using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MyLibrary
{
    public partial class mainForm : Form
    {
        List<Book> currentResults = new List<Book>();
        SqlConnection connection;
        SqlDataReader reader;
        List<string> log = new List<string>();
        int logLine = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prepare the initial form state on launch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_Load(object sender, EventArgs e)
        {
            // Attempt to establish the database connection
            try
            {
                Log("Attempting to establish database connection...");
                Log(@"Connection string: ""Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\""MyLibrary1.accdb\""""");
                connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
                connection.Open();
                Log("Connection successful");

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Database connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Connection failed. Error Description:");
                Log(ex.Message);
            }

            PopulateUIElements();
            sortComboBox.SelectedIndex = 0;
            sortOrderComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Displays the system log on the log form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openLogMenuItem_Click(object sender, EventArgs e)
        {
            debugForm debug = new debugForm();
            debug.PopulateLog(log);
            debug.Show();
        }

        /// <summary>
        /// Adds a given message to the debug log
        /// </summary>
        /// <param name="msg"></param>
        private void Log(string msg) {
            logLine++;
            log.Add($"{logLine,-3}| {msg}");
        }

        private void PopulateUIElements() {
            // Get all books from the database to count how many there are, as well as to populate the filter comboboxes
            try {
                SqlCommand command = new SqlCommand("SELECT genre, sub_genre, rating, spiciness, location " +
                                                    "FROM books", connection);
                Log($"Sending query to database: {command.CommandText}");
                reader = command.ExecuteReader();

                // Begin reading query return data
                List<string>[] filterData = {new List<string>(), new List<string>(), new List<string>(), 
                                             new List<string>(), new List<string>()};
                int bookCount = 0;
                while (reader.Read()) {
                    // Add only unique genres to the list
                    if (!filterData[0].Contains(reader[0])) {
                        filterData[0].Add(reader[0].ToString());
                    }
                    // Seperate all sub genre types into an array
                    string[] subgenres = reader[1].ToString().Split(',');
                    // Loop through each sub genre found on the book and add the unique ones
                    foreach (string str in subgenres) {
                        if (!filterData[1].Contains(str.Trim())) {
                            filterData[1].Add(str.Trim());
                        }
                    }
                    // Add only unique ratings to the list
                    if (!filterData[2].Contains(reader[2])) {
                        filterData[2].Add(reader[2].ToString());
                    }
                    // Add only unique spiciness ratings to the list
                    if (!filterData[3].Contains(reader[3])) {
                        filterData[3].Add(reader[3].ToString());
                    }
                    // Add only unique locations to the list
                    if (!filterData[4].Contains(reader[4])) {
                        filterData[4].Add(reader[4].ToString());
                    }
                     bookCount++;
                }
                reader.Close();

                // Log results and update library size label
                Log($"Query Success");
                Log($"Book Count: {bookCount}");
                librarySizeLabel.Text = $"You have {bookCount} books in your library";

                // Sort numeric options from high to low
                filterData[2].Sort((d1, d2) => {return d2.CompareTo(d1);});
                filterData[3].Sort((d1, d2) => {return d2.CompareTo(d1);});

                // Populate the filter dropdowns
                if (bookCount > 0) {
                    genreComboBox.Items.Add("Any");
                    subGenreComboBox.Items.Add("Any");
                    ratingComboBox.Items.Add("Any");
                    spicinessComboBox.Items.Add("Any");
                    locationComboBox.Items.Add("Any");

                    genreComboBox.Items.AddRange(filterData[0].ToArray());
                    subGenreComboBox.Items.AddRange(filterData[1].ToArray());
                    ratingComboBox.Items.AddRange(filterData[2].ToArray());
                    spicinessComboBox.Items.AddRange(filterData[3].ToArray());
                    locationComboBox.Items.AddRange(filterData[4].ToArray());
                    
                    Log("Search filters populated");

                    searchbyComboBox.SelectedIndex = 0;
                    genreComboBox.SelectedIndex = 0;
                    subGenreComboBox.SelectedIndex = 0;
                    ratingComboBox.SelectedIndex = 0;
                    spicinessComboBox.SelectedIndex = 0;
                    locationComboBox.SelectedIndex = 0;
                    displayComboBox.SelectedIndex = 0;
                    tbrComboBox.SelectedIndex = 0;
                }

            } catch (Exception ex) {
                Log($"Startup failed: {ex.Message}");
                MessageBox.Show(ex.Message, "Startup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Triggers a database query for the entered search text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            resultsListBox.Items.Clear();

            // Get the list of books that match the search
            currentResults = SearchDatabase(search);
            if (currentResults != null && currentResults.Count > 0) {
                // If any books are found, find their respective authors
                List<Author> authorList = GetAuthors(currentResults);
                // Display the results in the resultsListBox
                int index = 0;
                foreach (Book book in currentResults) {
                    resultsListBox.Items.Add($"{index+1}. {book.Title} By {authorList[index].FirstName} {authorList[index].LastName}");
                    index++;
                }
            } else {
                resultsListBox.Items.Add("No results");
            }
        }

        /// <summary>
        /// Gets the state of all search filters and pair them with their names for easy string building later
        /// </summary>
        /// <returns>State of all search filters</returns>
        private string[,] GetFilterStates() {
            return new string[,] {{"genre", "sub_genre", "rating", "spiciness", "location", "is_display", "to_be_read"}, 
                                {genreComboBox.Text == "Any" ? null : "'%"+genreComboBox.Text+"%'", 
                                 subGenreComboBox.Text == "Any" ? null : "'%"+subGenreComboBox.Text+"%'",
                                 ratingComboBox.Text == "Any" ? null : "'%"+ratingComboBox.Text+"%'", 
                                 spicinessComboBox.Text == "Any" ? null : "'%"+spicinessComboBox.Text+"%'",
                                 locationComboBox.Text == "Any" ? null : "'%"+locationComboBox.Text+"%'", 
                                 displayComboBox.Text == "Any" ? null : "'%"+displayComboBox.Text+"%'",
                                 tbrComboBox.Text == "Any" ? null : "'%"+tbrComboBox.Text+"%'"}};
        }

        /// <summary>
        /// Gets the current sorting settings
        /// </summary>
        /// <returns>Current sorting settings</returns>
        private string[] GetSortSettings() {

            string[] settings = new string[2];

            switch(sortComboBox.Text) {
                case "Title":
                    settings[0] = "title";
                break;
                case "Author":
                    settings[0] = "a.last_name"; // This option includes the 'a.' alias because the SQL statement uses a JOIN
                break;
                case "Genre":
                    settings[0] = "genre";
                break;
                case "Sub Genre":
                    settings[0] = "sub_genre";
                break;
                case "Rating":
                    settings[0] = "rating";
                break;
                case "Spiciness":
                    settings[0] = "spiciness";
                break;
                case "Location":
                    settings[0] = "location";
                break;
                case "Display":
                    settings[0] = "is_display";
                break;
                case "TBR":
                    settings[0] = "to_be_read";
                break;
            }

            switch(sortOrderComboBox.Text) {
                case "Ascending":
                    settings[1] = "ASC";
                break;
                case "Descending":
                    settings[1] = "DESC";
                break;
            }

            return settings;
        }

        /// <summary>
        /// Builds an SQL search query using provided values including search text, search type, and the current filter and sorting settings
        /// </summary>
        /// <param name="search">User's entered search string</param>
        /// <param name="searchType">Type of search being performed (title, author)</param>
        /// <returns>Fully formatted SQL query string for an SqlCommand object to use</returns>
        private string BuildQueryString(string search, string searchType) {
            
            // Format search string and gather current filter and sort settings
            string formattedSearch = "%" + search + "%";
            Log("Getting filter states...");
            string[,] filterStates = GetFilterStates();
            Log("Getting sort mode settings...");
            string[] sortSettings = GetSortSettings();
            if (searchType == "Search By Title") {
                searchType = "title";
            } else if (searchType == "Search By Author") {
                searchType = "last_name";
                sortSettings[0] = "b." + sortSettings[0];
            }

            // Attempt query assembly
            try {
                // Build first piece with or without JOIN depending on if we're sorting by author name
                string queryStart;
                if (sortSettings[0] == "a.last_name" || searchType == "last_name") {
                    queryStart = "SELECT * " +
                                        $"FROM books b " +
                                        $"JOIN authors a ON a.author_id = b.author_id " +
                                        $"WHERE {searchType} LIKE '{formattedSearch}' ";
                    
                } else {
                    queryStart = "SELECT * " +
                                        $"FROM books " +
                                        $"WHERE {searchType} LIKE '{formattedSearch}' ";
                }
                string queryMiddle;
                // Build middle section by dynamically inserting filter values as needed (Only if searching by book title, otherwise it is an empty string)
                if (searchType == "Title") {
                    queryMiddle = "";
                    int stateIndex = 0;
                    for (int i = 0; i < filterStates.GetLength(1); i++) {
                        if (filterStates[1,stateIndex] != null) {
                            queryMiddle += $"AND {filterStates[0,stateIndex]} LIKE {filterStates[1,stateIndex]} ";
                        }
                        stateIndex++;
                    }
                } else {queryMiddle = "";}
                // Assemble final section using sorting settings
                string queryEnd = $"ORDER BY {sortSettings[0]} {sortSettings[1]}";

                return queryStart + queryMiddle + queryEnd;

            } catch(Exception e) {
                Log("Failed to build query string. Error Description:");
                Log(e.Message);
            }

            return null;
        }

        /// <summary>
        /// Queries the database for a list of books based on a given search string
        /// </summary>
        /// <param name="search">User's entered search string</param>
        /// <returns>A list of books based on the given search string</returns>
        private List<Book> SearchDatabase(string search) {

            List<Book> results = new List<Book>();

            string queryString = BuildQueryString(search, searchbyComboBox.SelectedItem.ToString());

            if (queryString != null) {
                // Load the SQL command and run it, collecting all results into a list
                try {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    Log($"Sending search query to database: {command.CommandText}");
                    reader = command.ExecuteReader();
                    // Read the query results into the book list
                    while (reader.Read()) {
                        results.Add(new Book((int)reader[0], (int)reader[1], (int)reader[2], reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), (int)reader[7], (int)reader[8], (bool)reader[9], (bool)reader[10]));
                    }
                    reader.Close();
                    Log($"Success: {results.Count} results found");

                } catch (Exception ex) {
                    Log($"Database query failed: {ex.Message}");
                }
            } else {
                return null;
            }
            return results;
        }

        /// <summary>
        /// Query the database for a list of authors based on a list of books
        /// </summary>
        /// <param name="books"></param>
        /// <returns>A list of all author names related to the given books</returns>
        private List<Author> GetAuthors(List<Book> books) {

            List<Author> results = new List<Author>();

            // Build a string of all author ids from the book list to go inside the "IN" statement in the SQL query
            string authorIds = "";
            foreach (Book book in books) {
                if (book == books[books.Count - 1]) {
                    authorIds += $"{book.Author_Id}";
                } else {
                    authorIds += $"{book.Author_Id}, ";
                }
            }

            try {
                // Prepare the SQL command
                SqlCommand command = new SqlCommand("SELECT * " +
                                                    "FROM authors " +
                                                   $"WHERE author_id IN ({authorIds})", connection);
                Log($"Sending search query to database: {command.CommandText}");

                // Query the database to find the authors and read the output into an array
                reader = command.ExecuteReader();
                // Read the query results into the author list
                while (reader.Read()) {
                    results.Add(new Author((int)reader[0], (string)reader[1], (string)reader[2]));
                }
                reader.Close();
                Log($"Success: {results.Count} results found");

            } catch (Exception ex) {
                Log($"Database query failed: {ex.Message}");
            }
            return results;
        }

        /// <summary>
        /// Populates all book details when a search result is selected
        /// </summary>
        /// <param name="book">The currently selected book to display information about</param>
        private void PopulateDetails(Book book) {
            genreTextBox.Text = " " + book.Genre;
            subGenreTextBox.Text = " " + book.SubGenre;
            spicinessTextBox.Text = " " + String.Concat(Enumerable.Repeat("♥", book.Spiciness));
            locationTextBox.Text = " " + book.Location;
            ratingTextBox.Text = " " + String.Concat(Enumerable.Repeat("★", book.Rating));
            displayTextBox.Text = (book.IsDisplay == true) ? " Yes" : " No";
            tbrTextBox.Text = (book.ToBeRead == true) ? " Yes" : " No";
        }

        /// <summary>
        /// Triggers book detail box population when the selected search result changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure we don't select anything outside of the filled indexes
            if (resultsListBox.SelectedIndex != -1) {
                Book selected = currentResults[resultsListBox.SelectedIndex];
                if (selected != null) {
                    PopulateDetails(selected);
                }
                detailsPanel.Visible = true;
            } else {
                detailsPanel.Visible = false;
            }
        }

        /// <summary>
        /// Handle enter keypress in search bar by triggering search and supressing windows chime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                searchButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void showFiltersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showFiltersCheckBox.Checked) {
                filtersPanel.Visible = true;
            } else {
                filtersPanel.Visible = false;
            }
        }
    }
}