#pragma checksum "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46cf51742d7b5d63837bcf965a1b61bbb09e8ebc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Clairvoyance_Views_eKYC_eKYCDetailIncome), @"mvc.1.0.view", @"/Areas/Clairvoyance/Views/eKYC/eKYCDetailIncome.cshtml")]
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
#line 1 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\_ViewImports.cshtml"
using OneFin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\_ViewImports.cshtml"
using OneFin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46cf51742d7b5d63837bcf965a1b61bbb09e8ebc", @"/Areas/Clairvoyance/Views/eKYC/eKYCDetailIncome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622fc8d18856d447da45ae7a5adc190a28c65137", @"/Areas/Clairvoyance/Views/_ViewImports.cshtml")]
    public class Areas_Clairvoyance_Views_eKYC_eKYCDetailIncome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneFin.Models.CFCustomer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""border-bottom-cp"" style=""padding-top:20px"">
            <h4><strong>MONTHLY INCOME</strong></h4>
        </div>
        <div class=""box-body"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Period
                        </th>
                        <th>
                            Income Category
                        </th>
                        <th>
                            Total Monthly Income
                        </th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 24 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml"
                     foreach (var item in Model.MIncomeContentList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 28 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MI04_period));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 31 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MI04_periodMI05_incomeCatagory_FPSU));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 34 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MI03_totalMonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 37 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
    <div class=""col-lg-6"">
        <div class=""border-bottom-cp"" style=""padding-top:20px"">
            <h4><strong>ANNUAL INCOME</strong></h4>
        </div>
        <div class=""box-body"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Year
                        </th>
                        <th>
                            Income Category
                        </th>
                        <th>
                            Total Annual Income
                        </th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 63 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml"
                     foreach (var item in Model.YIncomeContentList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 67 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AI04_YYYY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 70 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AI05_incomeCat_FPSU));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 73 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AI03_annualIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 76 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailIncome.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneFin.Models.CFCustomer> Html { get; private set; }
    }
}
#pragma warning restore 1591