#pragma checksum "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f55221c8daf5130d9cc08a3e977116276438639"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminRole_Edit), @"mvc.1.0.view", @"/Views/AdminRole/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminRole/Edit.cshtml", typeof(AspNetCore.Views_AdminRole_Edit))]
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
#line 1 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\_ViewImports.cshtml"
using Survey2;

#line default
#line hidden
#line 2 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\_ViewImports.cshtml"
using Survey2.Models;

#line default
#line hidden
#line 3 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\_ViewImports.cshtml"
using Survey2.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f55221c8daf5130d9cc08a3e977116276438639", @"/Views/AdminRole/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9362cce18f39c40eb7ac24392d0bbc6c52c5dda8", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminRole_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(107, 135, true);
            WriteLiteral("<div class=\"container col-md-12\">\r\n    <div class=\"bg-primary text-white col-lg-pull-1 m-1\">\r\n        <h2>Edit</h2>\r\n\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(242, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b85d910673c418c9d71092b463074cd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 11 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(308, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(312, 1590, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b3f68586b1e44f2b21b0df583e21d62", async() => {
                BeginContext(350, 40, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 390, "\"", 412, 1);
#line 14 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 398, Model.Role.Id, 398, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(413, 45, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 458, "\"", 482, 1);
#line 15 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 466, Model.Role.Name, 466, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(483, 63, true);
                WriteLiteral(" />\r\n\r\n    <h6 class=\"bg-info p-1 text-white\">\r\n        Add to ");
                EndContext();
                BeginContext(547, 15, false);
#line 18 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
          Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(562, 66, true);
                WriteLiteral("\r\n    </h6>\r\n\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 22 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
                BeginContext(684, 65, true);
                WriteLiteral("            <tr><td colspan=\"2\">All Users Are Members</td></tr>\r\n");
                EndContext();
#line 25 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
        }
        else
        {
             

#line default
#line hidden
#line 28 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
              foreach (var user in Model.NonMembers)
             {

#line default
#line hidden
                BeginContext(855, 48, true);
                WriteLiteral("                 <tr>\r\n                     <td>");
                EndContext();
                BeginContext(904, 13, false);
#line 31 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
                    Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(917, 97, true);
                WriteLiteral("</td>\r\n                     <td>\r\n                         <input type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1014, "\"", 1030, 1);
#line 33 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 1022, user.Id, 1022, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1031, 57, true);
                WriteLiteral(" />\r\n                     </td>\r\n                 </tr>\r\n");
                EndContext();
#line 36 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
             }

#line default
#line hidden
#line 36 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
              
        }

#line default
#line hidden
                BeginContext(1115, 79, true);
                WriteLiteral("\r\n    </table>\r\n\r\n    <h6 class=\"bg-info p-1 text-white\">\r\n        Delete from ");
                EndContext();
                BeginContext(1195, 15, false);
#line 42 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
               Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1210, 66, true);
                WriteLiteral("\r\n\r\n    </h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 46 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
                BeginContext(1329, 64, true);
                WriteLiteral("            <tr><td colspan=\"2\">No Users Are Members</td></tr>\r\n");
                EndContext();
#line 49 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 52 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
             foreach (var user in Model.Members)
            {

#line default
#line hidden
                BeginContext(1494, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1541, 13, false);
#line 55 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1554, 98, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1652, "\"", 1668, 1);
#line 57 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 1660, user.Id, 1660, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1669, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 60 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
            }

#line default
#line hidden
#line 60 "C:\Users\Ertugrul Batur\Desktop\BITES\Projects\Survey2\Survey2\Views\AdminRole\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1750, 85, true);
                WriteLiteral("\r\n    </table>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n    ");
                EndContext();
                BeginContext(1835, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac0a7c9664a14a96aa9fc61ceec6312f", async() => {
                    BeginContext(1883, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1893, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1902, 24, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
