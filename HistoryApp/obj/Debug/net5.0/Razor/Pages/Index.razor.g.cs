#pragma checksum "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9285eb6ac0ae5f2395d34b34dc7e73aa9cff9a1d"
// <auto-generated/>
#pragma warning disable 1591
namespace HistoryApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\_Imports.razor"
using HistoryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\_Imports.razor"
using HistoryApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, " My Name is ");
            __builder.AddContent(2, 
#nullable restore
#line 2 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\Pages\Index.razor"
                 MyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.AddMarkupContent(4, "<p> The name of my theme is HistoryApp</p>\r\n");
            __builder.AddContent(5, 
#nullable restore
#line 4 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\Pages\Index.razor"
 DateTime.Now

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\HistoryApp\Pages\Index.razor"
      
string MyName="Ghanbode Ebierede";
private int currentCount = 0;

private void IncrementCount()
{
    currentCount += 2;

    if (currentCount > 15)
 {
   currentCount = 0;
 }

}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
