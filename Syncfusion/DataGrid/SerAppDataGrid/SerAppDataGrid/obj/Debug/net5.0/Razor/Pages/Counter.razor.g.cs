#pragma checksum "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34efabf9410f2164a257bd88d8a658151a3f9174"
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
#nullable restore
#line 5 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter1/{Name}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/routecons/{Id:guid}")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, "Counter1 with param: ");
            __builder.AddContent(3, 
#nullable restore
#line 13 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor"
                          Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Current count: ");
            __builder.AddContent(7, 
#nullable restore
#line 15 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor"
                                          QueryParams

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Query Params");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-lg-12 control-section");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "control_wrapper");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfUploader>(23);
            __builder.AddAttribute(24, "ID", "UploadFiles");
            __builder.AddAttribute(25, "DropArea", ".control-fluid");
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.UploaderEvents>(27);
                __builder2.AddAttribute(28, "OnRemove", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.RemovingEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.RemovingEventArgs>(this, 
#nullable restore
#line 24 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor"
                                      OnFileRemove

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.UploaderAsyncSettings>(30);
                __builder2.AddAttribute(31, "SaveUrl", "https://aspnetmvc.syncfusion.com/services/api/uploadbox/Save");
                __builder2.AddAttribute(32, "RemoveUrl", "https://aspnetmvc.syncfusion.com/services/api/uploadbox/Remove");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(34, "<h3>Route Constraints Example</h3>\r\n\r\n\r\n");
            __builder.OpenElement(35, "h4");
            __builder.AddContent(36, "Id : ");
            __builder.AddContent(37, 
#nullable restore
#line 36 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor"
          Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n");
            __builder.AddMarkupContent(39, "<style>\r\n    .control_wrapper {\r\n        width: 350px;\r\n        margin: 0 auto;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Counter.razor"
       
    [Parameter]
    public Guid Id { get; set; }

    [Parameter]
    public string Name { get; set; }

    public void OnFileRemove(RemovingEventArgs args)
    {
        args.PostRawFile = false;

    }
    private int currentCount = 0;

    protected override void OnInitialized()
    {
        StringValues initCount;
        var uri = navManager.ToAbsoluteUri(navManager.Uri);
        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("initialCount", out initCount))
        {
            currentCount = Convert.ToInt32(initCount);
        }

    }

    private void IncrementCount()
    {
        currentCount++;
    }

    private void QueryParams()
    {
        var query = new Dictionary<string, string> {
            { "firstname", "Noor" },
            { "lastname", "deen" }
        };
        navManager.NavigateTo(QueryHelpers.AddQueryString("/anothereg", query));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
    }
}
#pragma warning restore 1591
