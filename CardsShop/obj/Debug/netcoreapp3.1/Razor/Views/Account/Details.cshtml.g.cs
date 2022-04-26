#pragma checksum "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2317ad1455688f74d9de8b43cc26992206fda73e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Details), @"mvc.1.0.view", @"/Views/Account/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2317ad1455688f74d9de8b43cc26992206fda73e", @"/Views/Account/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f95b4fb5ec29f5737528b843ae3161f495c5b95", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">

            <h2>Sipariş Detay Bilgileri</h2>
            <hr />

            <dl class=""row"">

                <dt class=""col-sm-3"">Order State</dt>
                <dd class=""col-sm-9"">
");
#nullable restore
#line 17 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                     if (Model.OrderState == EnumOrderState.Waiting)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge-danger\">Onay Bekliyor</span>\r\n");
#nullable restore
#line 20 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                    }
                    else if (Model.OrderState == EnumOrderState.Completed)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge-success\">Sipariş Tamamlandı.</span>\r\n");
#nullable restore
#line 24 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </dd>\r\n\r\n                <dt class=\"col-sm-3\">Order Id</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 28 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                                Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                <dt class=\"col-sm-3\">Order Number</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 31 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                                Write(Model.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                <dt class=\"col-sm-3\">Total</dt>\r\n                <dd class=\"col-sm-9\">\r\n                    <i class=\"fa fa-try\" aria-hidden=\"true\"></i>\r\n                    ");
#nullable restore
#line 36 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
               Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n\r\n                <dt class=\"col-sm-3\">Order Date</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 40 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                                Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n\r\n                <dt class=\"col-sm-3\">Adres</dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 45 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
               Write(Model.AdresBasligi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <hr />\r\n                    ");
#nullable restore
#line 47 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
               Write(Model.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 49 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
               Write(Model.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 49 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                              Write(Model.Semt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 49 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                                            Write(Model.Mahalle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 51 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
               Write(Model.PostaKodu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </dd>

                <dt class=""col-sm-3"">Products</dt>
                <dd class=""col-sm-9"">
                    <table class=""table table-bordered"">

                        <thead>
                            <tr>
                                <th>Image</th>
                                <th style=""width: 45%;"">Product Name</th>
                                <th>Quantity</th>
                                <th>Price</th>
                                <th style=""width: 10%;""></th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 69 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                             foreach (var item in Model.Orderlines)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2529, "\"", 2554, 2);
            WriteAttributeValue("", 2535, "/Upload/", 2535, 8, true);
#nullable restore
#line 73 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
WriteAttributeValue("", 2543, item.Image, 2543, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70\" />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 76 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 79 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <i class=\"fa fa-try\" aria-hidden=\"true\"></i>\r\n                                        ");
#nullable restore
#line 83 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3207, "\"", 3243, 2);
            WriteAttributeValue("", 3214, "/Home/Details/", 3214, 14, true);
#nullable restore
#line 86 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
WriteAttributeValue("", 3228, item.ProductId, 3228, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-sm"" target=""_blank"">
                                            <i class=""fa fa-angle-double-right"" aria-hidden=""true""></i>
                                            Product Details
                                        </a>
                                    </td>
                                </tr>
");
#nullable restore
#line 92 "D:\pragmateck\CardsShop\CardsShop\Views\Account\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </dd>\r\n\r\n            </dl>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
