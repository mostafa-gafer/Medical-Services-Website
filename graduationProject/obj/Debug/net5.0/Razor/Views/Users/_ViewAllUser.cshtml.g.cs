#pragma checksum "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d5bfb3c362c4ba60053789a31505375c0f76a39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__ViewAllUser), @"mvc.1.0.view", @"/Views/Users/_ViewAllUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d5bfb3c362c4ba60053789a31505375c0f76a39", @"/Views/Users/_ViewAllUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19de8a9a31073cc8c88cdc97c543447b39cab6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__ViewAllUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 5 "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 6 "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 7 "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 8 "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 9 "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml"
       Write(string.Join(" , ", item.Roles.ToList()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"text-center\" >\r\n            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 436, "\"", 542, 3);
            WriteAttributeValue("", 446, "showInPopup(\'", 446, 13, true);
#nullable restore
#line 11 "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml"
WriteAttributeValue("", 459, Url.Action("ManageRoles","Users",new {id=item.Id},Context.Request.Scheme), 459, 74, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 533, "\',\'Edit\')", 533, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-tasks\"></i>Roles</a>\r\n            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 629, "\"", 735, 3);
            WriteAttributeValue("", 639, "showInPopup(\'", 639, 13, true);
#nullable restore
#line 12 "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml"
WriteAttributeValue("", 652, Url.Action("EditProfile","Users",new {id=item.Id},Context.Request.Scheme), 652, 74, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 726, "\',\'Edit\')", 726, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-user-edit\"></i></a>\r\n            <a href=\"javascript:;\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 13 "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml"
                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"far fa-trash-alt\"></i></a>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 16 "E:\visual Appliactions\graduationProject\graduationProject\Views\Users\_ViewAllUser.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
