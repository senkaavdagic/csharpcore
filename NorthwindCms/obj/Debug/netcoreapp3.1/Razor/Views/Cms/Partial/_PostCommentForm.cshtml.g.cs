#pragma checksum "C:\sourcecode\csharp\chapter14\PracticalApps\NorthwindCms\Views\Cms\Partial\_PostCommentForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ad89f069472801ce0df334abede2ebe4d779a4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Partial__PostCommentForm), @"mvc.1.0.view", @"/Views/Cms/Partial/_PostCommentForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad89f069472801ce0df334abede2ebe4d779a4c", @"/Views/Cms/Partial/_PostCommentForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Partial__PostCommentForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NorthwindCms.Models.BlogPost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "SaveComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\sourcecode\csharp\chapter14\PracticalApps\NorthwindCms\Views\Cms\Partial\_PostCommentForm.cshtml"
  
    var comments = await WebApp.Api.Posts.GetAllCommentsAsync(Model.Id, pageSize: 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\sourcecode\csharp\chapter14\PracticalApps\NorthwindCms\Views\Cms\Partial\_PostCommentForm.cshtml"
 if (Model.EnableComments)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"comments\">\n");
#nullable restore
#line 9 "C:\sourcecode\csharp\chapter14\PracticalApps\NorthwindCms\Views\Cms\Partial\_PostCommentForm.cshtml"
         if (Model.IsCommentsOpen)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning mt-5 mb-5 pt-4\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ad89f069472801ce0df334abede2ebe4d779a4c4438", async() => {
                WriteLiteral("\n                    ");
#nullable restore
#line 13 "C:\sourcecode\csharp\chapter14\PracticalApps\NorthwindCms\Views\Cms\Partial\_PostCommentForm.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    ");
#nullable restore
#line 14 "C:\sourcecode\csharp\chapter14\PracticalApps\NorthwindCms\Views\Cms\Partial\_PostCommentForm.cshtml"
               Write(Html.Hidden("Id", Model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                    <h4 class=""mb-3"">Leave a comment</h4>
                    <p class=""mb-4""><small>
                        Please note that we won't show your email to others, or use it for sending
                        unwanted emails. We will only use it to render your Gravatar image and to
                        validate you as a real person.
                    </small></p>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <input name=""CommentAuthor"" type=""text"" class=""form-control form-control-sm"" placeholder=""Your name"">
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <input name=""CommentEmail"" type=""text"" class=""form-control form-control-sm"" placeholder=""Your email address"">
                            </div>
                    ");
                WriteLiteral(@"    </div>
                    </div>
                    <div class=""form-group"">
                        <input name=""CommentUrl"" type=""text"" class=""form-control form-control-sm"" placeholder=""An (optional) URL to your website"">
                    </div>
                    <div class=""form-group"">
                        <textarea name=""CommentBody"" rows=""6"" class=""form-control form-control-sm"" placeholder=""Your awesome comment""></textarea>
                    </div>
                    <div class=""form-group text-left"">
                        <button class=""btn btn-sm btn-success"">Post Comment</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 45 "C:\sourcecode\csharp\chapter14\PracticalApps\NorthwindCms\Views\Cms\Partial\_PostCommentForm.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 46 "C:\sourcecode\csharp\chapter14\PracticalApps\NorthwindCms\Views\Cms\Partial\_PostCommentForm.cshtml"
   Write(Html.DisplayFor(m => comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 48 "C:\sourcecode\csharp\chapter14\PracticalApps\NorthwindCms\Views\Cms\Partial\_PostCommentForm.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindCms.Models.BlogPost> Html { get; private set; }
    }
}
#pragma warning restore 1591