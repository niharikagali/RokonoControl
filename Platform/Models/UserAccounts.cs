﻿using System;
using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public partial class UserAccounts
    {
        public UserAccounts()
        {
            AssociatedAccountNotes = new HashSet<AssociatedAccountNotes>();
            AssociatedProjectMemberRights = new HashSet<AssociatedProjectMemberRights>();
            AssociatedProjectMembers = new HashSet<AssociatedProjectMembers>();
            AssociatedProjectNotifications = new HashSet<AssociatedProjectNotifications>();
            AssociatedUserNotifications = new HashSet<AssociatedUserNotifications>();
            WorkItem = new HashSet<WorkItem>();
            WorkItemMessage = new HashSet<WorkItemMessage>();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ProjectRights { get; set; }
        public string GitUsername { get; set; }
        public string Salt { get; set; }

        public virtual ICollection<AssociatedAccountNotes> AssociatedAccountNotes { get; set; }
        public virtual ICollection<AssociatedProjectMemberRights> AssociatedProjectMemberRights { get; set; }
        public virtual ICollection<AssociatedProjectMembers> AssociatedProjectMembers { get; set; }
        public virtual ICollection<AssociatedProjectNotifications> AssociatedProjectNotifications { get; set; }
        public virtual ICollection<AssociatedUserNotifications> AssociatedUserNotifications { get; set; }
        public virtual ICollection<WorkItem> WorkItem { get; set; }
        public virtual ICollection<WorkItemMessage> WorkItemMessage { get; set; }
    }
}
