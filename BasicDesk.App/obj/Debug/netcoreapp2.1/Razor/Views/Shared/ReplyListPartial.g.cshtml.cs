#pragma checksum "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7189efc83262128063a868a3fa762dcce9dd63e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ReplyListPartial), @"mvc.1.0.view", @"/Views/Shared/ReplyListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ReplyListPartial.cshtml", typeof(AspNetCore.Views_Shared_ReplyListPartial))]
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
#line 1 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\_ViewImports.cshtml"
using BasicDesk.App;

#line default
#line hidden
#line 2 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\_ViewImports.cshtml"
using BasicDesk.App.Models;

#line default
#line hidden
#line 3 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\_ViewImports.cshtml"
using BasicDesk.Data.Models.Solution;

#line default
#line hidden
#line 4 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\_ViewImports.cshtml"
using BasicDesk.App.Models.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\_ViewImports.cshtml"
using BasicDesk.App.Models.Common.BindingModels;

#line default
#line hidden
#line 6 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\_ViewImports.cshtml"
using BasicDesk.App.Helpers.Messages;

#line default
#line hidden
#line 7 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\_ViewImports.cshtml"
using BasicDesk.App.Helpers;

#line default
#line hidden
#line 8 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\_ViewImports.cshtml"
using BasicDesk.App.Models.Common.ViewModels;

#line default
#line hidden
#line 9 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\_ViewImports.cshtml"
using BasicDesk.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7189efc83262128063a868a3fa762dcce9dd63e9", @"/Views/Shared/ReplyListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d96ffe35850e90bc8a938653933dc8ffd63c5d13", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ReplyListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RequestReplyViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Requests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(67, 327, true);
            WriteLiteral(@"    <button type=""button"" class=""btn btn-info"" data-toggle=""collapse"" data-target=""#replies"">Show Replies</button>
    <div id=""replies"" class=""collapse"">
        <div class=""panel"">
            <div class=""panel-heading clearfix"">
                <div class=""pull-left""><strong>Replies</strong></div>
            </div>
");
            EndContext();
#line 11 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
             foreach (var reply in Model)
            {

#line default
#line hidden
            BeginContext(452, 160, true);
            WriteLiteral("            <div class=\"panel-body\">\r\n                <div class=\"panel-heading clearfix\">\r\n                    <div class=\"pull-left\"><strong>Author:</strong> ");
            EndContext();
            BeginContext(613, 12, false);
#line 15 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                                                               Write(reply.Author);

#line default
#line hidden
            EndContext();
            BeginContext(625, 81, true);
            WriteLiteral("</div>\r\n                    <div class=\"pull-right\"><strong>Created On:</strong> ");
            EndContext();
            BeginContext(707, 18, false);
#line 16 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                                                                    Write(reply.CreationTime);

#line default
#line hidden
            EndContext();
            BeginContext(725, 123, true);
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"panel-body\">\r\n                    <p><strong>Subject:</strong> ");
            EndContext();
            BeginContext(849, 13, false);
#line 19 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                                            Write(reply.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(862, 79, true);
            WriteLiteral("</p>\r\n                    <strong>Description</strong>\r\n                    <p>");
            EndContext();
            BeginContext(942, 17, false);
#line 21 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                  Write(reply.Description);

#line default
#line hidden
            EndContext();
            BeginContext(959, 30, true);
            WriteLiteral("</p>\r\n                </div>\r\n");
            EndContext();
#line 23 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                 if (reply.Attachments.Any())
                {

#line default
#line hidden
            BeginContext(1055, 108, true);
            WriteLiteral("                    <div class=\"panel-footer clearfix\">\r\n                        <div class=\"text-center\">\r\n");
            EndContext();
#line 27 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                             foreach (var attachment in reply.Attachments)
                            {

#line default
#line hidden
            BeginContext(1270, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1302, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc492428ce745ae92fdf7a298a78657", async() => {
                BeginContext(1331, 12, true);
                WriteLiteral("Attachment: ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 29 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => attachment);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1351, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1385, 306, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e693c94c8f45450eb58e9f0cf081f7e4", async() => {
                BeginContext(1595, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1634, 19, false);
#line 32 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                               Write(attachment.FileName);

#line default
#line hidden
                EndContext();
                BeginContext(1653, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filename", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                                           WriteLiteral(attachment.FileName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filename"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filename", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filename"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                                                                                     WriteLiteral(attachment.PathToFile);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filePath"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filePath", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filePath"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                                                                                                                                  WriteLiteral(attachment.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["requestId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-requestId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["requestId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1691, 42, true);
            WriteLiteral("\r\n                                <br />\r\n");
            EndContext();
#line 35 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                            }

#line default
#line hidden
            BeginContext(1764, 60, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 38 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
                }

#line default
#line hidden
            BeginContext(1843, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 40 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(1878, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
            EndContext();
#line 43 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\ReplyListPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RequestReplyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
