#pragma checksum "D:\RokonoControl\Views\Accounts\ManageProjectMemebers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51bcf82ac3ea2153f5dd694eef770c94381c514c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_ManageProjectMemebers), @"mvc.1.0.view", @"/Views/Accounts/ManageProjectMemebers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51bcf82ac3ea2153f5dd694eef770c94381c514c", @"/Views/Accounts/ManageProjectMemebers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_ManageProjectMemebers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\RokonoControl\Views\Accounts\ManageProjectMemebers.cshtml"
  
    ViewData["Title"] = "ManageProjectMemebers";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var ProjectId = ViewData["ProjectId"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""https://cdn.syncfusion.com/ej2/material.css"" rel=""stylesheet"">


<style>
      .innerRow {
        padding: 5%;
    }
</style>
<div class=""main-content"" id=""main-text"" >
    <div class=""sidebar-content"">
        <div class=""container-fluid"">
            <div class=""row innerRow"">
                <div tabindex=""0"" class=""e-card"" id=""basic_card"">
                    <div class=""e-card-header"">
                        <h2 style=""text-align:center;"">Invite members to join by email</h2>

                    </div>
                    <div class=""e-card-content"">
                        <div class=""row innerRow"">
                            <div class=""row innerRow"">
                                <div class=""Thumbwrapper"">
                                </div>
                            </div>
                            <div class=""row innerRow"">
                                <div class=""col-md-6"">
                                    <input id=""email"" />
              ");
            WriteLiteral(@"                  </div>
                                <div class=""col-md-6"">
                                    <input id=""gitUsername"" />
                                </div>
                            </div>
                            <div class=""row innerRow"">
                                <div class=""col-md-6"">
                                    <input id=""password"" />
                                </div>
                                <div class=""col-md-6"">
                                    <input id=""password2"" />
                                </div>
                            </div>
                            <div class=""row innerRow"">
                                <div class=""content-wrapper"">
                                    <div class=""col-md-6"">
                                        <div class=""row innerRow"">
                                            <div>
                                                <label for=""WorkItemUserOption"" style=""padding:2%");
            WriteLiteral(@"; min-width:303px;""> Add/Edit Work Items</label>
                                                <input id=""WorkItemUserOption"" type=""checkbox"" />
                                            </div>
                                        </div>
                                        <div class=""row innerRow"">
                                            <div>
                                                <label for=""ChatUserChannels"" style=""padding:2%; min-width:303px;"">Create Chat Channels</label>
                                                <input id=""ChatUserChannels"" type=""checkbox"" />
                                            </div>
                                        </div>
                                        <div class=""row innerRow"">
                                            <div>
                                                <label for=""EditUserRightsUser"" style=""padding:2%; min-width:303px;"">Manage other user rights</label>
                                            ");
            WriteLiteral(@"    <input id=""EditUserRightsUser"" type=""checkbox"" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""row innerRow"">
                                            <div>
                                                <label for=""IterationUserOptions"" style=""padding:2%; min-width:303px;""> Manage Project Iterations</label>
                                                <input id=""IterationUserOptions"" type=""checkbox"" />
                                            </div>
                                        </div>
                                        <div class=""row innerRow"">
                                            <div>
                                                <label for=""ScheduleUserManagement"" style=""padding:2%; min-width:303px;"">Manage user work days</label>
                   ");
            WriteLiteral(@"                             <input id=""ScheduleUserManagement"" type=""checkbox"" />
                                            </div>
                                        </div>
                                        <div class=""row innerRow"">
                                            <div>
                                                <label for=""ViewWorkUserItems"" style=""padding: 2%; min-width:303px;"">View other people work items</label>
                                                <input id=""ViewWorkUserItems"" type=""checkbox"" />
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>
                            <div class=""row innerRow"">
                                <button type=""button"" id=""Persons"" class=""btn btn-primary"" style=""margin-top:2px;"">Add member</button>

                            </div>
                ");
            WriteLiteral(@"        </div>
                    </div>

                </div>
            </div>

            <div class=""row innerRow"">
                <div tabindex=""0"" class=""e-card"" id=""basic_card"">
                    <div class=""e-card-header"">
                        <h2 style=""text-align:center;"">Or add a member with existing account</h2>

                    </div>
                    <div class=""e-card-content"">
                        <div class=""row innerRow"">
                            <div class=""col-md-6"">
                                <p class=""text-center""> Existing Members</p>
                                <div class=""content-wrapper"">
                                    <div id=""Gird""></div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <p class=""text-center""> Assign project rights.</p>
                                <div class=""content-wrapper"">
                  ");
            WriteLiteral(@"                  <div class=""row innerRow"">
                                        <div>
                                            <label for=""WorkItemOption"" style=""padding:2%; min-width:303px;""> Add/Edit Work Items</label>
                                            <input id=""WorkItemOption"" type=""checkbox"" />
                                        </div>
                                    </div>
                                    <div class=""row innerRow"">
                                        <div>
                                            <label for=""ChatChannels"" style=""padding:2%; min-width:303px;"">Create Chat Channels</label>
                                            <input id=""ChatChannels"" type=""checkbox"" />
                                        </div>
                                    </div>
                                    <div class=""row innerRow"">
                                        <div>
                                            <label for=""EditUserRight");
            WriteLiteral(@"s"" style=""padding:2%; min-width:303px;"">Manage other user rights</label>
                                            <input id=""EditUserRights"" type=""checkbox"" />
                                        </div>
                                    </div>
                                    <div class=""row innerRow"">
                                        <div>
                                            <label for=""IterationOptions"" style=""padding:2%; min-width:303px;""> Manage Project Iterations</label>
                                            <input id=""IterationOptions"" type=""checkbox"" />
                                        </div>
                                    </div>
                                    <div class=""row innerRow"">
                                        <div>
                                            <label for=""ScheduleManagement"" style=""padding:2%; min-width:303px;"">Manage user work days</label>
                                            <input id=""ScheduleManage");
            WriteLiteral(@"ment"" type=""checkbox"" />
                                        </div>
                                    </div>
                                    <div class=""row innerRow"">
                                        <div>
                                            <label for=""ViewWorkItems"" style=""padding: 2%; min-width:303px;"">View other people work items</label>
                                            <input id=""ViewWorkItems"" type=""checkbox"" />
                                        </div>
                                    </div>
                                    <div class=""row innerRow"">
                                        <button id=""outlinebtn"" onclick=""AddSelectedUser()"">Add selected user and this these project rights.</button>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

    <");
            WriteLiteral(@"/div>
</div>
<script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>

<script>

    //Initializing new user input fields
    var email = new ej.inputs.TextBox({
        placeholder: 'email',
        cssClass: 'e-outline',
        floatLabelType: 'Auto'
    });
    email.appendTo('#email');
    var password = new ej.inputs.TextBox({
        placeholder: 'Password',
        cssClass: 'e-outline',
        floatLabelType: 'Auto'
    });
    password.appendTo('#password');
    var password2 = new ej.inputs.TextBox({
        placeholder: 'Confirm password',
        cssClass: 'e-outlin");
            WriteLiteral(@"e',
        floatLabelType: 'Auto'
    });
    password2.appendTo('#password2');
    var gitUsername = new ej.inputs.TextBox({
        placeholder: 'Username',
        cssClass: 'e-outline',
        floatLabelType: 'Auto'
    });
    gitUsername.appendTo('#gitUsername');


    var WorkItemUserOption = new ejs.buttons.Switch({ checked: true });
    WorkItemUserOption.appendTo('#WorkItemUserOption');
    var ChatUserChannels = new ejs.buttons.Switch({ checked: true });
    ChatUserChannels.appendTo('#ChatUserChannels');
    var EditUserRightsUser = new ejs.buttons.Switch({ checked: true });
    EditUserRightsUser.appendTo('#EditUserRightsUser');
    var IterationUserOptions = new ejs.buttons.Switch({ checked: true });
    IterationUserOptions.appendTo('#IterationUserOptions');
    var ScheduleUserManagement = new ejs.buttons.Switch({ checked: true });
    ScheduleUserManagement.appendTo('#ScheduleUserManagement');
    var ViewWorkUserItems = new ejs.buttons.Switch({ checked: true });
    ");
            WriteLiteral(@"ViewWorkUserItems.appendTo('#ViewWorkUserItems');
    //Initializing existing user fields

    var WorkItemOption = new ejs.buttons.Switch({ checked: true });
    WorkItemOption.appendTo('#WorkItemOption');
    var ChatChannels = new ejs.buttons.Switch({ checked: true });
    ChatChannels.appendTo('#ChatChannels');
    var EditUserRights = new ejs.buttons.Switch({ checked: true });
    EditUserRights.appendTo('#EditUserRights');
    var IterationOptions = new ejs.buttons.Switch({ checked: true });
    IterationOptions.appendTo('#IterationOptions');
    var ScheduleManagement = new ejs.buttons.Switch({ checked: true });
    ScheduleManagement.appendTo('#ScheduleManagement');
    var ViewWorkItems = new ejs.buttons.Switch({ checked: true });
    ViewWorkItems.appendTo('#ViewWorkItems');


    function LoadActiveUsers(data) {
        ActiveUsersGrid = new ej.grids.Grid({
            dataSource: data,
            allowPaging: true,
            allowSelection: true,
            enableHover: f");
            WriteLiteral(@"alse,

            pageSettings: { pageCount: 2 }
        });
        ActiveUsersGrid.appendTo('#Gird');
    }

    $.ajax({
        type: 'GET',
        url: '/Authenication/GetAvtiveUsers',
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        success: function (response) {
            LoadActiveUsers(response);
        },
        error: function (xhr, status, error) {

        }
    });
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
