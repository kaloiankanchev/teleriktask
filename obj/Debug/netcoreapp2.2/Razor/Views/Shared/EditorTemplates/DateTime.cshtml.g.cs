#pragma checksum "C:\Users\elite\Desktop\TelerikClient\TelerikThomas\Views\Shared\EditorTemplates\DateTime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82678515267821c23c599cad3a832db6816c6567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_DateTime), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/DateTime.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EditorTemplates/DateTime.cshtml", typeof(AspNetCore.Views_Shared_EditorTemplates_DateTime))]
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
#line 1 "C:\Users\elite\Desktop\TelerikClient\TelerikThomas\Views\_ViewImports.cshtml"
using TelerikThomas;

#line default
#line hidden
#line 2 "C:\Users\elite\Desktop\TelerikClient\TelerikThomas\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82678515267821c23c599cad3a832db6816c6567", @"/Views/Shared/EditorTemplates/DateTime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c677b418baa4ebad8c431b3867bbcd6efded02", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_DateTime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateTime?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(22, 38, false);
#line 3 "C:\Users\elite\Desktop\TelerikClient\TelerikThomas\Views\Shared\EditorTemplates\DateTime.cshtml"
Write(Html.Kendo().DateTimePickerFor(m => m));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateTime?> Html { get; private set; }
    }
}
#pragma warning restore 1591
