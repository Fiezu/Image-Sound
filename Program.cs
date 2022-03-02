// See https://aka.ms/new-console-template for more information
using System;

namespace MusicLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      List<MusicDetails> mscDetails = new List<MusicDetails>();
      string answer;
      do{
        Console.Write("Enter Name of the Artist: ");
        string name = Console.ReadLine();
        Console.Write("Enter Ttile of the song: ");
        string title = Console.ReadLine();
        Console.Write("Enter Genre of the song: ");
        string genre = Console.ReadLine();
        Console.Write("Enter the Duration of the song: ");
        double duration = Double.Parse(Console.ReadLine());
        Console.Write("Enter the year of the song: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Do you want to add more songs? (Yes/No): ");
        answer = Console.ReadLine();

        mscDetails.Add(new MusicDetails(name,title,genre.ToUpper(),duration,year));
      }while(answer.ToUpper() == "YES");

      Console.WriteLine();
      foreach(MusicDetails items in mscDetails){
        Console.WriteLine("Name: "+items.artist);
        Console.WriteLine("Title: "+items.title);
        Console.WriteLine("Genre: "+items.genre);
        Console.WriteLine("Duration: "+items.duration);
        Console.WriteLine("Year: "+items.year);
        Console.WriteLine();
      }
      Console.WriteLine("Lists of genres inside the list: ");
      foreach(MusicDetails items in mscDetails){
        Console.WriteLine(items.genre);
      }
      string ansGenre;
      Console.Write("Please enter what genre would you like based on the lists above: ");
      ansGenre = Console.ReadLine();
      bool identifyGenre = false;
      int count = 0;

      Console.WriteLine("Here are the lists of "+ansGenre);
      foreach(MusicDetails items in mscDetails){
        count = items.getMusicTracks(items, ansGenre, count);
      }
      if(count == 0)
        Console.WriteLine("Genre "+ansGenre+" in not the lists!");
    }
  }
}
