#pragma checksum "C:\Users\Emil Abdullayev\Desktop\BackEnd\Area - Admin panel\Fiorello-Admin panel\OneTwoMany-Fiorello\Areas\Admin\Views\SliderDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276588b023ae703ff14fa97f2a6d2463819e5257"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SliderDetail_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SliderDetail/Index.cshtml")]
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
#line 1 "C:\Users\Emil Abdullayev\Desktop\BackEnd\Area - Admin panel\Fiorello-Admin panel\OneTwoMany-Fiorello\Areas\Admin\Views\_ViewImports.cshtml"
using OneTwoMany_Fiorello.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276588b023ae703ff14fa97f2a6d2463819e5257", @"/Areas/Admin/Views/SliderDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39fac843ce26d2e2e0988ea70b312c3ee094dea6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SliderDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SliderDetail>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\BackEnd\Area - Admin panel\Fiorello-Admin panel\OneTwoMany-Fiorello\Areas\Admin\Views\SliderDetail\Index.cshtml"
  
    ViewData["Title"] = "Slider";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""table-responsive pt-3"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>
                        Detail
                    </th>
                    <th>
                        Settings
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        ");
#nullable restore
#line 24 "C:\Users\Emil Abdullayev\Desktop\BackEnd\Area - Admin panel\Fiorello-Admin panel\OneTwoMany-Fiorello\Areas\Admin\Views\SliderDetail\Index.cshtml"
                   Write(Html.Raw(Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info""><i class=""mdi mdi-information mx-0""></i></button>
                        <button type=""button"" class=""btn btn-primary""><i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-database-minus""></i></button>
                    </td>
                </tr>
                <tr>
                    <td>
                        ");
#nullable restore
#line 34 "C:\Users\Emil Abdullayev\Desktop\BackEnd\Area - Admin panel\Fiorello-Admin panel\OneTwoMany-Fiorello\Areas\Admin\Views\SliderDetail\Index.cshtml"
                   Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info""><i class=""mdi mdi-information mx-0""></i></button>
                        <button type=""button"" class=""btn btn-primary""><i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-database-minus""></i></button>
                    </td>
                </tr>
                <tr>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "276588b023ae703ff14fa97f2a6d2463819e52575643", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1668, "~/img/", 1668, 6, true);
#nullable restore
#line 44 "C:\Users\Emil Abdullayev\Desktop\BackEnd\Area - Admin panel\Fiorello-Admin panel\OneTwoMany-Fiorello\Areas\Admin\Views\SliderDetail\Index.cshtml"
AddHtmlAttributeValue("", 1674, Model.Image, 1674, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info""><i class=""mdi mdi-information mx-0""></i></button>
                        <button type=""button"" class=""btn btn-primary""><i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-database-minus""></i></button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SliderDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
