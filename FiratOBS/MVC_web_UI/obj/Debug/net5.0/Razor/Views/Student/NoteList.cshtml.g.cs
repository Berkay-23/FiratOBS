#pragma checksum "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793e9473240dc11fc85b4d9b7d3a83763976c32d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_NoteList), @"mvc.1.0.view", @"/Views/Student/NoteList.cshtml")]
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
#line 1 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\_ViewImports.cshtml"
using MVC_web_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\_ViewImports.cshtml"
using MVC_web_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793e9473240dc11fc85b4d9b7d3a83763976c32d", @"/Views/Student/NoteList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6165074ccb8b30f75b348ba200ff9bad175b54e", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_NoteList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoteListModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
  
    ViewData["Title"] = "Not Listesi";
    Layout = "~/Views/Shared/_StudentLayout.cshtml";
    TempData["studentModel"] = TempData["studentModel"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class= \"noteList\">\n\n");
#nullable restore
#line 10 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
     using (Html.BeginForm("NoteList", "Student", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <select onchange=\"this.form.submit()\" class=\"form-select\" id=\"periodSelectNote\" name=\"selectPeriod\" aria-label=\"Default select example\">\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "793e9473240dc11fc85b4d9b7d3a83763976c32d3845", async() => {
                WriteLiteral("Dönem Seçiniz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 16 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
         for (int i = 0; i < Model.Periods.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "793e9473240dc11fc85b4d9b7d3a83763976c32d5699", async() => {
#nullable restore
#line 18 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
               Write(Model.Periods[i]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 19 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </select>\r\n");
#nullable restore
#line 22 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n");
#nullable restore
#line 24 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
     if(Model.ReceivedLessons != null){


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"header\"><h2>");
#nullable restore
#line 26 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                           Write(Model.Period);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\n");
            WriteLiteral(@"        <table class=""table table-dark table-striped text-center"">

            <thead>
                <tr>
                    <th scope=""col"">Ders Kodu</th>
                    <th scope=""col"">Ders Adı</th>
                    <th scope=""col"">Vize Notu</th>
                    <th scope=""col"">Final Notu</th>
                    <th scope=""col"">Bütünleme Notu</th>
                    <th scope=""col"">Ortalama</th>
                    <th scope=""col"">Harf Notu</th>
                    <th scope=""col"">Durum</th>
                </tr>
            </thead>
        
            <tbody>
            
");
#nullable restore
#line 45 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
             for (int i = 0; i <Model.ReceivedLessons.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td scope=\"row\">");
#nullable restore
#line 48 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                               Write(Model.ReceivedLessons[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td scope=\"row\">");
#nullable restore
#line 49 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                               Write(Model.LessonNames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td scope=\"row\">");
#nullable restore
#line 50 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                               Write(Model.StudentNoteInfos[i].MidtermExam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td scope=\"row\">");
#nullable restore
#line 51 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                               Write(Model.StudentNoteInfos[i].FinalExamination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
#nullable restore
#line 53 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                     if (Model.StudentNoteInfos[i].MakeupExam == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td scope=\"row\">-</td>\n");
#nullable restore
#line 56 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td scope=\"row\">");
#nullable restore
#line 59 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                                   Write(Model.StudentNoteInfos[i].MakeupExam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 60 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <td scope=\"row\">");
#nullable restore
#line 62 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                               Write(Model.StudentNoteInfos[i].Average);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td scope=\"row\">");
#nullable restore
#line 63 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                               Write(Model.StudentNoteInfos[i].LetterGrade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td scope=\"row\">");
#nullable restore
#line 64 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
                               Write(Model.StudentNoteInfos[i].Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\r\n");
#nullable restore
#line 66 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\n");
#nullable restore
#line 70 "C:\Users\iredc\source\repos\FiratOBS\MVC_web_UI\Views\Student\NoteList.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoteListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
