#pragma checksum "C:\Users\Asus\source\repos\SelfLern2\SelfLern2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae55d2a02c202a21142648bd7535e5485abb3886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Asus\source\repos\SelfLern2\SelfLern2\Views\_ViewImports.cshtml"
using SelfLern2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\source\repos\SelfLern2\SelfLern2\Views\_ViewImports.cshtml"
using SelfLern2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae55d2a02c202a21142648bd7535e5485abb3886", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc253cd0bb109a9380f9ebc5644b138ffc5182b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Asus\source\repos\SelfLern2\SelfLern2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var teams = ViewBag.teams;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Football</h1>
    <p>Get Data from api-football by Jeremy / api-sports.</p>
</div>
<div class=""dropdown"">
    <button class=""btn btn-secondary dropdown-toggle btn-sm"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
        League
    </button>
    <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
        <a class=""dropdown-item"" href=""/4"">Ligue 1</a>
        <a class=""dropdown-item"" href=""/2"">premier league</a>
        <a class=""dropdown-item"" href=""/8"">Bundesliga</a>
    </div>
</div>
<table class=""table"">
    <thead>
        <tr>
            
            <th scope=""col"">Team Name</th>
            <th scope=""col"">Venue Name</th>
            <th scope=""col"">Logo</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\Asus\source\repos\SelfLern2\SelfLern2\Views\Home\Index.cshtml"
         foreach (var i in teams)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Asus\source\repos\SelfLern2\SelfLern2\Views\Home\Index.cshtml"
               Write(i.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Asus\source\repos\SelfLern2\SelfLern2\Views\Home\Index.cshtml"
               Write(i.venue_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 1106, "\"", 1119, 1);
#nullable restore
#line 36 "C:\Users\Asus\source\repos\SelfLern2\SelfLern2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1112, i.logo, 1112, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\"></td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Asus\source\repos\SelfLern2\SelfLern2\Views\Home\Index.cshtml"

            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
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
