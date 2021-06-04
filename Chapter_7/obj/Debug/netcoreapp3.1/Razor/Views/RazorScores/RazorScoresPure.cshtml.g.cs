#pragma checksum "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3526e182a83129c5b70b1919b262bedca4fee40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RazorScores_RazorScoresPure), @"mvc.1.0.view", @"/Views/RazorScores/RazorScoresPure.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3526e182a83129c5b70b1919b262bedca4fee40", @"/Views/RazorScores/RazorScoresPure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bad9c844ca0c6a8db7a006690741c906e4f389d9", @"/Views/_ViewImports.cshtml")]
    public class Views_RazorScores_RazorScoresPure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/scorestyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
        
    ViewBag.title = "學生期中考成績";
    var Students = (List<Student>)Model;
    Students.ForEach(s => s.Total = s.Chinese + s.Math + s.English);
    var topId = Students.OrderByDescending(s => s.Total)
        .Select(s => s.Id)
        .FirstOrDefault();
    string ScoreLevel (int score)
    {
        switch (score)
        {
            case int s when s < 60:
                return "poor";
            case int s when s >= 95:
                return "excellent";
            default:
                return "";
        };

    }
    string ScoreRating(int port) =>
        port switch
        {
            int s when s < 60 => "poor",
            int s when s >= 95 => "excellent",
            _ => "",
        };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
           Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
           Write(Html.DisplayNameFor(m => m.Chinese));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
           Write(Html.DisplayNameFor(m => m.English));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
           Write(Html.DisplayNameFor(m => m.Math));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
           Write(Html.DisplayNameFor(m => m.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 59 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
         foreach(var m in Students)
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 62 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
           Write(Html.DisplayFor(x => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 63 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
           Write(Html.DisplayFor(x => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td");
            BeginWriteAttribute("class", " class=\"", 1767, "\"", 1799, 1);
#nullable restore
#line 64 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
WriteAttributeValue("", 1775, ScoreLevel(m.Chinese), 1775, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
                                            Write(Html.DisplayFor(x => m.Chinese));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td");
            BeginWriteAttribute("class", " class=\"", 1855, "\"", 1888, 1);
#nullable restore
#line 65 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
WriteAttributeValue("", 1863, ScoreRating(m.English), 1863, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
                                             Write(Html.DisplayFor(x => m.English));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td");
            BeginWriteAttribute("class", " class=\"", 1944, "\"", 1974, 1);
#nullable restore
#line 66 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
WriteAttributeValue("", 1952, ScoreRating(m.Math), 1952, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
                                          Write(Html.DisplayFor(x => m.Math));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td");
            BeginWriteAttribute("class", " class=\"", 2027, "\"", 2059, 1);
#nullable restore
#line 67 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
WriteAttributeValue("", 2035, m.Id==topId?"top1":"", 2035, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
                                            Write(Html.DisplayFor(x => m.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "E:\program\C sharp\Chapter_7\Chapter_7\Views\RazorScores\RazorScoresPure.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            DefineSection("topCss", async() => {
                WriteLiteral(" \r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e3526e182a83129c5b70b1919b262bedca4fee4010597", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
