#pragma checksum "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb0413ea7faf6218f0fbee515b7e6eea828a0b97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_User), @"mvc.1.0.view", @"/Views/Users/User.cshtml")]
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
#line 1 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\_ViewImports.cshtml"
using FindsExplorer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\_ViewImports.cshtml"
using FindsExplorer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0413ea7faf6218f0fbee515b7e6eea828a0b97", @"/Views/Users/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b0c0768ac823643ee5370c4ebf3309e31295d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/User.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
  
    ViewData["Title"] = Model.UserName;
    Layout = "~/Views/Shared/_Layout.cshtml";
    bool phoneIsNull = (Model.PhoneNumber == null ? false : true);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-sm"">
    <thead>
        <tr>
            <th>Имя</th>
            <th>Телефон</th>
            <th>Откуда</th>
            <th>Дата регистрации</th>
            <th>О пользователе</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 20 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
                 if (Model.PhoneNumber != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 22 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
                  Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 22 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
                                                }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"dis\">Не указан</span>");
#nullable restore
#line 24 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
             if (Model.Location != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 27 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
              Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 27 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
                                         }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"dis\">Не указано</span>");
#nullable restore
#line 29 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
       Write(Model.RegistrationDate.Day.ToString("D2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 31 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
                                                  Write(Model.RegistrationDate.Month.ToString("D2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 31 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
                                                                                               Write(Model.RegistrationDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
         if (Model.AboutUser != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 33 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
          Write(Model.AboutUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 33 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
                                      }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"dis\">Не указано</span>");
#nullable restore
#line 35 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\User.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n\r\n<hr />\r\n<p>Находки пользователя</p>\r\n<div id=\"findsContainer\">\r\n\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb0413ea7faf6218f0fbee515b7e6eea828a0b978930", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
