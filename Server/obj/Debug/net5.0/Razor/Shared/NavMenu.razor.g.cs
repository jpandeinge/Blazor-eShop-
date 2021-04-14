#pragma checksum "C:\Dev\tutorials\E-Commerce\Server\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "259d39c15efad377d7eaf09d7ef017bbdbdd1dbd"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "Class", "mud-width-full");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavGroup>(3);
                __builder2.AddAttribute(4, "Title", "Shopping");
                __builder2.AddAttribute(5, "Icon", "fas fa-shopping-cart");
                __builder2.AddAttribute(6, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "C:\Dev\tutorials\E-Commerce\Server\Shared\NavMenu.razor"
                                                                        false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(8);
                    __builder3.AddAttribute(9, "Href", "/tshirts");
                    __builder3.AddAttribute(10, "Icon", "fas fa-tshirt");
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(12, "T-shirts");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(14);
                    __builder3.AddAttribute(15, "Href", "/shoes");
                    __builder3.AddAttribute(16, "Icon", "fas fa-shoe-prints");
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(18, "Shoes");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n\n   \n    ");
                __builder2.OpenComponent<MudBlazor.MudNavGroup>(20);
                __builder2.AddAttribute(21, "Title", "Stores");
                __builder2.AddAttribute(22, "Icon", "fas fa-store");
                __builder2.AddAttribute(23, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Dev\tutorials\E-Commerce\Server\Shared\NavMenu.razor"
                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(25);
                    __builder3.AddAttribute(26, "Href", "/clothing");
                    __builder3.AddAttribute(27, "Icon", "fas fa-tshirt");
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(29, "Clothing");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(31);
                    __builder3.AddAttribute(32, "Href", "/jewellery");
                    __builder3.AddAttribute(33, "Icon", "fas fa-gem");
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(35, "Jewellery");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(37);
                    __builder3.AddAttribute(38, "Href", "/restaurants");
                    __builder3.AddAttribute(39, "Icon", "fas fa-utensils");
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(41, "Restaurants");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(43);
                    __builder3.AddAttribute(44, "Href", "/fast-food");
                    __builder3.AddAttribute(45, "Icon", "fas fa-hamburger");
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(47, "Fast Food");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(49);
                __builder2.AddAttribute(50, "Href", "/billing");
                __builder2.AddAttribute(51, "Icon", "fas fa-file-invoice");
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, "Transactions");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavGroup>(55);
                __builder2.AddAttribute(56, "Title", "Settings");
                __builder2.AddAttribute(57, "Icon", "fas fa-cog");
                __builder2.AddAttribute(58, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Dev\tutorials\E-Commerce\Server\Shared\NavMenu.razor"
                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(60);
                    __builder3.AddAttribute(61, "Href", "/users");
                    __builder3.AddAttribute(62, "Icon", "fas fa-user-friends");
                    __builder3.AddAttribute(63, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "C:\Dev\tutorials\E-Commerce\Server\Shared\NavMenu.razor"
                                                                        Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(65, "Users");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(67);
                    __builder3.AddAttribute(68, "Href", "/security");
                    __builder3.AddAttribute(69, "Icon", "fas fa-shield-alt");
                    __builder3.AddAttribute(70, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 18 "C:\Dev\tutorials\E-Commerce\Server\Shared\NavMenu.razor"
                                                                         Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(72, "Security");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISearchProduct searchProduct { get; set; }
    }
}
#pragma warning restore 1591
