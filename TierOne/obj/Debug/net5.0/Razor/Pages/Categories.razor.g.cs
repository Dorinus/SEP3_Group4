#pragma checksum "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aec2fb220dca9b0556cb3083f80106a2cc0c8b6a"
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
#line 2 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
using TierOne.Data.Migrations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Categories")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Categories</h3>\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<label>Add category: </label>\r\n        ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "placeholder", "Category name");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
                                                                    Category.CategoryName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Category.CategoryName = __value, Category.CategoryName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
                            () => AddCategory()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "<i class=\"oi oi-cloud-upload\" style=\"color:violet\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
 if (CategoriesList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p><em>Loading...</em></p>");
#nullable restore
#line 23 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
}
else if (!CategoriesList.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<p><em>There are no categories currently</em></p>");
#nullable restore
#line 29 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table");
            __builder.AddMarkupContent(17, "<thead><tr><th>Category Name</th>\r\n            <th>Delete</th></tr></thead>\r\n        ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 41 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
         foreach (var item in  CategoriesList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 44 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
                     item.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
                                        () => RemoveCategory(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Professional\RiderProjects\SEP3_Group4\TierOne\Pages\Categories.razor"
       
    private IList<Category> CategoriesList;
    private Category Category = new Category();

    protected override async Task OnInitializedAsync()
    {
        CategoriesList = await CategoryManager.GetCategories();
    }

    private async void RemoveCategory(Category Category)
    {
        bool response = await CategoryManager.DeleteCategory(Category);
        if (response)
        {
            CategoriesList.Remove(Category);
        }
    }

    private async void AddCategory()
    {
        bool tempBool = new bool();
        if (!String.IsNullOrEmpty(Category.CategoryName))
        {
            bool response = await CategoryManager.CreateCategory(Category);
            if (response)
            {
                CategoriesList.Add(Category);
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryManager CategoryManager { get; set; }
    }
}
#pragma warning restore 1591
