#pragma checksum "C:\Users\Isko\Desktop\MVC_HomeWork_REPOSITORY\HomeWork4\HomeWork4\Views\Shered\_BooksPartalView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e836ed37b7fdd0a0b4aaa35010e7f3ca697427"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shered__BooksPartalView), @"mvc.1.0.view", @"/Views/Shered/_BooksPartalView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shered/_BooksPartalView.cshtml", typeof(AspNetCore.Views_Shered__BooksPartalView))]
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
#line 1 "C:\Users\Isko\Desktop\MVC_HomeWork_REPOSITORY\HomeWork4\HomeWork4\Views\_ViewImports.cshtml"
using HomeWork4.Models.DomainModels;

#line default
#line hidden
#line 2 "C:\Users\Isko\Desktop\MVC_HomeWork_REPOSITORY\HomeWork4\HomeWork4\Views\_ViewImports.cshtml"
using HomeWork4.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e836ed37b7fdd0a0b4aaa35010e7f3ca697427", @"/Views/Shered/_BooksPartalView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61531627b65105d21637e7444d36155869daf7a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shered__BooksPartalView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 52, true);
            WriteLiteral("<div class=\"card\" style=\"width: 18rem; \">\r\n   \r\n    ");
            EndContext();
            BeginContext(65, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "432c5b0d641249b1a4a84a15da794a47", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 75, "~/img/BooksImg/", 75, 15, true);
#line 4 "C:\Users\Isko\Desktop\MVC_HomeWork_REPOSITORY\HomeWork4\HomeWork4\Views\Shered\_BooksPartalView.cshtml"
AddHtmlAttributeValue("", 90, Model.Name, 90, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 103, ".png", 103, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(140, 102, true);
            WriteLiteral("\r\n    <ul class=\"list-group list-group-flush\">\r\n        \r\n        <li class=\"list-group-item\">Author: ");
            EndContext();
            BeginContext(243, 12, false);
#line 7 "C:\Users\Isko\Desktop\MVC_HomeWork_REPOSITORY\HomeWork4\HomeWork4\Views\Shered\_BooksPartalView.cshtml"
                                       Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(255, 55, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Rent Price: ");
            EndContext();
            BeginContext(311, 11, false);
#line 8 "C:\Users\Isko\Desktop\MVC_HomeWork_REPOSITORY\HomeWork4\HomeWork4\Views\Shered\_BooksPartalView.cshtml"
                                           Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(322, 50, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Genre: ");
            EndContext();
            BeginContext(373, 11, false);
#line 9 "C:\Users\Isko\Desktop\MVC_HomeWork_REPOSITORY\HomeWork4\HomeWork4\Views\Shered\_BooksPartalView.cshtml"
                                      Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(384, 78, true);
            WriteLiteral("</li>\r\n    \r\n    </ul>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
