#pragma checksum "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61aff6c5bcfb640c51da083d7d54e0f8db5de273"
// <auto-generated/>
#pragma warning disable 1591
namespace AdultsClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\_Imports.razor"
using AdultsClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\_Imports.razor"
using AdultsClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
using AdultsClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
using AdultsClient.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n    ");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "Filter by Id: \r\n        ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                                         (arg)=>FilterByAdultId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "\r\n        Filter by hair color:\r\n        ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control selectpicker");
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                                                               (arg) => FilterByHairColor(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "width: 100px");
            __builder.OpenElement(14, "option");
            __builder.AddContent(15, "Blond");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "option");
            __builder.AddContent(18, "Black");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "option");
            __builder.AddContent(21, "Leverpostej");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "option");
            __builder.AddContent(24, "White");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "option");
            __builder.AddContent(27, "Brown");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<p><em>Loading..</em></p>");
#nullable restore
#line 25 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<p><em>There are no adults in this list. Please add some.</em></p>");
#nullable restore
#line 31 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "table");
            __builder.AddAttribute(31, "class", "table");
            __builder.AddMarkupContent(32, @"<thead><tr><th>Id</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Age</th>
            <th>Sex</th>
            <th>Height</th>
            <th>Weight</th>
            <th>Eye Color</th>
            <th>Hair Color</th>
            <th>Job</th>
            <th>Salary</th>
            <th>Remove</th></tr></thead>
        ");
            __builder.OpenElement(33, "tbody");
#nullable restore
#line 52 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
         foreach (Adult item in adultsToShow) 
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "tr");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 55 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 56 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 57 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 58 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 59 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 60 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 61 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 62 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 63 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 64 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.Job.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 65 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                     item.Job.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.OpenElement(68, "td");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
                                        () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(71, "<i class=\"oi oi-trash\" style=\"color: red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\DNP1\DNP1\AdultsClient\Pages\Adults.razor"
       
    private IList<Adult> adults;
    private IList<Adult> adultsToShow;

    private int? filterById;
    private string? filterByHairColor;

    private void FilterByAdultId(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        ExecuteFilter();
    }

    private void FilterByHairColor(ChangeEventArgs args)
    {
        filterByHairColor = null;
        try
        {
            filterByHairColor = args.Value.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        adultsToShow = adults.Where(t =>
            (filterById != null && t.Id == filterById || filterById == null) &&
            (filterByHairColor != null && t.HairColor == filterByHairColor || filterByHairColor == null)).ToList();
    }
    protected override async Task OnInitializedAsync()
    {
        adults = await AdultData.GetAdultsAsync();
        adultsToShow = adults;
        foreach (Adult adult in adults)
        {
            Console.WriteLine(adult.FirstName);
        }
    }
    
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        adults = await AdultData.GetAdultsAsync();
     
    }

    private async Task RemoveAdult(int AdultId)
    {
        Adult adultToRemove = adultsToShow.First(t => t.Id == AdultId);
        try
        {
            await AdultData.RemoveAdultAsync(AdultId);
            adults.Remove(adultToRemove);
            adultsToShow.Remove(adultToRemove);
            //Console.WriteLine(adultsToShow[adultsToShow.Count-1].FirstName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultData { get; set; }
    }
}
#pragma warning restore 1591
