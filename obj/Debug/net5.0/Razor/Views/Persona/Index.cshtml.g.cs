#pragma checksum "/Users/cecilioalvarezcaules/Desktop/net2/Views/Persona/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e09e299d459072ee655ee08982b055ebaadf51f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Index), @"mvc.1.0.view", @"/Views/Persona/Index.cshtml")]
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
#line 1 "/Users/cecilioalvarezcaules/Desktop/net2/Views/_ViewImports.cshtml"
using net2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cecilioalvarezcaules/Desktop/net2/Views/_ViewImports.cshtml"
using net2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e09e299d459072ee655ee08982b055ebaadf51f", @"/Views/Persona/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f87fc912dcd28d8c56102941b2c3567ecb948ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/cecilioalvarezcaules/Desktop/net2/Views/Persona/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n  <script>\r\n    $(document).ready(function() {\r\n\r\n       $(\".borrar\").click(function(e) {\r\n\r\n                $(\"#cajaBorrar\").modal(\"show\");\r\n                 e.preventDefault();   \r\n       })\r\n    });\r\n  </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n <table class=\"table table-striped table-hover\">\r\n    <tr>\r\n        <th>Dni</th>\r\n        <th>Nombre</th>\r\n        <th>Apellidos</th>\r\n        <th>Borrar</th>\r\n         <th>Editar</th>\r\n    </tr>\r\n");
#nullable restore
#line 28 "/Users/cecilioalvarezcaules/Desktop/net2/Views/Persona/Index.cshtml"
     foreach (var persona in ViewBag.lista){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n        <td>");
#nullable restore
#line 30 "/Users/cecilioalvarezcaules/Desktop/net2/Views/Persona/Index.cshtml"
       Write(persona.Dni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "/Users/cecilioalvarezcaules/Desktop/net2/Views/Persona/Index.cshtml"
       Write(persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 32 "/Users/cecilioalvarezcaules/Desktop/net2/Views/Persona/Index.cshtml"
        Write(persona.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td><a class=\"borrar\"");
            BeginWriteAttribute("href", " href=\"", 683, "\"", 722, 2);
            WriteAttributeValue("", 690, "/persona/borrar?dni=", 690, 20, true);
#nullable restore
#line 33 "/Users/cecilioalvarezcaules/Desktop/net2/Views/Persona/Index.cshtml"
WriteAttributeValue("", 710, persona.Dni, 710, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">borrar</a></td>\r\n          <td><a class=\"editar\"");
            BeginWriteAttribute("href", " href=\"", 772, "\"", 821, 2);
            WriteAttributeValue("", 779, "/persona/formularioeditar?dni=", 779, 30, true);
#nullable restore
#line 34 "/Users/cecilioalvarezcaules/Desktop/net2/Views/Persona/Index.cshtml"
WriteAttributeValue("", 809, persona.Dni, 809, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "/Users/cecilioalvarezcaules/Desktop/net2/Views/Persona/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
    <a href=""/persona/formularioinsertar"">formulario Insertar</a>


    <div class=""modal"" tabindex=""-1"" id=""cajaBorrar"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
          <div class=""modal-content"">
            <div class=""modal-header"">
              <h5 class=""modal-title"">Quieres Borrar?</h5>
              <button
                type=""button""
                class=""close cerrar""
               
                data-dismiss=""modal""
                aria-label=""Close""
              >
                <span aria-hidden=""true"">&times;</span>
              </button>
            </div>
            <div class=""modal-body"">
              <p>Vamos a Borrarl</p>
            </div>
            <div class=""modal-footer"">
              <button type=""button"" id=""borrar"" class=""btn btn-primary"">
                Borrar
              </button>
              <button
                type=""button""
                
                class=""btn btn-secondary cance");
            WriteLiteral("lar\"\r\n                data-dismiss=\"modal\"\r\n              >\r\n                Cancelar\r\n              </button>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>");
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
