#pragma checksum "C:\ProjectsLuis\Teste\Views\Home\Competition.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e27433fedd4713d556935a65a97db36d02aa359b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Competition), @"mvc.1.0.view", @"/Views/Home/Competition.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Competition.cshtml", typeof(AspNetCore.Views_Home_Competition))]
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
#line 1 "C:\ProjectsLuis\Teste\Views\_ViewImports.cshtml"
using Teste;

#line default
#line hidden
#line 2 "C:\ProjectsLuis\Teste\Views\_ViewImports.cshtml"
using Teste.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27433fedd4713d556935a65a97db36d02aa359b", @"/Views/Home/Competition.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f51cfc5580c79daf4d9ab91e0de700d19835326", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Competition : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\ProjectsLuis\Teste\Views\Home\Competition.cshtml"
  
    ViewData["Title"] = "Competition";

#line default
#line hidden
            BeginContext(47, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(52, 17, false);
#line 4 "C:\ProjectsLuis\Teste\Views\Home\Competition.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(69, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(81, 19, false);
#line 5 "C:\ProjectsLuis\Teste\Views\Home\Competition.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(100, 76, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional COMPETITION information.</p>");
            EndContext();
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
