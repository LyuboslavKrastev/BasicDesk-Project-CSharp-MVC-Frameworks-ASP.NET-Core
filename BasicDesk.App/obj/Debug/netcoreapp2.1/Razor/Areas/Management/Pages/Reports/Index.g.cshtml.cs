#pragma checksum "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\Reports\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46e1c7a63893d2669f456e8114750aecc9ac7ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BasicDesk.App.Areas.Admin.Pages.Reports.Areas_Management_Pages_Reports_Index), @"mvc.1.0.razor-page", @"/Areas/Management/Pages/Reports/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Management/Pages/Reports/Index.cshtml", typeof(BasicDesk.App.Areas.Admin.Pages.Reports.Areas_Management_Pages_Reports_Index), null)]
namespace BasicDesk.App.Areas.Admin.Pages.Reports
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\_ViewImports.cshtml"
using BasicDesk.App.Models.Management;

#line default
#line hidden
#line 2 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\_ViewImports.cshtml"
using BasicDesk.App.Models.Management.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\_ViewImports.cshtml"
using BasicDesk.App.Models.Management.BindingModels;

#line default
#line hidden
#line 6 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\_ViewImports.cshtml"
using BasicDesk.App.Helpers.Messages;

#line default
#line hidden
#line 5 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\_ViewImports.cshtml"
using BasicDesk.App.Models.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\_ViewImports.cshtml"
using BasicDesk.App.Helpers;

#line default
#line hidden
#line 1 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\_ViewImports.cshtml"
using BasicDesk.App;

#line default
#line hidden
#line 2 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\_ViewImports.cshtml"
using BasicDesk.Data.Models.Solution;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46e1c7a63893d2669f456e8114750aecc9ac7ee", @"/Areas/Management/Pages/Reports/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad873917d461b70d76499d5428e82820ecf910c", @"/Areas/Management/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119dab7d0cd187ece2a66cc8c2af7b264bbe7a0e", @"/Areas/Management/Pages/_ViewImports.cshtml")]
    public class Areas_Management_Pages_Reports_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\Reports\Index.cshtml"
  
    ViewData["Title"] = "Reports";

#line default
#line hidden
#line 6 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\Reports\Index.cshtml"
  
    var XLabels = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Model.Select(x => x.DimensionOne).ToList());
    var YValues = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Model.Select(x => x.Quantity).ToList());

#line default
#line hidden
            BeginContext(346, 146, true);
            WriteLiteral("    <div class=\"box-body col-md-5\">\r\n        <div class=\"chart-container\">\r\n            <canvas id=\"chart\"></canvas>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(492, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "580e99eb64114c80a5bdb7070536e427", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(540, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(542, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2da3a3eec70c49d29541171756595113", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(593, 234, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\r\n            $(function () {\r\n            var chartName = \"chart\";\r\n            var ctx = document.getElementById(chartName).getContext(\'2d\');\r\n            var data = {\r\n                    labels: ");
            EndContext();
            BeginContext(828, 17, false);
#line 23 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\Reports\Index.cshtml"
                       Write(Html.Raw(XLabels));

#line default
#line hidden
            EndContext();
            BeginContext(845, 1549, true);
            WriteLiteral(@",
                    datasets: [{
                        label: ""Submitted report"",
                        backgroundColor: [
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(54, 162, 235, 0.2)',
                            'rgba(255, 206, 86, 0.2)',
                            'rgba(75, 192, 192, 0.2)',
                            'rgba(153, 102, 255, 0.2)',
                            'rgba(255, 159, 64, 0.2)',
                            'rgba(255, 0, 0)',
                            'rgba(0, 255, 0)',
                            'rgba(0, 0, 255)',
                            'rgba(192, 192, 192)',
                            'rgba(255, 255, 0)',
                            'rgba(255, 0, 255)'
                        ],
                        borderColor: [
                            'rgba(255,99,132,1)',
                            'rgba(54, 162, 235, 1)',
                            'rgba(255, 206, 86, 1)',
                            'rgb");
            WriteLiteral(@"a(75, 192, 192, 1)',
                            'rgba(153, 102, 255, 1)',
                            'rgba(255, 159, 64, 1)',
                            'rgba(255, 0, 0)',
                            'rgba(0, 255, 0)',
                            'rgba(0, 0, 255)',
                            'rgba(192, 192, 192)',
                            'rgba(255, 255, 0)',
                            'rgba(255, 0, 255)'
                        ],
                        borderWidth: 1,
                        data: ");
            EndContext();
            BeginContext(2395, 17, false);
#line 55 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\Reports\Index.cshtml"
                         Write(Html.Raw(YValues));

#line default
#line hidden
            EndContext();
            BeginContext(2412, 1059, true);
            WriteLiteral(@"
        }]
                };

    var options = {
                    maintainAspectRatio: false,
                    scales: {
                        yAxes: [{
                            ticks: {
                                min: 0,
                                beginAtZero: true
                            },
                            gridLines: {
                                display: true,
                                color: ""rgba(255,99,164,0.2)""
                            }
    }],
                        xAxes: [{
                            ticks: {
                                min: 0,
                                beginAtZero: true
                            },
                            gridLines: {
                                display: false
                            }
                        }]
                    }
                };
           var myChart = new  Chart(ctx, {
                    options: options,
                    data:");
            WriteLiteral(" data,\r\n                    type: \"");
            EndContext();
            BeginContext(3472, 16, false);
#line 86 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Pages\Reports\Index.cshtml"
                      Write(TempData["Type"]);

#line default
#line hidden
            EndContext();
            BeginContext(3488, 111, true);
            WriteLiteral("\"\r\n                    // may be pie bar doughnut and others\r\n                });\r\n            });\r\n</script>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasicDesk.App.Areas.Management.Pages.Reports.ReportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasicDesk.App.Areas.Management.Pages.Reports.ReportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasicDesk.App.Areas.Management.Pages.Reports.ReportModel>)PageContext?.ViewData;
        public BasicDesk.App.Areas.Management.Pages.Reports.ReportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
