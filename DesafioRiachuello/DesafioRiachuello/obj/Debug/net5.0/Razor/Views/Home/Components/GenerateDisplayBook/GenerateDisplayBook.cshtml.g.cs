#pragma checksum "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09fc19b5fed181659ba6609d8f6d4c7746120d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_GenerateDisplayBook_GenerateDisplayBook), @"mvc.1.0.view", @"/Views/Home/Components/GenerateDisplayBook/GenerateDisplayBook.cshtml")]
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
#line 1 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\_ViewImports.cshtml"
using DesafioRiachuello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\_ViewImports.cshtml"
using DesafioRiachuello.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09fc19b5fed181659ba6609d8f6d4c7746120d01", @"/Views/Home/Components/GenerateDisplayBook/GenerateDisplayBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11bf3a305eb0a04b8cd8328dda72f153829c19bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_GenerateDisplayBook_GenerateDisplayBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelsServicesInterfaces.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card-book col-sm w-100 m-2"">
    <div class=""row"">
        <div class=""d-flex"" style=""flex-wrap: wrap;"">
            <div class=""col p-4"" style=""justify-content: center;"">
                <div class=""m-auto"" style=""width: fit-content;"">
                    <img class=""img-book""");
            BeginWriteAttribute("src", " src=\"", 328, "\"", 351, 1);
#nullable restore
#line 7 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue("", 334, Model.GetPhoto(), 334, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col"" style=""text-align: center;min-width: 11rem;display: flex;align-items: center;justify-content: center;"">
            <div style=""margin: auto;"">
                <div class=""row mb-2"">
                    <a class=""clickable"" style=""font-size: 1.4rem;""");
            BeginWriteAttribute("href", " href=\"", 719, "\"", 752, 2);
            WriteAttributeValue("", 726, "/Books/Details/", 726, 15, true);
#nullable restore
#line 16 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue("", 741, Model.Code, 741, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        ");
#nullable restore
#line 17 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </a>\n                </div>\n                <div class=\"row mb-2\">\n                    <a class=\"clickable\" style=\"font-size: 1.4rem;\"");
            BeginWriteAttribute("href", " href=\"", 945, "\"", 994, 1);
#nullable restore
#line 21 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue("", 952, "/Search/GetAuthorName/" + Model.Author, 952, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        ");
#nullable restore
#line 22 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                   Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </a>\n                </div>\n                <div class=\"row mb-2\">\n                    <span style=\"font-size: 1.4rem;\">");
#nullable restore
#line 26 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                                                Write(Model.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n");
#nullable restore
#line 28 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                 if (string.IsNullOrWhiteSpace(Model.Recommendation) == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mb-2 d-flex justify-content-center\">\n");
#nullable restore
#line 31 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                          
                            int points = Convert.ToInt32((Model.Recommendation).Split('.')[0]);
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                         for (var i = 0; i < points; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-star classification-star-selected\"></i>\n");
#nullable restore
#line 37 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                         for (var i = points; i < 5; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-star classification-star\"></i>\n");
#nullable restore
#line 41 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n");
#nullable restore
#line 43 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row mb-2\">\n                    <i");
            BeginWriteAttribute("class", " class=\"", 2026, "\"", 2113, 5);
            WriteAttributeValue("", 2034, "clickable", 2034, 9, true);
            WriteAttributeValue(" ", 2043, "fas", 2044, 4, true);
            WriteAttributeValue(" ", 2047, "fa-heart", 2048, 9, true);
            WriteAttributeValue(" ", 2056, "favoriteToggle", 2057, 15, true);
#nullable restore
#line 45 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue(" ", 2071, Model.isFavorite? "favorited-book": "", 2072, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("model", " model=\"", 2114, "\"", 2173, 1);
#nullable restore
#line 45 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue("", 2122, Newtonsoft.Json.JsonConvert.SerializeObject(Model), 2122, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("isfavorite", "\n                       isfavorite=\"", 2174, "\"", 2246, 1);
#nullable restore
#line 46 "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue("", 2210, Model.isFavorite? "true": "false", 2210, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelsServicesInterfaces.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
