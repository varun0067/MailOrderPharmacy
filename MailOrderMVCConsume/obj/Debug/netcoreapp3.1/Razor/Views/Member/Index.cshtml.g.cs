#pragma checksum "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Member\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "783712db9927e5b48fc8514aaad5653de917098a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Index), @"mvc.1.0.view", @"/Views/Member/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\_ViewImports.cshtml"
using MailOrderMVCConsume;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\_ViewImports.cshtml"
using MailOrderMVCConsume.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"783712db9927e5b48fc8514aaad5653de917098a", @"/Views/Member/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a214a97ce29ac6d882e5aa061c973af48ece2731", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Member\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Dashboard</h1>\r\n\r\n<table cellpadding=\"30\">\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 12 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Member\Index.cshtml"
       Write(Html.ActionLink("View All Drugs", "AllDrugs", "Drug"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 17 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Member\Index.cshtml"
       Write(Html.ActionLink("Create Prescription", "CreatePrescription", "Subscription"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 22 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Member\Index.cshtml"
       Write(Html.ActionLink("Get All Prescription", "GetAllPrescriptions", "Subscription"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 27 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Member\Index.cshtml"
       Write(Html.ActionLink("Get All Subscription", "GetAllSubscriptions", "Subscription"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 32 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Member\Index.cshtml"
       Write(Html.ActionLink("Get Refill Dues As Of Date", "GetRefillDuesAsOfDate", "Refill"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>");
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
