#pragma checksum "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f330e947c91ba0c430a56c4e06895c45805525d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Clairvoyance_Views_eKYC_eKYCDetail), @"mvc.1.0.view", @"/Areas/Clairvoyance/Views/eKYC/eKYCDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f330e947c91ba0c430a56c4e06895c45805525d", @"/Areas/Clairvoyance/Views/eKYC/eKYCDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622fc8d18856d447da45ae7a5adc190a28c65137", @"/Areas/Clairvoyance/Views/_ViewImports.cshtml")]
    public class Areas_Clairvoyance_Views_eKYC_eKYCDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OneFin.Models.eKYCValidate>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n");
#nullable restore
#line 3 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
  
    ViewData["Title"] = "Index";
    var viewdata = ViewData["searchstring"];
    var customer = ViewData["Customer"] as CFCustomer;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    var filter = \"All\";\r\n    var tabType = \"BIO\";\r\n</script>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f330e947c91ba0c430a56c4e06895c45805525d3760", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <style>\r\n    </style>\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f330e947c91ba0c430a56c4e06895c45805525d4841", async() => {
                WriteLiteral(@"
    <div id=""overlay"" style=""display:none""></div>
    <div class=""form-popup"" id=""myForm""></div>
    <section class=""content-header"" id=""headerpanel"">

        <h1>
            <strong id=""HeaderName"">
            </strong>

        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""/home/index""><i class=""fa fa-dashboard""></i> Home</a></li>
            <li> eKYC Validation</li>
        </ol>
    </section>
    <section class=""content container-fluid"">
        <div id=""overlay"" style=""display: none"">
            <div id=""loader""></div>
        </div>
        <div class=""box"">
            <div class=""container col-lg-12"" style=""display: flex; align-items: center; padding-top:20px; padding-bottom:20px"">
                <div class=""col-lg-3"" style=""align-items:center"">

                    <div style=""position:relative;border:0;padding:0;margin:0; width:280px; height:280px "">
                        <canvas id=""myChart"" width=""200"" height=""200"" style=""position:absolute; z-inde");
                WriteLiteral("x:3\"></canvas>\r\n                        <div style=\"width: 300px; height: 300px; padding-left:39px;padding-top:57px \">\r\n                            <img style=\"width: 200px; height: 200px;\" class=\"img-circle\"");
                BeginWriteAttribute("src", " src=\"", 1650, "\"", 1685, 1);
#nullable restore
#line 47 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
WriteAttributeValue("", 1656, Html.Raw(customer.IMGSource), 1656, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4\" style=\"padding-bottom:10px\">\r\n                    <span style=\"font-size:40px\">\r\n                        <strong> ");
#nullable restore
#line 54 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
                            Write(Html.Raw(customer.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>
                    </span><br />
                    <div class=""box-body"" style=""padding-left:0"">
                        <span style=""font-size:14px""><i class=""fa fa-handshake-o""></i> Quant Onboarding</span><br />
                        <span style=""font-size: 14px""><i class=""fa fa-user-secret""></i> MLTF Risk Level 2</span><br />
                        <span style=""font-size: 14px""><i class=""fa fa-check-square-o""></i> Personal Score</span><br />
                        <span style="" font-size: 14px;""> <i class=""fa fa-warning""></i> Credit Risk Level </span><br />
                    </div>
                    <span");
                BeginWriteAttribute("style", " style=\"", 2597, "\"", 2605, 0);
                EndWriteAttribute();
                WriteLiteral(@"> Transaction Override </span><br />
                    <span style=""padding-bottom:20px;""> Bio-metric Authentication Failed </span>
                </div>
                <div class=""col-lg-4"" style=""padding-bottom: 10px; padding-bottom:100px; font-size: 30px; text-align: center; vertical-align: text-top; "">
                    <div class=""col-lg-4""><strong>3</strong><br /><span style=""font-size:16px"">e-KYC</span></div>
                    <div class=""col-lg-4""><strong>2</strong><br /><span style=""font-size:16px"">MLTF</span></div>
                    <div class=""col-lg-4""><strong>3</strong><br /><span style=""font-size:16px"">TX Monitoring</span></div>
                </div>
            </div>
            <div class=""box-header"">
                <div id=""DIV-source"" style=""margin-top:10px;"">

                    <button class=""btn-source active-btn-selected btn-rounded""> Ultron Pro</button>
                    <button class=""btn-source btn-rounded""> eXponential Pro</button>
                    <");
                WriteLiteral(@"button class=""btn-source btn-rounded""> Olive Pro</button>
                    <button class=""btn-source btn-rounded""> Olive for Business</button>
                    <!--<button class=""btn1 btn-rounded""><i class=""fa fa-user-circle-o""></i> Biometric</button>-->
                </div>
            </div>
            <script>
                // Add active class to the current button (highlight it)
                var header = document.getElementById(""DIV-source"");
                var btns = header.getElementsByClassName(""btn-source"");
                for (var i = 0; i < btns.length; i++) {
                    btns[i].addEventListener(""click"", function () {
                        var current = document.getElementsByClassName(""active-btn-selected"");
                        current[0].className = current[0].className.replace("" active-btn-selected"", """");
                        this.className += "" active-btn-selected"";
                    });
                }
            </script>

            <di");
                WriteLiteral(@"v class=""box-header border-bottom-cp"" style=""padding-top:20px"">
                <div class=""row"">
                    <div class=""col-lg-2"">
                        <h4> <strong>e-KYC Result </strong></h4>
                    </div>
                    <div class=""col-lg-10"">
                        <div id=""DIV-status"" style=""margin-top:10px; float:right"">
                            <button class=""btn-status active-btn-selected-0 btn-rounded""> All </button>
                            <button class=""btn-status btn-rounded""> Pass</button>
                            <button class=""btn-status btn-rounded""> Fail</button>
                            <button class=""btn-status btn-rounded""> Override</button>
                        </div>
                    </div>

                </div>
                <script>
                    // Add active class to the current button (highlight it)
                    var header = document.getElementById(""DIV-status"");
                    var btns = heade");
                WriteLiteral(@"r.getElementsByClassName(""btn-status"");
                    for (var i = 0; i < btns.length; i++) {
                        btns[i].addEventListener(""click"", function () {
                            var current = document.getElementsByClassName(""active-btn-selected-0"");
                            current[0].className = current[0].className.replace("" active-btn-selected-0"", """");
                            this.className += "" active-btn-selected-0"";
                            filter = this.innerText;
                            eKYCDetailList(tabType);
                            ('#eKYCDetailList').show();

                        });
                    }
                </script>
            </div>

            <div class=""tab-cp animate-bottom"" style=""padding-left:10px"">
                <button id=""tabBIO"" class=""tablinks"" onclick=""openValidation(event, 'BIO')"">Biometric Validation</button>
                <button id=""tabAddress"" class=""tablinks"" onclick=""openValidation(event, 'Address'");
                WriteLiteral(@")"">Address Validation</button>
                <button id=""tabID"" class=""tablinks"" onclick=""openValidation(event, 'ID')"">ID Validation</button>
                <button id=""tabContact"" class=""tablinks"" onclick=""openValidation(event, 'Contact')"">Contact Validation</button>
                <button id=""tabEmployment"" class=""tablinks"" onclick=""openValidation(event, 'Employment')"">Employment Validation</button>
                <button id=""tabIncome"" class=""tablinks"" onclick=""openValidation(event, 'Income')"">Income Validation</button>
                <button id=""tabRelationship"" class=""tablinks"" onclick=""openValidation(event, 'Relationship')"">Relationship Validation</button>
            </div>

            <div class=""box-body"">
                <div id=""BIO"" class=""tabcontent animate-bottom""> </div>
                <div id=""Address"" class=""tabcontent animate-bottom""></div>
                <div id=""ID"" class=""tabcontent animate-bottom""></div>
                <div id=""Contact"" class=""tabcontent animate-bot");
                WriteLiteral(@"tom""> </div>
                <div id=""Employment"" class=""tabcontent animate-bottom""> </div>
                <div id=""Income"" class=""tabcontent animate-bottom""> </div>
                <div id=""Relationship"" class=""tabcontent animate-bottom""> </div>

            </div>

        </div>
        <div class=""animate-bottom"" id=""eKYCDetailList""></div>
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
    function PopupDetail(type) {
        //$(""#myForm"").load(""CustomerLKOverride"", { LKOverride: data });
        document.getElementById(""overlay"").style.display = ""block"";
        document.getElementById(""myForm"").style.display = ""block"";
        document.getElementById(""myForm"").style.paddingTop = ""10%"";
        $(""#myForm"").load(""eKYCRegisteredHistory"")
    };
    function PopupOTP(type) {
    //$(""#myForm"").load(""CustomerLKOverride"", { LKOverride: data });
    document.getElementById(""overlay"").style.display = ""block"";
    document.getElementById(""myForm"").style.display = ""block"";
    document.getElementById(""myForm"").style.paddingTop = ""10%"";
    $(""#myForm"").load(""eKYCOTPHistory"")
    };


    function closeFormHistory() {
        document.getElementById(""overlay"").style.display = ""none"";
        document.getElementById(""myForm"").style.display = ""none"";
    };

    var ekycvalidate = '");
#nullable restore
#line 177 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
                   Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var customer = \'");
#nullable restore
#line 178 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
               Write(Html.Raw(Json.Serialize(customer)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    $(document).ready(function () {
        document.getElementById('tabBIO').click();

    });

    function GeteKYCListVerification(type, ekycid) {
        var tab = '#' + type;
        loader(""ON"");
        $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 190 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
                 Write(Url.Action("eKYCDetailListVerification", "eKYC"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    type: type,
                    ekycid: ekycid,
                    ekycvalidate: ekycvalidate

                },
                error: function (result) {
                    showMessage(""E"", result.status + "" "" + result.statusText + "" "" + ""Something wrong, please try again""
                    );
                    $(tab).html("""");;
                },
                success: function (result) {
                        if (result.status == false) {
                            showMessage(""E"", result.message);

                        }
                        else {
                            $(tab).html(result);

                        }
                    loader(""OFF"");
                }
            }
        );
        $(""#eKYCDetailList"").hide();
    };

    function openValidation(evt, ekyctab) {
        var i, tabcontent, tablinks;
        tabcontent = document.getElementsByClassName(""tabcontent"");
        for (i = 0; ");
            WriteLiteral(@"i < tabcontent.length; i++) {
            tabcontent[i].style.display = ""none"";
        }
        tablinks = document.getElementsByClassName(""tablinks"");
        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace("" active-selected"", "" "");
            tabType = ekyctab;


        }
        document.getElementById(ekyctab).style.display = ""block"";
        evt.currentTarget.className += "" active-selected"";

        eKYCDetailList(ekyctab);
        $('#eKYCDetailList').show();
        if (ekyctab == ""BIO"") {
            eKYCDetailBIO();
            $('#HeaderName').text(""Biometric Validation"");

        }
        else if (ekyctab == ""Address"") {
            eKYCDetailAddress();
           // $(""#Address"").load(""eKYCDetailAddress"");
            $('#HeaderName').text(""Address Validation"");

        }
        else if (ekyctab == ""ID"") {
            $(""#ID"").load(""eKYCDetailID"");
            $('#HeaderName').text(""ID Validation"");

 ");
            WriteLiteral(@"       }
        else if (ekyctab == ""Contact"") {
            eKYCDetailContact();
            //$(""#Contact"").load(""eKYCDetailContact"");
            $('#HeaderName').text(""Contact Validation"");

        }
        else if (ekyctab == ""Employment"") {
            eKYCDetailEmployment();
            //$(""#Employment"").load(""eKYCDetailEmployment"");
            $('#HeaderName').text(""Employment Validation"");

        }
        else if (ekyctab == ""Income"") {
            eKYCDetailIncome();
            //$(""#Income"").load(""eKYCDetailIncome"");
            $('#HeaderName').text(""Income Validation"");

        }
        else if (ekyctab == ""Relationship"") {
            eKYCDetailRelationship();
            //$(""#Relationship"").load(""eKYCDetailRelationship"");
            $('#HeaderName').text(""Relationship Validation"");

        }
        else {
            $('#eKYCDetailList').html("""");
            $('#HeaderName').text("""");
        }

    }


        var xValues = [""Pass"", ""Fail"", ""Ove");
            WriteLiteral(@"rride""];
        var yValues = [55, 49, 44];
        var barColors = [""#D4F0F0"", ""#FCB9AA"",""#CCE2CB""];

        new Chart(""myChart"", {
            type: ""doughnut"",
            data: {
                labels: xValues,
                datasets: [{ backgroundColor: barColors, data: yValues }],

            },
            options: {
                cutoutPercentage: 80,
            title: {
            display: false,
        text: ""eKYC Criteria""
    }
  }
        });


    function eKYCDetailList(type) {
        loader(""ON"");

        $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 311 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
                 Write(Url.Action("eKYCDetailList", "eKYC"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    filter: filter,
                    type: type,
                    ekycvalidate: ekycvalidate
                },
                error: function (result) {
                    showMessage(""E"", result.status + "" "" + result.statusText + "" "" + ""Something wrong, please try again""
                    );
                    $('#eKYCDetailList').html("""");;
                },
                success: function (result) {
                        if (result.status == false) {
                            showMessage(""E"", result.message);
                        }
                        else {
                            $(""#eKYCDetailList"").html(result);

                        }
                    loader(""OFF"");
                }
            }
        );
    }

      function eKYCDetailBIO() {
          loader(""ON"");
        $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 341 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
                 Write(Url.Action("eKYCDetailBIO", "eKYC"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {

                    cfcustomer: customer
                },
                error: function (result) {
                    showMessage(""E"", result.status + "" "" + result.statusText + "" "" + ""Something wrong, please try again""
                    );
                    $('#BIO').html("""");;
                },
                success: function (result) {
                        if (result.status == false) {
                            showMessage(""E"", result.message);

                        }
                        else {
                            $(""#BIO"").html(result);

                        }
                    loader(""OFF"");
                }
            }
        );
    }

        function eKYCDetailAddress() {
          loader(""ON"");
        $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 371 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
                 Write(Url.Action("eKYCDetailAddress", "eKYC"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {

                    cfcustomer: customer
                },
                error: function (result) {
                    showMessage(""E"", result.status + "" "" + result.statusText + "" "" + ""Something wrong, please try again""
                    );
                    $('#Address').html("""");;
                },
                success: function (result) {
                        if (result.status == false) {
                            showMessage(""E"", result.message);

                        }
                        else {
                            $(""#Address"").html(result);

                        }
                    loader(""OFF"");
                }
            }
        );
    }

           function eKYCDetailContact() {
          loader(""ON"");
        $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 401 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
                 Write(Url.Action("eKYCDetailContact", "eKYC"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    cfcustomer: customer
                },
                error: function (result) {
                    showMessage(""E"", result.status + "" "" + result.statusText + "" "" + ""Something wrong, please try again""
                    );
                    $('#Contact').html("""");;
                },
                success: function (result) {
                        if (result.status == false) {
                            showMessage(""E"", result.message);

                        }
                        else {
                            $(""#Contact"").html(result);

                        }
                    loader(""OFF"");
                }
            }
        );
    }

         function eKYCDetailEmployment() {
          loader(""ON"");
        $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 430 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
                 Write(Url.Action("eKYCDetailEmployment", "eKYC"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    cfcustomer: customer
                },
                error: function (result) {
                    showMessage(""E"", result.status + "" "" + result.statusText + "" "" + ""Something wrong, please try again""
                    );
                    $('#Employment').html("""");;
                },
                success: function (result) {
                        if (result.status == false) {
                            showMessage(""E"", result.message);

                        }
                        else {
                            $(""#Employment"").html(result);

                        }
                    loader(""OFF"");
                }
            }
        );
    }

    function eKYCDetailIncome() {
          loader(""ON"");
        $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 459 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
                 Write(Url.Action("eKYCDetailIncome", "eKYC"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    cfcustomer: customer
                },
                error: function (result) {
                    showMessage(""E"", result.status + "" "" + result.statusText + "" "" + ""Something wrong, please try again""
                    );
                    $('#Income').html("""");;
                },
                success: function (result) {
                        if (result.status == false) {
                            showMessage(""E"", result.message);

                        }
                        else {
                            $(""#Income"").html(result);

                        }
                    loader(""OFF"");
                }
            }
        );
    }

      function eKYCDetailRelationship() {
          loader(""ON"");
        $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 488 "C:\projects\OneFin.core\Areas\Clairvoyance\Views\eKYC\eKYCDetail.cshtml"
                 Write(Url.Action("eKYCDetailRelationship", "eKYC"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    cfcustomer: customer
                },
                error: function (result) {
                    showMessage(""E"", result.status + "" "" + result.statusText + "" "" + ""Something wrong, please try again""
                    );
                    $('#Relationship').html("""");;
                },
                success: function (result) {
                        if (result.status == false) {
                            showMessage(""E"", result.message);

                        }
                        else {
                            $(""#Relationship"").html(result);

                        }
                    loader(""OFF"");
                }
            }
        );
    }

    function ValidateCancel(type) {
        var text = 'tab' + type;
        document.getElementById(text).click();
    }



</script>

");
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
