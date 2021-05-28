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
#line 2 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
using TierOne.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
using TierOne.Data.Migrations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NewProduct")]
    public partial class CreateProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
       
    private Product NewProduct = new Product();
    private DateTime Date = DateTime.Now;
    private DateTime Hour = DateTime.Now;
    private IList<Category> CategoriesList;
    private IList<Category> SelectedCategoriesList = new List<Category>();
    private String Tags = "";


    protected override async Task OnInitializedAsync()
    {
        CategoriesList = await CategoryManager.GetCategories();
        
    }


    private async void CreateNewProduct()
    {
        GetTags();
        
        int response = await ProductManager.CreateProduct(NewProduct);
        if (response>-1)
        {
            Console.WriteLine(response);
            NavigationManager.NavigateTo("/Bid/" + response);
        }
        else
        {
            Console.WriteLine(response);
            Console.WriteLine("Creation of product was wrong");
        }
    }

    

    // Gets selected categoories
    private void SelectedCategories(ChangeEventArgs changeEventArgs, Category item)
    {
        if (SelectedCategoriesList.Contains(item))
        {
            SelectedCategoriesList.Remove(item);
        }
        else
        {
            SelectedCategoriesList.Add(item);
        }
    }
    
    
    // Gets and formats tags
    private void GetTags()
    {

        // IList<String> tempTags = Tags.Split(',').Select(tag => tag.Trim()).ToList();
        // tempTags = tempTags.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        //
        // foreach (var tag in tempTags)
        // {
        //     NewProduct.Tags.Add(new Tag(tag));
        // }
        //
        //
        // foreach (var tag in NewProduct.Tags)
        // {
        //     Console.WriteLine(tag.TagName);
        // }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryManager CategoryManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductManager ProductManager { get; set; }
    }
}
#pragma warning restore 1591
