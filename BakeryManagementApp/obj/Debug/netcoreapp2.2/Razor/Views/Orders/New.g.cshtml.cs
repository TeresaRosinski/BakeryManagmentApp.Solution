#pragma checksum "/Users/teresarosinski/Desktop/BakeryManagementApp.Solution/BakeryManagementApp/Views/Orders/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91002b32c4a06300cfd7cb2515831975d9a1ac39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_New), @"mvc.1.0.view", @"/Views/Orders/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/New.cshtml", typeof(AspNetCore.Views_Orders_New))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91002b32c4a06300cfd7cb2515831975d9a1ac39", @"/Views/Orders/New.cshtml")]
    public class Views_Orders_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/teresarosinski/Desktop/BakeryManagementApp.Solution/BakeryManagementApp/Views/Orders/New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 24, true);
            WriteLiteral("\n<h1>Add a new order to ");
            EndContext();
            BeginContext(52, 10, false);
#line 5 "/Users/teresarosinski/Desktop/BakeryManagementApp.Solution/BakeryManagementApp/Views/Orders/New.cshtml"
                  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(62, 12, true);
            WriteLiteral("</h1>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 74, "\"", 108, 3);
            WriteAttributeValue("", 83, "/vendors/", 83, 9, true);
#line 7 "/Users/teresarosinski/Desktop/BakeryManagementApp.Solution/BakeryManagementApp/Views/Orders/New.cshtml"
WriteAttributeValue("", 92, Model.Id, 92, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 101, "/orders", 101, 7, true);
            EndWriteAttribute();
            BeginContext(109, 68, true);
            WriteLiteral(" method=\"post\">\n  <input id=\"vendorId\" name=\"vendorId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 177, "\"", 194, 1);
#line 8 "/Users/teresarosinski/Desktop/BakeryManagementApp.Solution/BakeryManagementApp/Views/Orders/New.cshtml"
WriteAttributeValue("", 185, Model.Id, 185, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(195, 174, true);
            WriteLiteral(">\n  <label for=\"orderDescription\">Order Details</label>\n  <input id=\"orderDescription\" name=\"orderDescription\" type=\"text\">\n  <button type=\'submit\'>Add order</button>\n</form>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
