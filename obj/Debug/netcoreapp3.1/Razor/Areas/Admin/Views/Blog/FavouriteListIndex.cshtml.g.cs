#pragma checksum "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f134361bc3b2202b17850864fdb659cf1c2bd54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_FavouriteListIndex), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/FavouriteListIndex.cshtml")]
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
#line 1 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\_ViewImports.cshtml"
using SDProject03;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\_ViewImports.cshtml"
using SDProject03.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml"
using SDProject03.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f134361bc3b2202b17850864fdb659cf1c2bd54", @"/Areas/Admin/Views/Blog/FavouriteListIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75be8211752d49e4a5405b796b27ff84d18f9bde", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blog_FavouriteListIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LocationsModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("sss"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("wdth:100%;height:180px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml"
  
    ViewBag.Title = ("Add Favourite List");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml"
  
    // int count = 0;
    List<LocationsModel> locations = HttpContextAccessor.HttpContext.Session.Get<List<LocationsModel>>("locations");

    // count = hotels.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    \r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f134361bc3b2202b17850864fdb659cf1c2bd545689", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 803, "\"", 813, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 840, "\"", 850, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <link rel=""icon"" href=""/docs/4.0/assets/img/favicons/favicon.ico"">

    <title>Bottom navbar example for Bootstrap</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/4.0/examples/navbar-bottom/"">

    <!-- Bootstrap core CSS -->
    <link href=""../../dist/css/bootstrap.min.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f134361bc3b2202b17850864fdb659cf1c2bd547506", async() => {
                WriteLiteral("\r\n    \r\n");
#nullable restore
#line 67 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <div class=\"jumbotron mt-3\">\r\n\r\n                <h5>");
#nullable restore
#line 73 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml"
               Write(item.LocationName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f134361bc3b2202b17850864fdb659cf1c2bd548417", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1399, "~/Image/", 1399, 8, true);
#nullable restore
#line 74 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml"
AddHtmlAttributeValue("", 1407, item.ImageName, 1407, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <p class=\"lead\">");
#nullable restore
#line 75 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml"
                           Write(item.LocationTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p><strong>Rating:</strong>");
#nullable restore
#line 76 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml"
                                      Write(item.LocationRating);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>                
                <a class=""btn btn-lg btn-primary"" href=""../../components/navbar/"" role=""button"">Explore Now</a>
                <a class=""btn btn-lg btn-outline-success"" href=""../../components/navbar/"" role=""button"">Visited</a>

            </div>
        </div>
");
#nullable restore
#line 82 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\FavouriteListIndex.cshtml"


    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <nav class=""navbar fixed-bottom navbar-expand-sm navbar-dark bg-dark"">
            <a class=""navbar-brand"" href=""#"">Bottom navbar</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarCollapse"" aria-controls=""navbarCollapse"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarCollapse"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">WhishList <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/checkout"">Cart</a>
                    </li>

                </ul>
            </div>
        </nav>

        <!-- Bootstrap core JavaScript
        ===========================================");
                WriteLiteral(@"======= -->
        <!-- Placed at the end of the document so the pages load faster -->
        <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
        <script>window.jQuery || document.write('<script src=""../../assets/js/vendor/jquery-slim.min.js""><\/script>')</script>
        <script src=""../../assets/js/vendor/popper.min.js""></script>
        <script src=""../../dist/js/bootstrap.min.js""></script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LocationsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
