// See https://aka.ms/new-console-template for more information
using System;

namespace MusicLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello World!");    
      // // Type your username and press enter
      // Console.Write("Enter username: ");

      // // Create a string variable and get user input from the keyboard and store it in the variable
      // string userName = Console.ReadLine();

      // // Print the value of the variable (userName), which will display the input value
      // Console.WriteLine("Username is: " + userName);

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

        mscDetails.Add(new MusicDetails(name,title,genre,duration,year));
      }while(answer == "YES" || answer == "yes");
    
      foreach(MusicDetails items in mscDetails){
        Console.WriteLine("Name: "+items.artist);
        Console.WriteLine("Title: "+items.title);
        Console.WriteLine("Genre: "+items.genre);
        Console.WriteLine("Duration: "+items.duration);
        Console.WriteLine("Year: "+items.year);
        Console.WriteLine();
      }
    }
  }
}
