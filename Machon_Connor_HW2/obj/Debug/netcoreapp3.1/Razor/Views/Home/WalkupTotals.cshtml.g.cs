#pragma checksum "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d6c5f39a8feb1cf497b154065580bbe99c98414"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WalkupTotals), @"mvc.1.0.view", @"/Views/Home/WalkupTotals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6c5f39a8feb1cf497b154065580bbe99c98414", @"/Views/Home/WalkupTotals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6721c70986ad375634a6fe3a5a4d02cc195e473", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WalkupTotals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Machon_Connor_HW2.Models.WalkupOrder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
  
    ViewData["Title"] = "WalkupTotals";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Walkup Totals</h1>\r\n\r\n<div>\r\n    <h4>Walkup Order</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.CustomerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfHardbacks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfHardbacks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfPaperbacks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfPaperbacks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.TotalItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.HardbackSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.HardbackSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.PaperbackSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.PaperbackSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.SalesTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Connor Machon\OneDrive - The University of Texas at Austin\UT Classes\McCombs\MIS 333K\Machon_Connor_HW2\Machon_Connor_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <p><a asp-action=\"Index\">Home</a> | <a asp-action=\"CheckoutWalkup\">New Walkup Order</a></p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Machon_Connor_HW2.Models.WalkupOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
