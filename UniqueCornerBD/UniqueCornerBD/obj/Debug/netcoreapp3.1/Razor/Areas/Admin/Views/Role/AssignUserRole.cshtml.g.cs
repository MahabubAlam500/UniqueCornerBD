#pragma checksum "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\Role\AssignUserRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c34117cee4a984bf336777feaca2062f165c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_AssignUserRole), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/AssignUserRole.cshtml")]
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
#line 1 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\_ViewImports.cshtml"
using UniqueCornerBD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\_ViewImports.cshtml"
using UniqueCornerBD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c34117cee4a984bf336777feaca2062f165c7f", @"/Areas/Admin/Views/Role/AssignUserRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f6bbb108832ee2c876d24ad71cbc3156ca0c1a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Role_AssignUserRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\Role\AssignUserRole.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<br />\n<br />\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-info\">Assign User Role</h2>\n    </div>\n");
            WriteLiteral("</div>\n<br />\n<div>\n    <table class=\"table table-striped border\">\n        <tr class=\"table-info\">\n            <th>\n                User Name\n            </th>\n\n            <th>Role Name</th>\n        </tr>\n");
#nullable restore
#line 25 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\Role\AssignUserRole.cshtml"
         foreach (var item in ViewBag.UserRoles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 28 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\Role\AssignUserRole.cshtml"
   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 29 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\Role\AssignUserRole.cshtml"
   Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("</tr>");
#nullable restore
#line 41 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\Role\AssignUserRole.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</div>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js\"></script>\n    <script type=\"text/javascript\">\n        $(function(){\n            var save = \'");
#nullable restore
#line 49 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\n            if(save!=\'\') {\n                alertify.success(save);\n            }\n            var edit = \'");
#nullable restore
#line 53 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\n            if(edit!=\'\') {\n                alertify.success(edit);\n            }\n            var del = \'");
#nullable restore
#line 57 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\n            if (del!=\'\') {\n                alertify.error(del);\n            }\n        })\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
