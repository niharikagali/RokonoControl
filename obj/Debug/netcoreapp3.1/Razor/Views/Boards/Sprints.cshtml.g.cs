#pragma checksum "D:\RokonoControl\Views\Boards\Sprints.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4a7909e7a5a68b9041cc1d090dab99ee076559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boards_Sprints), @"mvc.1.0.view", @"/Views/Boards/Sprints.cshtml")]
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
#line 1 "D:\RokonoControl\Views\_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RokonoControl\Views\_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4a7909e7a5a68b9041cc1d090dab99ee076559", @"/Views/Boards/Sprints.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Boards_Sprints : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/material.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Sprints/Sprints.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
  
    ViewData["Title"] = "Board";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var ProjectId = ViewData["ProjectId"];
    var WorkItemTypes = ViewData["WorkItemTypes"] as List<WorkItemTypes>;
    var ProjectName = ViewData["ProjectName"] as string;
    var Iteration = ViewData["Iteration"] as int?;
    var Person = ViewData["Person"] as int?;
    var ViewRights = ViewData["GetUserViewRights"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://code.jquery.com/jquery-3.4.1.min.js\"></script>\r\n\r\n<script src=\"https://cdn.syncfusion.com/ej2/dist/ej2.min.js\" type=\"text/javascript\"></script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3d4a7909e7a5a68b9041cc1d090dab99ee0765594817", async() => {
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
            WriteLiteral("\r\n<link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\" rel=\"stylesheet\">\r\n\r\n<!--[if lt IE 9]>\r\n<script src=\"../scripts/jquery-1.11.3.min.js\" type=\"text/javascript\" ></script>\r\n<![endif]-->\r\n");
            WriteLiteral("<!--<![endif]-->\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3d4a7909e7a5a68b9041cc1d090dab99ee0765596253", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        <div class=""main-card mb-12 card"">
            <div class=""card-body text-center"">

                <div class=""page-title-heading"">
                    <div class=""page-title-icon"">
                        <i class=""pe-7s-graph text-success"">
                        </i>
                    </div>
                    <div>
                        Project Dashboard
                        <div class=""page-title-subheading"">
                            ");
#nullable restore
#line 46 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                       Write(ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">


            <div class=""col-md-5"">
                <button type=""button"" id=""iconbtn"" class=""btn btn-primary""");
            BeginWriteAttribute("onclick", " onclick=\"", 2503, "\"", 2618, 3);
            WriteAttributeValue("", 2513, "CallUrl(\'/Dashboard/AddNewWorkItem?projectId=\'+", 2513, 47, true);
#nullable restore
#line 56 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
WriteAttributeValue("", 2560, ProjectId, 2560, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2570, "+\'&workItemType=\'+7+\'&boardId=\'+0+\'&parentId=0\')", 2570, 48, true);
            EndWriteAttribute();
            WriteLiteral(">New Sprint</button>\r\n                <button id=\"backlogBtn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2680, "\"", 2764, 3);
            WriteAttributeValue("", 2690, "CallUrl(\'/Boards/ProjectBacklog?projectId=\'+", 2690, 44, true);
#nullable restore
#line 57 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
WriteAttributeValue("", 2734, ProjectId, 2734, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2744, "+\'&&workItemType=7\')", 2744, 20, true);
            EndWriteAttribute();
            WriteLiteral(@">View as backlog</button>
                <button id=""capacityBtn"" onclick=""CallUrl()"">Capacity</button>
                <button id=""analitycsBtn"" onclick=""CallUrl()"">Analitycs</button>
            </div>
            <div class=""col-md-3"">

            </div>
            <div class=""col-md-4"">
                <button type=""button"" id=""Iterations"" class=""btn btn-primary"">Active Iteration</button>
                <button type=""button"" id=""Persons"" class=""btn btn-primary"">Persons</button>

            </div>




        </div>
        <div class=""row"">
            <div class=""cols-sample-area"" id=""board"">

                <div id=""KanbanHolder"">
                    <div id=""Kanban""></div>
                </div>

            </div>
        </div>
        <div class=""row text-center"">
            <h2>Empty User Stories</h2>
        </div>
        <div class=""row"">
            <div class=""control-section"" style=""height:97vh;"">
                <div class=""content-wrapper"">
           ");
            WriteLiteral(@"         <div id=""TreeGrid""></div>
                </div>
            </div>
        </div>

    </div>
</div>




<script type=""text/javascript"">


        var iconbtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
        iconbtn.appendTo('#iconbtn');
        var backlogBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
        backlogBtn.appendTo('#backlogBtn');
        var capacityBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
        capacityBtn.appendTo('#capacityBtn');
        var analitycsBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
        analitycsBtn.appendTo('#analitycsBtn');



    // DropDownButton items declaration


        ej.base.enableRipple(true);
        var card;
        var gData;
        window.getTags = function (data) {
            var tagDiv = '<div class=""e-tags"">';
            var tags = data.Tags.split(',');
            for (var i = 0; i < tags.lengt");
            WriteLiteral(@"h; i++) {
                var tag = tags[i];
                tagDiv = tagDiv.concat('<div class=""e-tag e-tooltip-text"">' + tag + '</div>');
            }
            return tagDiv.concat('</div>');
        };
        $(function() {
            var incomingSprintDTO =
            {
                ""ProjectId"": ");
#nullable restore
#line 132 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                        Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                \"WorkItemTypeId\": $(\"#ItemPriority :selected\").val(),\r\n                \"IterationId\": ");
#nullable restore
#line 134 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                          Write(Iteration);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                \"PersonId\": ");
#nullable restore
#line 135 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                       Write(Person);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                \"All\" : ");
#nullable restore
#line 136 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                   Write(ViewRights);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            }



             $.ajax({
                type: 'POST',
                url: '/Boards/GetSprints',
                data: JSON.stringify(incomingSprintDTO),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function(response) {
                    GenerateKaban(response);
                },
                error: function(xhr, status, error) {
                    console.log(error);
                }
            });
            var iterationDTO = {
                ""Iteration"": ");
#nullable restore
#line 155 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                        Write(Iteration);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                \"ProjectId\":");
#nullable restore
#line 156 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                       Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            }

            $.ajax({
                type: 'POST',
                url: '/Boards/GetIterations',
                data: JSON.stringify(iterationDTO),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function(response) {
                    var Iterations = new ej.splitbuttons.DropDownButton({ items: response, iconCss: 'e-ddb-icons e-profile',cssClass: 'e-outline', select:WorkItemListClicked });
                    Iterations.appendTo('#Iterations');
                },
                error: function(xhr, status, error) {
                    console.log(error);
                }
            });
            $.ajax({
                type: 'POST',
                url: '/Boards/GetPersons',
                data: JSON.stringify(iterationDTO),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function(response) {
                    ");
            WriteLiteral(@"var Persons = new ej.splitbuttons.DropDownButton({ items: response, iconCss: 'e-ddb-icons e-profile',cssClass: 'e-outline', select:PersonClicked });
                    Persons.appendTo('#Persons');
                },
                error: function(xhr, status, error) {
                    console.log(error);
                }
            });

            
            var dto = {
                ""id"": ");
#nullable restore
#line 190 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                 Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                ""WorkItemType"":7
            }
            console.log(dto);
            $.ajax({
                type: 'POST',
                url: '/Backlogs/GetWorkItems',
                data: JSON.stringify(dto),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (response) {
                    InitiliazeGrid(response);
                },
                error: function (xhr, status, error) {
                    console.log(error);
                }
            });

		 });


         function GenerateKaban(response)
         {
             $(""#KanbanHolder"").html(""<div id=\""Kanban\""></div>"");
             $(""#KanbanHolder"").html();

            var data = ej.base.extend([], response, null, true); // To maintain the property changes, extend the object.
            console.log(data);
            var kanbanObj = new ej.kanban.Kanban({
                dataSource: data,
                dragStop: D");
            WriteLiteral(@"ragStopped,
                actionComplete: CardDropCheck,
                cardDoubleClick: CardSelected,
                keyField: 'status',
                enableTooltip: true,
                columns: [
                    { headerText: 'To Do', keyField: 'Open', template: '#headerTemplate', allowToggle: true },
                    { headerText: 'In Progress', keyField: 'InProgress', template: '#headerTemplate', allowToggle: true },
                    { headerText: 'In Review', keyField: 'Testing', template: '#headerTemplate', allowToggle: true },
                    { headerText: 'Done', keyField: 'Done', template: '#headerTemplate', allowToggle: true }
                ],
                cardSettings: {
                    contentField: 'summary',
                    headerField: 'id',
                    template: '#cardTemplate',
                    selectionType: 'Multiple'
                },
                swimlaneSettings: {
                    keyField: 'assignee',
             ");
            WriteLiteral("   }\r\n            });\r\n\r\n\r\n            kanbanObj.appendTo(\'#Kanban\');\r\n         }\r\n        function CardSelected(args)\r\n        {\r\n            console.log(args);\r\n            console.log(\"/Dashboard/EditWorkItem?projectId=");
#nullable restore
#line 248 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                                                      Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&workItem=\"+args.data.innerId);\r\n            window.location.href = \"/Dashboard/EditWorkItem?projectId=");
#nullable restore
#line 249 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                                                                 Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&&workItem=""+args.data.innerId;

        }
        function CardDropCheck(args)
        {
            console.log(args);
            if(args.requestType == ""cardChanged"" && card)
            {
                card.Board = args.changedRecords[0].status;
                ValidateCardChanged();
            }
        }
        function ValidateCardChanged()
        {
            console.log(""Posting"");
            $.ajax({
                type: 'POST',
                url: '/Boards/ChangeWorkItemBoard',
                data: JSON.stringify(card),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function(response) {
                    //window.location.href = ""/Dashboard/AssignAccountProjects?id=""+response;
                },
                error: function(xhr, status, error) {
                    console.log(error);
                }
            });
        }
         function DragStopped(args)
         {
   ");
            WriteLiteral("         console.log(args);\r\n            card = {\r\n                \"CardId\" :args.data[0].innerId,\r\n                \"Board\" :args.data[0].status,\r\n                \"ProjectId\" : ");
#nullable restore
#line 284 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                         Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            }\r\n\r\n         }\r\n         function WorkItemListClicked(args)\r\n         {\r\n             console.log(args);\r\n");
            WriteLiteral(@"         }

         function PersonClicked(args) {
             console.log(args);
         }

        function ChangeOwner()
        {
            console.log(""Changing Owner"");
        }

         function CallUrl(url) {
             window.location.href = url;
    }

    function InitiliazeGrid(data )
    {
        console.log(data);


        var treeGridObj = new ej.treegrid.TreeGrid({
            dataSource: data,
            allowSelection: true,
            allowFiltering: true,
            allowSorting: true,
            toolbar: ['Search'],
            recordDoubleClick: EditWorkItem,
            enableVirtualization: true,
            filterSettings: { type: 'Menu' },
            selectionSettings: { persistSelection: true, type: ""Multiple"" },
            enableHover: false,
            allowPaging: true,
            pageSettings: { pageSize: 20 },
            columns: [
                { type: ""checkbox"", field: """", allowFiltering: false, allowSorting: false, wid");
            WriteLiteral(@"th: '60' },
                { field: 'workItemType.TypeName', headerText: 'Type', width: 60 },
                { field: 'title', headerText: 'Title', width: 125 },
                { field: 'description', headerText: 'Description', width: 180 },
                { field: 'assignedAccountNavigation.Email', headerText: 'AssignedTo', width: 110 },
            ]
        });

        treeGridObj.appendTo('#TreeGrid');


    }

    function EditWorkItem(args)
    {
        console.log(args);
        window.location.href = ""/Dashboard/EditWorkItem?projectId=");
#nullable restore
#line 364 "D:\RokonoControl\Views\Boards\Sprints.cshtml"
                                                             Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&&workItem=""+args.rowData.id
    }
