#pragma checksum "C:\webApi\SessionProjesi\SessionProjesi\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65f9cd09effb11e19a48eabf80dee4fbd6c3071a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\webApi\SessionProjesi\SessionProjesi\Views\_ViewImports.cshtml"
using SessionProjesi;

#line default
#line hidden
#line 2 "C:\webApi\SessionProjesi\SessionProjesi\Views\_ViewImports.cshtml"
using SessionProjesi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65f9cd09effb11e19a48eabf80dee4fbd6c3071a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43c242ec6bfd7b5d80be2edb20ff63bf424d9c38", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\webApi\SessionProjesi\SessionProjesi\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\webApi\SessionProjesi\SessionProjesi\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "C:\webApi\SessionProjesi\SessionProjesi\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 69, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n<p>");
            EndContext();
            BeginContext(164, 11, false);
#line 8 "C:\webApi\SessionProjesi\SessionProjesi\Views\Home\About.cshtml"
Write(ViewBag.Age);

#line default
#line hidden
            EndContext();
            BeginContext(175, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(185, 12, false);
#line 9 "C:\webApi\SessionProjesi\SessionProjesi\Views\Home\About.cshtml"
Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(197, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(207, 16, false);
#line 10 "C:\webApi\SessionProjesi\SessionProjesi\Views\Home\About.cshtml"
Write(ViewData["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(223, 4, true);
            WriteLiteral("</p>");
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
