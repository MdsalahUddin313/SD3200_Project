#pragma checksum "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\TransportIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ced92be9952ee7a113dff3efbc02355afb6e32fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_TransportIndex), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/TransportIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced92be9952ee7a113dff3efbc02355afb6e32fd", @"/Areas/Admin/Views/Blog/TransportIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75be8211752d49e4a5405b796b27ff84d18f9bde", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blog_TransportIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\TransportIndex.cshtml"
  
    ViewBag.Title = ("Hotels");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">



    <h1 class=""text-center my-3 m-4"">Transport Lists</h1>
    <div class=""row"">
        <div class=""col-md-3"" style=""border-right:2px solid gray;"">

            <h1 class="" text-center m-auto mt-0"" style=""font-size:16px;"">Search filters</h1><br />
            <label for=""fdate"">Departure Time</label>
            <input class=""form-control"" type=""date"" id=""fdate"" name=""fdate"" /><br />
            <label for=""tdate"">Arrival Time</label>
            <input class=""form-control"" type=""date"" id=""tdate"" name=""tdate"" /><br />

            <h1 class="" text-center m-auto"" style=""font-size:16px;"">Search by Locations</h1><br />
            <label for=""location"">Choose your Transport Type.</label>
            <select class=""form-control"" id=""location"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ced92be9952ee7a113dff3efbc02355afb6e32fd4481", async() => {
                WriteLiteral("Bus");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ced92be9952ee7a113dff3efbc02355afb6e32fd5401", async() => {
                WriteLiteral("Train");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ced92be9952ee7a113dff3efbc02355afb6e32fd6323", async() => {
                WriteLiteral("Plane");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ced92be9952ee7a113dff3efbc02355afb6e32fd7245", async() => {
                WriteLiteral("Launch");
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

            <h1 class="" text-center m-auto"" style=""font-size:16px;"">Search filters</h1><br />
            <label for=""fplace"">Departure From</label>
            <input class=""form-control"" type=""text"" id=""fplace"" name=""fplace"" /><br />
            <label for=""tdate"">Arrival Time</label>
            <input class=""form-control"" type=""text"" id=""tplace"" name=""tplace"" /><br />
        </div>



        <div class=""col-md-9 jumbotron-fluid"">
            <div class=""card-deck"">
                <div class=""card"">
                    <img class=""card-img-top"" style=""width:100%"" src=""https://media.cntraveler.com/photos/5b97ea9959ff057868b4ea22/master/pass/The-Peninsula-Bangkok_2018_The-Peninsula-Bangkok_The-Pool-11.jpg"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 style=""font-size:16px;margin-top:0px;padding-top:0px;"" class=""card-title"">Bus</h5>
                        <p style=""font-size:12px;"" class=""card-text""><strong>IsAvailable:available<");
            WriteLiteral(@"/strong><br />Rating:4.6<br />Advantages:Pool,Wifi,Free Parking,Beach<br /><strong>Free Cancellation,30% off with family package</strong></br> <button class=""btn mt-3 btn-outline-info"">View Details</button></p>
                        <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                    </div>
                </div>
                <div class=""card"">
                    <img class=""card-img-top"" style=""width:100%;"" src=""https://badianhotel.com/wp-content/uploads/2020/08/the-spectator-charleston-south-carolina-lead-CHARLESTONHTLWB18-800x500.jpg"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 style=""font-size:16px;margin-top:0px;padding-top:0px;"" class=""card-title"">Train</h5>
                        <p style=""font-size:12px;"" class=""card-text""><strong>IsAvailable:available</strong><br />Rating:4.6<br />Advantages:Pool,Wifi,Free Parking,Beach<br /><strong>Free Cancellation,30% off with family package</strong>");
            WriteLiteral(@"</br> <button class=""btn mt-3 btn-outline-info"">View Details</button></p>
                        <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                    </div>
                </div>
                <div class=""card"">
                    <img class=""card-img-top"" src=""https://badianhotel.com/wp-content/uploads/2020/08/even-hotels-eugene-5405616297-4x3-1-800x600.jpeg"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 style=""font-size:16px;margin-top:0px;padding-top:0px;"" class=""card-title"">Plane</h5>
                        <p style=""font-size:12px;"" class=""card-text""><strong>IsAvailable:available</strong><br />Rating:4.6<br />Advantages:Pool,Wifi,Free Parking,Beach<br /><strong>Free Cancellation,30% off with family package</strong></br> <button class=""btn mt-3 btn-outline-info"">View Details</button></p>
                        <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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