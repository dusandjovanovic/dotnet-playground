#pragma checksum "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e686e45e39a3348495e69f3bf52f83d7dec5d3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.R2_Create), @"mvc.1.0.razor-page", @"/R2/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e686e45e39a3348495e69f3bf52f83d7dec5d3c", @"/R2/Create.cshtml")]
    public class R2_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Restaurant</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Restaurant.Name"" class=""control-label""></label>
                <input asp-for=""Restaurant.Name"" class=""form-control"" />
                <span asp-validation-for=""Restaurant.Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Restaurant.Location"" class=""control-label""></label>
                <input asp-for=""Restaurant.Location"" class=""form-control"" />
                <span asp-validation-for=""Restaurant.Location"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Restaurant.Cuisine"" class=""control-label""></label>
                <select asp-for=""Restaurant.Cuisine"" class=""form-control""></selec");
            WriteLiteral(@"t>
                <span asp-validation-for=""Restaurant.Cuisine"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dotnet_foody.R2.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dotnet_foody.R2.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dotnet_foody.R2.CreateModel>)PageContext?.ViewData;
        public dotnet_foody.R2.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591