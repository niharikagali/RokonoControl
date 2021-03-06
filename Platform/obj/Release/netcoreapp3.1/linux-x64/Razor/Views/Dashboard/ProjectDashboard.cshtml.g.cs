#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb0031a3f0641fa9e0a890a144ce517296d2eebb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_ProjectDashboard), @"mvc.1.0.view", @"/Views/Dashboard/ProjectDashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0031a3f0641fa9e0a890a144ce517296d2eebb", @"/Views/Dashboard/ProjectDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_ProjectDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
  

    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    ViewData["Title"] = $"Add New User";
    var Project = ViewData["Project"] as Projects;
    var ProjectMembers = ViewData["ProjectMembers"] as List<BindingUserAccount>;
    var ProjectId = ViewData["ProjectId"] as int?;
    var ProjectInitials = ViewData["Initials"] as string;
    var CreatedCount = ViewData["WorkItemsCreated"] as int?;
    var NewCount = ViewData["WorkItemsNew"] as int?;
    var ActiveCount = ViewData["WorkItemsActive"] as int?;
    var TestingCount = ViewData["WorkItemsTesting"] as int?;
    var CompleatedCount = ViewData["WorkItemsCompleated"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    object[type=""image/svg+xml""] {
        vertical-align: middle;
        display: inline-block;
    }

    .innerRow {
        padding: 5%;
    }

    .circle {
        display: inline-flex;
        border-radius: 50%;
        background-color: #1c86c8;
    }

        .circle a {
            width: 50px;
            height: 50px;
            padding-top: 31%;
            padding-left: 23%;
            text-decoration: none;
            color: white;
        }

    .Thumbwrapper {
        border-radius: 3%;
        background-color: #1c86c8;
    }

    .e-icons {
        color: #1c86c8;
        font-size: 26px;
    }

    .e-workitem:before {
        content: '\e30d';
    }

    .e-upload:before {
        content: '\e725';
    }

    .e-font:before {
        content: '\e34c';
    }
</style>
<link href=""https://cdn.syncfusion.com/ej2/material.css"" rel=""stylesheet"">

<!-- end of sidebar element -->
<!-- main-content declaration -->
 
        <div class=""row  card-layout"">
            <div class=""col-md");
            WriteLiteral(@"-12"">
                <!-- Basic Card Layout  -->
                <div tabindex=""0"" class=""e-card"" id=""basic_card"">
                    <div class=""e-card-header"">

                    </div>
                    <div class=""e-card-content"">
                        <div class=""row"" style=""height:87px"">
                            <div class=""col-md-1"">
                                <div class=""Thumbwrapper"">
                                    <p style=""color:white;font-size:48px;text-align:center;"">");
#nullable restore
#line 78 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                                                                                        Write(ProjectInitials);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                </div>\n                            </div>\n                            <div class=\"col-md-8\">\n                                <h3 style=\"font-size:48px; margin-top:2px;\"> ");
#nullable restore
#line 82 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                                                                        Write(Project.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            </div>\n                            <div class=\"col-md-3\">\n                                <button type=\"button\" id=\"Persons\" class=\"btn btn-primary\" style=\"margin-top:2px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2623, "\"", 2683, 3);
            WriteAttributeValue("", 2633, "CallUrl(\'/Dashboard/ManageAccounts?id=", 2633, 38, true);
#nullable restore
#line 85 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
WriteAttributeValue("", 2671, ProjectId, 2671, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2681, "\')", 2681, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">Manage members</button>

                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <div class=""row  card-layout"">
            <div class=""col-md-4"">
                <!-- Basic Card Layout  -->
                <div tabindex=""0"" class=""e-card"" id=""basic_card"">
                    <div class=""e-card-header"">

                        <h3 class=""center"">About the Project</h3>

                    </div>
                    <div class=""e-card-content"">
                        <div class=""row innerRow"">
                            <h2>Summary</h2>
                        </div>
                        <hr />

                        <div class=""row innerRow"">
                            <p style="" word-break: break-word; word-wrap: break-word;""> ");
#nullable restore
#line 111 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                                                                                   Write(Project.ProjectDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                        </div>
                    </div>

                </div>
            </div>
            <div class=""col-md-4"">
                <!-- Basic Card Layout  -->
                <div tabindex=""0"" class=""e-card"" id=""basic_card"">
                    <div class=""e-card-header"">

                        <h3 class=""center"">Project Stats</h3>

                    </div>
                    <div class=""e-card-content"">
                        <div class=""row innerRow"">
                            <p>Boards</p>
                        </div>
                        <hr />
                        <div class=""row innerRow"">
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-md-4"">
                                        <span class=""e-icons e-workitem""></span>
                                    </div>
                                    <div class=""col-md-8"">
                                   ");
            WriteLiteral("     <div class=\"row\">\n                                            ");
#nullable restore
#line 138 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                                       Write(CreatedCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                        <div class=""row"">
                                            Work items created
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-md-4"">
                                        <span class=""e-icons e-workitem""></span>
                                    </div>
                                    <div class=""col-md-8"">
                                        <div class=""row"">
                                            ");
#nullable restore
#line 153 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                                       Write(CompleatedCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                        <div class=""row"">
                                            Work items compleated
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row innerRow"">
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-md-4"">
                                        <span class=""e-icons e-workitem""></span>
                                    </div>
                                    <div class=""col-md-8"">
                                        <div class=""row"">
                                            ");
#nullable restore
#line 170 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                                       Write(ActiveCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                        <div class=""row"">
                                            Work items active
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-md-4"">
                                        <span class=""e-icons e-workitem""></span>
                                    </div>
                                    <div class=""col-md-8"">
                                        <div class=""row"">
                                            ");
#nullable restore
#line 185 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                                       Write(TestingCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                        <div class=""row"">
                                            Work items testing
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row innerRow"">

                        </div>
                    </div>

                </div>
            </div>
            <div class=""col-md-4"">
                <!-- Basic Card Layout  -->
                <div tabindex=""0"" class=""e-card"" id=""basic_card"">
                    <div class=""e-card-header"">

                        <h3 class=""center"">Project Members</h3>

                    </div>
                    <div class=""e-card-content"">

                        <hr />
                        <div class=""row innerRow"">
");
#nullable restore
#line 213 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                              
                                foreach (var member in ProjectMembers)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"circle\">\n                                        <a href=\"#\">");
#nullable restore
#line 217 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                                               Write(member.AliasName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                    </div>\n");
#nullable restore
#line 219 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                        <hr />\n                        <div class=\"row innerRow\">\n                            <p>Project members count: ");
#nullable restore
#line 224 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
                                                 Write(ProjectMembers.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>

                </div>
            </div>
        </div>

 
<script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>

<script>

$(document).ready(function() {
    var Persons = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    Persons.appendTo('#Persons');

      var id = ");
#nullable restore
#line 243 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDashboard.cshtml"
          Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

          var dto = {
            ""id"": id,

        }
        console.log(dto);
        $.ajax({
            type: 'POST',
            url: '/Dashboard/GetCommitChartBindingData',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                InitChart(response);
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
});

function InitChart(data)
{
    console.log(data);
    var bindingSeries = [];
    data.forEach(function(element) {
        console.log(element);
        var bindingItem =
        {
            ""x"": element.DateOfCommit,
            ""y"": element.dayCount
        }
        bindingSeries.push(bindingItem);
    });

     var chart = new ej.charts.Chart({
        //Initializing Primary X Axis
        primaryXAxis: {
            valueType: 'DateTime',
            labelFormat: 'y',
            edgeLa");
            WriteLiteral(@"belPlacement: 'Shift',
            majorGridLines: { width: 0 }
        },
        //Initializing Primary X Axis
        primaryYAxis: {
            labelFormat: '{value}%',
            rangePadding: 'None',
            minimum: 0,
            maximum: 100,
            interval: 20,
            lineStyle: { width: 0 },
            majorTickLines: { width: 0 },
            minorTickLines: { width: 0 }
        },
        chartArea: {
            border: {
                width: 0
            }
        },
        //Initializing Chart Series
        series: [
            {
                type: 'Line',
                dataSource:  bindingSeries,
                xName: 'x', width: 2, marker: {
                    visible: true,
                    width: 10,
                    height: 10
                },
                yName: 'y', name: 'Commits Per day',
            }
        ],
        //Initializing Chart Title
        title: 'Commit tracker',
        //Initializing Tooltip
        tooltip: {
            en");
            WriteLiteral("able: true\n        },\n        width: ej.base.Browser.isDevice ? \'100%\' : \'60%\',\n\n    });\n  //  chart.appendTo(\'#line-container\');\n    }\n\n\n    function CallUrl(url) {\n        window.location.href = url;\n    }\n</script>");
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
