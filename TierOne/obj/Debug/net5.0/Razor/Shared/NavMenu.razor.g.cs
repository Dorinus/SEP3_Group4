#pragma checksum "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ce2a0279b8e9e518a2d6888d7e0eb6d316ddc37"
// <auto-generated/>
#pragma warning disable 1591
namespace TierOne.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\_Imports.razor"
using TierOne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\_Imports.razor"
using TierOne.Shared;

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
            __builder.AddAttribute(2, "b-adxd061aku");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-adxd061aku>TierOne</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-adxd061aku");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-adxd061aku></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-adxd061aku");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-adxd061aku");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-adxd061aku");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-adxd061aku></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(27);
            __builder.AddAttribute(28, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "li");
                __builder2.AddAttribute(30, "class", "nav-item px-3");
                __builder2.AddAttribute(31, "b-adxd061aku");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
                __builder2.AddAttribute(33, "class", "nav-link");
                __builder2.AddAttribute(34, "href", "Register");
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-adxd061aku></span> Register\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenElement(38, "li");
                __builder2.AddAttribute(39, "class", "nav-item px-3");
                __builder2.AddAttribute(40, "b-adxd061aku");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
                __builder2.AddAttribute(42, "class", "nav-link");
                __builder2.AddAttribute(43, "href", "Login");
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "<span class=\"oi oi-box\" aria-hidden=\"true\" b-adxd061aku></span> Login\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(47);
            __builder.AddAttribute(48, "Policy", "manager");
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(50, "li");
                __builder2.AddAttribute(51, "class", "nav-item px-3");
                __builder2.AddAttribute(52, "b-adxd061aku");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
                __builder2.AddAttribute(54, "class", "nav-link");
                __builder2.AddAttribute(55, "href", "AllUsers");
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(57, "<span class=\"oi oi-box\" aria-hidden=\"true\" b-adxd061aku></span> View All Users\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(59);
            __builder.AddAttribute(60, "Policy", "manager");
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(62, "li");
                __builder2.AddAttribute(63, "class", "nav-item px-3");
                __builder2.AddAttribute(64, "b-adxd061aku");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(65);
                __builder2.AddAttribute(66, "class", "nav-link");
                __builder2.AddAttribute(67, "href", "NewProduct");
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(69, "<span class=\"oi oi-box\" aria-hidden=\"true\" b-adxd061aku></span> New Product\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(71);
            __builder.AddAttribute(72, "Policy", "manager");
            __builder.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(74, "li");
                __builder2.AddAttribute(75, "class", "nav-item px-3");
                __builder2.AddAttribute(76, "b-adxd061aku");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(77);
                __builder2.AddAttribute(78, "class", "nav-link");
                __builder2.AddAttribute(79, "href", "Categories");
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(81, "<span class=\"oi oi-box\" aria-hidden=\"true\" b-adxd061aku></span> Categories\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(83);
            __builder.AddAttribute(84, "Policy", "user");
            __builder.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(86, "li");
                __builder2.AddAttribute(87, "class", "nav-item px-3");
                __builder2.AddAttribute(88, "b-adxd061aku");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(89);
                __builder2.AddAttribute(90, "class", "nav-link");
                __builder2.AddAttribute(91, "href", "AllProducts");
                __builder2.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(93, "<span class=\"oi oi-box\" aria-hidden=\"true\" b-adxd061aku></span> Products\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(94, "\r\n\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(95);
            __builder.AddAttribute(96, "Policy", "user");
            __builder.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(98, "li");
                __builder2.AddAttribute(99, "class", "nav-item px-3");
                __builder2.AddAttribute(100, "b-adxd061aku");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(101);
                __builder2.AddAttribute(102, "class", "nav-link");
                __builder2.AddAttribute(103, "href", "ViewBids");
                __builder2.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(105, "<span class=\"oi oi-box\" aria-hidden=\"true\" b-adxd061aku></span> Bids\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(107);
            __builder.AddAttribute(108, "Policy", "user");
            __builder.CloseComponent();
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(110);
            __builder.AddAttribute(111, "Policy", "manager");
            __builder.CloseComponent();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(113);
            __builder.AddAttribute(114, "Policy", "admin");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Shared\NavMenu.razor"
       
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
