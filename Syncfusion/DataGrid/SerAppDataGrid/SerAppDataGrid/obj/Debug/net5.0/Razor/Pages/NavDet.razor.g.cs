#pragma checksum "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\NavDet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "307399708aa6918f28b59c796b8650cf09aaa32a"
// <auto-generated/>
#pragma warning disable 1591
namespace SerAppDataGrid.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using SerAppDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using SerAppDataGrid.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sample")]
    public partial class NavDet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .customDiv {\r\n        padding: 10px;\r\n        width: 100%;\r\n    }\r\n</style>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""btn-group""><button class=""btn btn-danger"">Button 1</button>
    <button class=""btn btn-default"">Button 2</button>
    <button class=""btn btn-info"">Button 3</button>
    <button class=""btn btn-primary"">Button 4</button>
    <button class=""btn btn-success"">Button 5</button>
    <button class=""btn btn-warning"">Button 6</button></div>

");
            __builder.AddMarkupContent(2, @"<form class=""col-sm-5""><div class=""form-group""><label for=""inputName"">Name</label>
        <input class=""form-control"" type=""text"" id=""inputName"" placeholder=""Full Name""></div>
    <div class=""form-group""><label for=""inputDOB"">Date of Birth</label>
        <input class=""form-control"" type=""date"" id=""inputDOB""></div>
    <div class=""form-group""><label for=""inputEmail"">Email</label>
        <input class=""form-control"" type=""email"" id=""inputEmail"" placeholder=""Email address""></div>
    <div class=""form-group""><label for=""inputExperience"">Work Experience</label>
        <input class=""form-control"" type=""number"" id=""inputExperience"" placeholder=""Total experience in years""></div>
    <div class=""form-group""><label for=""inputUrl"">Personal Website</label>
        <input class=""form-control"" type=""url"" id=""inputUrl"" placeholder=""Your website address""></div>
    <button type=""submit"" class=""btn btn-default"">Login</button></form>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
