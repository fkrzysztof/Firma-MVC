#pragma checksum "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Shared\Odnosniki.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "637c110a024b60ded3ace63367c04caf10ec9f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Odnosniki), @"mvc.1.0.view", @"/Views/Shared/Odnosniki.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Odnosniki.cshtml", typeof(AspNetCore.Views_Shared_Odnosniki))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637c110a024b60ded3ace63367c04caf10ec9f2f", @"/Views/Shared/Odnosniki.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"333cf0b783eb0ed75ea6e21d910eebca2d1b5bca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Odnosniki : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Firma.Data.Data.CMS.Strona>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(50, 94, true);
            WriteLiteral("\r\n<div class=\"nav-wrapper container\">\r\n    <a id=\"logo-container\" href=\"#\" class=\"brand-logo\">");
            EndContext();
            BeginContext(144, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d745a238c1e64709858615fe0cde7bb0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(172, 51, true);
            WriteLiteral("</a>\r\n    <ul class=\"right hide-on-med-and-down\">\r\n");
            EndContext();
            BeginContext(287, 27, true);
            WriteLiteral("        <li>\r\n             ");
            EndContext();
            BeginContext(315, 54, false);
#line 10 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Shared\Odnosniki.cshtml"
        Write(Html.ActionLink("Sklep internetowy", "Index", "Sklep"));

#line default
#line hidden
            EndContext();
            BeginContext(369, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 12 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Shared\Odnosniki.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(435, 34, true);
            WriteLiteral("            <li>\r\n                ");
            EndContext();
            BeginContext(470, 82, false);
#line 15 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Shared\Odnosniki.cshtml"
           Write(Html.ActionLink(item.LinkTytul, "Index", "Home", new { id = item.IdStrony }, null));

#line default
#line hidden
            EndContext();
            BeginContext(552, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 17 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Shared\Odnosniki.cshtml"
        }

#line default
#line hidden
            BeginContext(584, 57, true);
            WriteLiteral("    </ul>\r\n\r\n\r\n    <ul id=\"nav-mobile\" class=\"sidenav\">\r\n");
            EndContext();
#line 23 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Shared\Odnosniki.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(717, 34, true);
            WriteLiteral("            <li>\r\n                ");
            EndContext();
            BeginContext(752, 82, false);
#line 26 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Shared\Odnosniki.cshtml"
           Write(Html.ActionLink(item.LinkTytul, "Index", "Home", new { id = item.IdStrony }, null));

#line default
#line hidden
            EndContext();
            BeginContext(834, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 28 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.PortalWWW\Views\Shared\Odnosniki.cshtml"
        }

#line default
#line hidden
            BeginContext(866, 122, true);
            WriteLiteral("    </ul>\r\n    <a href=\"#\" data-target=\"nav-mobile\" class=\"sidenav-trigger\"><i class=\"material-icons\">menu</i></a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Firma.Data.Data.CMS.Strona>> Html { get; private set; }
    }
}
#pragma warning restore 1591
