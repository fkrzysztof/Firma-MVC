#pragma checksum "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Aktualnosc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "761eb8cdcf944157ae6d410e21c6c37a076e30b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aktualnosc_Index), @"mvc.1.0.view", @"/Views/Aktualnosc/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aktualnosc/Index.cshtml", typeof(AspNetCore.Views_Aktualnosc_Index))]
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
#line 1 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\_ViewImports.cshtml"
using Firma.PortalWWW;

#line default
#line hidden
#line 2 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\_ViewImports.cshtml"
using Firma.PortalWWW.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"761eb8cdcf944157ae6d410e21c6c37a076e30b1", @"/Views/Aktualnosc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"333cf0b783eb0ed75ea6e21d910eebca2d1b5bca", @"/Views/_ViewImports.cshtml")]
    public class Views_Aktualnosc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Firma.Data.Data.CMS.Aktualnosc>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Aktualnosc\Index.cshtml"
  
    ViewData["Title"] = @Model.Tytul;

#line default
#line hidden
            BeginContext(85, 57, true);
            WriteLiteral("\r\n    <div>Aktualno????</div>\r\n    <div>Tytu?? aktualno??ci: ");
            EndContext();
            BeginContext(143, 11, false);
#line 7 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Aktualnosc\Index.cshtml"
                       Write(Model.Tytul);

#line default
#line hidden
            EndContext();
            BeginContext(154, 13, true);
            WriteLiteral(" </div>\r\n    ");
            EndContext();
            BeginContext(168, 11, false);
#line 8 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Aktualnosc\Index.cshtml"
Write(Model.Tresc);

#line default
#line hidden
            EndContext();
            BeginContext(179, 41, true);
            WriteLiteral("\r\n    <br />\r\n    Data i godzina edycji: ");
            EndContext();
            BeginContext(221, 23, false);
#line 10 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Aktualnosc\Index.cshtml"
                      Write(DateTime.Now.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(244, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Firma.Data.Data.CMS.Aktualnosc> Html { get; private set; }
    }
}
#pragma warning restore 1591
