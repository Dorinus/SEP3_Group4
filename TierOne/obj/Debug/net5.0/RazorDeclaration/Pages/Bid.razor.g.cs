// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Bid.razor"
using TierOne.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Bid.razor"
using TierOne.Data.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Bid/{Id:int}")]
    public partial class Bid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Bid.razor"
       

    [Parameter]
    public int Id { get; set; }
    public int Price { get; set; }
    public String UserWinning { get; set; }

    private Product Product = new Product();

    protected override async Task OnInitializedAsync()
    {
        Price = 0;
        Console.WriteLine("Retrieving product with id " + Id);
        Product = await ProductManager.GetProduct(Id);
        
        
        // UserWinning = await BidManager.GetBidWinner(Id);
        // if (UserWinning == null)
        // {
        //     UserWinning = "None";
        // }
        
    }

    
    // Sends new price for the product, if the repsonse is true, the bid was accepted
    public async void BidButtonCliked()
    {
        if (Price > Product.Price)
        {
            int userId = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetUserId();
            var response = await BidManager.Bid(Product.Id, userId, Price);
            if (response)
            {
                //The price is not assigned to the product as the time may change
                Product = await ProductManager.GetProduct(Id);
            }
            
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBidManager BidManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductManager ProductManager { get; set; }
    }
}
#pragma warning restore 1591
