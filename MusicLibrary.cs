namespace MusicLibrary
{
    class MusicDetails
    {
        public string artist{get; set;}
        public string title{get; set;}
        public string genre{get; set;}
        public double duration{get; set;}
        public int year{get; set;}

        public MusicDetails()
        {
            this.artist = null;
            this.title = null;
            this.genre = null;
            this.duration = 0.00;
            this.year = 0;
        }

        public MusicDetails(string a, string t, string g, double d, int y){
            artist = a;
            title = t;
            genre = g;
            duration = d;
            year = y;
        }
    }
}