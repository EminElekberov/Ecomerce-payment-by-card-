#pragma checksum "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7353dfdce20858a82bf8a893ae488356f2ddb5bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7353dfdce20858a82bf8a893ae488356f2ddb5bb", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f95b4fb5ec29f5737528b843ae3161f495c5b95", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container pb-5\">\r\n\r\n    <h2>Yeni Ürün</h2>\r\n    <hr />\r\n    <p>\r\n        ");
#nullable restore
#line 14 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
   Write(Html.ActionLink("Yeni Ürün", "Create", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <hr />\r\n    <table class=\"table table-bordered table-striped\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsApproved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width: 140px;\"></th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 37 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1057, "\"", 1082, 2);
            WriteAttributeValue("", 1063, "/Upload/", 1063, 8, true);
#nullable restore
#line 41 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
WriteAttributeValue("", 1071, item.Image, 1071, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70\" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 50 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
                     if (item.IsHome)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"badge badge-success\">\r\n                            <i class=\"fa fa-check-circle-o\" aria-hidden=\"true\"></i>\r\n                            Evet\r\n                        </label>\r\n");
#nullable restore
#line 56 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"badge badge-danger\">\r\n                            <i class=\"fa fa-check-circle-o\" aria-hidden=\"true\"></i>\r\n                            Hayır\r\n                        </label>\r\n");
#nullable restore
#line 63 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 66 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
                     if (item.IsApproved)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"badge badge-success\">\r\n                            <i class=\"fa fa-check-circle-o\" aria-hidden=\"true\"></i>\r\n                            Evet\r\n                        </label>\r\n");
#nullable restore
#line 72 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"badge badge-danger\">\r\n                            <i class=\"fa fa-check-circle-o\" aria-hidden=\"true\"></i>\r\n                            Hayır\r\n                        </label>\r\n");
#nullable restore
#line 79 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
               Write(Html.ActionLink("Güncelle", "Edit", new { id = item.Id }, new { @class = "btn btn-primary btn-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 83 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
               Write(Html.ActionLink("Sil", "Delete", new { id = item.Id }, new { @class = "btn btn-danger btn-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 86 "D:\pragmateck\CardsShop\CardsShop\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
