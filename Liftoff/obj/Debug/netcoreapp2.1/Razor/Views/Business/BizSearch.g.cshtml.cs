#pragma checksum "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\BizSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a33f5434631165260ff2499e543118dfc99b960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Business_BizSearch), @"mvc.1.0.view", @"/Views/Business/BizSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Business/BizSearch.cshtml", typeof(AspNetCore.Views_Business_BizSearch))]
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
#line 1 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\_ViewImports.cshtml"
using Liftoff;

#line default
#line hidden
#line 2 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\_ViewImports.cshtml"
using Liftoff.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a33f5434631165260ff2499e543118dfc99b960", @"/Views/Business/BizSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35789c74336089cdbb2c99f5bdc62940f8665c24", @"/Views/_ViewImports.cshtml")]
    public class Views_Business_BizSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Liftoff.Models.Business>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BizSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 119, true);
            WriteLiteral("<!--I\'d need to create the nav bar so that it\'s available in all the pages of the app where it needs\r\n    to be.-->\r\n\r\n");
            EndContext();
            BeginContext(168, 30, true);
            WriteLiteral("    <h1>Business Search</h1>\r\n");
            EndContext();
            BeginContext(201, 98, true);
            WriteLiteral("\r\n<h4>Search for businesses to pitch or businesses you\'ve already pitched here...</h4>\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(299, 551, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61eca5b8fcb54665832292f775b008c0", async() => {
                BeginContext(366, 288, true);
                WriteLiteral(@"

    <div>
        <!--<label asp-for=""Search Here""></label>-->
        <input type=""text"" name=""text"" class=""search"" placeholder=""Search Here"" />
        <input type=""submit"" name=""submit"" class=""submit"" value=""Search"" />
        <br />
        <br />
        <b>Search by: </b>");
                EndContext();
                BeginContext(655, 36, false);
#line 20 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\BizSearch.cshtml"
                     Write(Html.RadioButton("searchBy", "name"));

#line default
#line hidden
                EndContext();
                BeginContext(691, 15, true);
                WriteLiteral(" Name\r\n        ");
                EndContext();
                BeginContext(707, 46, false);
#line 21 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\BizSearch.cshtml"
   Write(Html.RadioButton("searchBy", "address_number"));

#line default
#line hidden
                EndContext();
                BeginContext(753, 26, true);
                WriteLiteral(" Building number\r\n        ");
                EndContext();
                BeginContext(780, 38, false);
#line 22 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\BizSearch.cshtml"
   Write(Html.RadioButton("searchBy", "street"));

#line default
#line hidden
                EndContext();
                BeginContext(818, 25, true);
                WriteLiteral(" Street\r\n\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(850, 55, true);
            WriteLiteral("\r\n\r\n<!--if no businesses match the search criteria-->\r\n");
            EndContext();
            BeginContext(1030, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1309, 183, true);
            WriteLiteral("\r\n\r\n<!--I\'d like for the search bar to kind of extend across the page as in my wireframe.-->\r\n<!--now, a space for the results and a scrollbar for those results when they show up-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Liftoff.Models.Business>> Html { get; private set; }
    }
}
#pragma warning restore 1591
