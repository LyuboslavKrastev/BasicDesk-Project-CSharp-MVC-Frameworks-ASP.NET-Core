#pragma checksum "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Views\Users\Unban.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eae8b0250fdd8931cb67b1712acf375c77ffb1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BasicDesk.App.Areas.Admin.Views.Users.Areas_Management_Views_Users_Unban), @"mvc.1.0.view", @"/Areas/Management/Views/Users/Unban.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Management/Views/Users/Unban.cshtml", typeof(BasicDesk.App.Areas.Admin.Views.Users.Areas_Management_Views_Users_Unban))]
namespace BasicDesk.App.Areas.Admin.Views.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\_ViewImports.cshtml"
using BasicDesk.App.Models.Management;

#line default
#line hidden
#line 2 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\_ViewImports.cshtml"
using BasicDesk.App.Models.Management.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\_ViewImports.cshtml"
using BasicDesk.App.Models.Management.BindingModels;

#line default
#line hidden
#line 4 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\_ViewImports.cshtml"
using BasicDesk.App.Helpers.Messages;

#line default
#line hidden
#line 5 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\_ViewImports.cshtml"
using BasicDesk.App.Models.ViewModels;

#line default
#line hidden
#line 6 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\_ViewImports.cshtml"
using BasicDesk.App.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eae8b0250fdd8931cb67b1712acf375c77ffb1d", @"/Areas/Management/Views/Users/Unban.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad873917d461b70d76499d5428e82820ecf910c", @"/Areas/Management/_ViewImports.cshtml")]
    public class Areas_Management_Views_Users_Unban : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 31, true);
            WriteLiteral("\n<h2 class=\"text-center\">Unban ");
            EndContext();
            BeginContext(60, 14, false);
#line 3 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Views\Users\Unban.cshtml"
                         Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(74, 13, true);
            WriteLiteral("</h2>\n<hr />\n");
            EndContext();
            BeginContext(87, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "234b9ec5bf314188ae59e93068d92606", async() => {
                BeginContext(144, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(150, 22, false);
#line 6 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Areas\Management\Views\Users\Unban.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
                EndContext();
                BeginContext(172, 124, true);
                WriteLiteral("\n    <div class=\"col-sm-10 col-sm-push-2\">\n        <input type=\"submit\" value=\"Unban\" class=\"btn btn-success\" />\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(303, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
