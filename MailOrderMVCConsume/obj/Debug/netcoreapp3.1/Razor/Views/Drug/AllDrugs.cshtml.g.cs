#pragma checksum "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "463c24a531f9630b08aad907898fa97b83f7c9c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drug_AllDrugs), @"mvc.1.0.view", @"/Views/Drug/AllDrugs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463c24a531f9630b08aad907898fa97b83f7c9c8", @"/Views/Drug/AllDrugs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a214a97ce29ac6d882e5aa061c973af48ece2731", @"/Views/_ViewImports.cshtml")]
    public class Views_Drug_AllDrugs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MailOrderMVCConsume.DTO.DrugDetailsDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
  
    ViewData["Title"] = "AllDrugs";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Drugs Details</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayNameFor(model => model.DrugId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayNameFor(model => model.DrugName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayNameFor(model => model.ManufactureDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpiryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayNameFor(model => model.Composition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitsInPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayNameFor(model => model.CostPerPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayFor(modelItem => item.DrugId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayFor(modelItem => item.DrugName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayFor(modelItem => item.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayFor(modelItem => item.ManufactureDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpiryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayFor(modelItem => item.Composition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnitsInPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
           Write(Html.DisplayFor(modelItem => item.CostPerPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 74 "C:\Users\user\Desktop\All MicroServices\MailOrderMVCConsume\Views\Drug\AllDrugs.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MailOrderMVCConsume.DTO.DrugDetailsDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
