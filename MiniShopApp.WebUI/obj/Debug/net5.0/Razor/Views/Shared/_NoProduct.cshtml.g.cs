#pragma checksum "C:\Users\korkk\OneDrive\Masaüstü\MiniShopApp\MiniShopApp.WebUI\Views\Shared\_NoProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90ac3f1f1838d397a9ad13f3dc07cfca4d0d75f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NoProduct), @"mvc.1.0.view", @"/Views/Shared/_NoProduct.cshtml")]
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
#line 3 "C:\Users\korkk\OneDrive\Masaüstü\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\korkk\OneDrive\Masaüstü\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\korkk\OneDrive\Masaüstü\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\korkk\OneDrive\Masaüstü\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\korkk\OneDrive\Masaüstü\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\korkk\OneDrive\Masaüstü\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ac3f1f1838d397a9ad13f3dc07cfca4d0d75f0", @"/Views/Shared/_NoProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd3c89894a03aab7438ac4839f07264083b7b45d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NoProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 60, "\"", 98, 3);
            WriteAttributeValue("", 68, "alert", 68, 5, true);
            WriteAttributeValue(" ", 73, "alert-", 74, 7, true);
#nullable restore
#line 3 "C:\Users\korkk\OneDrive\Masaüstü\MiniShopApp\MiniShopApp.WebUI\Views\Shared\_NoProduct.cshtml"
WriteAttributeValue("", 80, ViewBag.AlertType, 80, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n             ");
#nullable restore
#line 4 "C:\Users\korkk\OneDrive\Masaüstü\MiniShopApp\MiniShopApp.WebUI\Views\Shared\_NoProduct.cshtml"
        Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
