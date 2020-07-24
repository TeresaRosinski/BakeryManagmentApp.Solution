using System.Collections.Generic;

namespace BakeryManagementApp.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List <Vendor> { };
    public string Name; 
    public string About; 

    public int Id {get; }
    
    public List<Order> Order {get; set; }

    public Vendor (string vendorName, string vendorAbout)
    {
      Name = vendorName; 
      About = vendorAbout;
      
    }
  }
}