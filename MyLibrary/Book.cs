namespace MyLibrary
{
    public class Book
    {
        public int Id {get;}
        public int Author_Id {get;}
        public int Series_Id {get;}
        public string Title {get;}
        public string Location {get;}
        public string Genre {get;}
        public string SubGenre {get;}
        public int Spiciness {get;}
        public int Rating {get;}
        public bool IsDisplay {get;}
        public bool ToBeRead {get;}

        public Book(int id, int author_id, int series_id, string title, string location, string genre, 
                    string subgenre, int spiciness, int rating, bool isDisplay, bool toBeRead) {
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
