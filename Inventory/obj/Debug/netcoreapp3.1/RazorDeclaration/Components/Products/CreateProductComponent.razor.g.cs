#pragma checksum "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc44fa889c38454400ea0f90ceef302a3c83b5b5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\acholado.LOLIMSA\source\repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
       
    ProductEntity objProduct = new ProductEntity();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        categories = B_Category.CategoryList();
    }

    private void SaveProduct()
    {
        B_Product.CreateProduct(objProduct);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
