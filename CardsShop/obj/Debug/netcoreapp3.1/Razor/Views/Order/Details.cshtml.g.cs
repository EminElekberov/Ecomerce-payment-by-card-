#pragma checksum "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a173c2f97cdb6e27e6f610a3910ad85ceb157120"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a173c2f97cdb6e27e6f610a3910ad85ceb157120", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f95b4fb5ec29f5737528b843ae3161f495c5b95", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n\r\n            <h2>Sipariş Detay Bilgileri</h2>\r\n            <hr />\r\n");
#nullable restore
#line 13 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
             if (TempData["message"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-success\">\r\n                    ");
#nullable restore
#line 16 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
               Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 18 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <dl class=\"row\">\r\n\r\n\r\n                <dt class=\"col-sm-3\">Username</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 24 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                                Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <dd>\r\n\r\n                <dt class=\"col-sm-3\">Order State</dt>\r\n                <dd class=\"col-sm-9\">\r\n\r\n");
#nullable restore
#line 30 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                     using (Html.BeginForm("UpdateOrderState", "Order", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                   Write(Html.HiddenFor(i => i.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <dl class=\"row\">\r\n                            <dt class=\"col-sm-8\">\r\n                                ");
#nullable restore
#line 36 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                           Write(Html.EnumDropDownListFor(i => i.OrderState, "Select Order State", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-4\">\r\n                                <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n                            </dd>\r\n                        </dl>\r\n");
#nullable restore
#line 42 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n\r\n                <dt class=\"col-sm-3\">Order Id</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 47 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                                Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                <dt class=\"col-sm-3\">Order Number</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 50 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                                Write(Model.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                <dt class=\"col-sm-3\">Total</dt>\r\n                <dd class=\"col-sm-9\">\r\n                    <i class=\"fa fa-try\" aria-hidden=\"true\"></i>\r\n                    ");
#nullable restore
#line 55 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
               Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n\r\n                <dt class=\"col-sm-3\">Order Date</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 59 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                                Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n\r\n                <dt class=\"col-sm-3\">Adres</dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 64 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
               Write(Model.AdresBasligi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <hr />\r\n                    ");
#nullable restore
#line 66 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
               Write(Model.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 68 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
               Write(Model.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 68 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                              Write(Model.Semt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 68 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                                            Write(Model.Mahalle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 70 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
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
#line 88 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                             foreach (var item in Model.Orderlines)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3189, "\"", 3214, 2);
            WriteAttributeValue("", 3195, "/Upload/", 3195, 8, true);
#nullable restore
#line 92 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
WriteAttributeValue("", 3203, item.Image, 3203, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70\" />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 95 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 98 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <i class=\"fa fa-try\" aria-hidden=\"true\"></i>\r\n                                        ");
#nullable restore
#line 102 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3867, "\"", 3903, 2);
            WriteAttributeValue("", 3874, "/Home/Details/", 3874, 14, true);
#nullable restore
#line 105 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
WriteAttributeValue("", 3888, item.ProductId, 3888, 15, false);

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
#line 111 "D:\pragmateck\CardsShop\CardsShop\Views\Order\Details.cshtml"
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
