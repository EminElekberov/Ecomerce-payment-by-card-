#pragma checksum "D:\pragmateck\CardsShop\CardsShop\Views\Home\GetCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b232494a986961959296dc4c9f13d05ad0db2396"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetCategories), @"mvc.1.0.view", @"/Views/Home/GetCategories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b232494a986961959296dc4c9f13d05ad0db2396", @"/Views/Home/GetCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f95b4fb5ec29f5737528b843ae3161f495c5b95", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<ul class=\"list-group\">\r\n\r\n    <a href=\"/Home/List\" class=\"list-group-item\">\r\n        <i class=\"fa fa-angle-double-right\" aria-hidden=\"true\"></i>\r\n        T??m Kategoriler\r\n    </a>\r\n\r\n");
#nullable restore
#line 11 "D:\pragmateck\CardsShop\CardsShop\Views\Home\GetCategories.cshtml"
     foreach (var item in Model)
    {
        
                //se??ilen kategori ile route id si birbirine e??it.

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 355, "\"", 381, 2);
            WriteAttributeValue("", 362, "/Home/List/", 362, 11, true);
#nullable restore
#line 15 "D:\pragmateck\CardsShop\CardsShop\Views\Home\GetCategories.cshtml"
WriteAttributeValue("", 373, item.Id, 373, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item active\">\r\n                    <i class=\"fa fa-angle-double-right\" aria-hidden=\"true\"></i>\r\n                    ");
#nullable restore
#line 17 "D:\pragmateck\CardsShop\CardsShop\Views\Home\GetCategories.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n");
#nullable restore
#line 19 "D:\pragmateck\CardsShop\CardsShop\Views\Home\GetCategories.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
