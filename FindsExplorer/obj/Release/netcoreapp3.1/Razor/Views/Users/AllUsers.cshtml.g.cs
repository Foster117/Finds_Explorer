#pragma checksum "D:\OneDrive\_Code_Learning\_C#_Projects\FindsExplorer\FindsExplorer\Views\Users\AllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b23d2b49d57548165c9a4e81776f177d97af973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AllUsers), @"mvc.1.0.view", @"/Views/Users/AllUsers.cshtml")]
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
#line 1 "D:\OneDrive\_Code_Learning\_C#_Projects\FindsExplorer\FindsExplorer\Views\_ViewImports.cshtml"
using FindsExplorer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive\_Code_Learning\_C#_Projects\FindsExplorer\FindsExplorer\Views\_ViewImports.cshtml"
using FindsExplorer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b23d2b49d57548165c9a4e81776f177d97af973", @"/Views/Users/AllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b0c0768ac823643ee5370c4ebf3309e31295d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagesFE/load_indicator.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/AllUsers.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\OneDrive\_Code_Learning\_C#_Projects\FindsExplorer\FindsExplorer\Views\Users\AllUsers.cshtml"
  
    ViewData["Title"] = "Все пользователи";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"h4 font-weight-normal\">Все пользователи</h1>\r\n</div>\r\n\r\n");
            WriteLiteral(@"<div class=""form-inline my-2 my-lg-3"">
    <div class=""input-group mb-3 mx-auto float-right"">
        <input type=""text"" id=""searchInput"" class=""form-control"" placeholder=""Поиск по имени"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
        <div class=""input-group-append"">
            <button class=""btn btn-outline-secondary"" id=""findButton"">Найти</button>
        </div>
    </div>
</div>

<div id=""loader"" class=""loader"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6b23d2b49d57548165c9a4e81776f177d97af9735134", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"usersList\">\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        ///////\r\n        //AJAX Request on load\r\n        $(document).ready(function () {\r\n            $(\"#loader\").css(\"display\", \"flex\");\r\n            $.ajax({\r\n                    url: \"");
#nullable restore
#line 39 "D:\OneDrive\_Code_Learning\_C#_Projects\FindsExplorer\FindsExplorer\Views\Users\AllUsers.cshtml"
                     Write(Url.Action("GetAllUsers"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    type: ""GET"",
                    data: ""offset="" + 0,
                    success: function (response) {
                        $(""#loader"").css(""display"", ""none"");
                        $(""#usersList"").html(response);
                    },
            });
        })


        ///////
        //AJAX Find By Name
        $(function () {
            $(""#findButton"").click(function() {
                if ($(""#searchInput"").val()) {
                    $(""#usersList"").text("""");
                    $(""#loader"").css(""display"", ""flex"");
                    $.ajax({
                        url: """);
#nullable restore
#line 58 "D:\OneDrive\_Code_Learning\_C#_Projects\FindsExplorer\FindsExplorer\Views\Users\AllUsers.cshtml"
                         Write(Url.Action("FindByName"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                        type: ""GET"",
                        data: ""name="" + $(""#searchInput"").val(),
                        success: function (response) {
                            $(""#loader"").css(""display"", ""none"");
                            $(""#usersList"").html(response);
                        },
                    });
                }
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6b23d2b49d57548165c9a4e81776f177d97af9738338", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
