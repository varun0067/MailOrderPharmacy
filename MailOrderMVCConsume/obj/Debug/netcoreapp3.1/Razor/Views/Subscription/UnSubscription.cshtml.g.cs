#pragma checksum "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Subscription\UnSubscription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50d5eb32eaa851312ffd34ad2c1e08f834b8386d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscription_UnSubscription), @"mvc.1.0.view", @"/Views/Subscription/UnSubscription.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50d5eb32eaa851312ffd34ad2c1e08f834b8386d", @"/Views/Subscription/UnSubscription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a214a97ce29ac6d882e5aa061c973af48ece2731", @"/Views/_ViewImports.cshtml")]
    public class Views_Subscription_UnSubscription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Subscription\UnSubscription.cshtml"
  
    ViewData["Title"] = "UnSubscription";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Subscription\UnSubscription.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        window.onload = function () {\r\n            alert(\"");
#nullable restore
#line 11 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Subscription\UnSubscription.cshtml"
              Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        };\r\n    </script>\r\n");
#nullable restore
#line 14 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Subscription\UnSubscription.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Subscription\UnSubscription.cshtml"
Write(Html.ActionLink("View All Subscriptions", "GetAllSubscriptions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
