#pragma checksum "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e31c33b127c888498daa3ad2d14f6540ca27f6f9"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListProductsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                                        CategoryChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value", true);
            __builder.AddContent(7, "Seleccione categoria...");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 8 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
     foreach(var category in categories)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 10 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                        category.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                                              category.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 11 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n<hr>\r\n\r\n\r\n");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-hover table-bordered");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.AddMarkupContent(18, "<thead>\r\n        <tr>\r\n            <th>Referencia</th>\r\n            <th>Nombre producto</th>\r\n            <th>Categoría</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(19, "tbody");
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 25 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
         foreach(var product in tempProducts)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 28 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                 product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 29 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                 product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 30 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                 product.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 32 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "   \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.AddContent(37, 
#nullable restore
#line 35 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
 message

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
       
    String message;

    List<ProductEntity> products = new List<ProductEntity>();
    List<ProductEntity> tempProducts = new List<ProductEntity>();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        products = B_Product.ProductList();
        tempProducts = products;
        categories = B_Category.CategoryList();
    }
    private void CategoryChanged(ChangeEventArgs e)
    {
        // message = e.Value.ToString();
        tempProducts = products.Where(c => c.CategoryId == e.Value.ToString())
                        .ToList();

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591