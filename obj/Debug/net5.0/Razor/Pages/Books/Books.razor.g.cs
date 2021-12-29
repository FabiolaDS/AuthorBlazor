#pragma checksum "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc96fcead48adc44d4ee3e6e08f89d39575c61db"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthorBlazor.Pages.Books
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
#line 2 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
using AuthorBlazor.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
using AuthorBlazor.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books")]
    public partial class Books : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Books</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex justify-content-end");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "placeholder", "Search by book title");
            __builder.AddAttribute(5, "class", " mr 3");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                    UpdateBookFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "placeholder", "Search by author");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                   UpdateAuthorFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
 if (_authors == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p><em> Loading...</em></p>");
#nullable restore
#line 26 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.AddMarkupContent(16, "<thead><tr><th>Isbn </th>\r\n            <th> Title</th>\r\n            <th>Author </th>\r\n            <th>Publication </th>\r\n            <th>Nbre of pages </th>\r\n            <th>Genre </th></tr></thead>\r\n\r\n        ");
            __builder.OpenElement(17, "tbody");
#nullable restore
#line 42 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
         foreach (var author in _authors)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
             foreach (var book in author.Books)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                 if (Filter(author, book))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "tr");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 49 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                             book.ISBN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 50 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                             book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 51 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                             author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " ");
            __builder.AddContent(28, 
#nullable restore
#line 51 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                                               author.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 52 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                             book.PublicationYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 53 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                             book.NumOfPages

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 54 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                             book.Genre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn-danger ");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                                                                    d => DeleteBookAsync(book.ISBN)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "\r\n                                Delete\r\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Privat\Desktop\DNP1\PraticeExam285055\AuthorBlazor\Pages\Books\Books.razor"
       
    private List<Author> _authors;
    private string _filterByAuthor="";
    private string _filterByBookTitle="";
    


    protected override async Task OnInitializedAsync()
    {
        _authors = await _authorService.GetAuthorsAsync();
        StateHasChanged();
        
    }

    private bool Filter(Author author, Book book)
    {
        
        if (_filterByAuthor.Equals("") || ($"{author.FirstName} {author.LastName}".Contains(_filterByAuthor)))
        {
            if (_filterByBookTitle.Equals(""))
            {
                return true;
            }
            if (book.Title.Contains(_filterByBookTitle))
            {
                return true;
            }
            return false;
        }
        else
        {
            return false;
        }
            
            
    }
    
    private void UpdateAuthorFilter(ChangeEventArgs e)
    {
        _filterByAuthor = e.Value.ToString();
        StateHasChanged();
    }

    private void UpdateBookFilter(ChangeEventArgs e)
    {
        _filterByBookTitle = e.Value.ToString();
        StateHasChanged();
    }
    

    private async Task DeleteBookAsync(int isbn)
    {
        await _bookService.DeleteBookAsync(isbn);
        _authors = await _authorService.GetAuthorsAsync();
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookService _bookService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorService _authorService { get; set; }
    }
}
#pragma warning restore 1591