#pragma checksum "C:\Proyectos\WEB 3\Material\Clase-3.MVC.Web\Clase-3.MVC.Web\Views\Partidos\EliminarConfirmacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b02fd96484cec014b059dfb4d00815431602331"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partidos_EliminarConfirmacion), @"mvc.1.0.view", @"/Views/Partidos/EliminarConfirmacion.cshtml")]
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
#line 1 "C:\Proyectos\WEB 3\Material\Clase-3.MVC.Web\Clase-3.MVC.Web\Views\_ViewImports.cshtml"
using Clase_3.MVC.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Proyectos\WEB 3\Material\Clase-3.MVC.Web\Clase-3.MVC.Web\Views\_ViewImports.cshtml"
using Clase_3.MVC.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b02fd96484cec014b059dfb4d00815431602331", @"/Views/Partidos/EliminarConfirmacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c247be85c59a7ab5ca356216a38dd923dcdf24", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Partidos_EliminarConfirmacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartidosViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/partidos/eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b02fd96484cec014b059dfb4d008154316023314044", async() => {
                WriteLiteral("\r\n    \r\n    <div>\r\n        Esta seguro que desea eliminar el partido del ");
#nullable restore
#line 6 "C:\Proyectos\WEB 3\Material\Clase-3.MVC.Web\Clase-3.MVC.Web\Views\Partidos\EliminarConfirmacion.cshtml"
                                                 Write(Model.Fecha.ToString("dd/MM/yy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" en ");
#nullable restore
#line 6 "C:\Proyectos\WEB 3\Material\Clase-3.MVC.Web\Clase-3.MVC.Web\Views\Partidos\EliminarConfirmacion.cshtml"
                                                                                      Write(Model.Lugar);

#line default
#line hidden
#nullable disable
                WriteLiteral(" a las ");
#nullable restore
#line 6 "C:\Proyectos\WEB 3\Material\Clase-3.MVC.Web\Clase-3.MVC.Web\Views\Partidos\EliminarConfirmacion.cshtml"
                                                                                                         Write(Model.Fecha.ToString("hh:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral("hs\r\n    </div>\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 275, "\"", 292, 1);
#nullable restore
#line 8 "C:\Proyectos\WEB 3\Material\Clase-3.MVC.Web\Clase-3.MVC.Web\Views\Partidos\EliminarConfirmacion.cshtml"
WriteAttributeValue("", 283, Model.Id, 283, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\" />\r\n    <input type=\"submit\" name=\"Confirmar\" value=\"Eliminar\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartidosViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
