#pragma checksum "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c0088152cd4b1930fa5e8e816d582bdd3940a2d"
// <auto-generated/>
#pragma warning disable 1591
namespace SerAppDataGrid.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-meb18paa2r");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-meb18paa2r>SerAppDataGrid</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-meb18paa2r");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-meb18paa2r></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-meb18paa2r");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-meb18paa2r");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-meb18paa2r");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-meb18paa2r></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-meb18paa2r");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "counter");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-meb18paa2r></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddAttribute(38, "b-meb18paa2r");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "sample");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<span class=\"oi oi-phone\" aria-hidden=\"true\" b-meb18paa2r></span> Sample\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "nav-item px-3");
            __builder.AddAttribute(47, "b-meb18paa2r");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "nav-link");
            __builder.AddAttribute(50, "href", "pivot");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "<span class=\"oi oi-arrow-right\" aria-hidden=\"true\" b-meb18paa2r></span> Pivot\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "nav-item px-3");
            __builder.AddAttribute(56, "b-meb18paa2r");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(57);
            __builder.AddAttribute(58, "class", "nav-link");
            __builder.AddAttribute(59, "href", "fetchdata");
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(61, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-meb18paa2r></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
