#pragma checksum "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f636ea5c276df09e587dd6d783c5e1f2808974c3"
// <auto-generated/>
#pragma warning disable 1591
namespace GhanbodeEbieredeFinalProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using GhanbodeEbieredeFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\_Imports.razor"
using GhanbodeEbieredeFinalProject.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Number of Tasks: ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                      GetIncompleteTaskCount()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "placeholder", "Task title");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                       newTaskTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTaskTitle = __value, newTaskTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "placeholder", "Task description");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                             newTaskDescription

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTaskDescription = __value, newTaskDescription));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "date");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                          newTaskDueDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTaskDueDate = __value, newTaskDueDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                  AddTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Add Task");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n<br>\r\n");
            __builder.OpenElement(23, "ul");
#nullable restore
#line 10 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
     foreach (var task in tasks)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "li");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "checkbox");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                             (e) => UpdateTaskStatus(task)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                                                                   task.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.IsDone = __value, task.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "span");
            __builder.AddContent(32, 
#nullable restore
#line 14 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                   task.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(33, " - ");
            __builder.OpenElement(34, "span");
            __builder.AddContent(35, 
#nullable restore
#line 14 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                              task.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(36, " (");
            __builder.AddContent(37, 
#nullable restore
#line 14 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                                                        task.DueDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, ")\r\n            ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                              () => DeleteTask(task)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                              () => AddSubTask(task)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Add SubTask");
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
             if (task.SubTasks != null && task.SubTasks.Count > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "ul");
#nullable restore
#line 21 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                     foreach (var subTask in task.SubTasks)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "li");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "checkbox");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                                             (e) => UpdateSubTaskStatus(task, subTask)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                                                                                               subTask.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => subTask.IsDone = __value, subTask.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "span");
            __builder.AddContent(55, 
#nullable restore
#line 25 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                   subTask.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(56, " - ");
            __builder.OpenElement(57, "span");
            __builder.AddContent(58, 
#nullable restore
#line 25 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                                                 subTask.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(59, " (");
            __builder.AddContent(60, 
#nullable restore
#line 25 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                                                                              subTask.DueDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(61, ")\r\n                            ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                                              () => DeleteSubTask(task, subTask)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\W0835765\Documents\GitHub\WEB315_Assignment\GhanbodeEbieredeFinalProject\Pages\Todo.razor"
 
    private List<TaskItem> tasks = new();
    private string newTaskTitle;
    private string newTaskDescription;
    private DateTime newTaskDueDate;

    private void AddTask()
    {
        if (!string.IsNullOrWhiteSpace(newTaskTitle) && !string.IsNullOrWhiteSpace(newTaskDescription))
        {
            tasks.Add(new TaskItem { Title = newTaskTitle, Description = newTaskDescription, DueDate = newTaskDueDate });
            newTaskTitle = "";
            newTaskDescription = "";
            newTaskDueDate = DateTime.Today;
        }
    }

    private void AddSubTask(TaskItem parentTask)
    {
        if (!string.IsNullOrWhiteSpace(newTaskTitle) && !string.IsNullOrWhiteSpace(newTaskDescription))
        {
            if (parentTask.SubTasks == null)
                parentTask.SubTasks = new List<SubTaskItem>();

            parentTask.SubTasks.Add(new SubTaskItem { Title = newTaskTitle, Description = newTaskDescription, DueDate = newTaskDueDate });
            newTaskTitle = "";
            newTaskDescription = "";
            newTaskDueDate = DateTime.Today;
        }
    }

    private void UpdateTaskStatus(TaskItem task)
    {
        task.IsDone = !task.IsDone;
    }

    private void UpdateSubTaskStatus(TaskItem parentTask, SubTaskItem subTask)
    {
        subTask.IsDone = !subTask.IsDone;
        UpdateParentTaskStatus(parentTask);
    }

    private void UpdateParentTaskStatus(TaskItem task)
    {
        if (task.SubTasks != null && task.SubTasks.Count > 0)
        {
            task.IsDone = task.SubTasks.All(subTask => subTask.IsDone);
        }
    }

    private void DeleteTask(TaskItem task)
    {
        tasks.Remove(task);
    }

    private void DeleteSubTask(TaskItem parentTask, SubTaskItem subTask)
    {
        parentTask.SubTasks.Remove(subTask);
        UpdateParentTaskStatus(parentTask);
    }

    private int GetIncompleteTaskCount()
    {
        return tasks.Count(task => !task.IsDone);
    }

    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
        public List<SubTaskItem> SubTasks { get; set; }
    }

    public class SubTaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
