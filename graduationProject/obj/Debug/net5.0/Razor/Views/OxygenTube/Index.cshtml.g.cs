#pragma checksum "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22025c16782fa582321176178788b1284e8f368f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OxygenTube_Index), @"mvc.1.0.view", @"/Views/OxygenTube/Index.cshtml")]
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
#line 1 "E:\visual Appliactions\graduationProject\graduationProject\Views\_ViewImports.cshtml"
using graduationProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\visual Appliactions\graduationProject\graduationProject\Views\_ViewImports.cshtml"
using graduationProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\visual Appliactions\graduationProject\graduationProject\Views\_ViewImports.cshtml"
using graduationProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\visual Appliactions\graduationProject\graduationProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22025c16782fa582321176178788b1284e8f368f", @"/Views/OxygenTube/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19de8a9a31073cc8c88cdc97c543447b39cab6c", @"/Views/_ViewImports.cshtml")]
    public class Views_OxygenTube_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<graduationProject.Models.OxygenTube>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml"
  
    ViewData["Title"] = "Oxegin Tubes";
    ViewBag.Oxeginlist = "active";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card mb-4"">
                    <div class=""card-header"">
                        <i class=""fas fa-table me-1""></i>
                        DataTable Example
                    </div>
                    <div class=""card-body"">
                        <div class=""create-edit text-end"">
                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 616, "\"", 723, 5);
            WriteAttributeValue("", 626, "showInPopup(\'", 626, 13, true);
#nullable restore
#line 17 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml"
WriteAttributeValue("", 639, Url.Action("AddOrEdit", "OxygenTube", null, Context.Request.Scheme), 639, 68, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 707, "\',", 707, 2, true);
            WriteAttributeValue(" ", 709, "\'Create", 710, 8, true);
            WriteAttributeValue(" ", 717, "New\')", 718, 6, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" id=""button1""><i class=""far fa-plus-square""></i>Create New</a>
                        </div>
                        <div class=""alert alert-success alert-dismissible fade show mt-4 d-none"" id=""alert"" role=""alert"">
                            <strong>Success</strong>
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <table id=""datatablesSimple"" class=""table table-striped mt-4"">
                            <thead>
                                <tr class=""bg-primary text-white"">
                                    <th>
                                        ");
#nullable restore
#line 29 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 32 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 35 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 38 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 41 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 44 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 47 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </th>
                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tfoot>

                            </tfoot>
                            <tbody id=""view-all"">
                                ");
#nullable restore
#line 56 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\Index.cshtml"
                           Write(Html.Partial("_ViewAllTubes", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22025c16782fa582321176178788b1284e8f368f9944", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<graduationProject.Models.OxygenTube>> Html { get; private set; }
    }
}
#pragma warning restore 1591
