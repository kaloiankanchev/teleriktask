#pragma checksum "C:\Users\elite\Desktop\TelerikClient\TelerikThomas\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92493b26c3e89db3b37ca49f2ea9351c39b68de5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\elite\Desktop\TelerikClient\TelerikThomas\Views\_ViewImports.cshtml"
using TelerikThomas;

#line default
#line hidden
#line 2 "C:\Users\elite\Desktop\TelerikClient\TelerikThomas\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#line 1 "C:\Users\elite\Desktop\TelerikClient\TelerikThomas\Views\Home\Index.cshtml"
using TelerikThomas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92493b26c3e89db3b37ca49f2ea9351c39b68de5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c677b418baa4ebad8c431b3867bbcd6efded02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 14, true);
            WriteLiteral("\r\n    \r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(45, 2144, false);
#line 7 "C:\Users\elite\Desktop\TelerikClient\TelerikThomas\Views\Home\Index.cshtml"
Write(Html.Kendo().Grid<Person>
            ()
            .Name("#Grid")
            .Selectable()
            .Columns(columns =>
            {

            columns.Select().Width(50);
            //  columns.Bound(c => c.EmployeeID);
            columns.Bound(c => c.FirstName).Width("200");
            columns.Bound(c => c.LastName).Width("200");
            columns.Bound(c => c.Phone).Width("200");
            columns.Command(command =>
            {
            command.Edit().CancelText("Reject").UpdateText("Update").Text("Edit");
            command.Destroy().Text("Delete");

            }).Width(350);

            })
            .Selectable(selectable => selectable
            .Mode(GridSelectionMode.Multiple)).PersistSelection(true)
            .ToolBar(tools =>
            {
            tools.Create().Text("Add item");
            })
            .DataSource(dataSource => dataSource
            .Ajax()
            .Model(model =>
            {
            model.Id(emp => emp.Id);
            model.Field(emp => emp.FirstName).Editable(true);
            model.Field(emp => emp.LastName).Editable(true);
            model.Field(emp => emp.Phone).Editable(true);

            }
            )

            .Read(read => read.Action("Get", "Grid"))
            .Update(update => update.Action("Update", "Grid"))
            .Create(create => create.Action("Create", "Grid"))
            .Destroy(destroy => destroy.Action("Delete", "Grid"))

            )
            .ToolBar(toolbar => toolbar.Save().SaveText("Save Changes").CancelText("Abort"))

            // Set grid editable.
            .Editable(editable => editable.Mode(GridEditMode.InLine))




            // Set grid pagable.
            .Pageable(pageable =>
            {
            pageable.Refresh(true);
            pageable.PageSizes(true);

            pageable.Messages(items => items.Display("{0} - {1} of {2} records"));
            pageable.Messages(items => items.ItemsPerPage("records per page"));


            pageable.PageSizes(new int[] { 10, 25, 100 });
            })

            );

#line default
#line hidden
            EndContext();
            BeginContext(2190, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
