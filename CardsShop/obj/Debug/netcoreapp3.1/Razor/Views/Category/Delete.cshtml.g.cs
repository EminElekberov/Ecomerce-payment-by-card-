#pragma checksum "D:\pragmateck\CardsShop\CardsShop\Views\Category\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90a8aa924bb2f7d5150098f80de64b1d358521e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Delete), @"mvc.1.0.view", @"/Views/Category/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\pragmateck\CardsShop\CardsShop\Views\_ViewImports.cshtml"
using CardsShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pragmateck\CardsShop\CardsShop\Views\_ViewImports.cshtml"
using CardsShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\pragmateck\CardsShop\CardsShop\Views\_ViewImports.cshtml"
using Microsoft.Net.Http.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\pragmateck\CardsShop\CardsShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90a8aa924bb2f7d5150098f80de64b1d358521e3", @"/Views/Category/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f95b4fb5ec29f5737528b843ae3161f495c5b95", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\pragmateck\CardsShop\CardsShop\Views\Category\Delete.cshtml"
  
    ViewBag.Title = "Delete";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container pb-5\">\r\n    <h2>Kategoriyi silmek istediğinizden emin misiniz ?</h2>\r\n    <hr />\r\n\r\n    <div>\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
#nullable restore
#line 15 "D:\pragmateck\CardsShop\CardsShop\Views\Category\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 19 "D:\pragmateck\CardsShop\CardsShop\Views\Category\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 23 "D:\pragmateck\CardsShop\CardsShop\Views\Category\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 27 "D:\pragmateck\CardsShop\CardsShop\Views\Category\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n\r\n");
#nullable restore
#line 32 "D:\pragmateck\CardsShop\CardsShop\Views\Category\Delete.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\pragmateck\CardsShop\CardsShop\Views\Category\Delete.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-actions no-color\">\r\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                ");
#nullable restore
#line 38 "D:\pragmateck\CardsShop\CardsShop\Views\Category\Delete.cshtml"
           Write(Html.ActionLink("Back to List", "Index", null, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 40 "D:\pragmateck\CardsShop\CardsShop\Views\Category\Delete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
