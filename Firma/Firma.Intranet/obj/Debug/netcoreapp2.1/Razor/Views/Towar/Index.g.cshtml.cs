#pragma checksum "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4667b14b0c45052fc558839f8d4a585d94d8a569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Towar_Index), @"mvc.1.0.view", @"/Views/Towar/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Towar/Index.cshtml", typeof(AspNetCore.Views_Towar_Index))]
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
#line 1 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\_ViewImports.cshtml"
using Firma.Intranet;

#line default
#line hidden
#line 2 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\_ViewImports.cshtml"
using Firma.Intranet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4667b14b0c45052fc558839f8d4a585d94d8a569", @"/Views/Towar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e5536e0e76827b885a60bd24cc8f220c03b0633", @"/Views/_ViewImports.cshtml")]
    public class Views_Towar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Firma.Data.Data.Sklep.Towar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(121, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d55813414ac4f05a829d77eefc34ae3", async() => {
                BeginContext(144, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(158, 104, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(263, 39, false);
#line 16 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kod));

#line default
#line hidden
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(358, 41, false);
#line 19 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nazwa));

#line default
#line hidden
            EndContext();
            BeginContext(399, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(455, 40, false);
#line 22 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(495, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(551, 43, false);
#line 25 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FotoURL));

#line default
#line hidden
            EndContext();
            BeginContext(594, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(650, 40, false);
#line 28 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(690, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(746, 42, false);
#line 31 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rodzaj));

#line default
#line hidden
            EndContext();
            BeginContext(788, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(906, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(955, 38, false);
#line 40 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kod));

#line default
#line hidden
            EndContext();
            BeginContext(993, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1049, 40, false);
#line 43 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nazwa));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1145, 39, false);
#line 46 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1240, 42, false);
#line 49 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FotoURL));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1338, 39, false);
#line 52 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1433, 47, false);
#line 55 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rodzaj.Nazwa));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1535, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5cd570875b42009285b80af2d234d8", async() => {
                BeginContext(1586, 68, true);
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary btn-sm\">Edytuj</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
                                       WriteLiteral(item.IdTowaru);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1658, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1676, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9608944926748f49e9282501ac9ad1c", async() => {
                BeginContext(1730, 68, true);
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary btn-sm\">Detale</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
                                          WriteLiteral(item.IdTowaru);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1802, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1820, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfa16f3661c946a2a02e71eb4826023d", async() => {
                BeginContext(1873, 66, true);
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary btn-sm\">Usuń</button>");
                EndContext();
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
#line 60 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
                                         WriteLiteral(item.IdTowaru);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1943, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\Ja\Dysk Google\wsb\III semestr 6\Internetowe\FranczykFirma1\Firma\Firma.Intranet\Views\Towar\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1982, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Firma.Data.Data.Sklep.Towar>> Html { get; private set; }
    }
}
#pragma warning restore 1591