#pragma checksum "C:\Users\Md salah Uddin\source\repos\SDProject03\Areas\Admin\Views\Blog\DashboardIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30f9af9ba49ee13fa78d61769c0477c0a8027f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_DashboardIndex), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/DashboardIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30f9af9ba49ee13fa78d61769c0477c0a8027f38", @"/Areas/Admin/Views/Blog/DashboardIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75be8211752d49e4a5405b796b27ff84d18f9bde", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blog_DashboardIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""container my-5 p-xl-2"">
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Table Name</th>
                <th scope=""col"">No Of column</th>
                <th scope=""col"">No Of Datas</th>


            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope=""row"">1</th>
                <td><a href=""/location/index"">Locations Table</a></td>
                <td>Attr (7)</td>
                <td>Data (5)</td>

            </tr>
            <tr>
                <th scope=""row"">2</th>
                <td><a href=""https://localhost:44354/hotels/index"">Hotels Table</a></td>
                <td>Attr (12)</td>
                <td>Data (5)</td>

            </tr>


            <tr>
                <th scope=""row"">5</th>
                <td><a href=""/blog/index"">Blogs Post Table</a></td>
                <td>Attr (15)</td>
                <td>Data (");
            WriteLiteral(@"5)</td>

            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td><a href=""/location/index"">Bus Table</a></td>
                <td>Attr (12)</td>
                <td>Data (5)</td>

            </tr>

            <tr>
                <th scope=""row"">4</th>
                <td><a href=""/location/index"">Train Table</a></td>
                <td>Attr (7)</td>
                <td>Data (5)</td>

            </tr>

        </tbody>
    </table>

   
</div>");
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
