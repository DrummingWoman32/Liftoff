#pragma checksum "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f53ff8ecd9cde077e796777a0a228716a8192d08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Business_JQueryDataTableEditableLayout), @"mvc.1.0.view", @"/Views/Business/JQueryDataTableEditableLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Business/JQueryDataTableEditableLayout.cshtml", typeof(AspNetCore.Views_Business_JQueryDataTableEditableLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f53ff8ecd9cde077e796777a0a228716a8192d08", @"/Views/Business/JQueryDataTableEditableLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35789c74336089cdbb2c99f5bdc62940f8665c24", @"/Views/_ViewImports.cshtml")]
    public class Views_Business_JQueryDataTableEditableLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 110, true);
            WriteLiteral("<!---<!DOCTYPE html>\r\n\r\n<html>\r\n<head>\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
            EndContext();
            BeginContext(111, 13, false);
#line 6 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(124, 46, true);
            WriteLiteral("</title>\r\n</head>\r\n<body>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(171, 12, false);
#line 10 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(183, 64, true);
            WriteLiteral("\r\n    </div>\r\n</body>\r\n</html>-->\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(247, 1305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a7e895dd81e4ffea2bbbb4c80c6751b", async() => {
                BeginContext(253, 67, true);
                WriteLiteral("\r\n    <title>Customization of Editable DataTable</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 320, "\"", 378, 1);
#line 20 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
WriteAttributeValue("", 327, Url.Content("~/Content/dataTables/demo_table.css"), 327, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(379, 58, true);
                WriteLiteral("\r\n          rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 437, "\"", 499, 1);
#line 22 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
WriteAttributeValue("", 444, Url.Content("~/Content/dataTables/demo_table_jui.css"), 444, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(500, 58, true);
                WriteLiteral("\r\n          rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 558, "\"", 616, 1);
#line 24 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
WriteAttributeValue("", 565, Url.Content("~/Content/themes/base/jquery-ui.css"), 565, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(617, 70, true);
                WriteLiteral("\r\n          rel=\"stylesheet\" type=\"text/css\" media=\"all\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 687, "\"", 764, 1);
#line 26 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
WriteAttributeValue("", 694, Url.Content("~/Content/themes/smoothness/jquery-ui-1.7.2.custom.css"), 694, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(765, 72, true);
                WriteLiteral("\r\n          rel=\"stylesheet\" type=\"text/css\" media=\"all\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 837, "\"", 888, 1);
#line 28 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
WriteAttributeValue("", 843, Url.Content("~/Scripts/jquery-1.4.4.min.js"), 843, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(889, 59, true);
                WriteLiteral("\r\n            type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 948, "\"", 1004, 1);
#line 30 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
WriteAttributeValue("", 954, Url.Content("~/Scripts/jquery.dataTables.min.js"), 954, 50, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1005, 59, true);
                WriteLiteral("\r\n            type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1064, "\"", 1115, 1);
#line 32 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
WriteAttributeValue("", 1070, Url.Content("~/Scripts/jquery.jeditable.js"), 1070, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1116, 59, true);
                WriteLiteral("\r\n            type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1175, "\"", 1219, 1);
#line 34 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
WriteAttributeValue("", 1181, Url.Content("~/Scripts/jquery-ui.js"), 1181, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1220, 59, true);
                WriteLiteral("\r\n            type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1279, "\"", 1329, 1);
#line 36 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
WriteAttributeValue("", 1285, Url.Content("~/Scripts/jquery.validate.js"), 1285, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1330, 59, true);
                WriteLiteral("\r\n            type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1389, "\"", 1450, 1);
#line 38 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
WriteAttributeValue("", 1395, Url.Content("~/Scripts/jquery.dataTables.editable.js"), 1395, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1451, 52, true);
                WriteLiteral("\r\n            type=\"text/javascript\"></script>\r\n    ");
                EndContext();
                BeginContext(1504, 38, false);
#line 40 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
Write(RenderSection("head", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1542, 3, true);
                WriteLiteral(";\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1552, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1554, 255, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51ecaa37310a42a5bbb5a61ccf2f88e5", async() => {
                BeginContext(1560, 215, true);
                WriteLiteral("\r\n    <div id=\"container\">\r\n        <!--<a href=\"/Company/Index\">Basic Example</a>\r\n        <a href=\"/Company/Ajax\">Getting data with Ajax</a>\r\n        <a href=\"/Company/Customization\">Customization</a>-->\r\n        ");
                EndContext();
                BeginContext(1776, 12, false);
#line 47 "C:\Users\Administrator\lc101\Liftoff\Liftoff\Views\Business\JQueryDataTableEditableLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1788, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1809, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
