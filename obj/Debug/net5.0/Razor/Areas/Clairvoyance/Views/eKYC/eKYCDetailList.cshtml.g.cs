#pragma checksum "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65f2804eeebc492f3231699979048b10aa7befab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Clairvoyance_Views_eKYC_eKYCDetailList), @"mvc.1.0.view", @"/Areas/Clairvoyance/Views/eKYC/eKYCDetailList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65f2804eeebc492f3231699979048b10aa7befab", @"/Areas/Clairvoyance/Views/eKYC/eKYCDetailList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622fc8d18856d447da45ae7a5adc190a28c65137", @"/Areas/Clairvoyance/Views/_ViewImports.cshtml")]
    public class Areas_Clairvoyance_Views_eKYC_eKYCDetailList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OneFin.Models.eKYCValidate>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""pre-scrollablex"">
        <table class=""table"">
            <thead>
                <tr>
                    <th style=""min-width:100px"">
                        Rule Name
                    </th>
                    <th style=""min-width:200px"">
                        Rule Description
                    </th>
                    <th style=""min-width:100px"">
                        Pass Or Fail
                    </th>
                    <th>
                        Recommendation
                    </th>
                    <th>
                        Label
                    </th>
                </tr>
            </thead>

            <tbody>

");
#nullable restore
#line 26 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                 foreach (var item in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <td>\r\n\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 916, "\"", 1022, 6);
            WriteAttributeValue("", 926, "GeteKYCListVerification(\'", 926, 25, true);
#nullable restore
#line 33 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 951, ViewBag.type, 951, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 964, "\',", 964, 2, true);
            WriteAttributeValue(" ", 966, "\'", 967, 2, true);
#nullable restore
#line 33 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 968, Html.DisplayFor(modelItem => item.DV01_lkbmdvIndex), 968, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1020, "\')", 1020, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                                                                                                                                              Write(Html.DisplayFor(modelItem => item.DV04_ruleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td>\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1179, "\"", 1284, 5);
            WriteAttributeValue("", 1189, "GeteKYCListVerification(\'", 1189, 25, true);
#nullable restore
#line 36 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 1214, ViewBag.type, 1214, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1227, "\',\'", 1227, 3, true);
#nullable restore
#line 36 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 1230, Html.DisplayFor(modelItem => item.DV01_lkbmdvIndex), 1230, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1282, "\')", 1282, 2, true);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 36 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                                                                                                                                              Write(Html.DisplayFor(modelItem => item.DV05_ruleDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n\r\n\r\n                        <td>\r\n                            <script>\r\n\r\n\r\n                    if (\'");
#nullable restore
#line 44 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                    Write(Html.DisplayFor(modelItem => item.DV07_passOrFail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \"FAIL\") {\r\n                        $(\"#");
#nullable restore
#line 45 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DV01_lkbmdvIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\").addClass(\"fa fa-close\");\r\n                        document.getElementById(\'");
#nullable restore
#line 46 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.DV01_lkbmdvIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style.color = \"red\";\r\n                    }\r\n\r\n                    if (\'");
#nullable restore
#line 49 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                    Write(Html.DisplayFor(modelItem => item.DV07_passOrFail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \"PASS\") {\r\n                        $(\"#");
#nullable restore
#line 50 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DV01_lkbmdvIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\").addClass(\"fa fa-check-circle\");\r\n                        document.getElementById(\'");
#nullable restore
#line 51 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.DV01_lkbmdvIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style.color = \"green\";\r\n                    }\r\n\r\n                            </script>\r\n                            <i");
            BeginWriteAttribute("id", " id=\'", 2238, "\'", 2295, 1);
#nullable restore
#line 55 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 2243, Html.DisplayFor(modelItem => item.DV01_lkbmdvIndex), 2243, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2312, "\"", 2417, 5);
            WriteAttributeValue("", 2322, "GeteKYCListVerification(\'", 2322, 25, true);
#nullable restore
#line 55 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 2347, ViewBag.type, 2347, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2360, "\',\'", 2360, 3, true);
#nullable restore
#line 55 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 2363, Html.DisplayFor(modelItem => item.DV01_lkbmdvIndex), 2363, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2415, "\')", 2415, 2, true);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 55 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayFor(modelItem => item.DV07_passOrFail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td>\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2577, "\"", 2682, 5);
            WriteAttributeValue("", 2587, "GeteKYCListVerification(\'", 2587, 25, true);
#nullable restore
#line 58 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 2612, ViewBag.type, 2612, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2625, "\',\'", 2625, 3, true);
#nullable restore
#line 58 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 2628, Html.DisplayFor(modelItem => item.DV01_lkbmdvIndex), 2628, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2680, "\')", 2680, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                                                                                                                                             Write(Html.DisplayFor(modelItem => item.DV09_recommendation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td>\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2845, "\"", 2950, 5);
            WriteAttributeValue("", 2855, "GeteKYCListVerification(\'", 2855, 25, true);
#nullable restore
#line 61 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 2880, ViewBag.type, 2880, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2893, "\',\'", 2893, 3, true);
#nullable restore
#line 61 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
WriteAttributeValue("", 2896, Html.DisplayFor(modelItem => item.DV01_lkbmdvIndex), 2896, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2948, "\')", 2948, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"
                                                                                                                                             Write(Html.DisplayFor(modelItem => item.OV05_TP_TN_FP_FN_Flag));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 64 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailList.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OneFin.Models.eKYCValidate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
