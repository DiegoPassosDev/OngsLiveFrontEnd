#pragma checksum "C:\Users\Gabriel Gomes\Documents\apagarhoje\pwa\OngsLiveFrontEnd\OngLivesPWA\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cd15e6647b16f675d7de34e93cb32c4bfaf8356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\Gabriel Gomes\Documents\apagarhoje\pwa\OngsLiveFrontEnd\OngLivesPWA\Views\_ViewImports.cshtml"
using OngLivesPWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriel Gomes\Documents\apagarhoje\pwa\OngsLiveFrontEnd\OngLivesPWA\Views\_ViewImports.cshtml"
using OngLivesPWA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd15e6647b16f675d7de34e93cb32c4bfaf8356", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84a91e9dd66ac924f48dcaf9859e3ff68a221ce2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
#line 1 "C:\Users\Gabriel Gomes\Documents\apagarhoje\pwa\OngsLiveFrontEnd\OngLivesPWA\Views\Home\Privacy.cshtml"
  
    var date = DateTime.Now.ToShortDateString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cd15e6647b16f675d7de34e93cb32c4bfaf83563579", async() => {
                WriteLiteral(@"
  <div class=""form-group row"">
    <label for=""inputEmail3"" class=""col-sm-2 col-form-label"">Email</label>
    <div class=""col-sm-10"">
      <input type=""email"" class=""form-control"" id=""inputEmail3"" placeholder=""Email"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""inputPassword3"" class=""col-sm-2 col-form-label"">Password</label>
    <div class=""col-sm-10"">
      <input type=""password"" class=""form-control"" id=""inputPassword3"" placeholder=""Password"">
    </div>
  </div>
  <fieldset class=""form-group"">
    <div class=""row"">
      <legend class=""col-form-label col-sm-2 pt-0"">Radios</legend>
      <div class=""col-sm-10"">
        <div class=""form-check"">
          <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios1"" value=""option1"" checked>
          <label class=""form-check-label"" for=""gridRadios1"">
            First radio
          </label>
        </div>
        <div class=""form-check"">
          <input class=""form-check-input"" type=""radio"" ");
                WriteLiteral(@"name=""gridRadios"" id=""gridRadios2"" value=""option2"">
          <label class=""form-check-label"" for=""gridRadios2"">
            Second radio
          </label>
        </div>
        <div class=""form-check disabled"">
          <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios3"" value=""option3"" disabled>
          <label class=""form-check-label"" for=""gridRadios3"">
            Third disabled radio
          </label>
        </div>

      </div>
    </div>
  </fieldset>
  <div class=""form-group row"">
    <div class=""col-sm-2"">Checkbox</div>
    <div class=""col-sm-10"">
      <div class=""form-check"">
        <input class=""form-check-input"" type=""checkbox"" id=""gridCheck1"">
        <label class=""form-check-label"" for=""gridCheck1"">
          Example checkbox
        </label>
      </div>
    </div>
  </div>
  <div class=""form-group row"">
    <div class=""col-sm-10"">
      <button type=""submit"" class=""btn btn-primary"">Sign in</button>
    </div>
  </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
