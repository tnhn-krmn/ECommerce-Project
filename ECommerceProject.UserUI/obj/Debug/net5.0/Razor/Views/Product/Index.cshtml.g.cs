#pragma checksum "C:\Users\tunah\OneDrive\Masaüstü\e-commerce-project\ECommerceProject\ECommerceProject\ECommerceProject.UserUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec08b67060243a7f5e75ff45d7fd6e15e25bff41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\tunah\OneDrive\Masaüstü\e-commerce-project\ECommerceProject\ECommerceProject\ECommerceProject.UserUI\Views\_ViewImports.cshtml"
using ECommerceProject.UserUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tunah\OneDrive\Masaüstü\e-commerce-project\ECommerceProject\ECommerceProject\ECommerceProject.UserUI\Views\_ViewImports.cshtml"
using ECommerceProject.UserUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec08b67060243a7f5e75ff45d7fd6e15e25bff41", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05e5c78ea7b55976b094137f1670607a1bb363c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mt-4 text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n<div class=\"container d-flex justify-content-center mt-50 mb-50\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\tunah\OneDrive\Masaüstü\e-commerce-project\ECommerceProject\ECommerceProject\ECommerceProject.UserUI\Views\Product\Index.cshtml"
         foreach (var item in Model.Products)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-10"">
                <div class=""card card-body"">
                    <div class=""media align-items-center align-items-lg-start text-center text-lg-left flex-column flex-lg-row"">
                        <div class=""mr-2 mb-3 mb-lg-0"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 483, "\"", 503, 1);
#nullable restore
#line 13 "C:\Users\tunah\OneDrive\Masaüstü\e-commerce-project\ECommerceProject\ECommerceProject\ECommerceProject.UserUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 489, item.ImageUrl, 489, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"150\"");
            BeginWriteAttribute("alt", " alt=\"", 529, "\"", 535, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"media-body\">\r\n                            <h6 class=\"media-title font-weight-semibold\">\r\n                                <a href=\"#\" data-abc=\"true\">");
#nullable restore
#line 17 "C:\Users\tunah\OneDrive\Masaüstü\e-commerce-project\ECommerceProject\ECommerceProject\ECommerceProject.UserUI\Views\Product\Index.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </h6>
                            <ul class=""list-inline list-inline-dotted mb-0"">
                                <li class=""list-inline-item"">All items from <a href=""#"" data-abc=""true"">Fruit</a></li>
                                <li class=""list-inline-item"">Add to <a href=""#"" data-abc=""true"">wishlist</a></li>
                            </ul>
                        </div>
                        <div class=""mt-3 mt-lg-0 ml-lg-3 text-center"">
                            <h3 class=""mb-0 font-weight-semibold"">$");
#nullable restore
#line 25 "C:\Users\tunah\OneDrive\Masaüstü\e-commerce-project\ECommerceProject\ECommerceProject\ECommerceProject.UserUI\Views\Product\Index.cshtml"
                                                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                            <div>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                            </div>
                            <div class=""text-muted"">1985 reviews</div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec08b67060243a7f5e75ff45d7fd6e15e25bff417852", async() => {
                WriteLiteral("<i class=\"icon-cart-add mr-2\"></i> Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\tunah\OneDrive\Masaüstü\e-commerce-project\ECommerceProject\ECommerceProject\ECommerceProject.UserUI\Views\Product\Index.cshtml"
                                                                                                                                           WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\tunah\OneDrive\Masaüstü\e-commerce-project\ECommerceProject\ECommerceProject\ECommerceProject.UserUI\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
