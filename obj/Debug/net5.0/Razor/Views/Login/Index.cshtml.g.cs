#pragma checksum "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fd3b0910dd3e25353c6c2509a69c070e0a3b811"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd3b0910dd3e25353c6c2509a69c070e0a3b811", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00e21533e8e289c7504da17adc6fd3520d4fa49", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/vendors/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/vendors/font-awesome/css/font-awesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/vendors/nprogress/nprogress.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/vendors/animate.css/animate.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/build/css/custom.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tourism_login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Admin_Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Asus\Desktop\LV_Etourism\LV_DuLichDienTu\Views\Login\Index.cshtml"
  
    Layout= null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd3b0910dd3e25353c6c2509a69c070e0a3b8117459", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"" />

    <title>Login</title>

    <!-- Bootstrap -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fd3b0910dd3e25353c6c2509a69c070e0a3b8118077", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- Font Awesome -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fd3b0910dd3e25353c6c2509a69c070e0a3b8119284", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- NProgress -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81110488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- Animate.css -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81111695", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- Custom Theme Style -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81112913", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81114092", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81115983", async() => {
                WriteLiteral(@"
    <div>
      <a class=""hiddenanchor"" id=""signup""></a>
      <a class=""hiddenanchor"" id=""signin""></a>
      <a class=""hiddenanchor"" id=""TypeUser""></a>
      <a class=""hiddenanchor"" id=""Tourist""></a>
      <a class=""hiddenanchor"" id=""Business""></a>
      <a class=""hiddenanchor"" id=""Login_Business""></a>
      <a class=""hiddenanchor"" id=""Login_Tourist""></a>
      <a class=""hiddenanchor"" id=""Login_Admin""></a>

      <div class=""login_wrapper"">
        <div class=""animate form login_form"">
          <section class=""login_content"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81116838", async() => {
                    WriteLiteral(@"
              <h1>Bạn đăng nhập là?</h1>
              <div>
                <a href=""#Login_Tourist"" class=""btn btn-round btn-success"">DU KHÁCH</a>
                <br />
                <a href=""#Login_Business"" class=""btn btn-round btn-primary"">NHÀ CUNG CẤP DỊCH VỤ</a>
                <br />
                <a href=""#Login_Admin"" class=""btn btn-round btn-danger"">NHÂN VIÊN</a>
              <div class=""clearfix""></div>
              <div class=""separator"">
                <p class=""change_link"">
                  
                  <a href=""#TypeUser"" class=""to_register""> Đăng Ký tài khoản </a>
                </p>

                <div class=""clearfix""></div>
                <br />
              </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </section>\r\n        </div>\r\n\r\n        <!-- form ĐĂNG NHẬP DU KHÁCH -->\r\n        <div id=\"Login_Tourist\" class=\"animate form Tourist_Login_form\">\r\n          <section class=\"login_content\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81119130", async() => {
                    WriteLiteral("\r\n              <h1>Du Khách</h1>\r\n              <h4>Đăng Nhập</h4>\r\n              <div>\r\n                <input name=\"email\"\r\n                  type=\"text\"\r\n                  class=\"form-control\"\r\n                  placeholder=\"Tài Khoản\"");
                    BeginWriteAttribute("required", "\r\n                  required=\"", 2889, "\"", 2919, 0);
                    EndWriteAttribute();
                    WriteLiteral("\r\n                />\r\n              </div>\r\n              <div>\r\n                <input\r\n                  type=\"password\" name=\"password\"\r\n                  class=\"form-control\"\r\n                  placeholder=\"Mật Khẩu\"");
                    BeginWriteAttribute("required", "\r\n                  required=\"", 3140, "\"", 3170, 0);
                    EndWriteAttribute();
                    WriteLiteral(@"
                />
              </div>
              <div>
                <button type=""submit"" class=""btn btn-default submit"">Đăng Nhập</button>
                <a class=""reset_pass"" href=""#"">Quên mật khẩu?</a>
              </div>

              <div class=""clearfix""></div>

              <div class=""separator"">
                <p class=""change_link"">
                  
                  <a href=""#TypeUser"" class=""to_register""> Đăng Ký tài khoản </a>
                </p>

                <div class=""clearfix""></div>
                <br />
              </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </section>\r\n        </div>\r\n\r\n        <!-- form ĐĂNG NHẬP NHÀ CUNG CẤP -->\r\n        <div id=\"Business_login\" class=\"animate form Business_Login_form\">\r\n          <section class=\"login_content\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81122377", async() => {
                    WriteLiteral("\r\n              <h1>Nhà Cung Cấp</h1>\r\n              <h4>Đăng Nhập</h4>\r\n              <div>\r\n                <input\r\n                  type=\"text\"\r\n                  class=\"form-control\"\r\n                  placeholder=\"Tài Khoản\"");
                    BeginWriteAttribute("required", "\r\n                  required=\"", 4235, "\"", 4265, 0);
                    EndWriteAttribute();
                    WriteLiteral("\r\n                />\r\n              </div>\r\n              <div>\r\n                <input\r\n                  type=\"password\"\r\n                  class=\"form-control\"\r\n                  placeholder=\"Mật Khẩu\"");
                    BeginWriteAttribute("required", "\r\n                  required=\"", 4470, "\"", 4500, 0);
                    EndWriteAttribute();
                    WriteLiteral(@"
                />
              </div>
              <div>
                <button type=""submit"" class=""btn btn-default submit"">Đăng Nhập</button>
                <a class=""reset_pass"" href=""#"">Quên mật khẩu?</a>
              </div>

              <div class=""clearfix""></div>

              <div class=""separator"">
                <p class=""change_link"">
                  
                  <a href=""#TypeUser"" class=""to_register""> Đăng Ký tài khoản </a>
                </p>

                <div class=""clearfix""></div>
                <br />
              </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </section>\r\n        </div>\r\n\r\n        <!-- form ĐĂNG NHẬP NHÂN VIÊN -->\r\n        <div id=\"Login_Admin\" class=\"animate form Admin_Login_form\">\r\n          <section class=\"login_content\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81125378", async() => {
                    WriteLiteral(@"
              <h1>XIN CHÀO ĐỒNG NGHIỆP</h1>
              <h4>Đăng Nhập</h4>
              <div>
                <input
                  type=""text""
                  name=""email""
                  class=""form-control""
                  placeholder=""Email""
                  required=""required""
                />
              </div>
              <div>
                <input
                  type=""password""
                  name=""password""
                  class=""form-control""
                  placeholder=""Mật Khẩu""
                  required=""required""
                />
              </div>
              <div>
                 <button type=""submit"" class=""btn btn-default submit"">Đăng Nhập</button>
                <a class=""reset_pass"" href=""#"">Quên mật khẩu?</a>
              </div>

              <div class=""clearfix""></div>

              <div class=""separator"">
                <p class=""change_link"">
                  
                  <a href=""#TypeUser"" class=""to_r");
                    WriteLiteral("egister\"> Đăng Ký tài khoản </a>\r\n                </p>\r\n\r\n                <div class=\"clearfix\"></div>\r\n                <br />\r\n              </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </section>\r\n        </div>\r\n\r\n");
                WriteLiteral("\r\n        <!-- form Loại NGƯỜI DÙNG -->\r\n        <div id=\"TypeUser\" class=\"animate form TypeUser_form\">\r\n          <section class=\"login_content\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81128411", async() => {
                    WriteLiteral(@"
              <h1>Bạn muốn đăng ký làm?</h1>
              <div>
                <a href=""#Tourist"" class=""btn btn-round btn-success"">DU KHÁCH</a>
                <br />
                <a href=""#Business"" class=""btn btn-round btn-primary"">NHÀ CUNG CẤP DỊCH VỤ</a>
              <div class=""clearfix""></div>

              <div class=""separator"">
                <p class=""change_link"">
                  Bạn đã có tài khoản?
                  <a href=""#signin"" class=""to_register""> Đăng nhập </a>
                </p>

                <div class=""clearfix""></div>
                <br />
              </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </section>\r\n        </div>\r\n        <!-- Đăng ký làm du KHÁCH -->\r\n        <div id=\"Tourist\" class=\"animate form registration_Tourist_form\">\r\n          <section class=\"login_content\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81130586", async() => {
                    WriteLiteral("\r\n              <h1>Đăng ký</h1>\r\n              <h4>Làm du khách</h4>\r\n              <div>\r\n                <input\r\n                  type=\"text\"\r\n                  class=\"form-control\"\r\n                  placeholder=\"Tài Khoản\"");
                    BeginWriteAttribute("required", "\r\n                  required=\"", 9058, "\"", 9088, 0);
                    EndWriteAttribute();
                    WriteLiteral("\r\n                />\r\n              </div>\r\n              <div>\r\n                <input\r\n                  type=\"email\"\r\n                  class=\"form-control\"\r\n                  placeholder=\"Email\"");
                    BeginWriteAttribute("required", "\r\n                  required=\"", 9287, "\"", 9317, 0);
                    EndWriteAttribute();
                    WriteLiteral("\r\n                />\r\n              </div>\r\n              <div>\r\n                <input\r\n                  type=\"password\"\r\n                  class=\"form-control\"\r\n                  placeholder=\"Mật khẩu\"");
                    BeginWriteAttribute("required", "\r\n                  required=\"", 9522, "\"", 9552, 0);
                    EndWriteAttribute();
                    WriteLiteral("\r\n                />\r\n              </div>\r\n              <div>\r\n                <a class=\"btn btn-default submit\"");
                    BeginWriteAttribute("href", " href=\"", 9667, "\"", 9674, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">Tạo tài khoản</a>
              </div>

              <div class=""clearfix""></div>

              <div class=""separator"">
                <p class=""change_link"">
                  Đã có tài khoản?
                  <a href=""#signin"" class=""to_register"">Đăng Nhập</a>
                </p>

                <div class=""clearfix""></div>
                <br />
              </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </section>\r\n        </div>\r\n        <!-- Đăng ký làm NCC -->\r\n        <div id=\"Business\" class=\"animate form registration_Business_form\">\r\n          <section class=\"login_content\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd3b0910dd3e25353c6c2509a69c070e0a3b81134073", async() => {
                    WriteLiteral("\r\n              <h1>Đăng ký</h1>\r\n              <h4>Làm nhà cung cấp dịch vụ</h4>\r\n              <div>\r\n                <input\r\n                  type=\"text\"\r\n                  class=\"form-control\"\r\n                  placeholder=\"Tài Khoản\"");
                    BeginWriteAttribute("required", "\r\n                  required=\"", 10539, "\"", 10569, 0);
                    EndWriteAttribute();
                    WriteLiteral("\r\n                />\r\n              </div>\r\n              <div>\r\n                <input\r\n                  type=\"email\"\r\n                  class=\"form-control\"\r\n                  placeholder=\"Email\"");
                    BeginWriteAttribute("required", "\r\n                  required=\"", 10768, "\"", 10798, 0);
                    EndWriteAttribute();
                    WriteLiteral("\r\n                />\r\n              </div>\r\n              <div>\r\n                <input\r\n                  type=\"password\"\r\n                  class=\"form-control\"\r\n                  placeholder=\"Mật khẩu\"");
                    BeginWriteAttribute("required", "\r\n                  required=\"", 11003, "\"", 11033, 0);
                    EndWriteAttribute();
                    WriteLiteral("\r\n                />\r\n              </div>\r\n              <div>\r\n                <a class=\"btn btn-default submit\"");
                    BeginWriteAttribute("href", " href=\"", 11148, "\"", 11155, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">Tạo tài khoản</a>
              </div>

              <div class=""clearfix""></div>

              <div class=""separator"">
                <p class=""change_link"">
                  Đã có tài khoản?
                  <a href=""#signin"" class=""to_register"">Đăng Nhập</a>
                </p>

                <div class=""clearfix""></div>
                <br />
              </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </section>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  \r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
