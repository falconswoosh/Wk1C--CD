using System;
using System.Collections.Generic;

class CD
{
  private string _title;
  private string _artist;
  private int _price;

  public void SetPrice (int newPrice)
  {
    if (newPrice >= 0)
    {
      _price = newPrice;
    }
    else
    {
      Console.WriteLine("The price for this item is not valid.");
    }
  }
  public void GetPrice()
  {
    return _price;
  }
  public void SetTitle(string newTitle)
  {
    _title = newTitle;
  }
  public string GetTitle()
  {
    return _title;
  }
  public void SetArtist(string newArtist)
  {
    _artist = newArtist;
  }
  public string GetArtist()
  {
    return _artist;
  }
  public CD(string newTitle, string newArtist, int newPrice = 10)
  {
    // SetTitle(newTitle);
    // SetArtist(newArtist);
    // SetPrice(newPrice);

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
      Console.WriteLine(album.GetTitle);
      Console.WriteLine("By " + album.GetArtist);
      Console.WriteLine("Price: $" + album.GetPrice);
    }
  }
}
}
