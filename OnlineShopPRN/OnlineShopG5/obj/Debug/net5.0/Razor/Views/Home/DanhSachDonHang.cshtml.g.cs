#pragma checksum "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2bab10f138a302478f2bd56c25559049541747e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DanhSachDonHang), @"mvc.1.0.view", @"/Views/Home/DanhSachDonHang.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 6 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
using OnlineShopG5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2bab10f138a302478f2bd56c25559049541747e", @"/Views/Home/DanhSachDonHang.cshtml")]
    public class Views_Home_DanhSachDonHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/base.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/grid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2bab10f138a302478f2bd56c25559049541747e5027", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Rin-Shop</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/popperjs/core@2.11.5/dist/umd/popper.min.js"" integrity=""sha384-Xe+8cL9oJa6tN/veChSP7q+mnSPaj5Bcu9mPX5F5xIGE0DVittaqT5lorf0EI7Vk"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.min.js"" integrity=""sha384-kjU+l4N0Yf4ZOJErLsIcvOU2qSb74wXpOhqTvwVx3OElZRweTnQ6d31fXEoRD1Jy"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.1/normalize.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2bab10f138a302478f2bd56c25559049541747e6268", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2bab10f138a302478f2bd56c25559049541747e7446", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2bab10f138a302478f2bd56c25559049541747e8624", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2bab10f138a302478f2bd56c25559049541747e9802", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2bab10f138a302478f2bd56c25559049541747e11904", async() => {
                WriteLiteral("\r\n    <div class=\"main\">\r\n        <header class=\"header\">\r\n            <div class=\"grid\">\r\n                <nav class=\"header__navbar\">\r\n                    <ul class=\"header__navbar-list\">\r\n\r\n");
#nullable restore
#line 35 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                         if (ViewBag.Role == "1")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <li class=""header__navbar-item header__navbar-item--separate""><a style=""text-decoration:none; color:white"" href=""/Home/DanhSachDonHang"">Quản lý đơn hàng</a></li>
                            <li class=""header__navbar-item header__navbar-item--separate""><a style=""text-decoration:none; color:white"" href=""/Home/Manager"">Quản lý sản phẩm</a></li>
");
#nullable restore
#line 39 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"header__navbar-item header__navbar-item--separate\">Kênh Người Bán</li>\r\n                            <li class=\"header__navbar-item header__navbar-item--separate\">Trở thành Người bán Rin-Shop</li>\r\n");
#nullable restore
#line 45 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <li class=""header__navbar-item header__navbar-item--qr header__navbar-item--separate"">
                            Tải ứng dụng
                            <div class=""header_qr"">
                                <img src=""./assets/img/QR_Code.png"" alt=""QR code"" class=""qr-img"">
                                <div class=""qr-apps"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 3001, "\"", 3008, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"qr_link\">\r\n                                        <img src=\"./assets/img/gg.png\" alt=\"App Store\" class=\"qr-download\">\r\n                                    </a>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3217, "\"", 3224, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""qr_link"">
                                        <img src=""./assets/img/gg2.png"" alt=""Google Play"" class=""qr-download"">
                                    </a>
                                </div>
                            </div>
                        </li>

                    </ul>

                    <ul class=""header__navbar-list"">
                        <li class=""header__navbar-item header__navbar-item-hasnotify"">
                            <a");
                BeginWriteAttribute("href", " href=\"", 3708, "\"", 3715, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""header__navbar-item-link"">
                                <i class=""header__navbar-icon far fa-bell""></i>
                                Thông báo
                            </a>
                            <div class=""header__notify"">
                                <header class=""header__notify-header"">
                                    <h3>Thông Báo Mới Nhận</h3>
                                </header>
                                <ul class=""header__notify-list"">
                                    <li class=""header__notify-item header__notify-item--viewed"">
                                        <a class=""header__notify-link""");
                BeginWriteAttribute("href", " href=\"", 4382, "\"", 4389, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <img src=""https://cdn.vuahanghieu.com/unsafe/0x0/left/top/smart/filters:quality(90)/https://admin.vuahanghieu.com/upload/news/content/2020/07/bo-san-pham-ngan-ngua-lao-hoa-chong-nhan-da-ohui-prime-advancer-8pcs-5d2d8fde3a04f-16072019155038-jpg-1594710946-14072020141546.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 4711, "\"", 4717, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""header__notify-img"">
                                            <div class=""header__notify-info"">
                                                <span class=""header__notify-name"">Xác thực chính hãng nguồn gốc các sản phẩm Ohui</span>
                                                <span class=""header__notify-desc"">Hidden Tag là giải pháp xác thực hàng chính hãng bằng công nghệ tiên tiến nhất hiện nay</span>
                                            </div>
                                        </a>
                                    </li>
                                    <li class=""header__notify-item"">
                                        <a class=""header__notify-link""");
                BeginWriteAttribute("href", " href=\"", 5424, "\"", 5431, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <img src=""https://cdn.vuahanghieu.com/unsafe/0x0/left/top/smart/filters:quality(90)/https://admin.vuahanghieu.com/upload/news/content/2020/07/bo-san-pham-ngan-ngua-lao-hoa-chong-nhan-da-ohui-prime-advancer-8pcs-5d2d8fde3a04f-16072019155038-jpg-1594710946-14072020141546.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5753, "\"", 5759, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""header__notify-img"">
                                            <div class=""header__notify-info"">
                                                <span class=""header__notify-name"">Sale sốc bộ dưỡng Ohui The First Tái tạo trẻ hóa da SALE OFF 70%</span>
                                                <span class=""header__notify-desc"">Giá chỉ còn 375.000(giá gốc: 1.250.000 vnđ)</span>
                                            </div>
                                        </a>
                                    </li>
                                    <li class=""header__notify-item header__notify-item--viewed"">
                                        <a class=""header__notify-link""");
                BeginWriteAttribute("href", " href=\"", 6467, "\"", 6474, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <img src=""https://cdn.vuahanghieu.com/unsafe/0x0/left/top/smart/filters:quality(90)/https://admin.vuahanghieu.com/upload/news/content/2020/07/bo-san-pham-ngan-ngua-lao-hoa-chong-nhan-da-ohui-prime-advancer-8pcs-5d2d8fde3a04f-16072019155038-jpg-1594710946-14072020141546.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 6796, "\"", 6802, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""header__notify-img"">
                                            <div class=""header__notify-info"">
                                                <span class=""header__notify-name"">Ohui chính thức ra mắt dòng son lì mới THE FIRST GENITURE LIPSTICK</span>
                                                <span class=""header__notify-desc"">Một làn môi căng mềm, quyến rũ với sắc màu nổi bật luôn là điều mà các quý cô ao ước</span>
                                            </div>
                                        </a>
                                    </li>

                                </ul>
                                <footer class=""header__notify-footer"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 7536, "\"", 7543, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"header__notify-footer-btn\">Xem tất cả</a>\r\n                                </footer>\r\n                            </div>\r\n                        </li>\r\n                        <li class=\"header__navbar-item\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 7793, "\"", 7800, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""header__navbar-item-link"">
                                <i class=""header__navbar-icon far fa-question-circle""></i>
                                Trợ giúp
                            </a>
                        </li>




                        <!-- <li class=""header__navbar-item header__navbar-user"">
                            <img src=""https://scontent.fhan4-3.fna.fbcdn.net/v/t1.6435-9/130673242_1072626889921945_6958961256365140847_n.jpg?_nc_cat=100&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=aAWpZRKn5pQAX-bdA29&_nc_ht=scontent.fhan4-3.fna&oh=00_AT__OLMUGyDY94tpkT7hVmO5WgIBKHCPw4TPP5f4cse2PQ&oe=620C3727"" alt="""" class=""header__navbar-user-img"">
                            <span class=""header__navbar-user-name"">Nguyễn Văn Rin</span>

                            <ul class=""header__navbar-user-menu"">
                                <li class=""header__navbar-user-item"">
                                    <a href="""">Tài khoản của tôi</a>
                                </li>
                   ");
                WriteLiteral(@"             <li class=""header__navbar-user-item"">
                                    <a href="""">Đơn mua</a>
                                </li>
                                <li class=""header__navbar-user-item"">
                                    <a href="""">Đăng xuất</a>
                                </li>

                            </ul>
                        </li> -->
                    </ul>
                </nav>

                <!-- header with search -->
                <div class=""header-with-search"">
                    <div class=""header__logo"">
                        <a href=""/Home/Trangchu"">
                            <img src=""/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 9519, "\"", 9525, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""header__logo-img"">
                        </a>
                    </div>

                    <div class=""header__search"">
                        <div class=""header__search-input-wrap"">
                            <input type=""text"" class=""header__search-input"" placeholder=""Nhập để tìm kiếm sản phẩm"">
                            <div class=""header__search-history"">
                                <h3 class=""header__search-history-heading"">Lịch sử tìm kiếm</h3>
                                <ul class=""header__search-history-list"">
                                    <li class=""header__search-history-item"">
                                        <a");
                BeginWriteAttribute("href", " href=\"", 10205, "\"", 10212, 0);
                EndWriteAttribute();
                WriteLiteral(">Kem dưỡng da</a>\r\n                                    </li>\r\n                                    <li class=\"header__search-history-item\">\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 10395, "\"", 10402, 0);
                EndWriteAttribute();
                WriteLiteral(">Kem trị mụn</a>\r\n                                    </li>\r\n                                    <li class=\"header__search-history-item\">\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 10584, "\"", 10591, 0);
                EndWriteAttribute();
                WriteLiteral(@">Áo hoodie</a>
                                    </li>
                                </ul>
                            </div>

                        </div>

                        <button class=""header__search-btn"">
                            <i class=""header__search-btn-icon fas fa-search""></i>
                        </button>
                    </div>


                </div>
            </div>
        </header>

        <section class=""py-5"">
            <div");
                BeginWriteAttribute("class", " class=\"", 11086, "\"", 11094, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"min-height: 1000px; margin-right:20%; margin-left:20%\">\r\n\r\n");
#nullable restore
#line 180 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                 foreach (Order order in ViewBag.list)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h4 style=\"border: 2pt\">Mã đơn hàng: ");
#nullable restore
#line 182 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                                                    Write(order.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" , Khách hàng : ");
#nullable restore
#line 182 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                                                                                  Write(order.User.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 182 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                                                                                                        Write(order.User.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(", Giá trị: ");
#nullable restore
#line 182 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                                                                                                                                       Write(order.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</h4>\r\n");
#nullable restore
#line 183 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                    using (var context = new ShopPRNContext())
                    {

                        List<OrderDetail> lodd = context.OrderDetails.Where(x => x.OrderId == order.OrderId).ToList();

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <table style=""border: 2pt"">
                            <tr style=""text-align:center"">
                                <td>Tên sản phẩm</td>
                                <td>Hình ảnh</td>
                                <td>Số lượng</td>
                                <td>Giá trị</td>
                            </tr>
");
#nullable restore
#line 194 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                             foreach (OrderDetail odd in lodd)
                            {
                                Product p = context.Products.Where(x => x.ProductId == odd.ProductId).SingleOrDefault();

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 198 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                                   Write(p.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td><img");
                BeginWriteAttribute("src", " src=\"", 12324, "\"", 12338, 1);
#nullable restore
#line 199 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
WriteAttributeValue("", 12330, p.Image, 12330, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"50px\" /></td>\r\n                                    <td>");
#nullable restore
#line 200 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                                   Write(odd.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 201 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                                    Write(odd.Quantity*p.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 203 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </table>\r\n");
#nullable restore
#line 205 "E:\FPTU\C#\Project\OnlineShopPRN\OnlineShopG5\Views\Home\DanhSachDonHang.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
        </section>

        <footer class=""footer"">
            <div class=""grid"">
                <div class=""grid__row"">
                    <div class=""grid__column-2-4"">
                        <h3 class=""footer__heading"">Chăm sóc khách hàng</h3>
                        <ul class=""footer-list"">
                            <li class=""footer-item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 13054, "\"", 13061, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Trung tâm trợ giúp</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 13236, "\"", 13243, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Rin-Shop Mall</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 13413, "\"", 13420, 0);
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
                BeginWriteAttribute("href", " href=\"", 13825, "\"", 13832, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Giới thiệu</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 13999, "\"", 14006, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Tuyển dụng</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 14173, "\"", 14180, 0);
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
                BeginWriteAttribute("href", " href=\"", 14575, "\"", 14582, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Sản phẩm</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 14747, "\"", 14754, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer-item__link\">Ưu đãi giảm giá</a>\r\n                            </li>\r\n                            <li class=\"footer-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 14926, "\"", 14933, 0);
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
                BeginWriteAttribute("href", " href=\"", 15326, "\"", 15333, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer-item__link"">
                                    <i class=""footer-item__icon fab fa-facebook""></i>
                                    Facebook
                                </a>
                            </li>
                            <li class=""footer-item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 15657, "\"", 15664, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer-item__link"">
                                    <i class=""footer-item__icon fab fa-instagram-square""></i>
                                    Instagram
                                </a>
                            </li>
                            <li class=""footer-item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 15997, "\"", 16004, 0);
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
                            <img src=""/img/QR_Code.png"" alt=""Download QR"" class=""footer__download-qr"">
                            <div class=""footer__download-apps"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 16693, "\"", 16700, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer__download-app-link\">\r\n\r\n                                    <img src=\"/img/gg.png\" alt=\"App Store\" class=\"footer__download-app-img\">\r\n                                </a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 16922, "\"", 16929, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer__download-app-link"">


                                    <img src=""/img/gg2.png"" alt=""Google Play"" class=""footer__download-app-img"">
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