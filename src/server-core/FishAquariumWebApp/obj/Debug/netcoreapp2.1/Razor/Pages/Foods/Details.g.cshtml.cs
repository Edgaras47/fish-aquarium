#pragma checksum "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11feb2bdca0d1065e523d995cf07a0ccf78f4ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FishAquariumWebApp.Pages.Foods.Pages_Foods_Details), @"mvc.1.0.razor-page", @"/Pages/Foods/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Foods/Details.cshtml", typeof(FishAquariumWebApp.Pages.Foods.Pages_Foods_Details), null)]
namespace FishAquariumWebApp.Pages.Foods
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11feb2bdca0d1065e523d995cf07a0ccf78f4ab0", @"/Pages/Foods/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed21058faf97ea2753f70f8edecf5973d910236", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Foods_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(104, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Food</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(223, 45, false);
#line 15 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Food.Name));

#line default
#line hidden
            EndContext();
            BeginContext(268, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(312, 41, false);
#line 18 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayFor(model => model.Food.Name));

#line default
#line hidden
            EndContext();
            BeginContext(353, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(397, 45, false);
#line 21 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Food.Mass));

#line default
#line hidden
            EndContext();
            BeginContext(442, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(486, 41, false);
#line 24 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayFor(model => model.Food.Mass));

#line default
#line hidden
            EndContext();
            BeginContext(527, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(571, 49, false);
#line 27 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Food.Calories));

#line default
#line hidden
            EndContext();
            BeginContext(620, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(664, 45, false);
#line 30 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayFor(model => model.Food.Calories));

#line default
#line hidden
            EndContext();
            BeginContext(709, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(753, 46, false);
#line 33 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Food.Carbs));

#line default
#line hidden
            EndContext();
            BeginContext(799, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(843, 42, false);
#line 36 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayFor(model => model.Food.Carbs));

#line default
#line hidden
            EndContext();
            BeginContext(885, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(929, 47, false);
#line 39 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Food.Proten));

#line default
#line hidden
            EndContext();
            BeginContext(976, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1020, 43, false);
#line 42 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayFor(model => model.Food.Proten));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1107, 44, false);
#line 45 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Food.Fat));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1195, 40, false);
#line 48 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayFor(model => model.Food.Fat));

#line default
#line hidden
            EndContext();
            BeginContext(1235, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1279, 51, false);
#line 51 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Food.PrepManual));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1374, 47, false);
#line 54 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayFor(model => model.Food.PrepManual));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1465, 55, false);
#line 57 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Food.ExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1564, 51, false);
#line 60 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayFor(model => model.Food.ExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1659, 49, false);
#line 63 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Food.Allergen));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1752, 45, false);
#line 66 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
       Write(Html.DisplayFor(model => model.Food.Allergen));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1844, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed6e37e08abd4f48b9ea37af06d10249", async() => {
                BeginContext(1895, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Foods\Details.cshtml"
                           WriteLiteral(Model.Food.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1903, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1911, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c8478376444aafa3dc86f15a0833a7", async() => {
                BeginContext(1933, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1949, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FishAquariumWebApp.Pages.Foods.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FishAquariumWebApp.Pages.Foods.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FishAquariumWebApp.Pages.Foods.DetailsModel>)PageContext?.ViewData;
        public FishAquariumWebApp.Pages.Foods.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591