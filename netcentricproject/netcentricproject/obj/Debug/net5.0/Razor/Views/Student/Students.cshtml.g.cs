#pragma checksum "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\Student\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "024a0f5010c6e20395cd53536fdcd9ad5eb44819"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Students), @"mvc.1.0.view", @"/Views/Student/Students.cshtml")]
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
#line 1 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\_ViewImports.cshtml"
using netcentricproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\_ViewImports.cshtml"
using netcentricproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"024a0f5010c6e20395cd53536fdcd9ad5eb44819", @"/Views/Student/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bdec2e042f1792c4a2940a41bfb50c7960c79bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable< StudentModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\Student\Students.cshtml"
  
    ViewData["Title"] = "Students";
    int studentCounter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Students</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "024a0f5010c6e20395cd53536fdcd9ad5eb448193774", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
              S.No.
            </th>
            <th>
               Name
            </th>
            <th>
              Roll
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\Student\Students.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n              ");
#nullable restore
#line 31 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\Student\Students.cshtml"
         Write(studentCounter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\Student\Students.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               ");
#nullable restore
#line 37 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\Student\Students.cshtml"
          Write(item.Roll);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\Student\Students.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { studentId = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                ");
#nullable restore
#line 42 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\Student\Students.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { studentId = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                ");
#nullable restore
#line 44 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\Student\Students.cshtml"
           Write(Html.ActionLink("Marks", "StudentMarks", "Marks" , new { studentId = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "E:\Project\netcentricproject\netcentricproject\netcentricproject\Views\Student\Students.cshtml"
    studentCounter++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable< StudentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
