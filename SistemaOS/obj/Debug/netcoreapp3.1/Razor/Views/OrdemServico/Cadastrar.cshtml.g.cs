#pragma checksum "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "809d7ddd471bf1a992c1465fdcf4f808a00e1651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdemServico_Cadastrar), @"mvc.1.0.view", @"/Views/OrdemServico/Cadastrar.cshtml")]
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
#line 1 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\_ViewImports.cshtml"
using SistemaOS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\_ViewImports.cshtml"
using SistemaOS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"809d7ddd471bf1a992c1465fdcf4f808a00e1651", @"/Views/OrdemServico/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7cf3a451e871706d2e5e1e51a8fda60111a3d9c", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdemServico_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaOS.Models.OrdemServico>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
   ViewData["Title"] = "Cadastrar"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Cadastrar Ordem Serviço</h2>\n\n<hr />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809d7ddd471bf1a992c1465fdcf4f808a00e16513414", async() => {
                WriteLiteral("\n    <script type=\'text/javascript\' src=\'//code.jquery.com/jquery-compat-git.js\'></script>\n    <script type=\'text/javascript\' src=\'//igorescobar.github.io/jQuery-Mask-Plugin/js/jquery.mask.min.js\'></script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 14 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
 using (Html.BeginForm("ConfirmaCadastro", "OrdemServico", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid mt-4\">\n    ");
#nullable restore
#line 18 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"row\">\n        <div class=\"col-sm-5\">\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 22 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
           Write(Html.LabelFor(model => model.NumeroOS, new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"col-sm-12\">\n                    ");
#nullable restore
#line 24 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.EditorFor(model => model.NumeroOS, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 25 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.ValidationMessageFor(model => model.NumeroOS, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <div class=\"col-sm-5\">\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 31 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
           Write(Html.LabelFor(model => model.TituloServico, new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"col-sm-12\">\n                    ");
#nullable restore
#line 33 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.EditorFor(model => model.TituloServico, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 34 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.ValidationMessageFor(model => model.TituloServico, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <div class=\"col-sm-5\">\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 40 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
           Write(Html.LabelFor(model => model.CNPJCliente, new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"col-sm-12\">\n                    ");
#nullable restore
#line 42 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.EditorFor(model => model.CNPJCliente, new { htmlAttributes = new { @class = "form-control", @id="CNPJ" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 43 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.ValidationMessageFor(model => model.CNPJCliente, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <div class=\"col-sm-5\">\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 49 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
           Write(Html.LabelFor(model => model.NomeCliente, new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"col-sm-12\">\n                    ");
#nullable restore
#line 51 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.EditorFor(model => model.NomeCliente, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 52 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.ValidationMessageFor(model => model.NomeCliente, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n\n    </div>\n    <br />\n    <div class=\"row\">\n        <div class=\"col-sm-5\">\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 62 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
           Write(Html.LabelFor(model => model.CPFPrestador, new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"col-sm-12\">\n                    ");
#nullable restore
#line 64 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.EditorFor(model => model.CPFPrestador, new { htmlAttributes = new { @class = "form-control" , @id="CPF" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 65 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.ValidationMessageFor(model => model.CPFPrestador, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <div class=\"col-sm-5\">\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 71 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
           Write(Html.LabelFor(model => model.NomePrestador, new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"col-sm-12\">\n                    ");
#nullable restore
#line 73 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.EditorFor(model => model.NomePrestador, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 74 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.ValidationMessageFor(model => model.NomePrestador, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <div class=\"col-sm-5\">\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 80 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
           Write(Html.LabelFor(model => model.Valor, new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"col-sm-12\">\n                    ");
#nullable restore
#line 82 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.EditorFor(model => model.Valor, new { htmlAttributes = new { @class = "form-control" , @id="Valor"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 83 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.ValidationMessageFor(model => model.Valor, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <div class=\"col-sm-5\">\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 89 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
           Write(Html.LabelFor(model => model.DataExecucao, new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"col-sm-12\">\n\n                    ");
#nullable restore
#line 92 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.EditorFor(model => model.DataExecucao, new { htmlAttributes = new { @class = "form-control Date" , @id="Data"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 93 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
               Write(Html.ValidationMessageFor(model => model.DataExecucao, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <br />

        </div>
    </div>
    <br />
    <div class=""form-group"">
        <div class=""form-group col-lg-6"">
            <input type=""submit"" class=""btn btn-success"" data-loading-text=""Cadastrando..."" autocomplete=""off"" value=""Salvar"" />
            <a class=""btn btn-danger""");
            BeginWriteAttribute("href", " href=\"", 4926, "\"", 4969, 1);
#nullable restore
#line 104 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
WriteAttributeValue("", 4933, Url.Action("Index", "OrdemServico"), 4933, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancelar</a>\n        </div>\n    </div>\n</div>");
#nullable restore
#line 107 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Cadastrar.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    $('#Telefone').mask('(00) 00000 - 0000');

    $('#Valor').mask('000.000.000.000.000,00', { reverse: true });

    $(""#Valor"").change(function () {
        $(""#value"").html($(this).val().replace(/\D/g, ''))
    })

    $(""#Data"").mask('00/00/0000');
    $(""#CPF"").mask(""999.999.999-99"");
    $(""#CNPJ"").mask(""99.999.999/9999-99"");


</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaOS.Models.OrdemServico> Html { get; private set; }
    }
}
#pragma warning restore 1591
