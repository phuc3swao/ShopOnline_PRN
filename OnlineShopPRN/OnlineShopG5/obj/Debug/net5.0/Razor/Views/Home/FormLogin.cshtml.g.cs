#pragma checksum "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\FormLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1578040d174c46ba7502cd40cee46e1daa0d1727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FormLogin), @"mvc.1.0.view", @"/Views/Home/FormLogin.cshtml")]
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
#line 6 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\FormLogin.cshtml"
using OnlineShopG5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1578040d174c46ba7502cd40cee46e1daa0d1727", @"/Views/Home/FormLogin.cshtml")]
    public class Views_Home_FormLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/base.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/grid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1578040d174c46ba7502cd40cee46e1daa0d17274484", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Login</title>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.1/normalize.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1578040d174c46ba7502cd40cee46e1daa0d17275057", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1578040d174c46ba7502cd40cee46e1daa0d17276236", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1578040d174c46ba7502cd40cee46e1daa0d17277415", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"/font/fontawesome-free-5.15.4-web/css/all.min.css\" rel=\"stylesheet\">\r\n    <link href=\"https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;700&display=swap\" rel=\"stylesheet\">\r\n\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1578040d174c46ba7502cd40cee46e1daa0d17279518", async() => {
                WriteLiteral(@"
    <div class=""main"">
        <header class=""login-header"">
            <div class=""login-header-left"">

                <h3 class=""login-header-title"">Đăng Nhập</h3>
            </div>
            <div class=""login-header-right"">
                <a");
                BeginWriteAttribute("href", " href=\"", 1137, "\"", 1144, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""header-help"">
                    Cần trợ giúp?
                </a>
            </div>
        </header>

        <div class=""app__container-login"">
            <div class=""header__logo"">
                <a href=""#"">
                    <img src=""./assets/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 1432, "\"", 1438, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"header__logo-img-login\">\r\n                </a>\r\n            </div>\r\n            <!-- Register form  -->\r\n");
                WriteLiteral(@"            <!-- Login form -->
            <div class=""auth-form"">
                <form action=""/Home/Login"" method=""post"">
                    <div class=""auth-form__container"">
                        <div class=""auth-form__header"">
                            <h3 class=""auth-form__heading"">Đăng nhập</h3>
                            <span class=""auth-form__switch-btn"">Đăng ký</span>

                        </div>
                        <div class=""auth-form__form"">
                            <div class=""auth-form__group"">
                                <input type=""text"" name=""username"" class=""auth-form__input"" placeholder=""Tên đăng nhập"">
                            </div>
                            <div class=""auth-form__group"">
                                <input type=""password"" name=""password"" class=""auth-form__input"" placeholder=""Mật khẩu"">
                            </div>
                        </div>

                        <div class=""auth-form__aside"">
             ");
                WriteLiteral("               <div class=\"auth-form__help\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 4355, "\"", 4362, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""auth-form__help-link auth-form__help-forgot"">
                                    Quên mật khẩu
                                </a>
                                <span class=""auth-form__help-separate""></span>
                                <a");
                BeginWriteAttribute("href", " href=\"", 4621, "\"", 4628, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""auth-form__help-link"">
                                    Cần trợ giúp?
                                </a>
                            </div>
                        </div>

                        <div class=""auth-form__controls"">
                            <button class=""btn auth-form__controls--back"">TRỞ LẠI</button>
                            <button type=""submit"" class=""btn btn--primary"">ĐĂNG NHẬP</button>
                        </div>
                    </div>
                </form>


                <div class=""auth-form__socials"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 5227, "\"", 5234, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""auth-form__socials-icon--facebook btn btn--size-s btn--with-icon"">
                        <i class=""auth-form__socials-icon fab fa-facebook-square""></i>
                        <span class=""auth-form__socials-title"">
                            Đăng nhập với Facebook
                        </span>
                    </a>
                    <a");
                BeginWriteAttribute("href", " href=\"", 5597, "\"", 5604, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""auth-form__socials-icon--google btn btn--size-s btn--with-icon"">
                        <i class=""auth-form__socials-icon fab fa-google""></i>
                        <span class=""auth-form__socials-title"">
                            Đăng nhập với Google
                        </span>

                    </a>
                </div>

            </div>
        </div>
        <footer class=""footer"">
            <div class=""grid"">
                <div class=""grid__row"">
                    <div class=""grid__column-2-4"">
                        <h3 class=""footer__heading"">Chăm sóc khách hàng</h3>
                        <ul class=""footer-list"">
                            <li class=""footer-item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 6370, "\"", 6377, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Trung tâm trợ giúp</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 6552, "\"", 6559, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Rin-Shop Mall</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 6729, "\"", 6736, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer-item__link"">Hướng dẫn mua hàng</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""grid__column-2-4"">
                        <h3 class=""footer__heading"">Giới thiệu</h3>
                        <ul class=""footer-list"">
                            <li class=""footer-item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 7141, "\"", 7148, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Giới thiệu</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 7315, "\"", 7322, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Tuyển dụng</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 7489, "\"", 7496, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer-item__link"">Điều khoản</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""grid__column-2-4"">
                        <h3 class=""footer__heading"">Danh mục</h3>
                        <ul class=""footer-list"">
                            <li class=""footer-item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 7891, "\"", 7898, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Sản phẩm</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 8063, "\"", 8070, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Ưu đãi giảm giá</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 8242, "\"", 8249, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer-item__link"">Giảm giá</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""grid__column-2-4"">
                        <h3 class=""footer__heading"">Theo dõi</h3>
                        <ul class=""footer-list"">
                            <li class=""footer-item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 8642, "\"", 8649, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer-item__link"">
                                    <i class=""footer-item__icon fab fa-facebook""></i>
                                    Facebook
                                </a>
                            </li>
                            <li class=""footer-item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 8973, "\"", 8980, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer-item__link"">
                                    <i class=""footer-item__icon fab fa-instagram-square""></i>
                                    Instagram
                                </a>
                            </li>
                            <li class=""footer-item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 9313, "\"", 9320, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer-item__link"">
                                    <i class=""footer-item__icon fab fa-linkedin""></i>
                                    Linked
                                </a>
                            </li>
                        </ul>
                    </div>
                    <div class=""grid__column-2-4"">
                        <h3 class=""footer__heading"">Vào cửa hàng trên ứng dụng</h3>
                        <div class=""footer__download"">
                            <img src=""/assets/img/QR_Code.png"" alt=""Download QR"" class=""footer__download-qr"">
                            <div class=""footer__download-apps"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 10016, "\"", 10023, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer__download-app-link\">\r\n\r\n                                    <img src=\"/assets/img/gg.png\" alt=\"App Store\" class=\"footer__download-app-img\">\r\n                                </a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 10252, "\"", 10259, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer__download-app-link"">


                                    <img src=""/assets/img/gg2.png"" alt=""Google Play"" class=""footer__download-app-img"">
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
