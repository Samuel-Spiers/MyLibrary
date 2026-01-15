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

namespace MyLibrary
{
    public partial class mainForm : Form
    {
        SqlConnection connection;
        SqlDataReader reader;
        List<Book> books = new List<Book>();
        List<Author> authors = new List<Author>();
        List<Series> series = new List<Series>();
        List<string> log = new List<string>();
        int logLine = 0;

        public mainForm()
        {
            InitializeComponent();
            genreComboBox.SelectedIndex = 0;
            subGenreComboBox.SelectedIndex = 0;
            authorComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Prepare the initial form state on launch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_Load(object sender, EventArgs e)
        {
            // Attempt to establish the database connection
            try {
                Log("Attempting to establish database connection...");
                Log(@"Connection string: @""Data Source=.\SQLEXPRESS;Initial Catalog=library;Integrated Security=True""");
                connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
                connection.Open();
                Log("Connection successful");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Database connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Connection failed. Error Description:");
                Log(ex.Message);
            }

            // Get the total number of books in the database
            try {
                SqlCommand command = new SqlCommand("SELECT * " +
                                                    "FROM books", connection);
                log.Add($"Sending query to database: {command.CommandText}");
                reader = command.ExecuteReader();
                int bookCount = 0;
                while (reader.Read()) {
                     bookCount++;
                }
                reader.Close();
                log.Add($"Query Success. Book Count: {bookCount}");
                librarySizeLabel.Text = $"You have {bookCount} books in your library";

            } catch (Exception ex) {
                log.Add($"Startup database query failed: {ex.Message}");
            }
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
            log.Add($"{logLine} | {msg}");
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

            // Get the list of books that match the search, and their respective authors
            List<Book> bookList = QueryDatabaseBooks(search);
            List<Author> authorList = QueryDatabaseAuthors(bookList);

            // Display the results in the resultsListBox
            int index = 0;
            foreach (Book book in bookList) {
                resultsListBox.Items.Add($"{index+1}. {book.Title} By {authorList[index].FirstName} {authorList[index].LastName}");
                index++;
            }
        }

        /// <summary>
        /// Queries the database for a list of books based on a given search string
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        private List<Book> QueryDatabaseBooks(string search) {

            List<Book> results = new List<Book>();
            string formattedSearch = "%" + search + "%";
            
            // Prepare the SQL command
            try {
                SqlCommand command = new SqlCommand("SELECT * " +
                                                    "FROM books " +
                                                   $"WHERE title LIKE @Search", connection);
                command.Parameters.AddWithValue("@Search", formattedSearch);
                log.Add($"Sending query to database: {command.CommandText}");
                reader = command.ExecuteReader();
                // Read the query results into the book list
                while (reader.Read()) {
                    results.Add(new Book((int)reader[0], (int)reader[1], (int)reader[2], reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), (int)reader[7], (int)reader[8], (bool)reader[9], (bool)reader[10]));
                }
                reader.Close();

            } catch (Exception ex) {
                log.Add($"Database query failed: {ex.Message}");
            }
            return results;
        }

        /// <summary>
        /// Query the database for a list of authors based on a list of books
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        private List<Author> QueryDatabaseAuthors(List<Book> books) {

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
                                                    "FROM authors a " +
                                                   $"WHERE a.author_id IN ({authorIds})", connection);
                log.Add($"Sending query to database: {command.CommandText}");

                // Query the database to find the authors and read the output into an array
                reader = command.ExecuteReader();
                // Read the query results into the author list
                while (reader.Read()) {
                    results.Add(new Author((int)reader[0], (string)reader[1], (string)reader[2]));
                }
                reader.Close();

            } catch (Exception ex) {
                log.Add($"Database query failed: {ex.Message}");
            }
            return results;
        }
    }
}
