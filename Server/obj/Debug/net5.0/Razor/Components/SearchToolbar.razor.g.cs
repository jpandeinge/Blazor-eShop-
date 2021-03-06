#pragma checksum "C:\Dev\tutorials\E-Commerce\Server\Components\SearchToolbar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2001d6eccea702d04d6822576794d34a83da5f6"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Components
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
    public partial class SearchToolbar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudToolBar>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTextField<string>>(2);
                __builder2.AddAttribute(3, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, 
#nullable restore
#line 4 "C:\Dev\tutorials\E-Commerce\Server\Components\SearchToolbar.razor"
                                  s => OnSearch(s)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(4, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 5 "C:\Dev\tutorials\E-Commerce\Server\Components\SearchToolbar.razor"
                           Variant.Outlined

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Placeholder", "Search...");
                __builder2.AddAttribute(6, "Adornment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Adornment>(
#nullable restore
#line 7 "C:\Dev\tutorials\E-Commerce\Server\Components\SearchToolbar.razor"
                             Adornment.End

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "AdornmentIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Dev\tutorials\E-Commerce\Server\Components\SearchToolbar.razor"
                                  Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 9 "C:\Dev\tutorials\E-Commerce\Server\Components\SearchToolbar.razor"
                            Size.Medium

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Class", "mt-0");
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
