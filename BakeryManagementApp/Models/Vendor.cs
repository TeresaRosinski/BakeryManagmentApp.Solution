using System.Collections.Generic;

namespace BakeryManagementApp.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List <Vendor> { };
    public string Name; 
    public string Phone; 

    public string Address; 

    public int Id {get; }
    
    public List<Order> Orders {get; set; }

    public Vendor (string vendorName, string vendorPhone, string vendorAddress)
    {
      Name = vendorName; 
      Phone = vendorPhone;
      Address = vendorAddress;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List <Order> { };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List <Vendor> GetAll()
    {
      return _instances; 
    }

    public static Vendor Find (int searchId)
    {
      return _instances[searchId - 1];
    }

    public void AddOrder( Order order)
    {
      Orders.Add(order);
    }
  }
}