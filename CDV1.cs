using System;
using System.Collections.Generic;

class CD
{
  public string Title;
  public string Artist;
  public int Price;

  public CD(string albumTitle, string albumArtist, int albumPrice = 10)
  {
    Title = albumTitle;
    Artist = albumArtist;
    Price = albumPrice;
  }
public class Program
{
  public static void Main()
  {
    CD firstCD = new CD("Master of Reality", "black Sabbath");
    CD secondCD = new CD("Electric Ladyland", "Jimi Hendrix");
    CD thirdCD = new CD("Nevermind", "Nirvana");
    CD fourthCD = new CD("I Don't Get It", "Pork Lion", 50);

    List<CD> CDs = new List<CD>() { firstCD, secondCD, thirdCD, fourthCD };

    foreach (CD album in CDs)
    {
      Console.WriteLine(album.Title);
      Console.WriteLine("By " + album.Artist);
      Console.WriteLine("Price: $" + album.Price);
    }
  }
}
}
