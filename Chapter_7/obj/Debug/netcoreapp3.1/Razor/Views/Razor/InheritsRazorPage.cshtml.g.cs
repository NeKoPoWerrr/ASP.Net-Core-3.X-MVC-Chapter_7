#pragma checksum "E:\program\C sharp\Chapter_7\Chapter_7\Views\Razor\InheritsRazorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f12bb015f0a9f7d49fdf40a435212ab3b524f8ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Razor_InheritsRazorPage), @"mvc.1.0.view", @"/Views/Razor/InheritsRazorPage.cshtml")]
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
#line 1 "E:\program\C sharp\Chapter_7\Chapter_7\Views\_ViewImports.cshtml"
using Chapter_7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\program\C sharp\Chapter_7\Chapter_7\Views\_ViewImports.cshtml"
using Chapter_7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12bb015f0a9f7d49fdf40a435212ab3b524f8ee", @"/Views/Razor/InheritsRazorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bad9c844ca0c6a8db7a006690741c906e4f389d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Razor_InheritsRazorPage : Chapter_7.RazorPage.CustomRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p>書籍名稱 : ");
#nullable restore
#line 10 "E:\program\C sharp\Chapter_7\Chapter_7\Views\Razor\InheritsRazorPage.cshtml"
     Write(GetBookName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>ASP.NET Core版本 : ");
#nullable restore
#line 11 "E:\program\C sharp\Chapter_7\Chapter_7\Views\Razor\InheritsRazorPage.cshtml"
               Write(AppVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>作者 : ");
#nullable restore
#line 12 "E:\program\C sharp\Chapter_7\Chapter_7\Views\Razor\InheritsRazorPage.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
