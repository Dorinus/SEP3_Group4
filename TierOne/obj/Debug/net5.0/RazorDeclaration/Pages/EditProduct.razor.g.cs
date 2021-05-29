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
#line 1 "D:\SEP3Proj\SEP3_Group4\TierOne\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3Proj\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3Proj\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3Proj\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3Proj\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3Proj\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEP3Proj\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEP3Proj\SEP3_Group4\TierOne\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEP3Proj\SEP3_Group4\TierOne\_Imports.razor"
using TierOne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SEP3Proj\SEP3_Group4\TierOne\_Imports.razor"
using TierOne.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3Proj\SEP3_Group4\TierOne\Pages\EditProduct.razor"
using TierOne.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3Proj\SEP3_Group4\TierOne\Pages\EditProduct.razor"
using TierOne.Data.Migrations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditProduct/{Id:int}")]
    public partial class EditProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "D:\SEP3Proj\SEP3_Group4\TierOne\Pages\EditProduct.razor"
       
   
    [Parameter]
    public int Id { get; set; }
    private Product OldProduct = new Product();
    private Product EditedProduct = new Product();
    private DateTime Date = DateTime.Now;
    private DateTime Hour = DateTime.Now;
    private IList<Category> CategoriesList;
    private IList<Category> SelectedCategoriesList = new List<Category>();
    private String Tags = "";

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Retrieving product with id " + Id);
        OldProduct = await ProductManager.GetProduct(Id);
    }

    public async void EditTheProduct()
    {
        bool response = await ProductManager.EditProduct(EditedProduct);
        if (response)
        {
            NavigationManager.NavigateTo("/Bid/" + EditedProduct.Id);
        }
    }

    private  void SelectedCategories(ChangeEventArgs changeEventArgs, Category item)
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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryManager CategoryManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductManager ProductManager { get; set; }
    }
}
#pragma warning restore 1591
