#pragma checksum "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f499eed60ca6842de7a2ef79d219f1c464d0363e"
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
#line 1 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\_ViewImports.cshtml"
using Imtahan_Backend.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\_ViewImports.cshtml"
using Imtahan_Backend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f499eed60ca6842de7a2ef79d219f1c464d0363e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a47ab5b55f2edf4fe574ba76f5d67ffcd510dcc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f499eed60ca6842de7a2ef79d219f1c464d0363e4198", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link
      rel=""stylesheet""
      href=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css""
      integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm""
      crossorigin=""anonymous""
    />
    <link
      rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
      integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
      crossorigin=""anonymous""
      referrerpolicy=""no-referrer""
    />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f499eed60ca6842de7a2ef79d219f1c464d0363e5220", async() => {
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
                WriteLiteral("\r\n    <title>Document</title>\r\n  ");
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
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f499eed60ca6842de7a2ef79d219f1c464d0363e7137", async() => {
                WriteLiteral(@"
    <header id=""header"">
      <div class=""h-first"">
        <div class=""container"">
          <div class=""row"">
            <div class=""col-lg-6"">
              <div class=""header-contact"">
                <ul class=""d-flex"">
                  <li>
                    <i class=""fa-solid fa-envelope""
                      ><a");
                BeginWriteAttribute("href", " href=\"", 1234, "\"", 1241, 0);
                EndWriteAttribute();
                WriteLiteral(@">contact@example.com</a></i
                    >
                  </li>
                  <li>
                    <i class=""fa-solid fa-mobile-screen-button""></i>+1 5589
                    55488 55
                  </li>
                </ul>
              </div>
            </div>
            <div class=""col-lg-6"">
              <div class=""header-logo-icons d-flex"">
                <a");
                BeginWriteAttribute("href", " href=\"", 1648, "\"", 1677, 1);
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1655, Model.Setting.Twitter, 1655, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1739, "\"", 1769, 1);
#nullable restore
#line 47 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1746, Model.Setting.Facebook, 1746, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-facebook\"></i></a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1832, "\"", 1864, 1);
#nullable restore
#line 48 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1839, Model.Setting.Instargarm, 1839, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-instagram\"></i></a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1928, "\"", 1958, 1);
#nullable restore
#line 49 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1935, Model.Setting.Linkedin, 1935, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa-brands fa-linkedin""></i></a>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div class=""container"">
        <div class=""row"">
          <div class=""header d-flex"">
            <div class=""col-lg-6"">
              <div class=""header-logo"">
                <h2>My<span>Biz</span></h2>
              </div>
            </div>
            <div class=""col-lg-6"">
              <div class=""header-items"">
                <ul class=""d-flex"">
                  <li><a");
                BeginWriteAttribute("href", " href=\"", 2495, "\"", 2502, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"color: skyblue\">HOME</a></li>\r\n                  <li><a");
                BeginWriteAttribute("href", " href=\"", 2566, "\"", 2573, 0);
                EndWriteAttribute();
                WriteLiteral(">ABOUT</a></li>\r\n                  <li><a");
                BeginWriteAttribute("href", " href=\"", 2615, "\"", 2622, 0);
                EndWriteAttribute();
                WriteLiteral(">SERVICES</a></li>\r\n                  <li><a");
                BeginWriteAttribute("href", " href=\"", 2667, "\"", 2674, 0);
                EndWriteAttribute();
                WriteLiteral(">PORTFOLIO</a></li>\r\n                  <li><a");
                BeginWriteAttribute("href", " href=\"", 2720, "\"", 2727, 0);
                EndWriteAttribute();
                WriteLiteral(">TEAM</a></li>\r\n                  <li><a");
                BeginWriteAttribute("href", " href=\"", 2768, "\"", 2775, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"d-flex\">DROPDOWN</a></li>\r\n                  <li><a");
                BeginWriteAttribute("href", " href=\"", 2835, "\"", 2842, 0);
                EndWriteAttribute();
                WriteLiteral(">CONTACT</a></li>\r\n                </ul>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </header>\r\n        ");
#nullable restore
#line 81 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                  
    <footer>
      <div class=""row"">
        <div class=""col-lg-3 mt-5 mb-5"">
          <div class=""f-left"">
            <h4>MyBiz</h4>
            <span> A108 Adam Street NY 535022, USA </span>

            <p>Phone: +1 5589 55488 55</p>
            <p>Email: info@example.com</p>

            <div class=""f-icons d-flex"">
              <a");
                BeginWriteAttribute("href", " href=\"", 3388, "\"", 3417, 1);
#nullable restore
#line 96 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3395, Model.Setting.Twitter, 3395, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n              <a");
                BeginWriteAttribute("href", " href=\"", 3477, "\"", 3507, 1);
#nullable restore
#line 97 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3484, Model.Setting.Facebook, 3484, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-facebook\"></i></a>\r\n              <a");
                BeginWriteAttribute("href", " href=\"", 3568, "\"", 3600, 1);
#nullable restore
#line 98 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3575, Model.Setting.Instargarm, 3575, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-instagram\"></i></a>\r\n              <a");
                BeginWriteAttribute("href", " href=\"", 3662, "\"", 3689, 1);
#nullable restore
#line 99 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3669, Model.Setting.Skype, 3669, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-skype\"></i></a>\r\n              <a");
                BeginWriteAttribute("href", " href=\"", 3747, "\"", 3777, 1);
#nullable restore
#line 100 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3754, Model.Setting.Linkedin, 3754, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa-brands fa-linkedin""></i></a>
            </div>
          </div>
        </div>
        <div class=""col-lg-3 mt-5 mb-5"">
          <div class=""f-left-center"">
            <h4>Useful Links</h4>
            <ul>
              <li><i class=""fa-solid fa-angle-right""></i> Home</li>
              <li><i class=""fa-solid fa-angle-right""></i> About</li>
              <li><i class=""fa-solid fa-angle-right""></i> Services</li>
              <li><i class=""fa-solid fa-angle-right""></i> Terms Of service</li>
              <li><i class=""fa-solid fa-angle-right""></i> Privicary Policy</li>
            </ul>
          </div>
        </div>
        <div class=""col-lg-3 mt-5 mb-5"">
          <div class=""f-right-center"">
            <h4>Our Services</h4>
            <ul>
              <li><i class=""fa-solid fa-angle-right""></i> Web Design</li>
              <li><i class=""fa-solid fa-angle-right""></i> Web Development</li>
              <li>
                <i class=""fa-solid fa-angle-right""></i>");
                WriteLiteral(@" Product Management
              </li>

              <li><i class=""fa-solid fa-angle-right""></i> Marketing</li>
              <li><i class=""fa-solid fa-angle-right""></i> Graphic Design</li>
            </ul>
          </div>
        </div>
        <div class=""col-lg-3 mt-5 mb-5"">
          <div class=""f-end"">
            <h4>Our Newsletter</h4>
            <p>
              Tamen quem nulla quae legam multos aute sint culpa legam noster
              magna
            </p>

            <div class=""f-end-btn d-flex"">
              <input type=""text"" /><button type=""submit"">Subscribe</button>
            </div>
          </div>
        </div>
      </div>
      <div class=""row"">
        <div class=""f-last"">
          <p>© Copyright MyBiz. All Rights Reserved</p>
          <p>Designed by <a");
                BeginWriteAttribute("href", " href=\"", 5627, "\"", 5634, 0);
                EndWriteAttribute();
                WriteLiteral(@">BootstrapMade</a></p>
        </div>
      </div>
    </footer>

    <script
      src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
      integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
      crossorigin=""anonymous""
    ></script>
    <script
      src=""https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js""
      integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
      crossorigin=""anonymous""
    ></script>
    <script
      src=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js""
      integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
      crossorigin=""anonymous""
    ></script>
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591