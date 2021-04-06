#pragma checksum "/home/jpandeinge/Dev/C#/E-Commerce/Server/Pages/DynamicContent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e8529e6c7ded894bcf9ba1efcfc05afc01a82f5"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using eShop.UseCases.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/jpandeinge/Dev/C#/E-Commerce/Server/_Imports.razor"
using eShop.UseCases.PluginInterfaces.DataStore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dynamic")]
    public partial class DynamicContent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"center\">Dynamic Content</h3>\n\n<br>\n<br>\n\n");
            __builder.OpenComponent<MudBlazor.MudButton>(1);
            __builder.AddAttribute(2, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/home/jpandeinge/Dev/C#/E-Commerce/Server/Pages/DynamicContent.razor"
                    OnClickWeb

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "/home/jpandeinge/Dev/C#/E-Commerce/Server/Pages/DynamicContent.razor"
                                       Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 9 "/home/jpandeinge/Dev/C#/E-Commerce/Server/Pages/DynamicContent.razor"
                                                               Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(6, "WAS");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n");
            __builder.OpenComponent<MudBlazor.MudButton>(8);
            __builder.AddAttribute(9, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/home/jpandeinge/Dev/C#/E-Commerce/Server/Pages/DynamicContent.razor"
                    OnClickServer

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "/home/jpandeinge/Dev/C#/E-Commerce/Server/Pages/DynamicContent.razor"
                                          Color.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 10 "/home/jpandeinge/Dev/C#/E-Commerce/Server/Pages/DynamicContent.razor"
                                                                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(13, "Server");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\n\n<br>\n<br>\n\n");
            __builder.OpenElement(15, "h3");
            __builder.AddContent(16, 
#nullable restore
#line 15 "/home/jpandeinge/Dev/C#/E-Commerce/Server/Pages/DynamicContent.razor"
     Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n\n<br>\n");
            __builder.OpenElement(18, "div");
            __builder.AddContent(19, 
#nullable restore
#line 18 "/home/jpandeinge/Dev/C#/E-Commerce/Server/Pages/DynamicContent.razor"
      Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/home/jpandeinge/Dev/C#/E-Commerce/Server/Pages/DynamicContent.razor"
       

    private string Title { get; set; }
    private string Content { get; set; }

    private void OnClickWeb()
    {
        Title = "Web Assembly";
        Content = "Web Assembly Content";
    }

    private void OnClickServer()
    {
        Title = "Web Server";
        Content = "Web Server Content";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
