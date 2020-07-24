using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryManagementApp.Models;
using System.Collections.Generic;
using System;

namespace BakeryManagementApp.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "about");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetNameAndAbout_ReturnsNameAndAbout_String()
    {
      string name = "Ben's Bakery";
      string about = "Chicago, Il.";
      Vendor newVendor = new Vendor(name, about);
      string resultName = newVendor.Name; 
      string resultAbout = newVendor.About; 
      Assert.AreEqual(name, resultName );
      Assert.AreEqual(about, resultAbout);

    }
    [TestMethod]

    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Teresa"; 
      string about = "Chicago, Il.";
      Vendor newVendor = new Vendor(name, about);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObejcts_VendorList()
    {
      string name1 = "Teresa"; 
      string about1 = "Chicago, Il.";  
      string name2 = "Ben's Bakery";
      string about2 = "Chicago, Il.";  
      Vendor newVendor1 = new Vendor(name1, about1);
      Vendor newVendor2 = new Vendor (name2, about2);
      List<Vendor> newList = new List <Vendor> {newVendor1, newVendor2};
      List <Vendor> result = Vendor.GetAll(); 
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Teresa"; 
      string about1 = "Chicago, Il.";  
      string name2 = "Ben's Bakery";
      string about2 = "Chicago, Il."; 
      Vendor newVendor1 = new Vendor(name1, about1);
      Vendor newVendor2 = new Vendor (name2, about2);
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(newVendor1, result);
    }
    
    [TestMethod]
    public void AddOrder_AssoicatesOrderWithVendor_OrderList()
    {
      string title = "Mary's Cakes";
      string description = "5 yellow cakes";
      string price = "$444";
      Order newOrder = new Order (title, description, price);
      List<Order> newList = new List<Order> { newOrder };
      string name1 = "Teresa"; 
      string about1 = "Chicago, Il.";
      Vendor newVendor = new Vendor (name1, about1);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);

    }

    
  }
}