#pragma checksum "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c30c3094e60944f3df767d8846e49abdc0fa9249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Detail), @"mvc.1.0.view", @"/Views/Employee/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Detail.cshtml", typeof(AspNetCore.Views_Employee_Detail))]
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
#line 1 "C:\Projects\Employees\Employees\Views\_ViewImports.cshtml"
using Employees;

#line default
#line hidden
#line 2 "C:\Projects\Employees\Employees\Views\_ViewImports.cshtml"
using Employees.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30c3094e60944f3df767d8846e49abdc0fa9249", @"/Views/Employee/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81332b46592c63f123e2ce6d1e08eab301192ff5", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 247, true);
            WriteLiteral("\r\n\r\n<div class=\"col-md-12 grid-margin grid-margin-md-0\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <nav aria-label=\"breadcrumb\">\r\n                <ol class=\"breadcrumb\">\r\n                    <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(279, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c30c3094e60944f3df767d8846e49abdc0fa92494024", async() => {
                BeginContext(323, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(331, 55, true);
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(386, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c30c3094e60944f3df767d8846e49abdc0fa92495653", async() => {
                BeginContext(408, 13, true);
                WriteLiteral("Employee List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(425, 344, true);
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Employee Details</li>
                </ol>
            </nav><br /><br />
            <div class=""wrap d-flex justify-content-start justify-content-sm-center flex-wrap"">
                <img class=""rounded-circle shadow-lg"" style=""width:300px; height:350px""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 769, "\"", 803, 1);
#line 15 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 775, Url.Content(Model.ImageUrl), 775, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(804, 156, true);
            WriteLiteral(" alt=\"\" />\r\n                <div class=\"wrap align-items-center ml-5\">\r\n                    <p class=\"font-weight-bold text-success\" style=\"font-size:20px\">");
            EndContext();
            BeginContext(961, 14, false);
#line 17 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                                                               Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(975, 63, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> Role: ");
            EndContext();
            BeginContext(1039, 17, false);
#line 18 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                                    Write(Model.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(1056, 65, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> Gender: ");
            EndContext();
            BeginContext(1122, 12, false);
#line 19 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                                      Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 71, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Date Of Birth: ");
            EndContext();
            BeginContext(1206, 32, false);
#line 20 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                                            Write(Model.DOB.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 73, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Employee Number: ");
            EndContext();
            BeginContext(1312, 16, false);
#line 21 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                                              Write(Model.EmployeeNo);

#line default
#line hidden
            EndContext();
            BeginContext(1328, 67, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">ID Number: ");
            EndContext();
            BeginContext(1396, 26, false);
#line 22 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                                        Write(Model.IdentificationNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1422, 75, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Email: <a href=\"#\">");
            EndContext();
            BeginContext(1498, 11, false);
#line 23 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                                                Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1509, 69, true);
            WriteLiteral("</a></p>\r\n                    <p class=\"font-weight-normal\">Phone: <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1578, "\"", 1601, 2);
            WriteAttributeValue("", 1585, "tel:", 1585, 4, true);
#line 24 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 1589, Model.Phone, 1589, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1602, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1604, 11, false);
#line 24 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                                                               Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1615, 325, true);
            WriteLiteral(@"</a></p>
                    <br /><br />
                    <p class=""font-weight-bold"">Send Message</p>
                    <hr style=""background-color:crimson"" />
                   
                    <p class=""font-weight-normal""><i class=""fas fa-envelope"" style=""margin-right:0.6em; color:cornflowerblue""></i> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1940, "\"", 2007, 5);
            WriteAttributeValue("", 1947, "mailto:", 1947, 7, true);
#line 29 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 1954, Model.Email, 1954, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1966, "?subject=Greeting&body=Good", 1966, 27, true);
            WriteAttributeValue(" ", 1993, "day.", 1994, 5, true);
            WriteAttributeValue(" ", 1998, "Welcome.", 1999, 9, true);
            EndWriteAttribute();
            BeginContext(2008, 233, true);
            WriteLiteral(">Send Message</a></p>\r\n                    <br /><br />\r\n\r\n                    <p class=\"font-weight-bold\"> Address</p>\r\n                    <hr style=\"background-color:crimson\" />\r\n                    <p class=\"font-weight-normal\"> ");
            EndContext();
            BeginContext(2242, 13, false);
#line 34 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                              Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2255, 57, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> ");
            EndContext();
            BeginContext(2313, 10, false);
#line 35 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                              Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(2323, 57, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> ");
            EndContext();
            BeginContext(2381, 14, false);
#line 36 "C:\Projects\Employees\Employees\Views\Employee\Detail.cshtml"
                                              Write(Model.Postcode);

#line default
#line hidden
            EndContext();
            BeginContext(2395, 142, true);
            WriteLiteral("</p>\r\n                    <br />\r\n                    <br />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591