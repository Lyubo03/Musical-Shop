#pragma checksum "D:\Musical Shop\MusicalShop.App\Views\Wishlist\Wishlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81d50e3c5ee1ab32fb8c850aa93564a79572c277"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wishlist_Wishlist), @"mvc.1.0.view", @"/Views/Wishlist/Wishlist.cshtml")]
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
#line 1 "D:\Musical Shop\MusicalShop.App\Views\_ViewImports.cshtml"
using MusicalShop.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Musical Shop\MusicalShop.App\Views\_ViewImports.cshtml"
using MusicalShop.App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Musical Shop\MusicalShop.App\Views\_ViewImports.cshtml"
using MusicalShop.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Musical Shop\MusicalShop.App\Views\_ViewImports.cshtml"
using MusicalShop.Web.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Musical Shop\MusicalShop.App\Views\_ViewImports.cshtml"
using MusicalShop.Web.ViewModels.Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Musical Shop\MusicalShop.App\Views\_ViewImports.cshtml"
using MusicalShop.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Musical Shop\MusicalShop.App\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81d50e3c5ee1ab32fb8c850aa93564a79572c277", @"/Views/Wishlist/Wishlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cdaa3ac5acf232ea6786ff4f04be8fc23cc825e", @"/Views/_ViewImports.cshtml")]
    public class Views_Wishlist_Wishlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MusicalShop.Web.ViewModels.Wishlist.WishlistViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/remove.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/add-to-basket.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Musical Shop\MusicalShop.App\Views\Wishlist\Wishlist.cshtml"
  
    ViewData["Title"] = "Wishlist";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var wishes = Model.ToList();
    var quantity = "qty";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""cart-table-area section-padding-100"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12 col-lg-8"">
                <div class=""cart-title mt-50"">
                    <h2>Wishlist</h2>
                </div>

                <div class=""cart-table clearfix"">
                    <table class=""table table-responsive"">
                        <thead>
                            <tr>
                                <th></th>
                                <th>Name</th>
                                <th>Price</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 27 "D:\Musical Shop\MusicalShop.App\Views\Wishlist\Wishlist.cshtml"
                             for (int i = 0; i < wishes.Count; i++)
                            {
                                quantity += i;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"cart_product_img\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1199, "\"", 1224, 1);
#nullable restore
#line 32 "D:\Musical Shop\MusicalShop.App\Views\Wishlist\Wishlist.cshtml"
WriteAttributeValue("", 1206, wishes[i].Picture, 1206, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1230, "\"", 1254, 1);
#nullable restore
#line 32 "D:\Musical Shop\MusicalShop.App\Views\Wishlist\Wishlist.cshtml"
WriteAttributeValue("", 1236, wishes[i].Picture, 1236, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product\"></a>\r\n                                </td>\r\n                                <td class=\"cart_product_desc\">\r\n                                    <h5>");
#nullable restore
#line 35 "D:\Musical Shop\MusicalShop.App\Views\Wishlist\Wishlist.cshtml"
                                   Write(wishes[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </td>\r\n                                <td class=\"price\">\r\n                                    <span>");
#nullable restore
#line 38 "D:\Musical Shop\MusicalShop.App\Views\Wishlist\Wishlist.cshtml"
                                     Write(wishes[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1637, "\"", 1674, 2);
            WriteAttributeValue("", 1644, "/Wishlist/Remove/", 1644, 17, true);
#nullable restore
#line 39 "D:\Musical Shop\MusicalShop.App\Views\Wishlist\Wishlist.cshtml"
WriteAttributeValue("", 1661, wishes[i].Id, 1661, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mx-3 my-1\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81d50e3c5ee1ab32fb8c850aa93564a79572c2778168", async() => {
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
            WriteLiteral("</a>\r\n                                    <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "81d50e3c5ee1ab32fb8c850aa93564a79572c2779252", async() => {
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
            WriteLiteral("</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 43 "D:\Musical Shop\MusicalShop.App\Views\Wishlist\Wishlist.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n         </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MusicalShop.Web.ViewModels.Wishlist.WishlistViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
