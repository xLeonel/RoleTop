#pragma checksum "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39f5a46d6f7167e1256e2f7e1d0a2f86a7c61ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_EventosAdm), @"mvc.1.0.view", @"/Views/Administrador/EventosAdm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/EventosAdm.cshtml", typeof(AspNetCore.Views_Administrador_EventosAdm))]
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
#line 1 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f5a46d6f7167e1256e2f7e1d0a2f86a7c61ab6", @"/Views/Administrador/EventosAdm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_EventosAdm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.EventoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Eventos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logoff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 78, true);
            WriteLiteral("\r\n<main>\r\n    <div id=\"dashboard\">\r\n        <div id=\"opcaoUser\">\r\n            ");
            EndContext();
            BeginContext(124, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f5a46d6f7167e1256e2f7e1d0a2f86a7c61ab65192", async() => {
                BeginContext(179, 7, true);
                WriteLiteral("Eventos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(190, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(204, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f5a46d6f7167e1256e2f7e1d0a2f86a7c61ab66781", async() => {
                BeginContext(239, 9, true);
                WriteLiteral("BlackList");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(252, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(266, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f5a46d6f7167e1256e2f7e1d0a2f86a7c61ab68372", async() => {
                BeginContext(301, 13, true);
                WriteLiteral("Configurações");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(318, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(332, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f5a46d6f7167e1256e2f7e1d0a2f86a7c61ab69968", async() => {
                BeginContext(378, 4, true);
                WriteLiteral("Sair");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(386, 1594, true);
            WriteLiteral(@"
        </div>
        <div id=""content"">
            <section id=""titulo"">
                <h2>Eventos</h2>
            </section>
            <div id=""osbutao"">
                <div id=""tab1"" class=""ta""><button class=""butoes"" id=""aprovado"" style=""font-weight: bolder"">Aprovados</button></div>
                <div id=""tab2"" class=""ta""><button class=""butoes"" id=""pendente"" style=""font-weight: bolder"">Pendentes</button></div>
                <div id=""tab3"" class=""ta""><button class=""butoes"" id=""recusado"" style=""font-weight: bolder"">Recusados</button></div>
            </div>

        <div id=""testando"">
            <div id=""amostra"">
                <!-- APROVADOS -->
                <div id=""tab1show"" class=""tab"">
                    <table id=""aprovado"">
                        <thead>
                            <tr>
                                <th rowspan=""2"">Nome</th>
                                <th rowspan=""2"">Dia</th>
                                <th rowspan=""2"">Tipo Evento");
            WriteLiteral(@"</th>
                                <th colspan=""2"" rowspan=""2"">Aprovar</th>
                            </tr>
                            <tr>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <td colspan=""6"">
                                    <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1981, 12, false);
#line 43 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                                         Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1993, 147, true);
            WriteLiteral("</p>\r\n                                </td>\r\n                            </tr>\r\n                        </tfoot>\r\n                        <tbody>\r\n");
            EndContext();
#line 48 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                             foreach (var evento in Model.Eventos)
                                {

#line default
#line hidden
            BeginContext(2243, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2322, 17, false);
#line 51 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                   Write(evento.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2339, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2387, 36, false);
#line 52 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                   Write(evento.DiaEvento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2423, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2471, 17, false);
#line 53 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                   Write(evento.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2488, 212, true);
            WriteLiteral("</td>\r\n                                    <td><a ><i class=\"fas fa-check\"></i></a></td>\r\n                                    <td><a ><i class=\"fas fa-times\"></i></a></td>\r\n                                </tr>\r\n");
            EndContext();
#line 57 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                }

#line default
#line hidden
            BeginContext(2735, 1094, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <!-- PENDENTES -->
                <div id=""tab2show"" class=""tab"">
                    <table id=""pendente"">
                        <thead>
                            <tr>
                                <th rowspan=""2"">Nome</th>
                                <th rowspan=""2"">Dia</th>
                                <th rowspan=""2"">Tipo Evento</th>
                                <th rowspan=""2"">Convidados</th>
                                <th colspan=""2"" rowspan=""2"">Aprovar</th>
                            </tr>
                            <tr>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <td colspa");
            WriteLiteral("n=\"6\">\r\n                                    <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(3830, 12, false);
#line 82 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                                         Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(3842, 147, true);
            WriteLiteral("</p>\r\n                                </td>\r\n                            </tr>\r\n                        </tfoot>\r\n                        <tbody>\r\n");
            EndContext();
#line 87 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                             foreach (var evento in Model.Eventos)
                                {

#line default
#line hidden
            BeginContext(4092, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(4171, 17, false);
#line 90 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                   Write(evento.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(4188, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(4236, 36, false);
#line 91 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                   Write(evento.DiaEvento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(4272, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(4320, 17, false);
#line 92 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                   Write(evento.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(4337, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(4385, 20, false);
#line 93 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                   Write(evento.NumeroPessoas);

#line default
#line hidden
            EndContext();
            BeginContext(4405, 49, true);
            WriteLiteral("</td>\r\n                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 4454, "\'", 4523, 1);
#line 94 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
WriteAttributeValue("", 4461, Url.Action("Aprovar", "Administrador", new {id = @evento.Id}), 4461, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4524, 82, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 4606, "\'", 4675, 1);
#line 95 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
WriteAttributeValue("", 4613, Url.Action("Recusar", "Administrador", new {id = @evento.Id}), 4613, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4676, 79, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                                </tr>\r\n");
            EndContext();
#line 97 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                }

#line default
#line hidden
            BeginContext(4790, 1075, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
        
                <div id=""tab3show"" class=""tab"">
                    <table id=""recusado"">
                            <thead>
                                <tr>
                                    <th rowspan=""2"">Nome</th>
                                    <th rowspan=""2"">Dia</th>
                                    <th rowspan=""2"">Tipo Evento</th>
                                    <th colspan=""2"" rowspan=""2"">Aprovar</th>
                                </tr>
                                <tr>
                                    <th></th>
                                    <th></th>
                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tfoot>
                                <tr>
                                    <td colspan=""6"">
               ");
            WriteLiteral("                         <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(5866, 12, false);
#line 121 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                                             Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(5878, 163, true);
            WriteLiteral("</p>\r\n                                    </td>\r\n                                </tr>\r\n                            </tfoot>\r\n                            <tbody>\r\n");
            EndContext();
#line 126 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                 foreach (var evento in Model.Eventos)
                                    {

#line default
#line hidden
            BeginContext(6152, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(6239, 17, false);
#line 129 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                       Write(evento.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(6256, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6308, 36, false);
#line 130 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                       Write(evento.DiaEvento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(6344, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6396, 17, false);
#line 131 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                       Write(evento.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(6413, 224, true);
            WriteLiteral("</td>\r\n                                        <td><a ><i class=\"fas fa-check\"></i></a></td>\r\n                                        <td><a ><i class=\"fas fa-times\"></i></a></td>\r\n                                    </tr>\r\n");
            EndContext();
#line 135 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Administrador\EventosAdm.cshtml"
                                    }

#line default
#line hidden
            BeginContext(6676, 167, true);
            WriteLiteral("                            </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
