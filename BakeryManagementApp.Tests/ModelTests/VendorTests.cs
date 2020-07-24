using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryManagementApp.Models;
using System.Collections.Generic;
using System;

namespace BakeryManagementApp.Tests
{
  [TestClass]
  public class VendorTest //: IDisposable
  {

  //   public void Dispose()
  //   {
  //     Vendor.ClearAll();
  //   }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    
  }
}