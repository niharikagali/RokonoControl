#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67864c19d2f8c135ed3a6ce8ce9d6d84cc715247"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Commit_Index), @"mvc.1.0.view", @"/Views/Commit/Index.cshtml")]
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
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67864c19d2f8c135ed3a6ce8ce9d6d84cc715247", @"/Views/Commit/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Commit_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/material.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/dist/ej2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/Index.cshtml"
  
    ViewData["Title"] = "Commits";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var result = ViewData["Projects"] as List<Projects>;
    var userName =  ViewData["Name"] as string;
    var ProjectId = ViewData["ProjectId"];
    var Branches = ViewData["Branches"] as List<Branches>;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67864c19d2f8c135ed3a6ce8ce9d6d84cc7152474726", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
 <!-- end of sidebar element -->
        <!-- main-content declaration -->
        <div class=""main-content"" id=""main-text"" style=""height: 94vh;"">
            <div class=""sidebar-content"">
<Div class=""container"">
<div class=""row"">
    <div class=""control-wrapper"" style=""width:100%"">

        <select id=""branches""> 
");
#nullable restore
#line 19 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/Index.cshtml"
          
            foreach(var branch in Branches){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67864c19d2f8c135ed3a6ce8ce9d6d84cc7152476430", async() => {
#nullable restore
#line 21 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/Index.cshtml"
                                          Write(branch.BranchName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/Index.cshtml"
                       WriteLiteral(branch.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 22 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </select>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""main-card mb-3 card"">
            <div class=""control-section"">
                <div class=""content-wrapper"" id=""GridHolder"">
                    <div id=""Grid""></div>        
                </div>
            </div>
        </div>
    </div>
</div>
</div>
            </div>
        </div>
<script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
 
 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67864c19d2f8c135ed3a6ce8ce9d6d84cc7152479452", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script>

    $( document ).ready(function() 
    {

    
        var listObj = new ej.dropdowns.DropDownList({
            // set the index value to select an item based on index at initial rendering
            index: 1,
            // set the placeholder to DropDownList input element
            placeholder: 'Select a branch',
            // set the height of the popup element
            popupHeight: '200px',
            // bind the change event
            change:  BranchChanged
        });
        listObj.appendTo('#branches');
      
        $.ajax({
            type: 'GET',
            url: '/Commit/GetCommits?projectId=");
#nullable restore
#line 68 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/Index.cshtml"
                                          Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&branchId=0',
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                console.log(response);
                LoadCommitGrid(response);
            },
            error: function (xhr, status, error) {
    
            }
        });
        
    });

    function LoadCommitGrid(data)
    {
        $(""#GridHolder"").html("""");
        $(""#GridHolder"").html(""<div id=\""Grid\""></div>"");
        var grid = new ej.grids.Grid({
            dataSource: data,
            editSettings: { allowEditing: true, allowAdding: true, allowDeleting: true, allowEditOnDblClick: false },
             columns: [
                { field: 'commitKey', headerText: 'Commit Key', width: 120, textAlign: 'Right' },
                { field: 'message', headerText: 'Message', width: 150 },
                { field: 'author', headerText: 'Author', width: 130,  textAlign: 'Right' },
                { field: 'date', headerText: 'Date', width: 130, format: '");
            WriteLiteral(@"yMd', textAlign: 'Right' },
                { field: 'pullRequest', headerText: 'PullRequest', width: 130, textAlign: 'Right' },

            ]
        });
        grid.appendTo('#Grid');
    }

    // call the change event's function after initialized the component.
    function BranchChanged(args) {
       console.log();
        $.ajax({
            type: 'GET',
            url: '/Commit/GetCommits?projectId=");
#nullable restore
#line 106 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/Index.cshtml"
                                          Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&branchId='+args.value,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                console.log(response);
                LoadCommitGrid(response);
            },
            error: function (xhr, status, error) {
    
            }
        });
        
    }
</script>");
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
