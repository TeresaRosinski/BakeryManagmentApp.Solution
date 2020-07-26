using System.Collections.Generic;

namespace BakeryManagementApp.Models
{
  public class Order
  {
    public string Title {get; set;}

    public string BakedGoodType {get; set;}
    public string Quantity {get; set;}
    public string Price {get; set;}
    public string Date {get; set;}

    public int Id {get; }

    private static List<Order> _instances = new List <Order> { };

    public Order (string title, string quantity, string price,  string bakedGoodType,  string date)
    {
      Title = title;
      Quantity = quantity; 
      Price = price;
      BakedGoodType = bakedGoodType; 
      Date = date; 
      _instances.Add(this);
      Id = _instances.Count; 
    }
    
    public static List<Order> GetAll()
    {
      return _instances; 
    }

    public static void ClearAll()
    {
      _instances.Clear(); 
    }

    public static Order Find (int searchId)
    {
      return _instances[searchId -1];
    }

  }

}