#pragma checksum "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Account\BizSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "799b317ffe79da1a8eb0f46d9c0fc47f13fdfedc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_BizSearch), @"mvc.1.0.view", @"/Views/Account/BizSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/BizSearch.cshtml", typeof(AspNetCore.Views_Account_BizSearch))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"799b317ffe79da1a8eb0f46d9c0fc47f13fdfedc", @"/Views/Account/BizSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35789c74336089cdbb2c99f5bdc62940f8665c24", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_BizSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Liftoff.Models.Business>>
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
            BeginContext(45, 121, true);
            WriteLiteral("\r\n<!--I\'d need to create the nav bar so that it\'s available in all the pages of the app where it needs\r\n    to be.-->\r\n\r\n");
            EndContext();
            BeginContext(170, 30, true);
            WriteLiteral("    <h1>Business Search</h1>\r\n");
            EndContext();
            BeginContext(203, 98, true);
            WriteLiteral("\r\n<h4>Search for businesses to pitch or businesses you\'ve already pitched here...</h4>\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(301, 535, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca3a486970b4d668fd18144f6c4d235", async() => {
                BeginContext(368, 272, true);
                WriteLiteral(@"

    <div>
        <!--<label asp-for=""Search Here""></label>-->
        <input type=""text"" name=""text"" class=""search"" placeholder=""Search Here"" />
        <input type=""submit"" name=""submit"" class=""submit"" value=""Search"" />
        <br />
        <b>Search by: </b>");
                EndContext();
                BeginContext(641, 36, false);
#line 20 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Account\BizSearch.cshtml"
                     Write(Html.RadioButton("searchBy", "name"));

#line default
#line hidden
                EndContext();
                BeginContext(677, 15, true);
                WriteLiteral(" Name\r\n        ");
                EndContext();
                BeginContext(693, 46, false);
#line 21 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Account\BizSearch.cshtml"
   Write(Html.RadioButton("searchBy", "address_number"));

#line default
#line hidden
                EndContext();
                BeginContext(739, 26, true);
                WriteLiteral(" Building number\r\n        ");
                EndContext();
                BeginContext(766, 38, false);
#line 22 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Account\BizSearch.cshtml"
   Write(Html.RadioButton("searchBy", "street"));

#line default
#line hidden
                EndContext();
                BeginContext(804, 25, true);
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
            BeginContext(836, 59, true);
            WriteLiteral("\r\n\r\n    <!--if no businesses match the search criteria-->\r\n");
            EndContext();
#line 29 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Account\BizSearch.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
            BeginContext(932, 81, true);
            WriteLiteral("        <tr>\r\n            <td>No rows match search criteria</td>\r\n        </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Account\BizSearch.cshtml"
    }

    

#line default
#line hidden
            BeginContext(1351, 167, true);
            WriteLiteral("\r\n\r\n<!--I\'d like for the search bar to kind of extend across the page as in my wireframe.-->\r\n\r\n<!--now, a space for the results and a scrollbar for those results-->\r\n");
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
