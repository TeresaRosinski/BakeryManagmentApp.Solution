using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryManagementApp.Models;
using System;

namespace BakeryManagementApp.Tests
{
  [TestClass]
  public class OrderTest //: //IDisposable
  {

    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Cake Off", "2 cakes", "$450");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitleDescriptionPrice_ReturnsTitleDescriptionPrice_String()
    {
      string title = "Mary's Cakes";
      string description = "5 yellow cakes";
      string price = "$444";
      Order newOrder = new Order(title, description, price);
      string resultTitle = newOrder.Title; 
      string resultDescription = newOrder.Description;
      string resultPrice = newOrder.Price; 
      Assert.AreEqual(title, resultTitle);
      Assert.AreEqual(description, resultDescription);
      Assert.AreEqual(price, resultPrice);
    }

    
  }
}