#pragma checksum "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Customer\Views\Order\ConfirmOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcebeb0b4503ddb0904ad036dc308e0c412561d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_ConfirmOrder), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/ConfirmOrder.cshtml")]
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
#line 1 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Customer\Views\_ViewImports.cshtml"
using UniqueCornerBD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Customer\Views\_ViewImports.cshtml"
using UniqueCornerBD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcebeb0b4503ddb0904ad036dc308e0c412561d6", @"/Areas/Customer/Views/Order/ConfirmOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f6bbb108832ee2c876d24ad71cbc3156ca0c1a", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_ConfirmOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\md.mahabub alam\OneDrive\Desktop\PROJECT FILE FIRST\Backup Everything\BACKUP 10122020\uniquecorner\UniqueCornerBD\UniqueCornerBD\Areas\Customer\Views\Order\ConfirmOrder.cshtml"
   
    ViewData["Title"] = "ConfirmOrder";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1 class=\"text-primary\">Congratulation!</h1>\r\n    \r\n    <h2 class=\"text-success\"> Your Order Has Been Confirmed.You Will Get Notification Soon</h2>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 

<script>
    $(document).ready(function () {
        $(""h1"").animate({
            left: '250px',
            height: '+=150px',
            width: '+=150px'
        });
        //var h1 = $(""h1"");
        //h1.animate({ height: '300px', opacity: '0.5' }, ""slow"");
        //h1.animate({ width: '400px', opacity: '0.8' }, ""slow"");
        //h1.animate({ height: '400px', opacity: '0.5' }, ""slow"");
        //h1.animate({ width: '400px', opacity: '0.8' }, ""slow"");

            //var h1 = $(""h2"");
            //h1.animate({ height: '300px', opacity: '0.5' }, ""slow"");
            //h1.animate({ width: '400px', opacity: '0.8' }, ""slow"");
            //h1.animate({ height: '400px', opacity: '0.5' }, ""slow"");
            //h1.animate({ width: '400px', opacity: '0.8' }, ""slow"");



        $(""h2"").animate({
            left: '250px',
            height: '+=150px',
            width: '+=150px'
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
