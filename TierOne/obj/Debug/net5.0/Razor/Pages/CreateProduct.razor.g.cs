#pragma checksum "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fbd8892d8af47d5ba2596530ed2ee511df211c0"
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
            __builder.AddMarkupContent(0, "<h3>Create new product</h3>\r\n<hr>");
#nullable restore
#line 12 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
 if (CategoriesList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 17 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
}
else if (!CategoriesList.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>No Users exist in the system. Or something went wrong</em></p>");
#nullable restore
#line 23 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 27 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                      NewProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 27 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                                                  CreateNewProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddContent(8, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, " Name:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                                                                    NewProduct.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewProduct.Name = __value, NewProduct.Name))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewProduct.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, " End Date:<br> ");
                __Blazor.TierOne.Pages.CreateProduct.TypeInference.CreateInputDate_0(__builder2, 22, 23, "4", 24, 
#nullable restore
#line 32 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                                                                                 Date

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Date = __value, Date)), 26, () => Date);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, " End Time:<br> ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "type", "time");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                                                                          Hour

#line default
#line hidden
#nullable disable
                , format: "HH:mm", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Hour = __value, Hour, format: "HH:mm", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, " Price:<br> ");
                __Blazor.TierOne.Pages.CreateProduct.TypeInference.CreateInputNumber_1(__builder2, 39, 40, "4", 41, 
#nullable restore
#line 36 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                                                                                NewProduct.Price

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewProduct.Price = __value, NewProduct.Price)), 43, () => NewProduct.Price);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, " Image URL:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                                                                         NewProduct.PhotoUrl

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewProduct.PhotoUrl = __value, NewProduct.PhotoUrl))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewProduct.PhotoUrl));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, " Description:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(56);
                __builder2.AddAttribute(57, "rows", "4");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                                                                                        NewProduct.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewProduct.Description = __value, NewProduct.Description))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewProduct.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, " Tags:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(65);
                __builder2.AddAttribute(66, "text", "Separate by comma");
                __builder2.AddAttribute(67, "rows", "5");
                __builder2.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                                                                                                          Tags

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Tags = __value, Tags))));
                __builder2.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Tags));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 43 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
         foreach (var item in CategoriesList)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(71, "input");
                __builder2.AddAttribute(72, "type", "checkbox");
                __builder2.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                                                (arg) => SelectedCategories(arg, item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddContent(74, 
#nullable restore
#line 46 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
             item.CategoryName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "<br>");
#nullable restore
#line 48 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
         foreach (var cat in SelectedCategoriesList)
        {
            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(76, 
#nullable restore
#line 52 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
             cat.CategoryName

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 52 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                             
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(77, "p");
                __builder2.AddAttribute(78, "class", "actions");
                __builder2.OpenElement(79, "button");
                __builder2.AddAttribute(80, "class", "btn btn-outline-dark");
                __builder2.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
                                                           CreateNewProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "type", "submit");
                __builder2.AddContent(83, "Create new product");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 62 "C:\Users\tolde\RiderProjects\DNPAssignments\SEP3_Group4\TierOne\Pages\CreateProduct.razor"
}

#line default
#line hidden
#nullable disable
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
        
        bool response = await ProductManager.CreateProduct(NewProduct);
        if (response)
        {
            NavigationManager.NavigateTo("/");
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
        NewProduct.Tags = Tags.Split(',').Select(tag => tag.Trim()).ToList();
        NewProduct.Tags = NewProduct.Tags.Where(x => !string.IsNullOrEmpty(x)).ToArray();

        foreach (var tag in NewProduct.Tags)
        {
            Console.WriteLine(tag);
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
namespace __Blazor.TierOne.Pages.CreateProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
