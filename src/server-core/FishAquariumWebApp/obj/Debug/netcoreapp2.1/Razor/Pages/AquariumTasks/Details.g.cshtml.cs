#pragma checksum "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29f90508109cea5904aac00f4fe5eaa128d56e6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FishAquariumWebApp.Pages.AquariumTasks.Pages_AquariumTasks_Details), @"mvc.1.0.razor-page", @"/Pages/AquariumTasks/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AquariumTasks/Details.cshtml", typeof(FishAquariumWebApp.Pages.AquariumTasks.Pages_AquariumTasks_Details), null)]
namespace FishAquariumWebApp.Pages.AquariumTasks
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29f90508109cea5904aac00f4fe5eaa128d56e6f", @"/Pages/AquariumTasks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed21058faf97ea2753f70f8edecf5973d910236", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AquariumTasks_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(112, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Tasks</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(232, 53, false);
#line 15 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AquariumTask.Name));

#line default
#line hidden
            EndContext();
            BeginContext(285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(329, 49, false);
#line 18 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.AquariumTask.Name));

#line default
#line hidden
            EndContext();
            BeginContext(378, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(422, 57, false);
#line 21 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AquariumTask.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(479, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(523, 53, false);
#line 24 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.AquariumTask.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(620, 58, false);
#line 27 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AquariumTask.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(678, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(722, 54, false);
#line 30 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.AquariumTask.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(776, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(820, 60, false);
#line 33 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AquariumTask.Description));

#line default
#line hidden
            EndContext();
            BeginContext(880, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(924, 56, false);
#line 36 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.AquariumTask.Description));

#line default
#line hidden
            EndContext();
            BeginContext(980, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1024, 54, false);
#line 39 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AquariumTask.State));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1122, 50, false);
#line 42 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.AquariumTask.State));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1216, 59, false);
#line 45 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AquariumTask.FkAquarium));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1319, 55, false);
#line 48 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.AquariumTask.FkAquarium));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1418, 63, false);
#line 51 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AquariumTask.FkAquariumUser));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1525, 59, false);
#line 54 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.AquariumTask.FkAquariumUser));

#line default
#line hidden
            EndContext();
            BeginContext(1584, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1631, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f87e96ada346424e92c3e50887ec49f1", async() => {
                BeginContext(1690, 4, true);
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
#line 59 "C:\xampp\htdocs\fish-aquarium\src\server-core\FishAquariumWebApp\Pages\AquariumTasks\Details.cshtml"
                           WriteLiteral(Model.AquariumTask.Id);

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
            BeginContext(1698, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1706, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "898df53c544a4568a2638e97cf165469", async() => {
                BeginContext(1728, 12, true);
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
            BeginContext(1744, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FishAquariumWebApp.Pages.AquariumTasks.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FishAquariumWebApp.Pages.AquariumTasks.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FishAquariumWebApp.Pages.AquariumTasks.DetailsModel>)PageContext?.ViewData;
        public FishAquariumWebApp.Pages.AquariumTasks.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
