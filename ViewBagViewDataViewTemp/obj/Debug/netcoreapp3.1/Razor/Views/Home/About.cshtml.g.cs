#pragma checksum "C:\Users\User\Desktop\ViewBagViewDataViewTemp\ViewBagViewDataViewTemp\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cd7dc1e50772179c9e6ac9ab10b37c1be2ac58b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\Desktop\ViewBagViewDataViewTemp\ViewBagViewDataViewTemp\Views\_ViewImports.cshtml"
using ViewBagViewDataViewTemp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd7dc1e50772179c9e6ac9ab10b37c1be2ac58b", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c2589a4809f350caf405bbbe8e61aa1296517c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\ViewBagViewDataViewTemp\ViewBagViewDataViewTemp\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"/home/index\">Go to home</a>\r\n<h1>About</h1>\r\n\r\n\r\n<p>tempdata=>");
#nullable restore
#line 10 "C:\Users\User\Desktop\ViewBagViewDataViewTemp\ViewBagViewDataViewTemp\Views\Home\About.cshtml"
        Write(TempData["Age"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>viewbag=>");
#nullable restore
#line 11 "C:\Users\User\Desktop\ViewBagViewDataViewTemp\ViewBagViewDataViewTemp\Views\Home\About.cshtml"
       Write(ViewBag.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>viewdata=>");
#nullable restore
#line 12 "C:\Users\User\Desktop\ViewBagViewDataViewTemp\ViewBagViewDataViewTemp\Views\Home\About.cshtml"
        Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
