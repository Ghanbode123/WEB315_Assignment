// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GhanbodeEbieredeFinalProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using GhanbodeEbieredeFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using GhanbodeEbieredeFinalProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\FetchData.razor"
using GhanbodeEbieredeFinalProject.Data;

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
#line 39 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\FetchData.razor"
       
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
