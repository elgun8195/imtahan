#pragma checksum "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5cfc7c91b55f9ab88236cfdce2f48e9c4fca46c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5cfc7c91b55f9ab88236cfdce2f48e9c4fca46c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a47ab5b55f2edf4fe574ba76f5d67ffcd510dcc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slide-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slide-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Second slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slide-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Third slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""slider"">
        <div id=""carouselExampleIndicators""
             class=""carousel slide""
             data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#carouselExampleIndicators""
                    data-slide-to=""0""
                    class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5cfc7c91b55f9ab88236cfdce2f48e9c4fca46c7464", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""carousel-caption d-none d-md-block"">
                        <h1>Welcome to MyBiz</h1>
                        <p>
                            Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut
                            et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem
                            mollitia ut. Similique ea voluptatem. Esse doloremque
                            accusamus repellendus deleniti vel. Minus et tempore modi
                            architecto.
                        </p>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1480, "\"", 1487, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Read More</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"carousel-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5cfc7c91b55f9ab88236cfdce2f48e9c4fca46c9570", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""carousel-caption d-none d-md-block"">
                        <h1>Lorem Ipsum Dolor</h1>
                        <p>
                            Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut
                            et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem
                            mollitia ut. Similique ea voluptatem. Esse doloremque
                            accusamus repellendus deleniti vel. Minus et tempore modi
                            architecto.
                        </p>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2375, "\"", 2382, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Read More</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"carousel-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5cfc7c91b55f9ab88236cfdce2f48e9c4fca46c11677", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""carousel-caption d-none d-md-block"">
                        <h1>Sequi ea ut et est quaerat</h1>
                        <p>
                            Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut
                            et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem
                            mollitia ut. Similique ea voluptatem. Esse doloremque
                            accusamus repellendus deleniti vel. Minus et tempore modi
                            architecto.
                        </p>
                        <a");
            BeginWriteAttribute("href", " href=\"", 3278, "\"", 3285, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Read More</a>
                    </div>
                </div>
            </div>
            <a class=""carousel-control-prev""
               href=""#carouselExampleIndicators""
               role=""button""
               data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next""
               href=""#carouselExampleIndicators""
               role=""button""
               data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </section>

    <section id=""services"">
        <div class=""container"">
            <div class=""row"">
                <div class=""services"">
                    <div class=""service-head mt-5"">
                        <h2>SERVICES</h2>
               ");
            WriteLiteral(@"         <p>
                            Sit sint consectetur velit quisquam cupiditate impedit
                            suscipit alias
                        </p>
                    </div>

                    <div class=""service-main mt-5 d-flex"">
                        <div class=""lo-lg-6"">
                            <div class=""service-item d-flex"">
                                <div class=""service-icon mt-4 ml-4"">
                                    <i class=""fa-solid fa-briefcase""></i>
                                </div>

                                <div class=""item mt-3"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 4964, "\"", 4971, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <h3>Lorem Ipsum</h3>
                                    </a>
                                    <p>
                                        Voluptatum deleniti atque corrupti quos dolores et quas
                                        molestias excepturi sint occaecati cupiditate non
                                        provident
                                    </p>
                                </div>
                            </div>
                            <div class=""service-item d-flex"">
                                <div class=""service-icon mt-4 ml-4"">
                                    <i class=""fa-solid fa-briefcase""></i>
                                </div>

                                <div class=""item mt-3"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 5822, "\"", 5829, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <h3>Lorem Ipsum</h3>
                                    </a>
                                    <p>
                                        Voluptatum deleniti atque corrupti quos dolores et quas
                                        molestias excepturi sint occaecati cupiditate non
                                        provident
                                    </p>
                                </div>
                            </div>
                            <div class=""service-item d-flex"">
                                <div class=""service-icon mt-4 ml-4"">
                                    <i class=""fa-solid fa-briefcase""></i>
                                </div>

                                <div class=""item mt-3"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 6680, "\"", 6687, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <h3>Lorem Ipsum</h3>
                                    </a>
                                    <p>
                                        Voluptatum deleniti atque corrupti quos dolores et quas
                                        molestias excepturi sint occaecati cupiditate non
                                        provident
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""lo-lg-6 ml-3"">
                            <div class=""service-item d-flex"">
                                <div class=""service-icon mt-4 ml-4"">
                                    <i class=""fa-solid fa-briefcase""></i>
                                </div>

                                <div class=""item mt-3"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 7622, "\"", 7629, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <h3>Lorem Ipsum</h3>
                                    </a>
                                    <p>
                                        Voluptatum deleniti atque corrupti quos dolores et quas
                                        molestias excepturi sint occaecati cupiditate non
                                        provident
                                    </p>
                                </div>
                            </div>
                            <div class=""service-item d-flex"">
                                <div class=""service-icon mt-4 ml-4"">
                                    <i class=""fa-solid fa-briefcase""></i>
                                </div>

                                <div class=""item mt-3"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 8480, "\"", 8487, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <h3>Lorem Ipsum</h3>
                                    </a>
                                    <p>
                                        Voluptatum deleniti atque corrupti quos dolores et quas
                                        molestias excepturi sint occaecati cupiditate non
                                        provident
                                    </p>
                                </div>
                            </div>
                            <div class=""service-item d-flex"">
                                <div class=""service-icon mt-4 ml-4"">
                                    <i class=""fa-solid fa-briefcase""></i>
                                </div>

                                <div class=""item mt-3"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 9338, "\"", 9345, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <h3>Lorem Ipsum</h3>
                                    </a>
                                    <p>
                                        Voluptatum deleniti atque corrupti quos dolores et quas
                                        molestias excepturi sint occaecati cupiditate non
                                        provident
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id=""team"">
        <div class=""container"">
            <div class=""row"">
                <div class=""service-head mt-5"">
                    <h2>Team</h2>
                    <p>
                        Sit sint consectetur velit quisquam cupiditate impedit suscipit
                        alias
                    </p>
                </div>

           ");
            WriteLiteral("     <div class=\"row\">\r\n                    <div class=\"team d-flex\">\r\n");
#nullable restore
#line 218 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
                         foreach (var item in Model.Team.Take(2))
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-6\">\r\n                            <div class=\"team-item d-flex\">\r\n                                <div class=\"team-img mt-3 ml-3\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5cfc7c91b55f9ab88236cfdce2f48e9c4fca46c22263", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10758, "~/images/", 10758, 9, true);
#nullable restore
#line 223 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 10767, item.Image, 10767, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"team-text mt-3\">\r\n                                    <h4>");
#nullable restore
#line 226 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 227 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
                                  Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>\r\n                                       ");
#nullable restore
#line 229 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
                                  Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <div class=\"team-icons d-flex\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 11254, "\"", 11274, 1);
