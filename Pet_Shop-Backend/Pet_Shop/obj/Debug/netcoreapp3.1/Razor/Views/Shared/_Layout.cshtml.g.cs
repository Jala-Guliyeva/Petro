#pragma checksum "C:\Users\Elgun\Desktop\Pet_Shop\Pet_Shop\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2d2fd5414839b758bab98e83978326499e5e037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Elgun\Desktop\Pet_Shop\Pet_Shop\Views\_ViewImports.cshtml"
using Pet_Shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elgun\Desktop\Pet_Shop\Pet_Shop\Views\_ViewImports.cshtml"
using Pet_Shop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2d2fd5414839b758bab98e83978326499e5e037", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2b56ad5b881ed2456cfbb27c2c854466937168", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/scss/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2d2fd5414839b758bab98e83978326499e5e0374145", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2d2fd5414839b758bab98e83978326499e5e0374815", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Document</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2d2fd5414839b758bab98e83978326499e5e0376732", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav id=\"navbar\">\r\n            <div class=\"row\">\r\n                <div class=\"navbarr d-flex\">\r\n                    <div class=\"nav-head d-flex\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 734, "\"", 741, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <h3>Home</h3>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 844, "\"", 851, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <h3>About</h3>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 955, "\"", 962, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <h3>Service</h3>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1068, "\"", 1075, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <h3>Price</h3>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1179, "\"", 1186, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <h3>Booking</h3>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1292, "\"", 1299, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <h3>Pages</h3>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1403, "\"", 1410, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <h3>Contact</h3>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"nav-end\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1587, "\"", 1594, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\"> Get Quote</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    <main>\r\n        ");
#nullable restore
#line 50 "C:\Users\Elgun\Desktop\Pet_Shop\Pet_Shop\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <footer id=""footer"">
            <div class=""row"">
                <div class=""footer-items d-flex"">
                    <div class=""col-lg-4"">
                        <div class=""footer-first"">
                            <h2><span>Pet</span>Lover</h2>
                            <p>
                                Ipsum amet sed vero et lorem stet eos ut, labore sed sed stet
                                sea est ipsum ut. Volup amet ea sanct ipsum, dolore vero lorem
                                no duo eirmod. Eirmod amet ipsum no ipsum lorem clita ut. Ut
                                sed sit lorem ea lorem sed, amet stet sit sea ea diam tempor
                                kasd kasd. Diam nonumy etsit tempor ut sed diam sed et ea
                            </p>
                        </div>
                    </div>
                    <div class=""col-lg-2"">
                        <div class=""footer-second"">
                            <h4>Get in touch</h4>
       ");
                WriteLiteral(@"                     <p>
                                <i class=""fa-solid fa-location-dot""></i> 123 Street, New York,
                                USA
                            </p>
                            <p><i class=""fa-solid fa-phone""></i> +012 345 67890</p>
                            <p><i class=""fa-solid fa-envelope""></i> mail@domain.com</p>
                            <div class=""f-icons d-flex"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 3255, "\"", 3262, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3340, "\"", 3347, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-facebook\"></i></a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3426, "\"", 3433, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-linkedin\"></i></a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3512, "\"", 3519, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa-brands fa-instagram""></i></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-2"">
                        <div class=""footer-third"">
                            <h4>Popular Links</h4>
                            <a");
                BeginWriteAttribute("href", " href=\"", 3839, "\"", 3846, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <p><i class=\"fa-solid fa-angle-right\"></i> Home</p>\r\n                            </a>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 3999, "\"", 4006, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <p><i class=\"fa-solid fa-angle-right\"></i> About Us</p>\r\n                            </a>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 4163, "\"", 4170, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <p><i class=\"fa-solid fa-angle-right\"></i> Our Services</p>\r\n                            </a>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 4331, "\"", 4338, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <p><i class=\"fa-solid fa-angle-right\"></i> Our Team</p>\r\n                            </a>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 4495, "\"", 4502, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <p><i class=""fa-solid fa-angle-right""></i> Contact Us</p>
                            </a>
                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""footer-four"">
                            <h4>
                                Newsletter
                            </h4>
                            <input type=""text"" placeholder=""    Your Name"" /><br />
                            <input type=""email"" placeholder=""    Your Email"" /><br />
                            <button type=""submit"">Submit Now</button>
                        </div>
                    </div>
                </div>
            </div>


            <div class=""row"">
                <div class=""footer-end d-flex"">
                    <div class=""col-lg-12"">
                        <div class=""f-start d-flex "">
                            <p>© <a");
                BeginWriteAttribute("href", " href=\"", 5465, "\"", 5472, 0);
                EndWriteAttribute();
                WriteLiteral(">Your Site Name</a>. All Rights Reserved. Designed by <a");
                BeginWriteAttribute("href", " href=\"", 5529, "\"", 5536, 0);
                EndWriteAttribute();
                WriteLiteral(">HTML Codex</a></p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-4\" style=\"padding-left: 100%;\">\r\n                        <div class=\"f-end d-flex\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 5772, "\"", 5779, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <p>Privacy</p>\r\n                            </a><a");
                BeginWriteAttribute("href", " href=\"", 5865, "\"", 5872, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <p>Terms</p>\r\n                            </a><a");
                BeginWriteAttribute("href", " href=\"", 5956, "\"", 5963, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <p>FAQs</p>\r\n                            </a><a");
                BeginWriteAttribute("href", " href=\"", 6046, "\"", 6053, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <p>Help</p>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
    </main>

    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
            integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js""
            integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js""
            integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
            crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
