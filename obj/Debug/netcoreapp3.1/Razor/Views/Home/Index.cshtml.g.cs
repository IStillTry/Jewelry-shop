#pragma checksum "E:\.Net ASP Projects\JewelryShop3Course\JewelryShop\Jewelry shop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d27e13a62c6e189e287ad5573f6c102b8ee7afef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\.Net ASP Projects\JewelryShop3Course\JewelryShop\Jewelry shop\Views\_ViewImports.cshtml"
using Jewelry_shop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.Net ASP Projects\JewelryShop3Course\JewelryShop\Jewelry shop\Views\_ViewImports.cshtml"
using Jewelry_shop.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d27e13a62c6e189e287ad5573f6c102b8ee7afef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33c706f4acd4ff34ed3858ec73fd923c1e5f05fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>\r\n    <h2>Кращі прикраси</h2>\r\n    <div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 7 "E:\.Net ASP Projects\JewelryShop3Course\JewelryShop\Jewelry shop\Views\Home\Index.cshtml"
          
            foreach (JewelryItem jewelryitem in Model.favJewelryItems)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\.Net ASP Projects\JewelryShop3Course\JewelryShop\Jewelry shop\Views\Home\Index.cshtml"
           Write(Html.Partial("AllJewelryItems", jewelryitem));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\.Net ASP Projects\JewelryShop3Course\JewelryShop\Jewelry shop\Views\Home\Index.cshtml"
                                                             
            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591