#nullable restore
#line 232 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 11261, item.Twitter, 11261, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 11360, "\"", 11381, 1);
#nullable restore
#line 233 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 11367, item.Facebook, 11367, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-facebook\"></i></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 11468, "\"", 11491, 1);
#nullable restore
#line 234 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 11475, item.Instargarm, 11475, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-instagram\"></i></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 11579, "\"", 11600, 1);
#nullable restore
#line 235 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 11586, item.Linkedin, 11586, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-linkedin\"></i></a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 240 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                    </div>\r\n\r\n                    <div class=\"team mt-5 d-flex\">\r\n");
#nullable restore
#line 245 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
                      foreach (var item in Model.Team.Skip(2).Take(2))
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-6\">\r\n                            <div class=\"team-item d-flex\">\r\n                                <div class=\"team-img mt-3 ml-3\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5cfc7c91b55f9ab88236cfdce2f48e9c4fca46c27825", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 12252, "~/images/", 12252, 9, true);
#nullable restore
#line 250 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 12261, item.Image, 12261, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"team-text mt-3\">\r\n                                    <h4>");
#nullable restore
#line 253 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 254 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
                                  Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>\r\n                                       ");
#nullable restore
#line 256 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
                                  Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <div class=\"team-icons d-flex\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 12748, "\"", 12768, 1);
#nullable restore
#line 259 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 12755, item.Twitter, 12755, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 12854, "\"", 12875, 1);
#nullable restore
#line 260 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 12861, item.Facebook, 12861, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-facebook\"></i></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 12962, "\"", 12985, 1);
#nullable restore
#line 261 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 12969, item.Instargarm, 12969, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-instagram\"></i></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 13073, "\"", 13094, 1);
#nullable restore
#line 262 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 13080, item.Linkedin, 13080, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-linkedin\"></i></a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 267 "C:\Users\Administrator\Desktop\imtahan\Imtahan-Backend\Views\Home\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id=""contact"">
        <div class=""container"">
            <div class=""row"">
                <div class=""contact-head mt-5"">
                    <h2>Contact</h2>
                    <p>
                        Sit sint consectetur velit quisquam cupiditate impedit suscipit
                        alias
                    </p>
                </div>
            </div>

            <div class=""row"">
                <div class=""contact-header d-flex"">
                    <div class=""c-items d-flex"">
                        <div class=""contact-icon"">
                            <i class=""fa-solid fa-location-dot""></i>
                        </div>

                        <div class=""c-text"">
                            <h3>Location:</h3>
                            <p>A108 Adam Street New York, NY 535022</p>
                        </div>
                    </div>
     ");
            WriteLiteral(@"               <div class=""c-items ml-4 d-flex"">
                        <div class=""contact-icon"">
                            <i class=""fa-solid fa-envelope""></i>
                        </div>

                        <div class=""c-text"">
                            <h3>Location:</h3>
                            <p>A108 Adam Street New York, NY 535022</p>
                        </div>
                    </div>
                    <div class=""c-items ml-4 d-flex"">
                        <div class=""contact-icon"">
                            <i class=""fa-solid fa-phone""></i>
                        </div>

                        <div class=""c-text"">
                            <h3>Location:</h3>
                            <p>A108 Adam Street New York, NY 535022</p>
                        </div>
                    </div>
                </div>

                <div class=""form"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5cfc7c91b55f9ab88236cfdce2f48e9c4fca46c34791", async() => {
                WriteLiteral(@"
                        <div class=""forms d-flex"">
                            <input type=""text"" placeholder=""   Your Name"" />
                            <input type=""email""
                                   class=""ml-3""
                                   placeholder=""   Your Email"" />
                        </div>

                        <input class=""mt-5 mb-5""
                               type=""text""
                               placeholder=""    Subject"" />
                        <br />

                        <textarea");
                BeginWriteAttribute("name", " name=\"", 15856, "\"", 15863, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                                  id=\"", 15864, "\"", 15904, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                  cols=\"30\"\r\n                                  rows=\"10\"\r\n                                  placeholder=\"Message\"></textarea>\r\n\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 16094, "\"", 16101, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">Send Message</a>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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
