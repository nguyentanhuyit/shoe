#pragma checksum "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eca45da1e1f39a66dfa8a2890aaad12b7ba4a26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductDetail), @"mvc.1.0.view", @"/Views/Product/ProductDetail.cshtml")]
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
#line 1 "D:\dotnet-workspace\Shoe\Shoe\Views\_ViewImports.cshtml"
using Shoe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotnet-workspace\Shoe\Shoe\Views\_ViewImports.cshtml"
using Shoe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eca45da1e1f39a66dfa8a2890aaad12b7ba4a26", @"/Views/Product/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ab9ced67c29f9216e1ca434fdd17ec89dabdf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
  
    ViewData["Title"] = "ProductDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Breadcrumb Section Begin -->
    <section class=""breadcrumb-section set-bg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <div class=""breadcrumb__text"">
                        <div class=""breadcrumb__option"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eca45da1e1f39a66dfa8a2890aaad12b7ba4a264209", async() => {
                WriteLiteral("Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a href=\"./index.html\">");
#nullable restore
#line 13 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                              Write(ViewBag.Detail.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <a href=\"./index.html\"></a>\r\n                            <span> ");
#nullable restore
#line 15 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                              Write(ViewBag.Detail.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Breadcrumb Section End -->
 <!-- Product Details Section Begin -->
    <section class=""product-details spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-6"">
                    <div class=""product__details__pic"">
                        <div class=""product__details__pic__item"">
                            <img class=""product__details__pic__item--large""");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1227, "\"", 1289, 1);
#nullable restore
#line 31 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1266, ViewBag.Detail.MainImg, 1266, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1290, "\"", 1296, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"product__details__pic__slider owl-carousel\">\r\n                            <img data-imgbigurl=\"");
#nullable restore
#line 34 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                            Write(ViewBag.Detail.Img1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1484, "\"", 1543, 1);
#nullable restore
#line 35 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1523, ViewBag.Detail.Img1, 1523, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1544, "\"", 1550, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img data-imgbigurl=\"");
#nullable restore
#line 36 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                            Write(ViewBag.Detail.Img2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1624, "\"", 1683, 1);
#nullable restore
#line 37 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1663, ViewBag.Detail.Img2, 1663, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1684, "\"", 1690, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img data-imgbigurl=\"");
#nullable restore
#line 38 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                            Write(ViewBag.Detail.Img3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1764, "\"", 1823, 1);
#nullable restore
#line 39 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1803, ViewBag.Detail.Img3, 1803, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1824, "\"", 1830, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img data-imgbigurl=\"");
#nullable restore
#line 40 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                            Write(ViewBag.Detail.Img3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1904, "\"", 1963, 1);
#nullable restore
#line 41 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1943, ViewBag.Detail.Img3, 1943, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1964, "\"", 1970, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 col-md-6\">\r\n                    <div class=\"product__details__text\">\r\n                        <h3>");
#nullable restore
#line 47 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                       Write(ViewBag.Detail.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <div class=""product__details__rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star-half-o""></i>
                            <span>(18 đánh giá)</span>
                        </div>
                        <div class=""product__details__price"">");
#nullable restore
#line 56 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                                        Write(ViewBag.Detail.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</div>\r\n                        <p>- Màu sắc: ");
#nullable restore
#line 57 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                 Write(ViewBag.Detail.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""size""></div>
                        <p>- Tình trạng: </p>
                        <div class=""product__details__quantity"">
                            <div class=""quantity"">
                                <div class=""pro-qty"">
                                    <input type=""text"" value=""1"">
                                </div>
                            </div>
                        </div>
                        <a href=""#"" class=""primary-btn"">Thêm vào giỏ hàng</a>
                        <a href=""#"" class=""heart-icon""><span class=""icon_heart_alt""></span></a>
                        <ul>
                            <li><b>Tình trạng</b> <span>Còn hàng</span></li>
                            <li><b>Vận chuyển</b> <span>Trong 1 ngày <samp></samp></span></li>
                            <li><b>Chia sẻ</b>
                                <div class=""share"">
                                    <a href=""#""><i class=""fa fa-facebook""></i></a>
        ");
            WriteLiteral(@"                            <a href=""#""><i class=""fa fa-twitter""></i></a>
                                    <a href=""#""><i class=""fa fa-instagram""></i></a>
                                    <a href=""#""><i class=""fa fa-pinterest""></i></a>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-12"">
                    <div class=""product__details__tab"">
                        <ul class=""nav nav-tabs"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" data-toggle=""tab"" href=""#tabs-1"" role=""tab""
                                    aria-selected=""true"">Mô tả</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-2"" role=""tab""
                                    aria-selected=""");
            WriteLiteral(@"false"">Nhận xét <span>(1)</span></a>
                            </li>
                        </ul>
                        <div class=""tab-content"">
                            <div class=""tab-pane active"" id=""tabs-1"" role=""tabpanel"">
                                <div class=""product__details__tab__desc"">
                                    <h6>Mô tả</h6>
                                    <p></p>
                                </div>
                            </div>
                            
                            <div class=""tab-pane"" id=""tabs-2"" role=""tabpanel"">
                                <div class=""product__details__tab__desc"">
                                    <div class=""container bootstrap snippets bootdey"">
                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""blog-comment"">
                                                    <p>4 ");
            WriteLiteral(@"bình luận</p>
                                                    <hr/>
                                                    <ul class=""comments"">
                                                        <li class=""clearfix"">
                                                        <img src=""user/img/products/boot/boot-1.jpg"" class=""avatar""");
            BeginWriteAttribute("alt", " alt=\"", 6232, "\"", 6238, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <div class=""post-comments"">
                                                            <p class=""meta"">2/2/2020, JohnDoe: <i class=""pull-right""><a href=""#""><small>Trả lời</small></a></i></p>
                                                            <p>
                                                                Đẹp quá ạ
                                                            </p>
                                                        </div>
                                                        </li>
                                                        <li class=""clearfix"">
                                                        <img src=""user/img/products/boot/boot-1.jpg"" class=""avatar""");
            BeginWriteAttribute("alt", " alt=\"", 7019, "\"", 7025, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <div class=""post-comments"">
                                                            <p class=""meta"">3/2/2020, Jack: <i class=""pull-right""><a href=""#""><small>Trả lời</small></a></i></p>
                                                            <p>
                                                               Dễ thương quá shop
                                                            </p>
                                                        </div>
                                                        
                                                        <ul class=""comments"">
                                                            <li class=""clearfix"">
                                                                <img src=""user/img/products/boot/boot-1.jpg"" class=""avatar""");
            BeginWriteAttribute("alt", " alt=\"", 7897, "\"", 7903, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                <div class=""post-comments"">
                                                                    <p class=""meta"">3/2/2020 admin : <i class=""pull-right""><a href=""#""><small>Reply</small></a></i></p>
                                                                    <p>
                                                                        Shop xin cảm ơn
                                                                    </p>
                                                                </div>
                                                            </li>
                                                        </ul>
                                                        </li>
                                                    </ul>
                                                    <textarea class=""form-control"" placeholder=""Viết bình luận"" rows=""3""></textarea>
                                                    <br>
       ");
            WriteLiteral(@"                                             <button type=""button"" class=""btn btn-info pull-right"">Post</button>
                                                    <div class=""clearfix""></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Product Details Section End -->
<!-- Related Product Section Begin -->
    <section class=""related-product"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section-title related__product__title"">
                        <h2>Thú cưng liên quan</h2>
                    </div>
                </div>
            ");
            WriteLiteral(@"</div>
            <div class=""row"">
                <div class=""col-lg-3 col-md-4 col-sm-6"">
                    <div class=""product__item"">
                        <div class=""product__item__pic set-bg"" data-setbg=""user/img/products/boot/boot-1.jpg"">
                            <ul class=""product__item__pic__hover"">
                                <li><a href=""wish-list.html""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""shop-details.html""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""shoping-cart.html""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""product__item__text"">
                            <h6><a href=""shop-details.html"">Phóc sóc trắng 02</a></h6>
                            <h5>7.000.000đ</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 c");
            WriteLiteral(@"ol-md-4 col-sm-6"">
                    <div class=""product__item"">
                        <div class=""product__item__pic set-bg"" data-setbg=""user/img/products/boot/boot-1.jpg"">
                            <ul class=""product__item__pic__hover"">
                                <li><a href=""wish-list.html""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""shop-details.html""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""shoping-cart.html""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""product__item__text"">
                            <h6><a href=""shop-details.html"">Poodle mơ 02</a></h6>
                            <h5>5.000.000đ</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6"">
                    <div class=""product__item"">
             ");
            WriteLiteral(@"           <div class=""product__item__pic set-bg"" data-setbg=""user/img/products/boot/boot-1.jpg"">
                            <ul class=""product__item__pic__hover"">
                                <li><a href=""wish-list.html""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""shop-details.html""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""shoping-cart.html""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""product__item__text"">
                            <h6><a href=""shop-details.html"">Corgi vàng 05</a></h6>
                            <h5>15.000.000đ</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6"">
                    <div class=""product__item"">
                        <div class=""product__item__pic set-bg"" data-setbg=""user/img/products/");
            WriteLiteral(@"boot/boot-1.jpg"">
                            <ul class=""product__item__pic__hover"">
                                <li><a href=""wish-list.html""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""shop-details.html""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""shoping-cart.html""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""product__item__text"">
                            <h6><a href=""shop-details.html"">Pomeranian vàng 06</a></h6>
                            <h5>9.000.000đ</h5>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Related Product Section End -->

");
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
