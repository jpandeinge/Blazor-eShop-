#pragma checksum "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\SearchProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ac479f711cbb14611d7c8ac710543369d8a826"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.SearchProducts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using eShop.UseCases.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using eShop.UseCases.PluginInterfaces.DataStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Dev\tutorials\E-Commerce\Server\_Imports.razor"
using Server.Components;

#line default
#line hidden
#nullable disable
    public partial class SearchProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Server.Pages.SearchProducts.SearchProducts.TypeInference.CreateMudTable_0(__builder, 0, 1, 
#nullable restore
#line 3 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\SearchProducts.razor"
                        new Func<TableState,Task<TableData<Product>>>(ServerReload)

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 3 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\SearchProducts.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 3 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\SearchProducts.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(5);
                __builder2.AddAttribute(6, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\SearchProducts.razor"
                      Color.Default

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "StartIcon", "fas fa-file-excel");
                __builder2.AddAttribute(8, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\SearchProducts.razor"
                                                                             ExportExcel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, " Export Excel");
                }
                ));
                __builder2.CloseComponent();
            }
            , 11, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTableSortLabel<Product>>(14);
                    __builder3.AddAttribute(15, "SortLabel", "name_field");
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(17, "Name");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(19);
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTableSortLabel<Product>>(21);
                    __builder3.AddAttribute(22, "SortLabel", "brand_field");
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(24, "Brand");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(26);
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTableSortLabel<Product>>(28);
                    __builder3.AddAttribute(29, "SortLabel", "price_field");
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, "Price");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 32, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(33);
                __builder2.AddAttribute(34, "DataLabel", "Name");
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(36, 
#nullable restore
#line 22 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\SearchProducts.razor"
                                 context.Name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(38);
                __builder2.AddAttribute(39, "DataLabel", "Brand");
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(41, 
#nullable restore
#line 23 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\SearchProducts.razor"
                                  context.Brand

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(43);
                __builder2.AddAttribute(44, "DataLabel", "Price");
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(46, 
#nullable restore
#line 24 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\SearchProducts.razor"
                                  context.Price.ToString("NAD ### ###.00")

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            , 47, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(48);
                __builder2.CloseComponent();
            }
            , 49, (__value) => {
#nullable restore
#line 3 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\SearchProducts.razor"
                                                                                                                      table = __value;

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISearchProduct searchProduct { get; set; }
    }
}
namespace __Blazor.Server.Pages.SearchProducts.SearchProducts
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::MudBlazor.TableState, global::System.Threading.Tasks.Task<global::MudBlazor.TableData<T>>> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::System.Action<global::MudBlazor.MudTable<T>> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "ServerData", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Hover", __arg2);
        __builder.AddAttribute(__seq3, "ToolBarContent", __arg3);
        __builder.AddAttribute(__seq4, "HeaderContent", __arg4);
        __builder.AddAttribute(__seq5, "RowTemplate", __arg5);
        __builder.AddAttribute(__seq6, "PagerContent", __arg6);
        __builder.AddComponentReferenceCapture(__seq7, (__value) => { __arg7((global::MudBlazor.MudTable<T>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
