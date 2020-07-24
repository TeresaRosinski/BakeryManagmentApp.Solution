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
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    
  }
}