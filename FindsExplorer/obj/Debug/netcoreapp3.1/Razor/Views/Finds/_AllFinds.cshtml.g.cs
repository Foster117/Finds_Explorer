#pragma checksum "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5308cc2c146a1d8f6faa5dee237d587ce712d46a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finds__AllFinds), @"mvc.1.0.view", @"/Views/Finds/_AllFinds.cshtml")]
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
#line 1 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\_ViewImports.cshtml"
using FindsExplorer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\_ViewImports.cshtml"
using FindsExplorer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
using FindsExplorer.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5308cc2c146a1d8f6faa5dee237d587ce712d46a", @"/Views/Finds/_AllFinds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b0c0768ac823643ee5370c4ebf3309e31295d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Finds__AllFinds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AllFindsModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Finds", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Find", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
  
    int allFindsQuantity = ViewBag.AllFindsQuantity;
    int nextOffset = ViewBag.Offset + allFindsQuantity;
    int prevOffset = ViewBag.Offset - allFindsQuantity;
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
            WriteLiteral(@"


<div class=""container"">
    <div class=""row"">

        <table class=""table table-sm table-striped"">
            <thead class=""thead-light"">
                <tr>
                    <th>Превью</th>
                    <th>Название</th>
                    <th>Материал</th>
                    <th>Период</th>
                    <th>Владелец</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 36 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
                 foreach (AllFindsModel item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><img class=\"imagePreview\"");
            BeginWriteAttribute("src", " src=\"", 1045, "\"", 1077, 2);
            WriteAttributeValue("", 1051, "/FindsPhotos/", 1051, 13, true);
#nullable restore
#line 39 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
WriteAttributeValue("", 1064, item.Preview, 1064, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40\" /></td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5308cc2c146a1d8f6faa5dee237d587ce712d46a6396", async() => {
#nullable restore
#line 40 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
                                                                                             Write(item.FindName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
                                                                            WriteLiteral(item.Id);

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
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
                       Write(item.MaterialName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
                       Write(item.PeriodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5308cc2c146a1d8f6faa5dee237d587ce712d46a9641", async() => {
#nullable restore
#line 43 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
                                                                                                    Write(item.OwnerName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
                                                                            WriteLiteral(item.OwnerName);

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
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"form-inline my-lg-4\">\r\n    <div class=\"btn-group justify-content-center d-inline-block m-auto\">\r\n        <a id=\"PrevButton\"");
            BeginWriteAttribute("class", " class=\"", 1700, "\"", 1735, 3);
            WriteAttributeValue("", 1708, "btn", 1708, 3, true);
            WriteAttributeValue(" ", 1711, "btn-light", 1712, 10, true);
#nullable restore
#line 53 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
WriteAttributeValue(" ", 1721, prevDisabled, 1722, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Предыдущие</a>\r\n        <a id=\"NextButton\"");
            BeginWriteAttribute("class", " class=\"", 1779, "\"", 1814, 3);
            WriteAttributeValue("", 1787, "btn", 1787, 3, true);
            WriteAttributeValue(" ", 1790, "btn-light", 1791, 10, true);
#nullable restore
#line 54 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
WriteAttributeValue(" ", 1800, nextDisabled, 1801, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Следующие</a>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n\r\n   $(\"#NextButton\").click(function () {\r\n       GetAllFinds(");
#nullable restore
#line 61 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
              Write(nextOffset);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n   });\r\n\r\n   $(\"#PrevButton\").click(function () {\r\n       GetAllFinds(");
#nullable restore
#line 65 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
              Write(prevOffset);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n   });\r\n\r\n    function GetAllFinds(offset) {\r\n        $(\"#findsList\").text(\"\");\r\n        $(\"#loader\").css(\"display\", \"flex\");\r\n       $.ajax({\r\n           url: \"");
#nullable restore
#line 72 "C:\Users\Foster117\Desktop\Finds_Explorer\FindsExplorer\Views\Finds\_AllFinds.cshtml"
            Write(Url.Action("GetAllFinds"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
           type: ""GET"",
           data: ""offset="" + offset,
           success: function (response) {
               $(""#loader"").css(""display"", ""none"");
               $(""#findsList"").html(response);
           },
       });
   }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AllFindsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
