#pragma checksum "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c804fe0ebc83d1ffe62aa7146617e38fe69d0fc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__FindByName), @"mvc.1.0.view", @"/Views/Users/_FindByName.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c804fe0ebc83d1ffe62aa7146617e38fe69d0fc4", @"/Views/Users/_FindByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b0c0768ac823643ee5370c4ebf3309e31295d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__FindByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
  
    int allNamesQuantity = ViewBag.AllNamesQuantity;
    int namesInColumnQuantity = allNamesQuantity / 4;
    int nextOffset = ViewBag.Offset + allNamesQuantity;
    int prevOffset = ViewBag.Offset - allNamesQuantity;
    List<string>[] columns = {
    Model.Skip(0).Take(namesInColumnQuantity).ToList(),
    Model.Skip(namesInColumnQuantity).Take(namesInColumnQuantity).ToList(),
    Model.Skip(namesInColumnQuantity * 2).Take(namesInColumnQuantity).ToList(),
    Model.Skip(namesInColumnQuantity * 3).Take(namesInColumnQuantity).ToList()};
    string prevDisabled = null;
    string nextDisabled = null;
    if (ViewBag.Offset == 0)
    {
        prevDisabled = "disabled";
    }
    if (!ViewBag.IsNextVisible)
    {
        nextDisabled = "disabled";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
  
    if (Model.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center\">\r\n            <h1 class=\"h4 font-weight-normal\">Результаты поиска</h1>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 34 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
                  
                    for (int i = 0; i < columns.Length; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-3\">\r\n                            <ul class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 39 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
                                  
                                    foreach (var item in columns[i])
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"list-group-item\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c804fe0ebc83d1ffe62aa7146617e38fe69d0fc45677", async() => {
#nullable restore
#line 42 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
                                                                                                            Write(item);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
                                                                                              WriteLiteral(item);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 43 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n");
#nullable restore
#line 47 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-inline my-lg-4\">\r\n            <div class=\"btn-group justify-content-center d-inline-block m-auto\">\r\n                <a id=\"PrevButton\"");
            BeginWriteAttribute("class", " class=\"", 1916, "\"", 1951, 3);
            WriteAttributeValue("", 1924, "btn", 1924, 3, true);
            WriteAttributeValue(" ", 1927, "btn-light", 1928, 10, true);
#nullable restore
#line 54 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
WriteAttributeValue(" ", 1937, prevDisabled, 1938, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Предыдущие</a>\r\n                <a id=\"NextButton\"");
            BeginWriteAttribute("class", " class=\"", 2003, "\"", 2038, 3);
            WriteAttributeValue("", 2011, "btn", 2011, 3, true);
            WriteAttributeValue(" ", 2014, "btn-light", 2015, 10, true);
#nullable restore
#line 55 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
WriteAttributeValue(" ", 2024, nextDisabled, 2025, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Следующие</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 58 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"



    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center\">\r\n            <h1 class=\"h4 font-weight-normal\">Поиск не дал результатов</h1>\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n         $(function () {\r\n             $(\"#NextButton\").click(function () {\r\n                 FindByName(");
#nullable restore
#line 74 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
                       Write(nextOffset);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n            });\r\n\r\n             $(\"#PrevButton\").click(function () {\r\n                 FindByName(");
#nullable restore
#line 78 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
                       Write(prevOffset);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n            });\r\n\r\n            function FindByName(offset) {\r\n                $(\"#usersList\").text(\"\");\r\n                $(\"#loader\").css(\"display\", \"flex\");\r\n                $.ajax({\r\n                    url: \"");
#nullable restore
#line 85 "C:\Users\Foster117\Desktop\FindsExplorer\FindsExplorer\Views\Users\_FindByName.cshtml"
                     Write(Url.Action("FindByName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                    type: ""GET"",
                    data: ""name="" + $(""#searchInput"").val() + ""&offset="" + offset,
                    success: function (response) {
                        $(""#loader"").css(""display"", ""none"");
                        $(""#usersList"").html(response);
                    },
                });
            }
        });
</script>");
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