namespace MyLibrary
{
    internal class Series
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int Author_Id {get; set;}

        public Series(int id, string seriesName, int authorId) {
            Id = id;
            Name = seriesName;
            Author_Id = authorId;
        }
    }
}
