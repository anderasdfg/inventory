#pragma checksum "C:\Code\inventory\Inventory\Components\Categories\ListCategoriesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "340b5991c4cf80d530d39e3b1619af2544e90e06"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Code\inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Code\inventory\Inventory\_Imports.razor"
using Inventory.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Code\inventory\Inventory\Components\Categories\ListCategoriesComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\inventory\Inventory\Components\Categories\ListCategoriesComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListCategoriesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-hover table-bordered");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<thead>\r\n        <tr>\r\n            <th>ID</th>            \r\n            <th>Categoría</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 14 "C:\Code\inventory\Inventory\Components\Categories\ListCategoriesComponent.razor"
         foreach(var category in tempcategories)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 17 "C:\Code\inventory\Inventory\Components\Categories\ListCategoriesComponent.razor"
                 category.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 18 "C:\Code\inventory\Inventory\Components\Categories\ListCategoriesComponent.razor"
                 category.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "            \r\n            ");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", "category/update/" + (
#nullable restore
#line 19 "C:\Code\inventory\Inventory\Components\Categories\ListCategoriesComponent.razor"
                                          category.CategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Actualizar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 21 "C:\Code\inventory\Inventory\Components\Categories\ListCategoriesComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "   \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.AddContent(24, 
#nullable restore
#line 24 "C:\Code\inventory\Inventory\Components\Categories\ListCategoriesComponent.razor"
 message

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Code\inventory\Inventory\Components\Categories\ListCategoriesComponent.razor"
       
    String message;

    
    List<CategoryEntity> tempcategories = new List<CategoryEntity>();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        categories = B_Category.CategoryList();
        tempcategories = categories;
    }
    private void CategoryChanged(ChangeEventArgs e)
    {
        // message = e.Value.ToString();
        tempcategories = categories.Where(c => c.CategoryId == e.Value.ToString())
                        .ToList();

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
