#pragma checksum "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d272e0790572aaa48d7acb35748338aa1e016af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evento_Index), @"mvc.1.0.view", @"/Views/Evento/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d272e0790572aaa48d7acb35748338aa1e016af", @"/Views/Evento/Index.cshtml")]
    public class Views_Evento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<proyectoFinal.Models.Evento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaInic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.horaInic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.horaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Localizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fechaInic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.horaInic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.horaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Categoria.categoriaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Localizacion.localizacionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2012, "\"", 2041, 1);
#nullable restore
#line 70 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
WriteAttributeValue("", 2027, item.eventoId, 2027, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2094, "\"", 2123, 1);
#nullable restore
#line 71 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
WriteAttributeValue("", 2109, item.eventoId, 2109, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2178, "\"", 2207, 1);
#nullable restore
#line 72 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
WriteAttributeValue("", 2193, item.eventoId, 2193, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\2daw3\Desktop\proyectoFinal\Views\Evento\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<proyectoFinal.Models.Evento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
