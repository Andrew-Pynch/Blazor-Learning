#pragma checksum "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b16a95c12a04bd5e22f9d6b0cea77581d006d0b3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Service_Learning.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\_Imports.razor"
using Service_Learning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\_Imports.razor"
using Service_Learning.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\apynch\Documents\GitHub\blazor-learning\Model Services\Service_Learning\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
