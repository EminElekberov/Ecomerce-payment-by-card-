#pragma checksum "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0a85606ca9d12b8cdec9bc922517761a87da4d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0a85606ca9d12b8cdec9bc922517761a87da4d5", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f95b4fb5ec29f5737528b843ae3161f495c5b95", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShippingDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"
  
    ViewBag.Title = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .field-validation-error {
        color: #f00;
    }

    .field-validation-valid {
        display: none;
    }

    .input-validation-error {
        border: 1px solid #f00;
        background-color: #fee;
    }

    .validation-summary-errors {
        font-weight: bold;
        color: #f00;
    }

    .validation-summary-valid {
        display: none;
    }
</style>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <h2>Sipariş Bilgileriniz</h2>
            <p>Lütfen sipariş bilgilerinizi doldurunuz.</p>
            <hr />

");
#nullable restore
#line 37 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-group row"">
                    <label for=""inputEmail3"" class=""col-sm-2 col-form-label"">Username</label>
                    <div class=""col-sm-6"">
                        <span class=""badge-danger"">
                            ");
#nullable restore
#line 45 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group row\">\r\n                    <label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Adres Tanımı</label>\r\n                    <div class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 53 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"
                   Write(Html.TextBoxFor(x => x.AdresBasligi, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group row\">\r\n                    <label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Adres</label>\r\n                    <div class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 60 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"
                   Write(Html.TextBoxFor(x => x.Adres, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group row\">\r\n                    <label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Şehir</label>\r\n                    <div class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 67 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"
                   Write(Html.TextBoxFor(x => x.Sehir, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group row\">\r\n                    <label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Semt</label>\r\n                    <div class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 74 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"
                   Write(Html.TextBoxFor(x => x.Semt, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group row\">\r\n                    <label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Mahalle</label>\r\n                    <div class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 81 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"
                   Write(Html.TextBoxFor(x => x.Mahalle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group row\">\r\n                    <label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Posta Kodu</label>\r\n                    <div class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 88 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"
                   Write(Html.TextBoxFor(x => x.PostaKodu, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""form-group row"">
                    <label for=""inputEmail3"" class=""col-sm-2 col-form-label""></label>
                    <div class=""col-sm-6"">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    </div>
                </div>
");
#nullable restore
#line 98 "D:\pragmateck\CardsShop\CardsShop\Views\Cart\Checkout.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a85606ca9d12b8cdec9bc922517761a87da4d510381", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a85606ca9d12b8cdec9bc922517761a87da4d511421", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a85606ca9d12b8cdec9bc922517761a87da4d512461", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShippingDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
