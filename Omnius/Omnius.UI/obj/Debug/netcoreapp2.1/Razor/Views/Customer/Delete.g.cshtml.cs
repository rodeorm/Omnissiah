#pragma checksum "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c9f5a2d3f0e39f46ba5ed3beb19b4f127743cf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c9f5a2d3f0e39f46ba5ed3beb19b4f127743cf", @"/Views/Customer/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef610cff33c416990315850c30bdaab077b902b2", @"/Views/_ViewImports.cshtml")]
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
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(79, 82, true);
            WriteLiteral("\n<h3>Вы действительно хотите удалить этого потребителя?</h3>\n<div>\n    <hr />\n    ");
            EndContext();
            BeginContext(161, 1515, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db79707beda4d0cb62b756bcb5b8c35", async() => {
                BeginContext(205, 26, true);
                WriteLiteral("\n        <dt>\n            ");
                EndContext();
                BeginContext(232, 40, false);
#line 12 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(272, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(313, 36, false);
#line 15 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(349, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(390, 46, false);
#line 18 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FamilyName));

#line default
#line hidden
                EndContext();
                BeginContext(436, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(477, 42, false);
#line 21 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FamilyName));

#line default
#line hidden
                EndContext();
                BeginContext(519, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(560, 48, false);
#line 24 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PaternalName));

#line default
#line hidden
                EndContext();
                BeginContext(608, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(649, 44, false);
#line 27 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PaternalName));

#line default
#line hidden
                EndContext();
                BeginContext(693, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(734, 45, false);
#line 30 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstCase));

#line default
#line hidden
                EndContext();
                BeginContext(779, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(820, 41, false);
#line 33 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstCase));

#line default
#line hidden
                EndContext();
                BeginContext(861, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(902, 46, false);
#line 36 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SecondCase));

#line default
#line hidden
                EndContext();
                BeginContext(948, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(989, 42, false);
#line 39 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SecondCase));

#line default
#line hidden
                EndContext();
                BeginContext(1031, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(1072, 39, false);
#line 42 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
                EndContext();
                BeginContext(1111, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1152, 35, false);
#line 45 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sex));

#line default
#line hidden
                EndContext();
                BeginContext(1187, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(1228, 47, false);
#line 48 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
                EndContext();
                BeginContext(1275, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1316, 43, false);
#line 51 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
                EndContext();
                BeginContext(1359, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(1400, 47, false);
#line 54 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfDeath));

#line default
#line hidden
                EndContext();
                BeginContext(1447, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1488, 43, false);
#line 57 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateOfDeath));

#line default
#line hidden
                EndContext();
                BeginContext(1531, 99, true);
                WriteLiteral("\n        </dd>\n        <button type=\"submit\" class=\"button\"><span>Удалить</span></button>\n\n        ");
                EndContext();
                BeginContext(1630, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "123800d6bb0a411c967509a80d0abb6c", async() => {
                    BeginContext(1651, 9, true);
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
                BeginContext(1664, 5, true);
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
            BeginContext(1676, 8, true);
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
