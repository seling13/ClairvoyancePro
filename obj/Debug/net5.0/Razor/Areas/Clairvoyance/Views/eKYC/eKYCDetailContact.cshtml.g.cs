#pragma checksum "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a066a7fcb6e7f223f2a98b618907e837ca0a73a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Clairvoyance_Views_eKYC_eKYCDetailContact), @"mvc.1.0.view", @"/Areas/Clairvoyance/Views/eKYC/eKYCDetailContact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a066a7fcb6e7f223f2a98b618907e837ca0a73a4", @"/Areas/Clairvoyance/Views/eKYC/eKYCDetailContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622fc8d18856d447da45ae7a5adc190a28c65137", @"/Areas/Clairvoyance/Views/_ViewImports.cshtml")]
    public class Areas_Clairvoyance_Views_eKYC_eKYCDetailContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneFin.Models.CFCustomer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""pre-scrollablex"">
        <div class=""border-bottom-cp"" style=""padding-top:20px"">
            <h4><strong>PHONE</strong></h4>
        </div>
        <div class=""box-body"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Phone Number
                        </th>
                        <th>
                            Contact Type
                        </th>
                        <th>
                            Source
                        </th>
                        <th style=""min-width:120px"">
                            Start Date
                        </th>
                        <th style=""min-width:120px"">
                            End Date
                        </th>
                        <th>
                            Updated By
                        </th>
                        <th style=""min-width:120px"">
                            Last Update");
            WriteLiteral(@"
                        </th>
                        <th style=""text-align:center"">
                            Registered To History
                        </th>
                        <th style=""text-align:center"">
                            OTP Pass
                        </th>
                        <th style=""text-align:center"">
                            OTP Fail
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 43 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                     foreach (var item in Model.PhoneContentList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PH03_phoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PH04_phoneType_FPTL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PH05_source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PH06_startDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 59 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PH07_EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PH87_userID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PH88_lastUpdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            <a href=\"#\" onclick=\"PopupDetail(\'Addres\')\">");
#nullable restore
#line 68 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.RegHist));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            <a href=\"#\" onclick=\"PopupOTP(\'Addres\')\"> ");
#nullable restore
#line 71 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.OTPHist));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            <a href=\"#\" onclick=\"PopupOTP(\'Addres\')\"> ");
#nullable restore
#line 74 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.OTPHist));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 77 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
    <div class=""pre-scrollablex"">
        <div class=""border-bottom-cp"" style=""padding-top:20px"">
            <h4><strong>Email</strong></h4>
        </div>
        <div class=""box-body"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Email Address
                        </th>
                        <th>
                            Source
                        </th>
                        <th style=""min-width:120px"">
                            Start Date
                        </th>
                        <th style=""min-width:120px"">
                            End Date
                        </th>
                        <th>
                            Updated By
                        </th>
                        <th style=""min-width:120px"">
                            Last Update
                        ");
            WriteLiteral(@"</th>
                        <th style=""text-align:center"">
                            Registered To History
                        </th>
                        <th style=""text-align:center"">
                            OTP Pass
                        </th>
                        <th style=""text-align:center"">
                            OTP Fail
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 120 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                     foreach (var item in Model.EmailContentList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 124 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EM03_emailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 127 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EM06_source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 130 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EM04_startDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 133 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EM05_endDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 136 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EM87_userID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 139 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EM88_lastUpdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            <a href=\"#\" onclick=\"PopupDetail(\'Addres\')\">");
#nullable restore
#line 142 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.RegHist));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            <a href=\"#\" onclick=\"PopupOTP(\'Addres\')\"> ");
#nullable restore
#line 145 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.OTPHist));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            <a href=\"#\" onclick=\"PopupOTP(\'Addres\')\"> ");
#nullable restore
#line 148 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.OTPHist));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 151 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>

    <div class=""pre-scrollablex"">
        <div class=""border-bottom-cp"" style=""padding-top:20px"">
            <h4><strong>Social Medial</strong></h4>
        </div>
        <div class=""box-body"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Social Media ID
                        </th>
                        <th>
                            Social Media Type
                        </th>
                        <th style=""min-width:120px"">
                            Start Date
                        </th>
                        <th style=""min-width:120px"">
                            End Date
                        </th>
                        <th>
                            Updated By
                        </th>
                        <th style=""min-width:120px"">
                            Last Update
 ");
            WriteLiteral("                       </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 186 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                     foreach (var item in Model.SocialMediaContentList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 190 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SM04_socialMediaUserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 193 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SM03_socialMediaType_FKXX));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 196 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SM05_startDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 199 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SM06_endDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 202 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SM87_userID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 205 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                           Write(Html.DisplayFor(modelItem => item.lastUpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 208 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailContact.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>");
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
