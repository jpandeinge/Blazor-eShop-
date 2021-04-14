#pragma checksum "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88825a8a41a122c08248963ba0d982f47fbfd60d"
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
#nullable restore
#line 1 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
using Server.Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 4 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                         _currentTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(3);
            __builder.AddAttribute(4, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 5 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth?>(
#nullable restore
#line 5 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                              MaxWidth.ExtraSmall

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenComponent<MudBlazor.MudSwipeArea>(9);
            __builder.AddAttribute(10, "OnSwipe", new System.Action<MudBlazor.SwipeDirection>(
#nullable restore
#line 8 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                        OnSwipe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudLayout>(12);
                __builder2.AddAttribute(13, "RightToLeft", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                             _rightToLeft

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudAppBar>(15);
                    __builder3.AddAttribute(16, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                              25

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(18);
                        __builder4.AddAttribute(19, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                  Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                     Color.Inherit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 11 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                                          Edge.Start

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                                                                 (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudText>(24);
                        __builder4.AddAttribute(25, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 12 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "Class", "mudblazor-appbar-brand-text d-none d-md-flex");
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(28, "Shop");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(29, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudAppBarSpacer>(30);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(31, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudAutocomplete<AppLinkServiceEntry>>(32);
                        __builder4.AddAttribute(33, "Placeholder", "Search");
                        __builder4.AddAttribute(34, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 14 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(35, "Class", "docs-search-bar");
                        __builder4.AddAttribute(36, "ItemTemplate", (Microsoft.AspNetCore.Components.RenderFragment<AppLinkServiceEntry>)((result) => (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(37);
                            __builder5.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(39, 
#nullable restore
#line 16 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                              result.Title

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddContent(40, " ");
                            __builder5.OpenComponent<MudBlazor.MudText>(41);
                            __builder5.AddAttribute(42, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 16 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                    Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(44, 
#nullable restore
#line 16 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                                 result.SubTitle

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudAppBarSpacer>(46);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(47, "\n\n            ");
                        __builder4.OpenElement(48, "div");
                        __builder4.AddAttribute(49, "class", "px-2");
                        __builder4.AddAttribute(50, "b-kkt30o18ti");
                        __builder4.OpenComponent<MudBlazor.MudTooltip>(51);
                        __builder4.AddAttribute(52, "Text", "Toggle light/dark theme");
                        __builder4.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(54);
                            __builder5.AddAttribute(55, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                          Icons.Material.Filled.Brightness4

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(56, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                                    Color.Inherit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(57, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                                                              (e) => DarkMode()

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(58, "\n                ");
                        __builder4.OpenComponent<MudBlazor.MudTooltip>(59);
                        __builder4.AddAttribute(60, "Text", "GitHub");
                        __builder4.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(62);
                            __builder5.AddAttribute(63, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                          Icons.Custom.Brands.GitHub

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(64, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 26 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                             Color.Inherit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(65, "Link", "https://github.com/jpandeinge");
                            __builder5.AddAttribute(66, "Target", "_blank");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudDrawer>(68);
                    __builder3.AddAttribute(69, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                     25

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "Class", "mudblazor-appbar-band");
                    __builder3.AddAttribute(71, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                              _drawerOpen

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                    __builder3.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudDrawerHeader>(74);
                        __builder4.AddAttribute(75, "Class", "mudblazor-brand");
                        __builder4.AddAttribute(76, "LinkToIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(78, "MudBlazorLogo");
                            __builder5.AddAttribute(79, "b-kkt30o18ti");
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(80, "\n            ");
                        __builder4.OpenComponent<Server.Shared.NavMenu>(81);
                        __builder4.AddComponentReferenceCapture(82, (__value) => {
#nullable restore
#line 34 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                            _navMenuRef = (Server.Shared.NavMenu)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n\n        ");
                    __builder3.OpenComponent<MudBlazor.MudMainContent>(84);
                    __builder3.AddAttribute(85, "Class", "mudblazor-main-content");
                    __builder3.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(87, 
#nullable restore
#line 38 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(88, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudScrollToTop>(89);
                        __builder4.AddAttribute(90, "TopOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                       400

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudFab>(92);
                            __builder5.AddAttribute(93, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                               Icons.Material.Filled.KeyboardArrowUp

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(94, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 40 "C:\Dev\tutorials\E-Commerce\Server\Shared\MainLayout.razor"
                                                                             Color.Primary

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
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISearchProduct searchProduct { get; set; }
    }
}
#pragma warning restore 1591
