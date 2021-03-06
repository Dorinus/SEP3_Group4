#pragma checksum "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c56d3298f7dadd55e953da4541268ee5fc4283fa"
// <auto-generated/>
#pragma warning disable 1591
namespace TierOne.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\_Imports.razor"
using TierOne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\_Imports.razor"
using TierOne.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
using TierOne.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllUsers")]
    public partial class AllUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "All Users. Page: ");
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                      PageNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
}
else if (!users.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>No Users exist in the system. Or something went wrong</em></p>");
#nullable restore
#line 21 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.OpenElement(7, "thead");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "<th>User ID</th> ");
            __builder.AddMarkupContent(10, "<th>UserName</th> ");
            __builder.AddMarkupContent(11, "<th>Email</th> ");
            __builder.AddMarkupContent(12, "<th>FirstName</th>\r\n            ");
            __builder.AddMarkupContent(13, "<th>LastName</th> ");
            __builder.AddMarkupContent(14, "<th>Address</th> ");
            __builder.AddMarkupContent(15, "<th>PostalIndex</th> ");
            __builder.AddMarkupContent(16, "<th>Dob</th>\r\n            ");
            __builder.AddMarkupContent(17, "<th>Type</th>\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(18);
            __builder.AddAttribute(19, "Policy", "OnlyAdmin");
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "<th>Change Type</th>\r\n                ");
                __builder2.AddMarkupContent(22, "<th>Delete</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "tbody");
#nullable restore
#line 39 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
         foreach (var item in  users)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "tr");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 42 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(28, " ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 42 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                                       item.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(31, " ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 42 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                                                               item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(34, " ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 42 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                                                                                    item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 43 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(40, " ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 43 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                                             item.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(43, " ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 43 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                                                                    item.PostalIndex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(46, " ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 43 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                                                                                               item.Dob

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 44 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                     item.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(53);
            __builder.AddAttribute(54, "Policy", "OnlyAdmin");
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(56, "td");
                __builder2.OpenElement(57, "button");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                                            () => ChangeUserType(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(59, "<i class=\"oi oi-person\" style=\"color:blue\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                    ");
                __builder2.OpenElement(61, "td");
                __builder2.OpenElement(62, "button");
                __builder2.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                                            () => RemoveUser(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(64, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                        () => backPage()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "<i class=\"oi oi-chevron-left\" style=\"color:blue\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
                        () => nextPage()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(71, "<i class=\"oi oi-chevron-right\" style=\"color:blue\"></i>");
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\AllUsers.razor"
       

    [Parameter]
    public int PageNumber { get; set; } =  1;

    private IList<User> users;

    protected override async Task OnInitializedAsync()
    {
        users = await UserManager.GetUsers(PageNumber);
    }

    private async void RemoveUser(int userId)
    {
        bool response = await UserManager.RemoveUser(userId);

        if (response)
        {
            User user = users.First(t => t.Id == userId);
            users.Remove(user);
        }
        else
        {
    //TO DO write an error message
        }
    }

    private async void ChangeUserType(int userId)
    {
        String response = await UserManager.ChangeUserType(userId);

        User user = users.First(t => t.Id == userId);
        if (user.Type.Equals("user"))
        {
            response = "manager";
        }
        else
        {
            response = "user";
        }
        users.First(t => t.Id == userId).Type = response;
    }


    // go back
    private async void backPage()
    {
        // makes sure page doesnt go lower then 1
        if (PageNumber > 1)
        {
            bool PageExist = await UserManager.PageExist(PageNumber);
            if (PageExist)
            {
                PageNumber--;
                users = await UserManager.GetUsers(PageNumber);
                
                // should change url
                jsRuntime.InvokeVoidAsync("ChangeUrl", PageNumber.ToString());
            }
        }
    }

    // go next page
    private async void nextPage()
    {
        // checks for existance of page
        bool PageExist = await UserManager.PageExist(PageNumber);
        
        // if it exist loads next page
        if (PageExist)
        {
            PageNumber++;
            users = await UserManager.GetUsers(PageNumber);
        } 
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager UserManager { get; set; }
    }
}
#pragma warning restore 1591
