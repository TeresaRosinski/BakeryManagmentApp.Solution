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

    
  }
}