#pragma checksum "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "086f6293641dd5493775f4412a711a4842f7bc60"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(2);
                __builder2.AddAttribute(3, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\Index.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\Index.razor"
                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\Index.razor"
                                4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Server.Components.SearchToolbar>(7);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudGrid>(9);
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(13);
                    __builder3.AddAttribute(14, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\Index.razor"
                           spacing

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Justify", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Justify>(
#nullable restore
#line 13 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\Index.razor"
                                             Justify.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(17);
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Server.Components.ImageCard>(19);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(20, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(21);
                        __builder4.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Server.Components.ImageCard>(23);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(25);
                        __builder4.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Server.Components.ImageCard>(27);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(28, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(29);
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Server.Components.ImageCard>(31);
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
#nullable restore
#line 30 "C:\Dev\tutorials\E-Commerce\Server\Pages\SearchProducts\Index.razor"
       
    public int spacing { get; set; } = 1;

    void AddSpacing()
    {
        if (spacing >= 10)
        {
            spacing = 0;
        }
        else
        {
            spacing += 1;
        }
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISearchProduct searchProduct { get; set; }
    }
}
#pragma warning restore 1591
