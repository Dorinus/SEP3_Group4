#pragma checksum "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8233e252ed8e3db4e3a61ccb46d0adff175cb7d6"
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
#nullable restore
#line 2 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
using TierOne.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Bid/{Id:int}")]
    public partial class Bid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 6 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
     Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
 if (Product == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group");
            __builder.AddMarkupContent(5, " Id:<br> ");
            __builder.AddContent(6, 
#nullable restore
#line 16 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
                                       Product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, " Name:<br> ");
            __builder.AddContent(11, 
#nullable restore
#line 17 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
                                         Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, " Date:<br> ");
            __builder.AddContent(16, 
#nullable restore
#line 18 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
                                         Product.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group");
            __builder.AddMarkupContent(20, " Description:<br> ");
            __builder.AddContent(21, 
#nullable restore
#line 19 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
                                                Product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, " Name:<br> ");
            __builder.AddContent(26, 
#nullable restore
#line 20 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
                                         Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group");
            __builder.AddMarkupContent(29, " Categories:\r\n");
#nullable restore
#line 24 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
         foreach (var category in Product.Categories)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, 
#nullable restore
#line 26 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
             category

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, ", ");
#nullable restore
#line 26 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
                                     

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, " Tags:\r\n");
#nullable restore
#line 32 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
         foreach (var tag in Product.Tags)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, 
#nullable restore
#line 34 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
             tag

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, ", ");
#nullable restore
#line 34 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
                                
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(37, "img");
            __builder.AddAttribute(38, "src", 
#nullable restore
#line 39 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
               Product.PhotoUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "asp-append-version", "true");
            __builder.AddAttribute(40, "width", "300px");
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\Bid.razor"
       

    [Parameter]
    public int Id { get; set; }
    
    private Product Product = new Product();

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Retrieving product with id " + Id);
        Product = await ProductManager.GetProduct(Id);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductManager ProductManager { get; set; }
    }
}
#pragma warning restore 1591
