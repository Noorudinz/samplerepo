// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SerAppDataGrid.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using SerAppDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using SerAppDataGrid.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\Pages\ToDoList.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\Pages\ToDoList.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\Pages\ToDoList.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
    public partial class ToDoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "d:\program\samplesongit\syncfusion\datagrid\serappdatagrid\SerAppDataGrid\Pages\ToDoList.razor"
       
    private string item;
    private List<ItemModel> items = new List<ItemModel>();

    private void UpdateItem(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {
        item = args.Value.ToString();
    }

    // Add new items on button click.
    private void AddItem()
    {
        if (item != null && item.Length > 0)
        {
            var newItem = new ItemModel(items.Count + 1, item);
            items.Add(newItem);
            item = null;
        }
    }

    // List view data source model.
    public class ItemModel
    {
        public ItemModel(int id, string text)
        {
            Id = id;
            Text = text;
        }
        public int Id { get; set; }
        public string Text { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
