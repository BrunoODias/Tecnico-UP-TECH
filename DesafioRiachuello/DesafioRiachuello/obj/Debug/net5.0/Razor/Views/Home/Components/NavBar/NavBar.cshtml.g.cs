#pragma checksum "C:\Users\bruno\Documents\GitHub\Tecnico-UP-TECH\DesafioRiachuello\DesafioRiachuello\Views\Home\Components\NavBar\NavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "486dda5de049507fbee04775d4619aa58c88a385"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_NavBar_NavBar), @"mvc.1.0.view", @"/Views/Home/Components/NavBar/NavBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"486dda5de049507fbee04775d4619aa58c88a385", @"/Views/Home/Components/NavBar/NavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11bf3a305eb0a04b8cd8328dda72f153829c19bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_NavBar_NavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .toggleFavoritesMenu {
        transition: all 1s;
        color: red;
        font-size: 1.5rem;
        -webkit-text-stroke-color: black;
        -webkit-text-stroke-width: 2px;
        border: none;
    }
    .rotate {
        transform: rotate(360deg);
    }
    .navbar {
        background: #d8d7d7;
        font-size: 1.3rem;
    }
    #favoritesBlock {
        width: 3rem;
        height: 2rem;
        position: absolute;
        z-index: -1;
        margin: auto;
    }
</style>

<nav class=""navbar px-0"">
    <div style=""width: 3rem;text-align: center;"">
        <div id=""favoritesBlock""></div>
        <i class=""fas fa-heart toggleFavoritesMenu clickable""></i>
    </div>
    <div class=""d-flex p-0"" style=""margin-left: 0rem;margin-right: 0.5rem;width: calc(100% - 4rem);"">
        <input id=""SearchTerm"" placeholder=""Pesquisar..."" class=""form-control"" style=""width: calc(100% - 5rem);"">
        <div class=""d-flex p-0"" style=""width: 5rem;justify-content: space-around;"">
            <i class");
            WriteLiteral(@"=""btn fas fa-search px-2 clickable"" id=""btnSearch"" style=""font-size: 1.3rem;""></i>
            <div class=""dropdown dropstart"">
                <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""toggleSearchFilter"" data-bs-toggle=""dropdown"" aria-expanded=""false""></button>
                <ul class=""dropdown-menu p-2"" aria-labelledby=""toggleSearchFilter"" style=""white-space: nowrap;text-align: end;"" data-bs-popper=""none"">
                    <li style=""text-align: center;"">
                    <label for=""searchForBookName"">Pesquisar por:</label></li>
                    <li class=""d-flex justify-content-between"">
                        <div>
                            <label>Nome do livro</label>
                        </div>
                        <div>
                            <input name=""searchType"" type=""radio"" value=""BookName"" checked=""true"">
                        </div>
                    </li>
                    <li class=""d-flex justify-content-between"">
                   ");
            WriteLiteral(@"     <div>
                            <label>Nome do autor</label>
                        </div>
                        <div>
                            <input name=""searchType"" value=""AuthorName"" type=""radio"">
                        </div>
                    </li>
                    <li class=""d-flex justify-content-between"">
                        <div>
                            <label>Categoria</label>
                        </div>
                        <div>
                            <input name=""searchType"" value=""CategoryName"" type=""radio"">
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</nav>");
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
