#pragma checksum "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b357caaedf9fd8a02034b3f780da5f234561f2f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetAprioriFromDB_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GetAprioriFromDB/Default.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\_ViewImports.cshtml"
using LV_DuLichDienTu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\_ViewImports.cshtml"
using LV_DuLichDienTu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b357caaedf9fd8a02034b3f780da5f234561f2f8", @"/Views/Shared/Components/GetAprioriFromDB/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00e21533e8e289c7504da17adc6fd3520d4fa49", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GetAprioriFromDB_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LV_DuLichDienTu.Models.DichVu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LayoutTourism", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details_Service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img img-2 d-flex justify-content-center align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"destination-slider owl-carousel ftco-animate  \" style=\"display: block; width: 80%; margin: auto;\">\n");
#nullable restore
#line 3 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
     foreach (var items in @ViewBag.list4)
    { 
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
         foreach (var item in Model)
        {
            if(items == "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><p>Bạn cần lựa chọn nhiều hơn để được gợi ý</p></div>\n");
#nullable restore
#line 10 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
                break;
            }
            else
            {
                int checkVal = int.Parse(items);

                if (checkVal == item.dv_id)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item\">\n                        <div class=\"destination\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b357caaedf9fd8a02034b3f780da5f234561f2f85535", async() => {
                WriteLiteral("\n                                <div class=\"icon d-flex justify-content-center align-items-center\">\n                                    <span class=\"icon-search2\"></span>\n                                </div>\n                            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
                                                                                             WriteLiteral(item.dv_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 876, "background-image:", 876, 17, true);
            AddHtmlAttributeValue(" ", 893, "url(\'", 894, 6, true);
#nullable restore
#line 22 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
AddHtmlAttributeValue("", 899, Html.DisplayFor(modelItem => item.dv_hinh_duongdan), 899, 52, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 951, "\');object-fit:", 951, 14, true);
            AddHtmlAttributeValue(" ", 965, "contain;", 966, 9, true);
            AddHtmlAttributeValue(" ", 974, "", 975, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <div class=\"text p-3\">\n                                <div>\n                                    <div class=\"items-center\">\n                                        <h3 class=\"title-destination\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b357caaedf9fd8a02034b3f780da5f234561f2f89417", async() => {
                WriteLiteral("\n                                                ");
#nullable restore
#line 32 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.dv_ten));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
                                      WriteLiteral(item.dv_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h3>
                                    </div>
                                </div>
                                <hr>
                                <p class=""bottom-area d-flex"">
                                    <span><i class=""icon-map-o""></i> ");
#nullable restore
#line 38 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.dv_quanhuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                    <span class=\"ml-auto\"><a>");
#nullable restore
#line 39 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
                                                          Write(Math.Round(@item.dv_trungbinhchatluong,1));

#line default
#line hidden
#nullable disable
            WriteLiteral("★</a></span>\n                                </p>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 44 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
                }
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Shared\Components\GetAprioriFromDB\Default.cshtml"
         
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LV_DuLichDienTu.Models.DichVu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