</script>


<script id=""headerTemplate"" type=""text/x-jsrender"">
    <div class=""header-template-wrap"">
        <div class=""header-icon e-icons ${keyField}""></div>
        <div class=""header-text"">${headerText}</div>

    </div>
</script>
<script id=""cardTemplate"" type=""text/x-jsrender"">
    <div class='card-template ${priority}' style='content: ""\e511 "";'>
        <div class='card-header e-tooltip-text'>
            <div class=""row"" style=""display:flex;"">
                <div class=""col-2"">
                    <span class=""e-search""></span>
                </div>
                <div class=""col-10"" style=""width:100%; text-align:center;"">
                    <span style=""text-align:center;"">${id} ${title}</span>
                </div>
            </div>
        </div>


        <div class='card-template-wrap'>
            <div class=""row"" style=""padding:2%;"">
                <div class='e-text'>${summary}</div>

            </div>
            <d");
            WriteLiteral(@"iv class=""row"" style=""padding:2%;"">
                <div class='Interactice' onclick=""ChangeOwner()"">${assgignedAccount}</div>
            </div>
            <div class=""row status"" style=""display:flex;padding:2%;"">

                <div class=""col-3"">
                    <span class='status'></span><div class='e-text' style=""text-align:left;"">Status:</div>
                </div>
                <div class=""col-9"" style=""width:100%;"">
                    <div class='Interactice'>${status}</div>
                </div>
            </div>

        </div>

    </div>
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
