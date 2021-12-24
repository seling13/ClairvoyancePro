#pragma checksum "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailRelationship.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b565f8f1cdfce252673fdb747f45ccc0288d878d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Clairvoyance_Views_eKYC_eKYCDetailRelationship), @"mvc.1.0.view", @"/Areas/Clairvoyance/Views/eKYC/eKYCDetailRelationship.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b565f8f1cdfce252673fdb747f45ccc0288d878d", @"/Areas/Clairvoyance/Views/eKYC/eKYCDetailRelationship.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622fc8d18856d447da45ae7a5adc190a28c65137", @"/Areas/Clairvoyance/Views/_ViewImports.cshtml")]
    public class Areas_Clairvoyance_Views_eKYC_eKYCDetailRelationship : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneFin.Models.CFCustomer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""pre-scrollablex"">
        <div class=""border-bottom-cp"" style=""padding-top:20px"">
            <h4><strong>RELATIONSHIPS</strong></h4>
        </div>
        <div class=""box-body"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Relationship Name
                        </th>
                        <th>
                            Relationship Type
                        </th>
                        <th>
                            Relationship Status
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
        ");
            WriteLiteral("                    Last Update\r\n                        </th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 35 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailRelationship.cshtml"
                     foreach (var item in Model.RelationshipContentList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 39 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailRelationship.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SU09_relationshipCIFName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 42 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailRelationship.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SU05_relationshipType_FPRE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 45 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailRelationship.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SU06_relationshipStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 48 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailRelationship.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SU07_startDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailRelationship.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SU08_endDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 54 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailRelationship.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SU87_updatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailRelationship.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SU88_lastModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 61 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetailRelationship.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
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
