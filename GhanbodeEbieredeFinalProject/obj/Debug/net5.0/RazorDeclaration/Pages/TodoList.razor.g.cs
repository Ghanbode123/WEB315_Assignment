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
    public partial class TodoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 1 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\TodoList.razor"
       
   private class TaskItem
{
    public string Description { get; set; }
    public bool IsComplete { get; set; }
    public DateTime DueDate { get; set; }
}

    private List<TaskItem> tasks = new List<TaskItem>();
    private string newTaskDescription;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\TodoList.razor"
       
    // ... previous code ...

    private DateTime newTaskDueDate = DateTime.Today;

    private void AddTask()
    {
        if (!string.IsNullOrWhiteSpace(newTaskDescription))
        {
            tasks.Add(new TaskItem
            {
                Description = newTaskDescription,
                IsComplete = false,
                DueDate = newTaskDueDate
            });
            newTaskDescription = string.Empty;
            newTaskDueDate = DateTime.Today;
        }
    }

    private void DeleteTask(TaskItem taskToDelete)
    {
        tasks.Remove(taskToDelete);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
