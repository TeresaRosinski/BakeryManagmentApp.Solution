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
      Order newOrder = new Order("Cake Off", "2 cakes", "$450", "Cake", "2/22/2020");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitleDescriptionPrice_ReturnsTitleDescriptionPrice_String()
    {
      string title = "Mary's Cakes";
      string quantity = "5";
      string price = "$444";
      string typeBakedGood = "cake";
      string dateCreated = "2/2/2020";
      Order newOrder = new Order(title, quantity, price, typeBakedGood, dateCreated);
      string resultTitle = newOrder.Title; 
      string resultQuantity = newOrder.Quantity;
      string resultPrice = newOrder.Price; 
      string resultBakedGood = newOrder.BakedGoodType;
      string resultDate = newOrder.Date;
      Assert.AreEqual(title, resultTitle);
      Assert.AreEqual(quantity, resultQuantity);
      Assert.AreEqual(price, resultPrice);
      Assert.AreEqual(typeBakedGood, resultBakedGood);
      Assert.AreEqual(dateCreated, resultDate);

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
      string quantity = "5";
      string price = "$444";
      string typeBakedGood = "cake";
      string dateCreated = "2/2/2020";
      string title2 = "Ben's Cakes";
      string quantity2 = "8 yellow cakes";
      string price2 = "$888";
      string typeBakedGood2 = "cake2";
      string dateCreated2 = "2/3/2020";
      Order newOrder = new Order(title, quantity, price, typeBakedGood, dateCreated);
      Order newOrder2 = new Order(title2, quantity2, price2, typeBakedGood2, dateCreated2);
      List<Order> newList = new List<Order> { newOrder, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "Mary's Cakes";
      string quantity = "5 yellow cakes";
      string price = "$444";
      string typeBakedGood = "cake";
      string dateCreated = "2/2/2020";
      Order newOrder = new Order(title, quantity, price, typeBakedGood, dateCreated);
      int result = newOrder.Id; 
      Assert.AreEqual(1,result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title = "Mary's Cakes";
      string quantity = "5";
      string price = "$444";
      string typeBakedGood = "cake";
      string dateCreated = "2/2/2020";
      string title2 = "Ben's Cakes";
      string quantity2 = "8 yellow cakes";
      string price2 = "$888";
      string typeBakedGood2 = "cake2";
      string dateCreated2 = "2/3/2020";
      Order newOrder = new Order(title, quantity, price, typeBakedGood, dateCreated);
      Order newOrder2 = new Order(title2, quantity2, price2, typeBakedGood2, dateCreated2);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}