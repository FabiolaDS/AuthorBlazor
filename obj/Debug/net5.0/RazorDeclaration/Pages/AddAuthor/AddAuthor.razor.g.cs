// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AuthorBlazor.Pages.AddAuthor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\_Imports.razor"
using AuthorBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\_Imports.razor"
using AuthorBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\AddAuthor\AddAuthor.razor"
using AuthorBlazor.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\AddAuthor\AddAuthor.razor"
using AuthorBlazor.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addAuthor")]
    public partial class AddAuthor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\AddAuthor\AddAuthor.razor"
       
    private Author _newAuthor = new Author();

    private async Task AddNewAuthorAsync()
    {
        await _authorService.SaveAuthorAsync(_newAuthor);
        NavigationManager.NavigateTo("/authors");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorService _authorService { get; set; }
    }
}
#pragma warning restore 1591