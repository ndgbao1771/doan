#pragma checksum "D:\Developer\Code\Projects\NetCore\AppMVC.Net\MyView\xinchao1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cfd648a66b70b774a310488c217d8069a6470c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.MyView_xinchao1), @"mvc.1.0.view", @"/MyView/xinchao1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cfd648a66b70b774a310488c217d8069a6470c5", @"/MyView/xinchao1.cshtml")]
    #nullable restore
    public class MyView_xinchao1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Developer\Code\Projects\NetCore\AppMVC.Net\MyView\xinchao1.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card bg-primary text-white\">\n    <h1 class=\"card-header\">Xin chào ");
#nullable restore
#line 8 "D:\Developer\Code\Projects\NetCore\AppMVC.Net\MyView\xinchao1.cshtml"
                                Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <div class=\"card-body\">\n      <p class=\"card-text\">\n        Bạn đang tìm hiểu về View (.cshtml) trong ASP.NET MVC\n      </p>\n    </div>\n</div>\n<hr>\n\n");
#nullable restore
#line 17 "D:\Developer\Code\Projects\NetCore\AppMVC.Net\MyView\xinchao1.cshtml"
Write(this.Path);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
