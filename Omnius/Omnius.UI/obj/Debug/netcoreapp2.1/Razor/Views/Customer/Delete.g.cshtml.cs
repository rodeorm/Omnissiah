#pragma checksum "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "316176ed392ab4886eb50f63355dd81a23cc2fa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Delete), @"mvc.1.0.view", @"/Views/Customer/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Delete.cshtml", typeof(AspNetCore.Views_Customer_Delete))]
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
#line 1 "G:\StagingArea\Omnius\Omnius.UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#line 2 "G:\StagingArea\Omnius\Omnius.UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#line 3 "G:\StagingArea\Omnius\Omnius.UI\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316176ed392ab4886eb50f63355dd81a23cc2fa3", @"/Views/Customer/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c354c0482baa1e50b4d03cb4d8892992660ea44", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Omnius.Domain.Entities.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
  
    ViewData["Title"] = "Удалить";

#line default
#line hidden
            BeginContext(80, 82, true);
            WriteLiteral("\n<h3>Вы действительно хотите удалить этого потребителя?</h3>\n<div>\n    <hr />\n    ");
            EndContext();
            BeginContext(162, 1515, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eabc03a0cdc41e2866e15e2c074c3ae", async() => {
                BeginContext(206, 26, true);
                WriteLiteral("\n        <dt>\n            ");
                EndContext();
                BeginContext(233, 40, false);
#line 12 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(273, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(314, 36, false);
#line 15 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(350, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(391, 46, false);
#line 18 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FamilyName));

#line default
#line hidden
                EndContext();
                BeginContext(437, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(478, 42, false);
#line 21 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FamilyName));

#line default
#line hidden
                EndContext();
                BeginContext(520, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(561, 48, false);
#line 24 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PaternalName));

#line default
#line hidden
                EndContext();
                BeginContext(609, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(650, 44, false);
#line 27 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PaternalName));

#line default
#line hidden
                EndContext();
                BeginContext(694, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(735, 45, false);
#line 30 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstCase));

#line default
#line hidden
                EndContext();
                BeginContext(780, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(821, 41, false);
#line 33 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstCase));

#line default
#line hidden
                EndContext();
                BeginContext(862, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(903, 46, false);
#line 36 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SecondCase));

#line default
#line hidden
                EndContext();
                BeginContext(949, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(990, 42, false);
#line 39 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SecondCase));

#line default
#line hidden
                EndContext();
                BeginContext(1032, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(1073, 39, false);
#line 42 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
                EndContext();
                BeginContext(1112, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1153, 35, false);
#line 45 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sex));

#line default
#line hidden
                EndContext();
                BeginContext(1188, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(1229, 47, false);
#line 48 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
                EndContext();
                BeginContext(1276, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1317, 43, false);
#line 51 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
                EndContext();
                BeginContext(1360, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(1401, 47, false);
#line 54 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfDeath));

#line default
#line hidden
                EndContext();
                BeginContext(1448, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1489, 43, false);
#line 57 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateOfDeath));

#line default
#line hidden
                EndContext();
                BeginContext(1532, 99, true);
                WriteLiteral("\n        </dd>\n        <button type=\"submit\" class=\"button\"><span>Удалить</span></button>\n\n        ");
                EndContext();
                BeginContext(1631, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59ddbf4701e4400f9d30247befd502a9", async() => {
                    BeginContext(1652, 9, true);
                    WriteLiteral("Вернуться");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1665, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1677, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Omnius.Domain.Entities.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
