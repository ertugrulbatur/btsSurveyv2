#pragma checksum "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\Answers\GetAnswers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46e810485d81037b31deb214798c71848096bef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answers_GetAnswers), @"mvc.1.0.view", @"/Views/Answers/GetAnswers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Answers/GetAnswers.cshtml", typeof(AspNetCore.Views_Answers_GetAnswers))]
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
#line 1 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\_ViewImports.cshtml"
using Survey2;

#line default
#line hidden
#line 2 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\_ViewImports.cshtml"
using Survey2.Models;

#line default
#line hidden
#line 3 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\_ViewImports.cshtml"
using Survey2.Models.ViewModels;

#line default
#line hidden
#line 4 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46e810485d81037b31deb214798c71848096bef6", @"/Views/Answers/GetAnswers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9362cce18f39c40eb7ac24392d0bbc6c52c5dda8", @"/Views/_ViewImports.cshtml")]
    public class Views_Answers_GetAnswers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\Answers\GetAnswers.cshtml"
  
    ViewData["Title"] = "GetAnswers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\Answers\GetAnswers.cshtml"
 foreach (var question in Model.Questions)
{    

#line default
#line hidden
            BeginContext(161, 32, true);
            WriteLiteral("        <tr>\r\n\r\n            <td>");
            EndContext();
            BeginContext(194, 13, false);
#line 11 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\Answers\GetAnswers.cshtml"
           Write(question.Text);

#line default
#line hidden
            EndContext();
            BeginContext(207, 11, true);
            WriteLiteral("</td>\r\n\r\n\r\n");
            EndContext();
#line 14 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\Answers\GetAnswers.cshtml"
             foreach (var choice in question.Choices)
            {

#line default
#line hidden
            BeginContext(288, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(309, 11, false);
#line 16 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\Answers\GetAnswers.cshtml"
               Write(choice.Text);

#line default
#line hidden
            EndContext();
            BeginContext(320, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 17 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\Answers\GetAnswers.cshtml"
            }

#line default
#line hidden
            BeginContext(342, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 19 "D:\MASAÜSTÜ\proje2\btsSurveyv2\Survey2\Survey2\Views\Answers\GetAnswers.cshtml"
    }

#line default
#line hidden
            BeginContext(364, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
