#pragma checksum "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d348d4ef140c022df0bb2d3af2af53e13a61635f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OxygenTube_GetUserByTube), @"mvc.1.0.view", @"/Views/OxygenTube/GetUserByTube.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d348d4ef140c022df0bb2d3af2af53e13a61635f", @"/Views/OxygenTube/GetUserByTube.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19de8a9a31073cc8c88cdc97c543447b39cab6c", @"/Views/_ViewImports.cshtml")]
    public class Views_OxygenTube_GetUserByTube : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<graduationProject.Models.UserReservationOxegin>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
  
    ViewData["Title"] = "GetUserByTubes";
    ViewBag.UserBytube = "active";

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
                        DataTable
                    </div>
                    <div class=""card-body"">
                        <div class=""header"">
                            <h1>User Reservation</h1>
                        </div>
                        <table id=""datatablesSimple"" class=""table table-striped mt-4"">
                            <thead>
                                <tr class=""bg-primary text-white"">
                                    <th>
                                        ");
#nullable restore
#line 24 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                   Write(Html.DisplayNameFor(model => model.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 27 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                   Write(Html.DisplayNameFor(model => model.User.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 30 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OxygenTube));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 33 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                   Write(Html.DisplayNameFor(model => model.User.SSN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 36 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                   Write(Html.DisplayNameFor(model => model.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 39 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Res_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 42 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Num_tubes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tfoot></tfoot>\r\n                            <tbody>\r\n");
#nullable restore
#line 49 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 53 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 56 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.User.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 59 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.OxygenTube.OxgnType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 62 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.User.SSN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 65 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 68 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Res_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 71 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Num_tubes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a href=\"javascript:;\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 74 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"far fa-trash-alt\"></i>Cancel Reservation</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 77 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserByTube.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d348d4ef140c022df0bb2d3af2af53e13a61635f12899", async() => {
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
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.js-delete').on('click', function () {
                var btn = $(this);
                bootbox.confirm({
                    message: ""This is a confirm with custom button text and color! Do you like it?"",
                    buttons: {
                        confirm: {
                            label: 'Yes',
                            className: 'btn-danger'
                        },
                        cancel: {
                            label: 'No',
                            className: 'btn-secondary'
                        }
                    },
                    callback: function (result) {
                        if (result) {
                            $.ajax({
                                url: '/api/UserreservationTube/?Id=' + btn.data('id'),
                                method: 'DELETE',
                                success: function () {
                                    btn.");
                WriteLiteral(@"parents('tr').fadeOut();
                                    $('#alert').removeClass('d-none');
                                    setTimeout(function () { $('#alert').addClass('d-none'); }, 3000);
                                },
                                error: function () {
                                    alert('some this went wrong');
                                },
                            });
                        }


                    }
                });
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<graduationProject.Models.UserReservationOxegin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
