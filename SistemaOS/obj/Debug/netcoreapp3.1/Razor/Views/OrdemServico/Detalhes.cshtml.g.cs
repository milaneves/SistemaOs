#pragma checksum "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e51502ff98faa9837b515ef74dfdbc41e198b7d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdemServico_Detalhes), @"mvc.1.0.view", @"/Views/OrdemServico/Detalhes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51502ff98faa9837b515ef74dfdbc41e198b7d5", @"/Views/OrdemServico/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7cf3a451e871706d2e5e1e51a8fda60111a3d9c", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdemServico_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaOS.Models.OrdemServico>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
   ViewData["Title"] = "Detalhe"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Ordem de Serviço?</h3>\n<hr />\n\n<div>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
#nullable restore
#line 12 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroOS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 15 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.NumeroOS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 18 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.TituloServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 21 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.TituloServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 24 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 27 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.NomeCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 30 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.NomePrestador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 33 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.NomePrestador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 36 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 39 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 42 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.DataExecucao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 45 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.DataExecucao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n    </dl>\n\n    <div class=\"form-group\">\n        <div class=\"form-group col-lg-6\">\n            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1302, "\"", 1345, 1);
#nullable restore
#line 52 "C:\Users\t-msantos\Documents\SistemaOS\SistemaOS\Views\OrdemServico\Detalhes.cshtml"
WriteAttributeValue("", 1309, Url.Action("Index", "OrdemServico"), 1309, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Voltar</a>\n        </div>\n    </div>\n</div>\n");
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