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
      Vendor newVendor = new Vendor("name", "phone", "address");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetNameAndAbout_ReturnsNameAndAbout_String()
    {
      string name = "Ben's Bakery";
      string address = "Chicago, Il.";
      string phone = "123";
      Vendor newVendor = new Vendor(name, phone , address);
      string resultName = newVendor.Name; 
      string resultAddress = newVendor.Address; 
      string resultPhone = newVendor.Phone;
      Assert.AreEqual(name, resultName );
      Assert.AreEqual(address, resultAddress);
      Assert.AreEqual(phone, resultPhone);

    }
    [TestMethod]

    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Teresa"; 
      string address = "Chicago, Il.";
      string phone = "123";
      Vendor newVendor = new Vendor(name, address, phone);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObejcts_VendorList()
    {
      string name1 = "Teresa"; 
      string address1 = "Chicago, Il.";  
      string phone1 = "123";
      string name2 = "Ben's Bakery";
      string address2 = "Chicago, Il.";  
      string phone2 = "12345";
      Vendor newVendor1 = new Vendor(name1, address1, phone1);
      Vendor newVendor2 = new Vendor (name2, address2, phone2);
      List<Vendor> newList = new List <Vendor> {newVendor1, newVendor2};
      List <Vendor> result = Vendor.GetAll(); 
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Teresa"; 
      string address1 = "Chicago, Il.";  
      string phone1 = "123";
      string name2 = "Ben's Bakery";
      string address2 = "Chicago, Il.";  
      string phone2 = "12345";
      Vendor newVendor1 = new Vendor(name1, address1, phone1);
      Vendor newVendor2 = new Vendor (name2, address2, phone2);
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(newVendor1, result);
    }
    
    [TestMethod]
    public void AddOrder_AssoicatesOrderWithVendor_OrderList()
    {
      string title = "Mary's Cakes";
      string quantity = "5 yellow cakes";
      string price = "$444";
      string typeBakedGood = "cake";
      string dateCreated = "2/2/2020";
      Order newOrder = new Order(title, quantity, price, typeBakedGood, dateCreated);
      List<Order> newList = new List<Order> { newOrder };
      string name1 = "Teresa"; 
      string address1 = "Chicago, Il.";  
      string phone1 = "123";
      Vendor newVendor = new Vendor(name1, address1, phone1);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);

    }

    
  }
}