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

        public int getMusicTracks(MusicDetails tracks, string ansGenre, int count){
            string aGenre = ansGenre.ToUpper();
            
            MusicDetails obj = new MusicDetails();
            if(tracks.genre == aGenre && tracks.duration != 0.00){
                List<MusicDetails> music = new List<MusicDetails>();
                music.Add(new MusicDetails(tracks.artist,tracks.title,tracks.genre.ToUpper(),tracks.duration,tracks.year));
                Console.WriteLine("Name: "+tracks.artist);
                Console.WriteLine("Title: "+tracks.title);
                Console.WriteLine("Genre: "+tracks.genre);
                Console.WriteLine("Duration: "+tracks.duration);
                Console.WriteLine("Year: "+tracks.year);
                Console.WriteLine();
                count++;
            }
            return count;
        }
    }
}