#pragma checksum "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e336ede7842acedf9abd0c644d84d2f7afb33188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Clairvoyance_Views_eKYC_eKYCSearch), @"mvc.1.0.view", @"/Areas/Clairvoyance/Views/eKYC/eKYCSearch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e336ede7842acedf9abd0c644d84d2f7afb33188", @"/Areas/Clairvoyance/Views/eKYC/eKYCSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622fc8d18856d447da45ae7a5adc190a28c65137", @"/Areas/Clairvoyance/Views/_ViewImports.cshtml")]
    public class Areas_Clairvoyance_Views_eKYC_eKYCSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n");
#nullable restore
#line 2 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCSearch.cshtml"
  
    ViewData["Title"] = "Index";
    var viewdata = ViewData["searchstring"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e336ede7842acedf9abd0c644d84d2f7afb331885222", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
 /* Apple Tab */

        .tab-ap 
        {
            margin-top: 10px;
            margin-left: 10px;
            padding: 2px 2px 2px 2px;
            overflow: hidden;
            background-color: var(--applegrey);
            border-radius: 10px;
            width: -webkit-fit-content;
        }

            .tab-ap button {
                border-radius: 10px;
                background-color: inherit;
                border: none;
                outline: none;
                cursor: pointer;
                transition: 0.3s;
                min-width: 145px;
                min-height: 25px;
                font-size: 12px;
            }

            /* Change background color of buttons on hover */
            .tab-ap button:hover {
                background-color: #ddd;
            }

            /* Create an active/current tablink class */
                .tab-ap button.activ");
                WriteLiteral("e-selected {\r\n                    background-color: white;\r\n                    border-color: none;\r\n                    color: black;\r\n                    border-radius: 10px;\r\n                }\r\n\r\n\r\n/* Add animation (fade in the popup) */\r\n");
                WriteLiteral("@keyframes fadeIn {\r\n  from {opacity: 0;}\r\n  to {opacity: 1;}\r\n}\r\n\r\n");
                WriteLiteral(@"@keyframes fadeIn {
  from {opacity: 0;}
  to {opacity:1 ;}
}

/*datepicker*/
        input[type=""date""]::-webkit-calendar-picker-indicator {
            background-image: url('');
          
        }

        .cal-wrp {
            position: relative;
            background-color: white;
        }

        .btnCal-wrp {
            display: inline-block;
            width: 100%;
            position: relative;
            z-index: 10;
        }

      
        .btnCal {
            background: transparent;
            border: none;
            color: grey;
            padding: 6px 10px 0 0;
            position: absolute;
            right: 0;
            top: 0;
        }

    </style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e336ede7842acedf9abd0c644d84d2f7afb331888394", async() => {
                WriteLiteral(@"
    <section class=""content-header"" id=""headerpanel"">
        <h1 style=""font-size:43px"">
            <strong>Search</strong>
        </h1>
 
    </section>
        <section class=""content container-fluid"">
            <div id=""overlay"" style=""display: none"">
                <div id=""loader""></div>
            </div>


            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e336ede7842acedf9abd0c644d84d2f7afb331889010", async() => {
                    WriteLiteral("\r\n                <div style=\"position:relative;border:0;padding:0;margin:0;\">\r\n                    <select class=\"form-control form-search-cp\" id=\"select\" style=\"padding-left:10px;\">\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e336ede7842acedf9abd0c644d84d2f7afb331889495", async() => {
                        WriteLiteral("Search");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e336ede7842acedf9abd0c644d84d2f7afb3318810806", async() => {
                        WriteLiteral("ID Number");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e336ede7842acedf9abd0c644d84d2f7afb3318812121", async() => {
                        WriteLiteral("Name");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                    </select>
                    <input class=""form-control"" style=""padding-left: 90px; background-color: #EEEEEF"" type=""text"" placeholder=""Leave Blank to Search All, Search Function is open to - ID Number, Name"" id=""id"" name=""id"">
                </div>


                <div class=""box-header"">
                    <div class=""col-sm-4 nopadding"">
                        <div class=""row-cp"" style=""padding-top:15px; padding-right:15px"">
                            <div class=""col-sm-4 nopadding"">Search From</div>
                            <div class=""col-sm-8  "">
                                <div class=""cal-wrp"">
                                    <div class=""btnCal-wrp"">
                                        <input id=""txtSearch"" style=""display: flex; align-items: center; background-color:transparent"" class=""form-control"" type=""date"" />
                                    </div>
                                    <button class=""btnCal""><span class=""fa fa-calendar""></");
                    WriteLiteral(@"span></button>
                                </div>
                               
                            </div>

                        </div>
                    </div>
                    <div class=""col-sm-4 nopadding"">
                        <div class=""row-cp"" style=""padding-top:15px; padding-right:15px;"">
                            <div class=""col-sm-4 nopadding"">Search Until</div>
                            <div class=""col-sm-8 "">
                                <div class=""cal-wrp"">
                                    <div class=""btnCal-wrp"">
                                        <input id=""txtSearch"" style=""display: flex; align-items: center; background-color:transparent"" class=""form-control"" type=""date"" />
                                    </div>
                                    <button class=""btnCal""><span class=""fa fa-calendar""></span></button>
                                </div>
                            </div>
                        </div>
           ");
                    WriteLiteral(@"         </div>

                </div>
                <div class=""border-bottom-cp"">
                    <h4><strong>History</strong></h4>
                </div>

                <div class=""box-header"">
                    <div id=""DIV-LVL"" style=""margin-top:10px;"">
                        <button class=""btn-lvl btn-rounded active-btn-selected"" hidden> </button>
                        <button class=""btn-lvl btn-rounded""> Level 1</button>
                        <button class=""btn-lvl btn-rounded""> Level 2</button>
                        <button class=""btn-lvl btn-rounded""> Level 3</button>
                        <button class=""btn-lvl btn-rounded""> Level 4</button>
                        <button class=""btn-lvl btn-rounded""> Quant</button>
                        <button class=""btn-lvl btn-rounded""> Ultron Pro</button>
                        <!--<button class=""btn1 btn-rounded""><i class=""fa fa-user-circle-o""></i> Biometric</button>-->
                    </div>
                </div>");
                    WriteLiteral(@"
                <script>
                    // Add active class to the current button (highlight it)
                    var header = document.getElementById(""DIV-LVL"");
                    var btns = header.getElementsByClassName(""btn-lvl"");
                    for (var i = 0; i < btns.length; i++) {
                        btns[i].addEventListener(""click"", function () {
                            var current = document.getElementsByClassName(""active-btn-selected"");
                            current[0].className = current[0].className.replace("" active-btn-selected"", """");
                            this.className += "" active-btn-selected"";
                            if (this.innerText == ""Level 1"") {
                                if ($('#id').val() != """" && $('#select').val() == """") {
                                    //myPopup(""Please select Type"", true);

                                    $('#7days').html("""");;
                                }
                                els");
                    WriteLiteral(@"e {
                                    //myPopup("""", false);
                                    GeteKYC();
                                }
                            }
                            else {
                                $(""#7days"").html("""");
                            }

                        });

                    }
                </script>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""tab-ap"" >
                <button id=""default7days"" class=""tablinks"" onclick=""openPeriod(event, '7days')"">7 Days</button>
                <button class=""tablinks"" onclick=""openPeriod(event, '14Days')"">14 days</button>
                <button class=""tablinks"" onclick=""openPeriod(event, '21days')"">21 days</button>
                <button class=""tablinks"" onclick=""openPeriod(event, '21daysmore')"">> 21 days</button>

            </div>

            <div class=""box-body"">
                <div id=""7days"" class=""tabcontent animate-bottom"">

                </div>
                <div id=""14Days"" class=""tabcontent animate-bottom"">
                    <div class=""box-header with-border"">
                        <i class=""fa fa-wrench""></i> Under Contrustion
                    </div>
                </div>

                <div id=""21days"" class=""tabcontent animate-bottom"">
                    <div class=""box-header with-border"">
                        <i class=""fa fa-wre");
                WriteLiteral(@"nch""></i> Under Contrustion
                    </div>

                </div>
                <div id=""21daysmore"" class=""tabcontent animate-bottom"">
                    <div class=""box-header with-border"">
                        <i class=""fa fa-wrench""></i> Under Contrustion
                    </div>
                </div>
            </div>

        </section>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<script>
    $('#nav-link').attr(""href"", ""eKYCSearch"")
    $('#nav-name').text(""e-KYC"");

    $(""#id"").on('keyup', function (e) {
        if ($(""#id"").val() == """")
            {
            $(""select"").prop('required', false);
        }
        else {
            $(""select"").prop('required', true);
        }
        }
    );

    $(""#_form"").submit(function (e) {
        e.preventDefault();
    });

    $(document).ready(function () {
        document.getElementById('default7days').click();
    
    });



    function openPeriod(evt, cityName) {
        var i, tabcontent, tablinks;
        tabcontent = document.getElementsByClassName(""tabcontent"");
        for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = ""none"";
        }
        tablinks = document.getElementsByClassName(""tablinks"");
        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace("" active-selected"", "" "");
      ");
            WriteLiteral(@"  }
        document.getElementById(cityName).style.display = ""block"";
        evt.currentTarget.className += "" active-selected"";
    }

    function GeteKYC() {
        loader(""ON"");
        $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 274 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCSearch.cshtml"
                 Write(Url.Action("eKYCSearchList", "eKYC"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    Name: $('#id').val()
                },
                error: function (result) {
                    showMessage(""E"", result.status + "" "" + result.statusText + "" "" + ""Something wrong, please try again""
                    );
                    $('#7days').html("""");
                },
                success: function (result) {
                        if (result.status == false) {
                            showMessage(""E"", result.message);
                        }
                        else {
                            var list_html = '';
                            for (var i = 0; i < 3; i++) {

                                result = result.replace(/myChart/g, ""myChart"" + i.toString());
                                console.log(result);
                                list_html += result;
                            }
                            //$(""#7days"").html(list_html);
                            $(""#7days"").html(result)");
            WriteLiteral(";\r\n                        }\r\n                    loader(\"OFF\");\r\n                }\r\n            }\r\n        );\r\n    }\r\n</script>\r\n");
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
