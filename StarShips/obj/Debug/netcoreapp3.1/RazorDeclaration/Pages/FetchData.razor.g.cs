#pragma checksum "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02756402d56854b3107ad73c880257b14bfc1cba"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StarShips.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\_Imports.razor"
using StarShips;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\_Imports.razor"
using StarShips.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\Pages\FetchData.razor"
using StarShips.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\apynch\Documents\GitHub\blazor-learning\StarShips\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
