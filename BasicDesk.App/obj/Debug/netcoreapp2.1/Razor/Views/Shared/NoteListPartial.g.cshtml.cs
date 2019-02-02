#pragma checksum "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\NoteListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d13c738a6241c3a0dde5d8dc83e199b2bf0a01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NoteListPartial), @"mvc.1.0.view", @"/Views/Shared/NoteListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/NoteListPartial.cshtml", typeof(AspNetCore.Views_Shared_NoteListPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d13c738a6241c3a0dde5d8dc83e199b2bf0a01", @"/Views/Shared/NoteListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c1d29139d626e96128cadfffc2f5d32ab3411f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NoteListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RequestDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 276, true);
            WriteLiteral(@"
<div class=""modal fade modal-wide"" id=""noteListModal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"" style=""overflow:inherit"">
            <div class=""modal-body modal-wide"">
");
            EndContext();
#line 7 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\NoteListPartial.cshtml"
                  
                        foreach (var note in Model.Notes)
                        {

#line default
#line hidden
            BeginContext(414, 241, true);
            WriteLiteral("                    <div class=\"panel-group\">\r\n                        <div class=\"panel\">\r\n                            <div class=\"panel-heading clearfix\">\r\n                                <div class=\"pull-left\"><strong>Requester:</strong> ");
            EndContext();
            BeginContext(656, 11, false);
#line 13 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\NoteListPartial.cshtml"
                                                                              Write(note.Author);

#line default
#line hidden
            EndContext();
            BeginContext(667, 93, true);
            WriteLiteral("</div>\r\n                                <div class=\"pull-right\"><strong>Created On:</strong> ");
            EndContext();
            BeginContext(761, 17, false);
#line 14 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\NoteListPartial.cshtml"
                                                                                Write(note.CreationTime);

#line default
#line hidden
            EndContext();
            BeginContext(778, 195, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"panel-body\">\r\n                                <strong>Description</strong>\r\n                                <p>");
            EndContext();
            BeginContext(974, 16, false);
#line 18 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\NoteListPartial.cshtml"
                              Write(note.Description);

#line default
#line hidden
            EndContext();
            BeginContext(990, 102, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 22 "C:\Users\Zorko\Documents\BasicDesk\BasicDesk-Project-CSharp-MVC-Frameworks-ASP.NET-Core\BasicDesk.App\Views\Shared\NoteListPartial.cshtml"
                        }
                

#line default
#line hidden
            BeginContext(1138, 56, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RequestDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
