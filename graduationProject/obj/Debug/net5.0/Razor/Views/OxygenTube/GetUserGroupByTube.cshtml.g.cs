#pragma checksum "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "816e1c2384e061d9bb97abe4fd14691c8236f307"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OxygenTube_GetUserGroupByTube), @"mvc.1.0.view", @"/Views/OxygenTube/GetUserGroupByTube.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"816e1c2384e061d9bb97abe4fd14691c8236f307", @"/Views/OxygenTube/GetUserGroupByTube.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19de8a9a31073cc8c88cdc97c543447b39cab6c", @"/Views/_ViewImports.cshtml")]
    public class Views_OxygenTube_GetUserGroupByTube : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TubesViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
  
    ViewData["Title"] = "Users by Tubes";
    ViewBag.usergrouptubes = "active";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content bg-white\" style=\"min-height: 425px; padding: 20px; \">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n");
#nullable restore
#line 11 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                 foreach (var gr in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3>Tubes Type: ");
#nullable restore
#line 13 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                               Write(gr.OxgnType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <table class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>
                                    First Name
                                </th>
                                <th>
                                    Last Name
                                </th>
                                <th>
                                    SSN
                                </th>
                                <th>
                                    Phone
                                </th>
                                <th>
                                    Reservation Date
                                </th>
                                <th>
                                    Number Of Incubators
                                </th>

                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 40 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                             foreach (var item in gr.UserReservationOxegin)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 44 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 47 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.User.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 50 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.User.SSN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 53 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 56 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Res_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 59 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Num_tubes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 63 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 66 "E:\visual Appliactions\graduationProject\graduationProject\Views\OxygenTube\GetUserGroupByTube.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TubesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
