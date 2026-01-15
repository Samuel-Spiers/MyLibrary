namespace MyLibrary
{
    internal class Book
    {
        public int Id {get; set;}
        public int Author_Id {get; set;}
        public int Series_Id {get; set;}
        public string Title {get; set;}
        public string Location {get; set;}
        public string Genre {get; set;}
        public string SubGenre {get; set;}
        public int Spiciness {get; set;}
        public int Rating {get; set;}
        public bool IsDisplay {get; set;}
        public bool ToBeRead {get; set;}

        public Book(int id, int author_id, int series_id, string title, string location, string genre, string subgenre, int spiciness, int rating, bool isDisplay, bool toBeRead) {
            Id = id; 
            Author_Id = author_id; 
            Series_Id = series_id; 
            Title = title; 
            Location = location; 
            Genre = genre; 
            SubGenre = subgenre; 
            Spiciness = spiciness; 
            Rating = rating; 
            IsDisplay = isDisplay; 
            ToBeRead = toBeRead;
        }
    }
}
