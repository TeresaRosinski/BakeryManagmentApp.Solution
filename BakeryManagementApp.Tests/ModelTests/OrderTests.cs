using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryManagementApp.Models;
using System;

namespace BakeryManagementApp.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

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
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title = "Mary's Cakes";
      string description = "5 yellow cakes";
      string price = "$444";
      string title2 = "Ben's Cakes";
      string description2 = "8 yellow cakes";
      string price2 = "$888";
      Order newOrder = new Order(title, description, price);
      Order newOrder2 = new Order(title2, description2, price2);
      List<Order> newList = new List<Order> { newOrder, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }


    
  }
}