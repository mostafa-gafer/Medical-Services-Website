#pragma checksum "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da17eff04b36e2591c75b43de82e8813807e186a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OxygenTube_GetTubeByPublisher), @"mvc.1.0.view", @"/Views/OxygenTube/GetTubeByPublisher.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da17eff04b36e2591c75b43de82e8813807e186a", @"/Views/OxygenTube/GetTubeByPublisher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19de8a9a31073cc8c88cdc97c543447b39cab6c", @"/Views/_ViewImports.cshtml")]
    public class Views_OxygenTube_GetTubeByPublisher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<graduationProject.Models.OxygenTube>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml"
  
    ViewData["Title"] = "OxygenTube";
    ViewBag.tubebypulisher = "active";

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
            BeginWriteAttribute("onclick", " onclick=\"", 620, "\"", 738, 5);
            WriteAttributeValue("", 630, "showInPopup(\'", 630, 13, true);
#nullable restore
#line 18 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml"
WriteAttributeValue("", 643, Url.Action("AddOrEditbyPublisher", "OxygenTube", null, Context.Request.Scheme), 643, 79, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 722, "\',", 722, 2, true);
            WriteAttributeValue(" ", 724, "\'Create", 725, 8, true);
            WriteAttributeValue(" ", 732, "New\')", 733, 6, true);
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
#line 30 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 33 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 36 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 39 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 42 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 45 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxgnDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 48 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Department.Dept_Name));

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
#line 57 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetTubeByPublisher.cshtml"
                           Write(Html.Partial("_ViewTubesbyPublisher", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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