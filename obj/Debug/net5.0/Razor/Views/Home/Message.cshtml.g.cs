#pragma checksum "C:\projects\OneFin.core\Views\Home\Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b18b5613b645dd90e6a23e9dae47ee8940d4eefc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Message), @"mvc.1.0.view", @"/Views/Home/Message.cshtml")]
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
#line 1 "C:\projects\OneFin.core\Views\_ViewImports.cshtml"
using OneFin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\OneFin.core\Views\_ViewImports.cshtml"
using OneFin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b18b5613b645dd90e6a23e9dae47ee8940d4eefc", @"/Views/Home/Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622fc8d18856d447da45ae7a5adc190a28c65137", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""form-container"">

    <div class=""box-header with-border"">
        <span onclick=""closeMessage()"" class=""close"" title=""Close Override"">&times;</span>
        <h4 style=""text-align: left;"">Message</h4>
    </div>
    <div class=""box-body"">
        <div id=""errormessage"" style=""background-color: antiquewhite ;border-radius: 10px; "">
            <div class=""row"" style="" display: flex; align-items: center; justify-content: left"">
                <div class=""col-lg-1"">
                    <div class=""icon"" style=""color:firebrick; font-size: 40px; padding-left:20px"">
                        <i class=""fa fa-warning""></i>
                    </div>
                </div>
                <div class=""col-lg-11"">
                    <span  style=""color: firebrick; overflow: hidden"">");
#nullable restore
#line 18 "C:\projects\OneFin.core\Views\Home\Message.cshtml"
                                                                 Write(Html.Raw(ViewBag.message));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
            </div>

        </div>
        <div id=""infomessage"" style=""background-color:#A2E1DB; border-radius: 10px; "">
            <div class=""row"" style="" display: flex; align-items: center; justify-content: left"">
                <div class=""col-lg-1"">
                    <div class=""icon"" style=""color: darkgreen; font-size: 40px; padding-left: 20px;"">
                        <i class=""fa fa-check-circle""></i>
                    </div>
                </div>
                <div class=""col-lg-11"">
                    <span  style="" color: darkgreen; overflow: hidden"">");
#nullable restore
#line 31 "C:\projects\OneFin.core\Views\Home\Message.cshtml"
                                                                  Write(Html.Raw(ViewBag.message));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"box-footer\">\r\n        <button class=\"btn\" onclick=\"closeMessage()\" style=\"float:right\">Close</button>\r\n    </div>\r\n </div>\r\n    <script>\r\n        var type = \"");
#nullable restore
#line 41 "C:\projects\OneFin.core\Views\Home\Message.cshtml"
               Write(Html.Raw(ViewBag.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        if (type == \"E\") {\r\n            $(\"#errormessage\").show();\r\n            $(\"#infomessage\").hide();\r\n\r\n        }\r\n        else {\r\n            $(\"#errormessage\").hide();\r\n            $(\"#infomessage\").show();\r\n        }\r\n    </script>\r\n");
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
