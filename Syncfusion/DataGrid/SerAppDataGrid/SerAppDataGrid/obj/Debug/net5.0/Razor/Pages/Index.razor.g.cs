#pragma checksum "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38d97da753fe5c63e18e3f8504520868daa745e6"
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
#line 1 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using SerAppDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using SerAppDataGrid.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.SerAppDataGrid.Pages.Index.TypeInference.CreateSfGrid_0(__builder, 0, 1, "Grid", 2, 
#nullable restore
#line 16 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                 OrderList

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 16 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                                       new List<string>() { "ExcelExport","PdfExport","Search" }

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 17 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                     true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 18 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                          true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 19 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                        true

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.SfToolbar>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.ToolbarItems>(10);
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.ToolbarItem>(12);
                        __builder4.AddAttribute(13, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.ItemType>(
#nullable restore
#line 22 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                               ItemType.Input

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.ItemAlign>(
#nullable restore
#line 22 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                      Syncfusion.Blazor.Navigations.ItemAlign.Right

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "Template", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(16);
                            __builder5.AddAttribute(17, "Placeholder", "Enter values to search");
                            __builder5.AddAttribute(18, "Input", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.InputEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.InputEventArgs>(this, 
#nullable restore
#line 24 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                                           OnInput

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(19, "\r\n                    <span class=\"e-search-icon e-icons\"></span>");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(21);
                __builder2.AddAttribute(22, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(26);
                __builder2.AddAttribute(27, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "PageSizes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 32 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(30);
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(32);
                    __builder3.AddAttribute(33, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                            nameof(Orders.OrderId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "HeaderText", "Order Id");
                    __builder3.AddAttribute(36, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 38 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                               TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Width", "120");
                    __builder3.AddAttribute(38, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 40 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                       new ValidationRules{ Required=true, Number=true}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(40);
                    __builder3.AddAttribute(41, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                            nameof(Orders.CustomerId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "HeaderText", "Customer Name");
                    __builder3.AddAttribute(43, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 44 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                               TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 45 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                       new ValidationRules{ Required=true}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Width", "150");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(47);
                    __builder3.AddAttribute(48, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                            nameof(Orders.OrderDate)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "HeaderText", "Order Date");
                    __builder3.AddAttribute(50, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 49 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                               TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "Format", "d");
                    __builder3.AddAttribute(52, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ColumnType>(
#nullable restore
#line 51 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                          ColumnType.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "EditType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditType>(
#nullable restore
#line 52 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                              EditType.DatePickerEdit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "Width", "140");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(56);
                    __builder3.AddAttribute(57, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                            nameof(Orders.Freight)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "HeaderText", "Freight");
                    __builder3.AddAttribute(59, "Format", "C2");
                    __builder3.AddAttribute(60, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 58 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                               TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 59 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                       new ValidationRules{ Required=true, Range = new double[]{1, 1000}}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "EditType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditType>(
#nullable restore
#line 59 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                                                                                      EditType.NumericEdit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(65);
                    __builder3.AddAttribute(66, "HeaderText", "Manage Records");
                    __builder3.AddAttribute(67, "Width", "150");
                    __builder3.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumns>(69);
                        __builder4.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(71);
                            __builder5.AddAttribute(72, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 64 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                         CommandButtonType.Edit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(73, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 64 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                                                 new CommandButtonOptions() {IconCss="e-icons e-edit", CssClass="e-flat" }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(74, "\r\n                ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(75);
                            __builder5.AddAttribute(76, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 65 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                         CommandButtonType.Delete

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(77, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 65 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                                                   new CommandButtonOptions() {IconCss="e-icons e-delete", CssClass="e-flat" }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(78, "\r\n                ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(79);
                            __builder5.AddAttribute(80, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 66 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                         CommandButtonType.Save

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(81, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 66 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                                                 new CommandButtonOptions() {IconCss="e-icons e-save", CssClass="e-flat" }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(82, "\r\n                ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(83);
                            __builder5.AddAttribute(84, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 67 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                         CommandButtonType.Cancel

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(85, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 67 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                                                                                   new CommandButtonOptions() {IconCss="e-icons e-cancel-icon", CssClass="e-flat" }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 86, (__value) => {
#nullable restore
#line 16 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
                        DefaultGrid = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(87, "\r\n\r\n");
            __builder.AddMarkupContent(88, "<style>\r\n    .error {\r\n        color: red;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "D:\Program\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\Index.razor"
      

    public List<Orders> OrderList { get; set; }


    protected override void OnInitialized()
    {
        
        OrderList = Enumerable.Range(1, 75).Select(x => new Orders()
        {
            OrderId = 1000 + x,
            CustomerId = (new string[] { "NOOR", "RAM", "VINOTH", "KUMAR", "ROBERT" })[new Random().Next(5)],
            Freight = 2.1 * x,
            OrderDate = DateTime.Now.AddDays(-x),
        }).ToList();
    }

    public class Orders
    {
        public int? OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Freight { get; set; }
    }
    SfGrid<Orders> Grid;
    public async Task ToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Text == "PDF Export")
        {
            await this.Grid.ExportToPdfAsync();
        }
        if (args.Item.Text == "Excel Export")
        {
            await this.Grid.ExportToExcelAsync();
        }
    }
    private SfGrid<Orders> DefaultGrid;

    public void OnInput(InputEventArgs args)
    {
        this.DefaultGrid.Search(args.Value);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
namespace __Blazor.SerAppDataGrid.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TValue> __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ID", __arg0);
        __builder.AddAttribute(__seq1, "DataSource", __arg1);
        __builder.AddAttribute(__seq2, "Toolbar", __arg2);
        __builder.AddAttribute(__seq3, "AllowPaging", __arg3);
        __builder.AddAttribute(__seq4, "AllowExcelExport", __arg4);
        __builder.AddAttribute(__seq5, "AllowPdfExport", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.AddComponentReferenceCapture(__seq7, (__value) => { __arg7((global::Syncfusion.Blazor.Grids.SfGrid<TValue>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
