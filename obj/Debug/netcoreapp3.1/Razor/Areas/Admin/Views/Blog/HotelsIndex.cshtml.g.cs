#pragma checksum "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\HotelsIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91d0fc8a9279eb9df20bc3a32f7eb80e803d2178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_HotelsIndex), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/HotelsIndex.cshtml")]
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
#line 3 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\HotelsIndex.cshtml"
using SDProject03.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91d0fc8a9279eb9df20bc3a32f7eb80e803d2178", @"/Areas/Admin/Views/Blog/HotelsIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75be8211752d49e4a5405b796b27ff84d18f9bde", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blog_HotelsIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelsModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100% ;height:350px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HotelDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn mt-3 btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\HotelsIndex.cshtml"
  
    ViewBag.Title = ("Hotel");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">

    <h1 class=""text-center my-3 m-4"">Hotels Lists</h1>
    <div class=""row"">
        <div class=""col-md-3"">

            <h1 class="" text-center m-auto"" style=""font-size:16px;"">Search filters</h1><br /><br />
            <label for=""fdate"">Check In</label>
            <input class=""form-control"" type=""date"" id=""fdate"" name=""fdate"" /><br />
            <label for=""tdate"">Check Out</label>
            <input class=""form-control"" type=""date"" id=""tdate"" name=""tdate"" /><br />

            <h1 class="" text-center m-auto"" style=""font-size:16px;"">Search by Locations</h1><br />
            <label for=""location"">Choose your Hotel by using Location.</label>
            <select class=""form-control"" id=""location"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91d0fc8a9279eb9df20bc3a32f7eb80e803d21786883", async() => {
                WriteLiteral("Dhaka");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91d0fc8a9279eb9df20bc3a32f7eb80e803d21787805", async() => {
                WriteLiteral("Sylhet");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91d0fc8a9279eb9df20bc3a32f7eb80e803d21788728", async() => {
                WriteLiteral("Rajshahi");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91d0fc8a9279eb9df20bc3a32f7eb80e803d21789653", async() => {
                WriteLiteral("Chittagong");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</select>

        </div>


        <div class=""col-md-9 jumbotron-fluid"">
           

            <div class=""card-deck"">




                <div class=""card"">
                    <img class=""card-img-top"" style=""width:100%"" src=""https://media.cntraveler.com/photos/5b97ea9959ff057868b4ea22/master/pass/The-Peninsula-Bangkok_2018_The-Peninsula-Bangkok_The-Pool-11.jpg"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 style=""font-size:16px;margin-top:0px;padding-top:0px;"" class=""card-title"">Hotel1</h5>
                        <p style=""font-size:12px;"" class=""card-text""><strong>IsAvailable:available</strong><br />Rating:4.6<br />Advantages:Pool,Wifi,Free Parking,Beach<br /><strong>Free Cancellation,30% off with family package</strong></br> <button class=""btn mt-3 btn-outline-info"">View Details</button></p>
                        <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                    </div>
        ");
            WriteLiteral(@"        </div>


                <div class=""card"">
                    <img class=""card-img-top"" style=""width:100%;"" src=""https://badianhotel.com/wp-content/uploads/2020/08/the-spectator-charleston-south-carolina-lead-CHARLESTONHTLWB18-800x500.jpg"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 style=""font-size:16px;margin-top:0px;padding-top:0px;"" class=""card-title"">Hotel2</h5>
                        <p style=""font-size:12px;"" class=""card-text""><strong>IsAvailable:available</strong><br />Rating:4.6<br />Advantages:Pool,Wifi,Free Parking,Beach<br /><strong>Free Cancellation,30% off with family package</strong></br> <button class=""btn mt-3 btn-outline-info"">View Details</button></p>
                        <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                    </div>
                </div>
                <div class=""card"">
                    <img class=""card-img-top"" src=""https://badianhotel.com/wp-co");
            WriteLiteral(@"ntent/uploads/2020/08/even-hotels-eugene-5405616297-4x3-1-800x600.jpeg"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 style=""font-size:16px;margin-top:0px;padding-top:0px;"" class=""card-title"">Hotel3</h5>
                        <p style=""font-size:12px;"" class=""card-text""><strong>IsAvailable:available</strong><br />Rating:4.6<br />Advantages:Pool,Wifi,Free Parking,Beach<br /><strong>Free Cancellation,30% off with family package</strong></br> <button class=""btn mt-3 btn-outline-info"">View Details</button></p>
                        <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                    </div>
                </div>
            </div>


        </div>

    </div>
    <div");
            BeginWriteAttribute("class", " class=\"", 3968, "\"", 3976, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 77 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\HotelsIndex.cshtml"
     foreach (var Hotel in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row container my-auto h-100 mt-5\">\r\n    <div class=\"col-md-12 col-sm-12\" style=\"border:1px solid gray;margin:15px;padding:15px;\">\r\n        <div class=\"card\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "91d0fc8a9279eb9df20bc3a32f7eb80e803d217814187", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4285, "~/Image/Hotels/", 4285, 15, true);
#nullable restore
#line 82 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\HotelsIndex.cshtml"
AddHtmlAttributeValue("", 4300, Hotel.ImageName, 4300, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <h5 style=\"font-size:16px;margin-top:0px;padding-top:0px;\" class=\"card-title\">");
#nullable restore
#line 84 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\HotelsIndex.cshtml"
                                                                                         Write(Hotel.HotelsName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p style=\"font-size:12px;\" class=\"card-text\">");
#nullable restore
#line 85 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\HotelsIndex.cshtml"
                                                        Write(Hotel.HotelsRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\"><small class=\"text-muted\">Last updated 3 mins ago</small></p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91d0fc8a9279eb9df20bc3a32f7eb80e803d217816888", async() => {
                WriteLiteral(" View Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\HotelsIndex.cshtml"
                                               WriteLiteral(Hotel.HotelsId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n   </div>\r\n");
#nullable restore
#line 93 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\HotelsIndex.cshtml"

     
               

           


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
