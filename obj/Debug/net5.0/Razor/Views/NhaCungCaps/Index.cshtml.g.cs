#pragma checksum "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "195fd9058c7b014353608f5bb833371f1850b8d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhaCungCaps_Index), @"mvc.1.0.view", @"/Views/NhaCungCaps/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"195fd9058c7b014353608f5bb833371f1850b8d2", @"/Views/NhaCungCaps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00e21533e8e289c7504da17adc6fd3520d4fa49", @"/Views/_ViewImports.cshtml")]
    public class Views_NhaCungCaps_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LV_DuLichDienTu.Models.NhaCungCap>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DichVus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 2084, "\"", 2092, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n  <div class=\"row\">\r\n    <div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n      <div class=\"x_panel\">\r\n        <div class=\"x_content\">\r\n          <div>\r\n            <h2>\r\n              NHÀ CUNG CẤP<small>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195fd9058c7b014353608f5bb833371f1850b8d25050", async() => {
                WriteLiteral(" Thêm mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</small>\r\n            </h2>\r\n          </div>\r\n\r\n          <table id=\"datatable\" class=\"table table-striped table-bordered\">\r\n            <thead>\r\n              <tr>\r\n                <th>\r\n                  ");
#nullable restore
#line 91 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
             Write(Html.DisplayNameFor(model => model.ncc_taikhoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n\r\n                <th>\r\n                  ");
#nullable restore
#line 96 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
             Write(Html.DisplayNameFor(model => model.ncc_ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                  ");
#nullable restore
#line 100 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
             Write(Html.DisplayNameFor(model => model.ncc_email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                  ");
#nullable restore
#line 104 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
             Write(Html.DisplayNameFor(model => model.ncc_dienthoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                  ");
#nullable restore
#line 108 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
             Write(Html.DisplayNameFor(model => model.ncc_diachi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n\r\n\r\n\r\n                <th>Tùy chọn</th>\r\n              </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 118 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
               foreach (var item in Model)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                  <td>\r\n                    ");
#nullable restore
#line 122 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ncc_taikhoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n\r\n\r\n                  <td>\r\n                    ");
#nullable restore
#line 127 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ncc_ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n\r\n                  <td>\r\n                    ");
#nullable restore
#line 131 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ncc_email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n\r\n                  <td>\r\n                    ");
#nullable restore
#line 135 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ncc_dienthoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n\r\n                  <td>\r\n                    ");
#nullable restore
#line 139 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ncc_diachi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n\r\n\r\n\r\n\r\n                  <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195fd9058c7b014353608f5bb833371f1850b8d210268", async() => {
                WriteLiteral("<i\r\n                      class=\"fa fa-search\"></i>Dịch Vụ NCC");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
                                                                     WriteLiteral(item.ncc_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </td>\r\n                </tr>\r\n");
#nullable restore
#line 150 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\NhaCungCaps\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n          </table>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LV_DuLichDienTu.Models.NhaCungCap>> Html { get; private set; }
    }
}
#pragma warning restore 1591
