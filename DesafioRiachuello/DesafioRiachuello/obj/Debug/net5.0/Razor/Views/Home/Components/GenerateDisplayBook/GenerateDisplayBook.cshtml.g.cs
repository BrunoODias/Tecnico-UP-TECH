#pragma checksum "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2a18c16652026f9433afbe5a02b8f5e7128f7ac"
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
#line 1 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\_ViewImports.cshtml"
using DesafioRiachuello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\_ViewImports.cshtml"
using DesafioRiachuello.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2a18c16652026f9433afbe5a02b8f5e7128f7ac", @"/Views/Home/Components/GenerateDisplayBook/GenerateDisplayBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dab2fe09784621ff899496fea4daf9c34011104", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_GenerateDisplayBook_GenerateDisplayBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelsServicesInterfaces.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""card-book col-sm w-100 m-2"">
        <div class=""row"">
            <div class=""d-flex"" style=""flex-wrap: wrap;"">
                <div class=""col p-4"" style=""justify-content: center;"">
                    <div class=""m-auto"" style=""width: fit-content;"">
                        <img class=""img-book""");
            BeginWriteAttribute("src", " src=\"", 358, "\"", 436, 1);
#nullable restore
#line 7 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue("", 364, string.IsNullOrWhiteSpace(Model.Photo) ? "/nophoto.jpg" : Model.Photo, 364, 72, false);

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
            BeginWriteAttribute("href", " href=\"", 849, "\"", 882, 2);
            WriteAttributeValue("", 856, "/Books/Details/", 856, 15, true);
#nullable restore
#line 16 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue("", 871, Model.Code, 871, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 17 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"row mb-2\">\r\n                        <a class=\"clickable\" style=\"font-size: 1.4rem;\"");
            BeginWriteAttribute("href", " href=\"", 1100, "\"", 1135, 1);
#nullable restore
#line 21 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue("", 1107, "/Search/" + Model.Author, 1107, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 22 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                       Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"row mb-2\">\r\n                        <span style=\"font-size: 1.4rem;\">");
#nullable restore
#line 26 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                                                    Write(Model.PublicationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"row mb-2\">\r\n                        <i");
            BeginWriteAttribute("class", "  class=\"", 1470, "\"", 1558, 5);
            WriteAttributeValue("", 1479, "clickable", 1479, 9, true);
            WriteAttributeValue(" ", 1488, "fas", 1489, 4, true);
            WriteAttributeValue(" ", 1492, "fa-heart", 1493, 9, true);
            WriteAttributeValue(" ", 1501, "favoriteToggle", 1502, 15, true);
#nullable restore
#line 29 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue(" ", 1516, Model.isFavorite? "favorited-book": "", 1517, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("isfavorite", " isfavorite=\"", 1559, "\"", 1618, 2);
#nullable restore
#line 29 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
WriteAttributeValue("", 1572, Model.isFavorite? "true": "false", 1572, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1608, "bookCode=", 1609, 10, true);
            EndWriteAttribute();
#nullable restore
#line 29 "C:\Users\Bruno\Desktop\Projetos\DesafioRiachuello\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\GenerateDisplayBook\GenerateDisplayBook.cshtml"
                                                                                                                                                                          Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></i>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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