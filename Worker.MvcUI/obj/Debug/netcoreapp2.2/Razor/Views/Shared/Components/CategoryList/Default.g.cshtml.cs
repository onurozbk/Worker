#pragma checksum "C:\Users\onur.ozbek\Desktop\Worker-repo\Worker\Worker.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7efb43d81a0f7a57a2313b0fd9868cc3ae9a3a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoryList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoryList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7efb43d81a0f7a57a2313b0fd9868cc3ae9a3a3", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Worker.MvcUI.Models.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 30, true);
            WriteLiteral("\r\n\r\n<div class=\"list-group\">\r\n");
            EndContext();
#line 5 "C:\Users\onur.ozbek\Desktop\Worker-repo\Worker\Worker.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var item in Model.Categories)
    {
        var css = "list-group-item ";
        css = (Model.CurrentCategory == item.CategoryId) ? css + " active" : css;

#line default
#line hidden
            BeginContext(254, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 264, "\"", 311, 2);
            WriteAttributeValue("", 271, "/product/index?category=", 271, 24, true);
#line 9 "C:\Users\onur.ozbek\Desktop\Worker-repo\Worker\Worker.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 295, item.CategoryId, 295, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 312, "\"", 324, 1);
#line 9 "C:\Users\onur.ozbek\Desktop\Worker-repo\Worker\Worker.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 320, css, 320, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(325, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(327, 17, false);
#line 9 "C:\Users\onur.ozbek\Desktop\Worker-repo\Worker\Worker.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                   Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(344, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 10 "C:\Users\onur.ozbek\Desktop\Worker-repo\Worker\Worker.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(357, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Worker.MvcUI.Models.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
