#pragma checksum "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40c6c7ef8bc306f58d5a2a4b2a5e1ce30eb0b536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LayoutTourism_Index_Destination), @"mvc.1.0.view", @"/Views/LayoutTourism/Index_Destination.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c6c7ef8bc306f58d5a2a4b2a5e1ce30eb0b536", @"/Views/LayoutTourism/Index_Destination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00e21533e8e289c7504da17adc6fd3520d4fa49", @"/Views/_ViewImports.cshtml")]
    public class Views_LayoutTourism_Index_Destination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LV_DuLichDienTu.Models.DiaDiem_DuLich>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DiaDiem_DuLichs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
  
    ViewData["Title"] = "Index_Destination";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""hero-wrap js-fullheight"" style=""background-image: url('/TourismTemplate/images/bg_3.jpg');"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text js-fullheight align-items-center justify-content-center""
            data-scrollax-parent=""true"">
            <div class=""col-md-9 ftco-animate text-center"" data-scrollax="" properties: { translateY: '70%' }"">
                <h1 class=""mb-3 bread"" data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">
                
                        ");
#nullable restore
#line 17 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
                   Write(ViewBag.TP);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h1>
            </div>
        </div>
    </div>
</div>


<section class=""ftco-section ftco-degree-bg"">
    <div class=""container"">
        <div>
            Địa điểm du lịch
            <div class=""col-md-12"">
                <div class=""destination-slider owl-carousel ftco-animate"">
");
#nullable restore
#line 31 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"destination\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40c6c7ef8bc306f58d5a2a4b2a5e1ce30eb0b5366437", async() => {
                WriteLiteral(@"
                                    <div class=""icon d-flex justify-content-center align-items-center"">
                                        <span class=""icon-search2""></span>
                                    </div>
                                ");
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
#line 35 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
                                                                                           WriteLiteral(item.dddl_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1477, "background-image:", 1477, 17, true);
            AddHtmlAttributeValue(" ", 1494, "url(\'", 1495, 6, true);
#nullable restore
#line 36 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
AddHtmlAttributeValue("", 1500, item.dddl_Hinh_duongdan, 1500, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1524, "\');object-fit:", 1524, 14, true);
            AddHtmlAttributeValue(" ", 1538, "contain;", 1539, 9, true);
            AddHtmlAttributeValue(" ", 1547, "", 1548, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <div class=""text p-3"">
                                    <div class=""d-flex"">
                                        <div class=""one"">
                                            <h3 class=""title-destination""><a href=""#"">
                                                ");
#nullable restore
#line 45 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.dddl_ten));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </a></h3>
                                        </div>
                                    </div>
                                    <hr>
                                    <p class=""bottom-area d-flex"">
                                        <span><i class=""icon-map-o""></i> ");
#nullable restore
#line 51 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.dddl_quanhuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"ml-auto\"><a href=\"#\">Chi Tiết</a></span>\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 57 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
    <div class=""container"">

        <h2 class=""title-text"">Dịch Vụ</h2>     
        <div class=""ln_solid""></div>
        <h5 class=""title-text"">Dịch Vụ Tham Quan</h5>
        <div class=""col-md-12"">
             ");
#nullable restore
#line 68 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
        Write(await Component.InvokeAsync("GetDichVu_ThamQuan",@ViewBag.TP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"ln_solid\"></div>\r\n        <h5 class=\"title-text\">Dịch Vụ Ăn Uống</h5>\r\n        <div class=\"col-md-12\">\r\n             ");
#nullable restore
#line 73 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
        Write(await Component.InvokeAsync("GetDichVu_AnUong",@ViewBag.TP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        \r\n        <div class=\"ln_solid\"></div>\r\n        <h5 class=\"title-text\">Dịch Vụ Lưu Trú</h5>\r\n        <div class=\"col-md-12\">\r\n             ");
#nullable restore
#line 79 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\LayoutTourism\Index_Destination.cshtml"
        Write(await Component.InvokeAsync("GetDichVu_LuuTru",@ViewBag.TP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section> \r\n<div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LV_DuLichDienTu.Models.DiaDiem_DuLich>> Html { get; private set; }
    }
}
#pragma warning restore 1591
