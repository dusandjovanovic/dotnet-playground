#pragma checksum "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59258cfcd8cc0597a5282ff538589f47a85c4ba9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.R2_Index), @"mvc.1.0.razor-page", @"/R2/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59258cfcd8cc0597a5282ff538589f47a85c4ba9", @"/R2/Index.cshtml")]
    public class R2_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].Cuisine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
 foreach (var item in Model.Restaurant) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cuisine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1012, "\"", 1035, 1);
#nullable restore
#line 41 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
WriteAttributeValue("", 1027, item.Id, 1027, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1088, "\"", 1111, 1);
#nullable restore
#line 42 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
WriteAttributeValue("", 1103, item.Id, 1103, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1166, "\"", 1189, 1);
#nullable restore
#line 43 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
WriteAttributeValue("", 1181, item.Id, 1181, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Dusan\Documents\Repositories\dotnet-playground\dotnet-foody\R2\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dotnet_foody.R2.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dotnet_foody.R2.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dotnet_foody.R2.IndexModel>)PageContext?.ViewData;
        public dotnet_foody.R2.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
