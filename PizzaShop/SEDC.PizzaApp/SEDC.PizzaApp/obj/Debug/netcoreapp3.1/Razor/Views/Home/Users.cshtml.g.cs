#pragma checksum "C:\Users\Com\Desktop\SEDC-Homework-ASP.NET-MVC\PizzaShop\SEDC.PizzaApp\SEDC.PizzaApp\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aa5893f6fda911e19d45dacbb88d761b7a13703"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
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
#line 1 "C:\Users\Com\Desktop\SEDC-Homework-ASP.NET-MVC\PizzaShop\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Com\Desktop\SEDC-Homework-ASP.NET-MVC\PizzaShop\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Com\Desktop\SEDC-Homework-ASP.NET-MVC\PizzaShop\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Com\Desktop\SEDC-Homework-ASP.NET-MVC\PizzaShop\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa5893f6fda911e19d45dacbb88d761b7a13703", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72e92adf7f1c49aca918f15f844bb3fd8dc58c8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>User details:</h2>\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Com\Desktop\SEDC-Homework-ASP.NET-MVC\PizzaShop\SEDC.PizzaApp\SEDC.PizzaApp\Views\Home\Users.cshtml"
  
    foreach (UserDetailsViewModel user in @ViewBag.Users)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Full name: ");
#nullable restore
#line 6 "C:\Users\Com\Desktop\SEDC-Homework-ASP.NET-MVC\PizzaShop\SEDC.PizzaApp\SEDC.PizzaApp\Views\Home\Users.cshtml"
                 Write(user.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small>Address: ");
#nullable restore
#line 6 "C:\Users\Com\Desktop\SEDC-Homework-ASP.NET-MVC\PizzaShop\SEDC.PizzaApp\SEDC.PizzaApp\Views\Home\Users.cshtml"
                                                    Write(user.UserAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n");
#nullable restore
#line 7 "C:\Users\Com\Desktop\SEDC-Homework-ASP.NET-MVC\PizzaShop\SEDC.PizzaApp\SEDC.PizzaApp\Views\Home\Users.cshtml"
    }

#line default
#line hidden
#nullable disable
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