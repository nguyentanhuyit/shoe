#pragma checksum "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ListProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "915f19333cf1e8b0000328faf5c51c933aeda1d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ListProduct), @"mvc.1.0.view", @"/Views/Product/ListProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915f19333cf1e8b0000328faf5c51c933aeda1d5", @"/Views/Product/ListProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ab9ced67c29f9216e1ca434fdd17ec89dabdf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ListProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ListProduct.cshtml"
  
    ViewData["Title"] = "ListProduct";

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "915f19333cf1e8b0000328faf5c51c933aeda1d55232", async() => {
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
            WriteLiteral(@"
                            <span>Shop</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Breadcrumb Section End -->
<!-- Product Section Begin -->
    <section class=""product spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-5"">
                    <div class=""sidebar"">
                        
                        <div class=""sidebar__item"">
                            <h4>Giá</h4>
                            <div class=""price-range-wrap"">
                                <div class=""price-range ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content""
                                    data-min=""0"" data-max=""100000000"">
                                    <div class=""ui-slider-range ui-corner-all ui-widget-header""></div>
                                    <span tabindex=""0"" class=""ui-slider-handle ui-corner-a");
            WriteLiteral(@"ll ui-state-default""></span>
                                    <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                                </div>
                                <div class=""range-slider"">
                                    <div class=""price-input"">
                                        <input type=""text"" id=""minamount"">
                                        <input type=""text"" id=""maxamount"">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""sidebar__item sidebar__item__color--option"">
                            <h4>Màu sắc</h4>
                            <div class=""sidebar__item__color sidebar__item__color--white"">
                                <label for=""white"">
                                    Trắng
                                    <input type=""radio"" id=""white"">
                      ");
            WriteLiteral(@"          </label>
                            </div>
                            <div class=""sidebar__item__color sidebar__item__color--gray"">
                                <label for=""gray"">
                                    Xám
                                    <input type=""radio"" id=""gray"">
                                </label>
                            </div>
                            <div class=""sidebar__item__color sidebar__item__color--red"">
                                <label for=""red"">
                                    Đỏ
                                    <input type=""radio"" id=""red"">
                                </label>
                            </div>
                            <div class=""sidebar__item__color sidebar__item__color--black"">
                                <label for=""black"">
                                    Đen
                                    <input type=""radio"" id=""black"">
                                </label>
               ");
            WriteLiteral(@"             </div>
                            <div class=""sidebar__item__color sidebar__item__color--blue"">
                                <label for=""blue"">
                                    Xanh dương
                                    <input type=""radio"" id=""blue"">
                                </label>
                            </div>
                            <div class=""sidebar__item__color sidebar__item__color--green"">
                                <label for=""green"">
                                    Xanh lá
                                    <input type=""radio"" id=""green"">
                                </label>
                            </div>
                        </div>
                        <div class=""sidebar__item"">
                            <h4>Kích cỡ</h4>
                            <div class=""sidebar__item__size"">
                                <label for=""large"">
                                    Lớn
                                    <inpu");
            WriteLiteral(@"t type=""radio"" id=""large"">
                                </label>
                            </div>
                            <div class=""sidebar__item__size"">
                                <label for=""medium"">
                                    Trung bình
                                    <input type=""radio"" id=""medium"">
                                </label>
                            </div>
                            <div class=""sidebar__item__size"">
                                <label for=""small"">
                                    Nhỏ
                                    <input type=""radio"" id=""small"">
                                </label>
                            </div>
                            <div class=""sidebar__item__size"">
                                <label for=""tiny"">
                                    Tiny
                                    <input type=""radio"" id=""tiny"">
                                </label>
                            </div>");
            WriteLiteral(@"
                        </div>
                        
                    </div>
                </div>
                <div class=""col-lg-9 col-md-7"">
                    <div class=""filter__item"">
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-5"">
                                <div class=""filter__sort"">
                                    <span>Sắp xếp</span>
                                    <select>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "915f19333cf1e8b0000328faf5c51c933aeda1d512526", async() => {
                WriteLiteral("Mặc định");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "915f19333cf1e8b0000328faf5c51c933aeda1d513728", async() => {
                WriteLiteral("Mặc định");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <div class=""filter__found"">
                                    <h6><span>");
#nullable restore
#line 128 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ListProduct.cshtml"
                                         Write(ViewBag.ListProductSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> sản phẩm được tìm thấy</h6>
                                </div>
                            </div>
                            <div class=""col-lg-4 col-md-3"">
                                <div class=""filter__option"">
                                    <span class=""icon_grid-2x2""></span>
                                    <span class=""icon_ul""></span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
");
#nullable restore
#line 140 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ListProduct.cshtml"
                         foreach(var item in ViewBag.ListProduct){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                            <div class=\"product__item\">\r\n                                <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 143 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ListProduct.cshtml"
                                                                              Write(item.MainImg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <ul class=\"product__item__pic__hover\">\r\n                                        <li><a href=\"wish-list.html\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "915f19333cf1e8b0000328faf5c51c933aeda1d516977", async() => {
                WriteLiteral("<i class=\"fa fa-retweet\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                        <li><a");
            BeginWriteAttribute("onclick", " onclick=\"", 7722, "\"", 7760, 3);
            WriteAttributeValue("", 7732, "addToCart(", 7732, 10, true);
#nullable restore
#line 147 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ListProduct.cshtml"
WriteAttributeValue(" ", 7742, item.ProductId, 7743, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 7758, ")", 7759, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a></li>\r\n                                    </ul>\r\n                                </div>\r\n                                <div class=\"product__item__text\">\r\n                                    <h6>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "915f19333cf1e8b0000328faf5c51c933aeda1d519160", async() => {
#nullable restore
#line 151 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ListProduct.cshtml"
                                                                                          Write(item.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\r\n                                    <h5>");
#nullable restore
#line 152 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ListProduct.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 156 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ListProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""product__pagination"">
                        <a href=""#"">1</a>
                        <a href=""#"">2</a>
                        <a href=""#"">3</a>
                        <a href=""#""><i class=""fa fa-long-arrow-right""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Product Section End -->

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
