using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyLibrary
{
    public partial class mainForm : Form
    {
        Book selectedBook;
        List<Book> currentResults = new List<Book>();
        List<string>[] bookInfoAutocompleteSource = {new List<string>(), new List<string>(), new List<string>(), 
                                                     new List<string>(), new List<string>(), new List<string>()};
        SqlConnection connection;
        SqlDataReader reader;
        List<string> log = new List<string>(); // List of log entries to print into the debugForm
        List<string> stackTraceLog = new List<string>(); // List of detailed stack traces
        int logLine = 0; // Current log line number

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
        AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
        var dd = (string)AppDomain.CurrentDomain.GetData("DataDirectory");
        Log("DataDirectory=" + dd);
        Log("DB exists? " + File.Exists(Path.Combine(dd, "MyLibrary1.accdb")));

            // Attempt to establish the database connection
            try
            {
                Log("Attempting to establish database connection...");
                Log(@"Connection string: ""Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\MyLibrary1.accdb;Persist Security Info=False;""""");
                connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
                connection.Open();
                Log("Connection successful");

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Database connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Connection failed. Error Description:");
                Log(ex.Message, ex.StackTrace);
            }

            PopulateUIElements();
            sortComboBox.SelectedIndex = 0;
            sortOrderComboBox.SelectedIndex = 0;

            searchbyComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            seriesComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            genreComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            subGenreComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            ratingComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            spicinessComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            locationComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            displayComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            tbrComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            sortComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            sortOrderComboBox.DrawMode = DrawMode.OwnerDrawFixed;
        }

        /// <summary>
        /// Displays the system log on the log form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openLogMenuItem_Click(object sender, EventArgs e)
        {
            debugForm debug = new debugForm(stackTraceLog);
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
            stackTraceLog.Add("");
        }

        /// <summary>
        /// Overload loggin method for additionally storing a stacktrace string
        /// Adds a given message to the debug log with a stacktrace
        /// </summary>
        /// <param name="msg"></param>
        private void Log(string msg, string stackTrace) {
            logLine++;
            log.Add($"{logLine,-3}| {msg}");
            stackTraceLog.Add(stackTrace);
        }

        private void PopulateUIElements() {
            // Get all books from the database to count how many there are, as well as to populate the filter comboboxes
            try {
                SqlCommand command = new SqlCommand("SELECT genre, sub_genre, rating, spiciness, location, s.series_name, CONCAT(CONCAT(a.first_name, ' '), a.last_name)" +
                                                    "FROM books b" +
                                                    " JOIN series s ON s.series_id = b.series_id" +
                                                    " JOIN authors a ON a.author_id = b.author_id", connection);
                Log($"Sending query to database: {command.CommandText}");
                reader = command.ExecuteReader();

                // Begin reading query return data
                List<string>[] filterData = {new List<string>(), new List<string>(), new List<string>(), 
                                             new List<string>(), new List<string>(), new List<string>(),
                                             new List<string>()};
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
                        filterData[2].Add(String.Concat(Enumerable.Repeat("★", (int)reader[2])));
                    }
                    // Add only unique spiciness ratings to the list
                    if (!filterData[3].Contains(reader[3])) {
                        filterData[3].Add(String.Concat(Enumerable.Repeat("♥", (int)reader[3])));
                    }
                    // Add only unique locations to the list
                    if (!filterData[4].Contains(reader[4])) {
                        filterData[4].Add(reader[4].ToString());
                    }
                    // Add only unique series names to the list
                    if (!filterData[5].Contains(reader[5])) {
                        filterData[5].Add(reader[5].ToString());
                    }

                    if (!filterData[6].Contains(reader[6])) {
                        filterData[6].Add(reader[6].ToString());
                    }
                     bookCount++;
                }
                reader.Close();

                // Prepare all auto complete sources for the book add menu
                bookInfoAutocompleteSource[0].AddRange(filterData[0]);
                bookInfoAutocompleteSource[1].AddRange(filterData[1]);
                bookInfoAutocompleteSource[2].AddRange(filterData[4]);
                bookInfoAutocompleteSource[3].AddRange(filterData[5]);
                bookInfoAutocompleteSource[4].AddRange(filterData[6]);

                // Log results and update library size label
                Log($"Query Success");
                Log($"Book Count: {bookCount}");
                librarySizeLabel.Text = $"You have {bookCount} books in your library";

                // Sort numeric options from high to low
                filterData[2].Sort((d1, d2) => {return d2.CompareTo(d1);});
                filterData[3].Sort((d1, d2) => {return d2.CompareTo(d1);});

                // Populate the filter dropdowns
                if (bookCount > 0) {
                    seriesComboBox.Items.Add("Any");
                    genreComboBox.Items.Add("Any");
                    subGenreComboBox.Items.Add("Any");
                    ratingComboBox.Items.Add("Any");
                    spicinessComboBox.Items.Add("Any");
                    locationComboBox.Items.Add("Any");

                    seriesComboBox.Items.AddRange(filterData[5].ToArray());
                    genreComboBox.Items.AddRange(filterData[0].ToArray());
                    subGenreComboBox.Items.AddRange(filterData[1].ToArray());
                    ratingComboBox.Items.AddRange(filterData[2].ToArray());
                    spicinessComboBox.Items.AddRange(filterData[3].ToArray());
                    locationComboBox.Items.AddRange(filterData[4].ToArray());
                    
                    Log("Search filters populated");

                    searchbyComboBox.SelectedIndex = 0;
                    seriesComboBox.SelectedIndex = 0;
                    genreComboBox.SelectedIndex = 0;
                    subGenreComboBox.SelectedIndex = 0;
                    ratingComboBox.SelectedIndex = 0;
                    spicinessComboBox.SelectedIndex = 0;
                    locationComboBox.SelectedIndex = 0;
                    displayComboBox.SelectedIndex = 0;
                    tbrComboBox.SelectedIndex = 0;
                }

            } catch (Exception ex) {
                Log($"UI setup failed: {ex.Message}", ex.StackTrace);
                MessageBox.Show(ex.Message, "UI setup failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                List<Series> seriesList = GetSeries(currentResults);
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
            return new string[,] {{"series_name", "genre", "sub_genre", "rating", "spiciness", "location", "is_display", "to_be_read"}, 
                                {seriesComboBox.Text == "Any" ? null : "'%"+seriesComboBox.Text+"%'",
                                 genreComboBox.Text == "Any" ? null : "'%"+genreComboBox.Text+"%'", 
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
                    settings[0] = "b.title";
                break;
                case "Author":
                    settings[0] = "CONCAT(a.first_name, a.last_name)"; // This option includes the 'a.' alias because the SQL statement uses a JOIN
                break;
                case "Series":
                    settings[0] = "s.series_name";
                break;
                case "Genre":
                    settings[0] = "b.genre";
                break;
                case "Sub Genre":
                    settings[0] = "b.sub_genre";
                break;
                case "Rating":
                    settings[0] = "b.rating";
                break;
                case "Spiciness":
                    settings[0] = "b.spiciness";
                break;
                case "Location":
                    settings[0] = "b.location";
                break;
                case "Display":
                    settings[0] = "b.is_display";
                break;
                case "TBR":
                    settings[0] = "b.to_be_read";
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
        /// <param name="searchType">Type of search being performed ("Search By" + Title, Author, or Series)</param>
        /// <returns>Fully formatted SQL query string for an SqlCommand object to use</returns>
        private string BuildQueryString(string search, string searchType) {
            
            // Format search string and gather current filter and sort settings
            string formattedSearch = "%" + search + "%";
            Log("Getting filter states...");
            string[,] filterStates = GetFilterStates();
            Log("Getting sort mode settings...");
            string[] sortSettings = GetSortSettings();

            // Reformat searchType to fit directly into SQL query
            if (searchType == "Search By Title") {
                searchType = "title";
            } else if (searchType == "Search By Author") {
                searchType = "CONCAT(a.first_name, a.last_name)"; // Concatenate first and last name together to allow searching for either part of the name
            } else if (searchType == "Search By Series") {
                searchType = "s.series_name";
            }

            // Decide whether we need the series JOIN statement
            string joinStatement = "JOIN authors a ON a.author_id = b.author_id";
            if (searchType == "s.series_name" || sortSettings[0] == "s.series_name" || filterStates[1,0] != null) {
                joinStatement += " JOIN series s ON s.series_id = b.series_id";
            }

            // Attempt query assembly
            try {
                // Build first piece with or without JOIN depending on if we're sorting or searching by author name
                string queryStart = "SELECT b.* " +
                                    $"FROM books b " +
                                    $"{joinStatement} " +
                                    $"WHERE {searchType} LIKE '{formattedSearch}' ";

                // Build middle section by dynamically inserting filter values as needed (Only if searching by book title, otherwise it is an empty string)
                string queryMiddle = "";
                for (int i = 0; i < filterStates.GetLength(1); i++) {
                    if (filterStates[1,i] != null) { // If a filter is null (isn't set), ignore it
                        if (filterStates[0,i] == "is_display" || filterStates[0,i] == "to_be_read") { // If the active filter is boolean, convert it to valid int values for the database
                            int boolState = displayComboBox.Text == "Yes" ? -1 : 0;
                            queryMiddle += $"AND {filterStates[0,i]} LIKE {boolState} ";
                        } else {
                            queryMiddle += $"AND {filterStates[0,i]} LIKE {filterStates[1,i]} ";
                        }
                    }
                }

                // Assemble final section using sorting settings
                string queryEnd = $"ORDER BY {sortSettings[0]} {sortSettings[1]}";

                // Assemble the query string and return
                return queryStart + queryMiddle + queryEnd;

            } catch(Exception e) {
                Log($"Failed to build query string: {e.Message}", e.StackTrace);
                MessageBox.Show(e.Message, "Query string assembly failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        /// <summary>
        /// Queries the database for a list of books based on a given search string
        /// </summary>
        /// <param name="search">User's entered search string</param>
        /// <returns>A list of books based on the given search string</returns>
        private List<Book> SearchDatabase(string search) {

            List<Book> results = new List<Book>(); // Index 0 will be a book list, index 1 will be a matching series list

            string queryString = BuildQueryString(search, searchbyComboBox.SelectedItem.ToString());

            if (queryString != null) {
                // Load the SQL command and run it, collecting all results into a list
                try {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    Log($"Sending search query to database: {command.CommandText}");
                    reader = command.ExecuteReader();
                    // Read the query results into the book list
                    while (reader.Read()) {
                        results.Add(new Book((int)reader[0], (int)reader[1], (int)reader[2], reader[3].ToString(), 
                                                  reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), 
                                                  (int)reader[7], (int)reader[8], (bool)reader[9], (bool)reader[10]));
                    }
                    reader.Close();
                    Log($"Success: {results.Count} results found");

                } catch (Exception ex) {
                    Log($"Database query failed: {ex.Message}", ex.StackTrace);
                    MessageBox.Show(ex.Message, "Query failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public List<Author> GetAuthors(List<Book> books) {

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
                Log($"Get authors failed: {ex.Message}", ex.StackTrace);
                MessageBox.Show(ex.Message, "Query failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return results;
        }

        /// <summary>
        /// Query the database for an author based on a single book
        /// </summary>
        /// <param name="book">The book to find the author name of</param>
        /// <returns>A list of all author names related to the given books</returns>
        public Author GetAuthor(Book book) {

            Author result;

            try {
                // Prepare the SQL command
                SqlCommand command = new SqlCommand("SELECT * " +
                                                    "FROM authors " +
                                                   $"WHERE author_id IN ({book.Author_Id})", connection);
                Log($"Sending search query to database: {command.CommandText}");

                // Query the database to find the authors and read the output into an array
                reader = command.ExecuteReader();
                // Read the query results into the author list
                if (reader.Read()) {
                    result = new Author((int)reader[0], (string)reader[1], (string)reader[2]);
                    reader.Close();
                    Log($"Success: Author found");
                    return result;
                } else {
                    throw new Exception();
                }

            } catch (Exception ex) {
                Log($"Get author failed: {ex.Message}", ex.StackTrace);
                MessageBox.Show(ex.Message, "Query failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        /// <summary>
        /// Query the database for a list of series' based on a list of books
        /// </summary>
        /// <param name="books"></param>
        /// <returns>A list of all author names related to the given books</returns>
        private List<Series> GetSeries(List<Book> books) {

            List<Series> results = new List<Series>();

            // Build a string of all author ids from the book list to go inside the "IN" statement in the SQL query
            string seriesIds = "";
            foreach (Book book in books) {
                if (book == books[books.Count - 1]) {
                    seriesIds += $"{book.Series_Id}";
                } else {
                    seriesIds += $"{book.Series_Id}, ";
                }
            }

            try {
                // Prepare the SQL command
                SqlCommand command = new SqlCommand("SELECT * " +
                                                    "FROM series " +
                                                   $"WHERE series_id IN ({seriesIds})", connection);
                Log($"Sending search query to database: {command.CommandText}");

                // Query the database to find the authors and read the output into an array
                reader = command.ExecuteReader();
                // Read the query results into the author list
                while (reader.Read()) {
                    results.Add(new Series((int)reader[0], reader[1].ToString(), (int)reader[2]));
                }
                reader.Close();
                Log($"Success: {results.Count} results found");

            } catch (Exception ex) {
                Log($"Get series failed: {ex.Message}", ex.StackTrace);
                MessageBox.Show(ex.Message, "Query failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return results;
        }

        /// <summary>
        /// Single book search overload of GetSeries method 
        /// Query the database for a series based on a single book
        /// </summary>
        /// <param name="books"></param>
        /// <returns>A list of all author names related to the given books</returns>
        public Series GetSeries(Book book) {

            try {
                // Prepare the SQL command
                SqlCommand command = new SqlCommand("SELECT * " +
                                                    "FROM series " +
                                                   $"WHERE series_id = {book.Series_Id}", connection);
                Log($"Sending search query to database: {command.CommandText}");

                // Query the database to find the book's series
                reader = command.ExecuteReader();
                // Read the query result
                Series result = null;
                while (reader.Read()) {
                    result = new Series((int)reader[0], reader[1].ToString(), (int)reader[2]);
                }
                reader.Close();
                Log($"Success: series found");
                return result;

            } catch (Exception ex) {
                Log($"Database query failed: {ex.Message}", ex.StackTrace);
                MessageBox.Show(ex.Message, "Get series failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Populates all book details when a search result is selected
        /// </summary>
        /// <param name="book">The currently selected book to display information about</param>
        private void PopulateDetails(Book book) {
            seriesTextBox.Text = GetSeries(book).Name;
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
            if (resultsListBox.SelectedIndex != -1 && currentResults[resultsListBox.SelectedIndex] != null) {
                selectedBook = currentResults[resultsListBox.SelectedIndex];
                PopulateDetails(selectedBook);
                removeButton.Enabled = true;
                removeButton.Visible = true;
                detailsPanel.Visible = true;
            } else {
                removeButton.Enabled = false;
                removeButton.Visible = false;
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

        /// <summary>
        /// Shows and hides the filters list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showFiltersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showFiltersCheckBox.Checked) {
                filtersPanel.Visible = true;
            } else {
                filtersPanel.Visible = false;
            }
        }

        /// <summary>
        /// Manually drawing the comboboxes to allow for more colour customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void DrawComboBox(object sender, DrawItemEventArgs e) {
            var cb = (ComboBox)sender;

            // Guard when there is no item to draw. Paint the empty/selected box area
            if (e.Index < 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Linen), e.Bounds);
                e.DrawFocusRectangle();
                return;
            }

            // Set colours
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color back = selected ? Color.Linen : Color.Linen;
            Color fore = selected ? Color.SaddleBrown : Color.Black;

            using (var backBrush = new SolidBrush(back))
            using (var textBrush = new SolidBrush(fore))
            {
                // Set background colour
                e.Graphics.FillRectangle(backBrush, e.Bounds);

                // Draw the text
                string text = cb.GetItemText(cb.Items[e.Index]);
                var textRect = new Rectangle(e.Bounds.X - 3, e.Bounds.Y + 2,
                                             e.Bounds.Width + 10, e.Bounds.Height - 4);
                TextRenderer.DrawText(e.Graphics, text, e.Font, textRect, fore,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
            }

            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Retreive an author_id from an author name
        /// </summary>
        /// <param name="authorName"></param>
        /// <returns></returns>
        private int GetAuthorId(string authorName) {  
            try {
                int id = 0;
                SqlCommand cmd = new SqlCommand($"SELECT author_id " +
                                                $"FROM authors " +
                                                $"WHERE CONCAT(CONCAT(first_name, ' '), last_name) LIKE '%{authorName}%'", connection);
                Log($"Sending search query to database: {cmd.CommandText}");
                reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    id = (int)reader[0];
                }
                reader.Close();
                // If we didn't find an id, return -1
                if (id == 0) {
                    Log("Author not found");
                    return -1;
                }
                Log($"Success");
                return id;

            } catch (Exception ex) {
                Log($"Failed getting author id: {ex.Message}", ex.StackTrace);
                MessageBox.Show(ex.Message, "Get author failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        /// <summary>
        /// Retreive a series_id from a series name
        /// </summary>
        /// <param name="seriesName"></param>
        /// <returns></returns>
        private int GetSeriesId(string seriesName) {
            try {
                int id = 0;
                SqlCommand cmd = new SqlCommand($"SELECT series_id " +
                                                $"FROM series " +
                                                $"WHERE series_name LIKE '%{seriesName}%'", connection);
                Log($"Sending search query to database: {cmd.CommandText}");
                reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    id = (int)reader[0];
                }
                reader.Close();
                // If we didn't find an id, return -1
                if (id == 0) {
                    Log("Series not found");
                    return -1;
                }
                Log($"Success");
                return id;

            } catch (Exception ex) {
                Log(ex.Message, ex.StackTrace);
                MessageBox.Show(ex.Message, "Get series failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        /// <summary>
        /// Inserts a new author entry into the database
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Newly created author_id on success, -1 on failure</returns>
        private int InsertAuthor(string name) {

            string[] nameParts = name.Split(' ');
            try {
                SqlCommand cmd = new SqlCommand($"INSERT INTO authors " +
                                                $"VALUES ('{nameParts[0]}', '{nameParts[1]}')", connection);

                Log($"Sending insert query to database: {cmd.CommandText}");
                int rows = cmd.ExecuteNonQuery();
                Log($"Author insert successful. {rows} rows affected\"");

                // Search for the inserted author, validating its existence
                cmd = new SqlCommand($"SELECT author_id " +
                                     $"FROM authors " +
                                     $"WHERE first_name = '{nameParts[0]}' " +
                                     $"AND last_name = '{nameParts[1]}'", connection);
                
                Log($"Sending search query to database: {cmd.CommandText}");
                reader = cmd.ExecuteReader();
                if (reader.Read() && reader[0] != null) {
                    Log($"New author_id retrieval successful. Insert validated");
                    int authorId = (int)reader[0];
                    reader.Close();
                    return authorId;
                } else {
                    reader.Close();
                    throw new Exception("Author insert not validated");
                }
            } catch (Exception ex) {
                Log($"Author insert failed: {ex.Message}", ex.StackTrace);
                MessageBox.Show(ex.Message, "Author insert failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        /// <summary>
        /// Inserts a new series entry into the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author_id"></param>
        /// <returns>Newly created series_id on success, -1 on failure</returns>
        private int InsertSeries(string name, int author_id) {

            try {
                SqlCommand cmd = new SqlCommand($"INSERT INTO series " +
                                                $"VALUES ('{name}', '{author_id}')", connection);

                Log($"Sending insert query to database: {cmd.CommandText}");
                int rows = cmd.ExecuteNonQuery();
                Log($"Series insert successful. {rows} rows affected");

                // Search for the inserted series, validating its existence
                cmd = new SqlCommand($"SELECT series_id " +
                                        $"FROM series " +
                                        $"WHERE series_name = '{name}'", connection);
                
                Log($"Sending search query to database: {cmd.CommandText}");
                reader = cmd.ExecuteReader();
                if (reader.Read() && reader[0] != null) {
                    Log($"New series_id retrieval successful. Insert validated");
                    int seriesId = (int)reader[0];
                    reader.Close();
                    return seriesId;
                } else {
                    reader.Close();
                    throw new Exception("Series insert not validated");
                }
            } catch (Exception ex) {
                Log($"Series insert failed: {ex.Message}", ex.StackTrace);
                MessageBox.Show(ex.Message, "Series insert failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        /// <summary>
        /// Overload of BuildQueryString for insert/delete/update usage
        /// Build an SQL query for adding/removing/updating a book
        /// </summary>
        /// <param name="bookInfo">title, author_name, series_name, genre, sub_genre, location, rating, spiciness, display, tbr</param>
        /// <param name="actionType">1 = Insert a book, 2 = Delete a book, 3 = Update a book</param>
        /// <returns></returns>
        private string BuildQueryString(string[] bookInfo, int actionType) {

            string query = "";
            if (actionType == 1) {
                Log("Building insert query...");
                // If we couldn't find the series_id (series doesn't exist yet) create a new series entry
                if (GetSeriesId(bookInfo[2]) == -1) {
                    // Use a ternary operator to use the author id if it can be found, or insert a new author if it can't be found
                    InsertSeries(bookInfo[2], GetAuthorId(bookInfo[1]) != -1 ? GetAuthorId(bookInfo[1]) : InsertAuthor(bookInfo[1]));
                }
                // If we couldn't find the author_id (author doesn't exist yet) create a new author entry
                if (GetAuthorId(bookInfo[1]) == -1) {
                    InsertAuthor(bookInfo[1]);
                }
                query = $"INSERT INTO books " +
                        $"VALUES ({GetAuthorId(bookInfo[1])}, {GetSeriesId(bookInfo[2])}, '{bookInfo[0]}', '{bookInfo[5]}', " +
                        $"'{bookInfo[3]}', '{bookInfo[4]}', {bookInfo[7].Length}, {bookInfo[6].Length}, {bookInfo[8]}, {bookInfo[9]})";

            } else if (actionType == 2) {
                Log("Building delete query...");
                query = $"DELETE FROM books " +
                        $"WHERE title = '{bookInfo[0]}'";

            } else if (actionType == 3) {
                Log("Building update query...");
                int bookId = -1;
                // Get the id of the book we're trying to edit
                try {
                    string bookIdQuery = BuildQueryString(selectedBook.Title, "Search By Title");
                    SqlCommand cmd = new SqlCommand(bookIdQuery, connection);
                    Log($"Sending query to database: {cmd.CommandText}");
                    reader = cmd.ExecuteReader();
                    if (reader.Read()) {
                        Log(reader[0].ToString());
                        bookId = (int)reader[0];
                    }
                    reader.Close();
                    Log($"New Series Name: {bookInfo[2]}");
                    // If we couldn't find the series_id (series doesn't exist yet) create a new series entry
                    if (GetSeriesId(bookInfo[2]) == -1) {
                        Log("Inserting new series");
                        // Use a ternary operator to use the author id if it can be found, or insert a new author if it can't be found
                        InsertSeries(bookInfo[2], GetAuthorId(bookInfo[1]) != -1 ? GetAuthorId(bookInfo[1]) : InsertAuthor(bookInfo[1]));
                    }
                    // If we couldn't find the author_id (author doesn't exist yet) create a new author entry
                    if (GetAuthorId(bookInfo[1]) == -1) {
                        InsertAuthor(bookInfo[1]);
                    }
                    query = $"UPDATE books " +
                        $"SET title = '{bookInfo[0]}', author_id = {GetAuthorId(bookInfo[1])}, series_id = {GetSeriesId(bookInfo[2])}, genre = '{bookInfo[3]}', " +
                        $"sub_genre = '{bookInfo[4]}', location = '{bookInfo[5]}', rating = {bookInfo[6].Length}, spiciness = {bookInfo[7].Length}, is_display = {bookInfo[8]}, " +
                        $"to_be_read = {bookInfo[9]} " +
                        $"WHERE book_id = {bookId}";

                } catch (Exception ex) {
                    Log($"Book id search failed: {ex.Message}", ex.StackTrace);
                }
            }
            return query;
        }
        
        /// <summary>
        /// Opens the book adding dialog and adds the entered book into the database, then searches for that book to validate the entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBookButton_Click(object sender, EventArgs e)
        {
            addBookForm addForm = new addBookForm(this, bookInfoAutocompleteSource);
            if (addForm.ShowDialog(this) == DialogResult.OK) {

                string insertString = BuildQueryString(addForm.BookInfo, 1);
                try {
                    SqlCommand insertCommand = new SqlCommand(insertString, connection);
                    Log($"Sending insert command to database: {insertCommand.CommandText}");
                    int rows = insertCommand.ExecuteNonQuery();
                    Log($"Book insert successful. {rows} rows affected");
                    // Search for the inserted book, validating its existance
                    SqlCommand cmd = new SqlCommand($"SELECT title " +
                                            $"FROM books " +
                                            $"WHERE title = '{addForm.BookInfo[0]}'", connection);
                    reader = cmd.ExecuteReader();
                    if (reader.Read() && reader[0] != null) {
                        Log("Book insert validation successful");
                    }
                    reader.Close();

                    searchButton_Click(sender, e);
                } catch (Exception ex) {
                    Log($"Book insert failed: {ex.Message}", ex.StackTrace);
                    MessageBox.Show(ex.Message, "Book insert failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Removes a book from the database, then searches for the bok to validate that it is gone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            Book toRemove = currentResults[resultsListBox.SelectedIndex];

            if (toRemove != null) {
                DialogResult choice = MessageBox.Show("Are you sure?", $"Deleting {toRemove.Title}", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (choice == DialogResult.Yes) {
                    string deleteString = BuildQueryString(new string[]{toRemove.Title}, 2);
                    try {
                        SqlCommand deleteCommand = new SqlCommand(deleteString, connection);
                        Log($"Sending delete command to database: {deleteCommand.CommandText}");
                        int rows = deleteCommand.ExecuteNonQuery();
                        Log($"Book delete successful. {rows} rows affected");
                        // Search for the inserted book, validating its existance
                        SqlCommand cmd = new SqlCommand($"SELECT title " +
                                                $"FROM books " +
                                                $"WHERE title = '{toRemove.Title}'", connection);
                        reader = cmd.ExecuteReader();
                        if (reader.Read() && reader[0] != null) {
                            Log("Book delete validation successful");
                        }
                        reader.Close();

                        searchButton_Click(sender, e);

                    } catch (Exception ex) {
                        Log($"Book delete failed: {ex.Message}", ex.StackTrace);
                        MessageBox.Show(ex.Message, "Book delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Updates a book in the database, then validates the update by checking that 1 row was updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            editBookForm editForm = new editBookForm(this, selectedBook);
            int selectedIndex = resultsListBox.SelectedIndex;
            if (editForm.ShowDialog(this) == DialogResult.OK) {

                string updateString = BuildQueryString(editForm.BookInfo, 3);
                try {
                    SqlCommand cmd = new SqlCommand (updateString, connection);
                    Log($"Sending update command to database: {cmd.CommandText}");
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 1) {
                        Log($"Book update successful. {rows} row affected");
                    } else {
                        throw new Exception($"Update failed: {rows} rows affected. Should be 1");
                    }
                    // Update the UI to reflect changes
                    searchButton_Click(sender, e);
                    resultsListBox.SelectedIndex = selectedIndex;

                } catch (Exception ex) {
                    Log($"Book update failed: {ex.Message}", ex.StackTrace);
                    MessageBox.Show(ex.Message, "Book update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}