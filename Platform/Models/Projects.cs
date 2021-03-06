﻿using System;
using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public partial class Projects
    {
        public Projects()
        {
            AssociatedAccountNotes = new HashSet<AssociatedAccountNotes>();
            AssociatedBoardWorkItems = new HashSet<AssociatedBoardWorkItems>();
            AssociatedProjectBoards = new HashSet<AssociatedProjectBoards>();
            AssociatedProjectBuilds = new HashSet<AssociatedProjectBuilds>();
            AssociatedProjectChangelogs = new HashSet<AssociatedProjectChangelogs>();
            AssociatedProjectIterations = new HashSet<AssociatedProjectIterations>();
            AssociatedProjectMemberRights = new HashSet<AssociatedProjectMemberRights>();
            AssociatedProjectMembers = new HashSet<AssociatedProjectMembers>();
            AssociatedProjectNotifications = new HashSet<AssociatedProjectNotifications>();
            AssociatedProjectPublicMessages = new HashSet<AssociatedProjectPublicMessages>();
            AssociatedWorkItemChangelogs = new HashSet<AssociatedWorkItemChangelogs>();
            Branches = new HashSet<Branches>();
        }

        public int Id { get; set; }
        public int RepositoryId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectTitle { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? BoardId { get; set; }
        public int? PublicBoard { get; set; }
        public int? AllowPublicControl { get; set; }
        public int? AllowPublicFeatures { get; set; }
        public int? AllowPublicBugs { get; set; }
        public int? AllowPublicFeedback { get; set; }
        public int? AllowPublicMessages { get; set; }

        public virtual Repository Repository { get; set; }
        public virtual ICollection<AssociatedAccountNotes> AssociatedAccountNotes { get; set; }
        public virtual ICollection<AssociatedBoardWorkItems> AssociatedBoardWorkItems { get; set; }
        public virtual ICollection<AssociatedProjectBoards> AssociatedProjectBoards { get; set; }
        public virtual ICollection<AssociatedProjectBuilds> AssociatedProjectBuilds { get; set; }
        public virtual ICollection<AssociatedProjectChangelogs> AssociatedProjectChangelogs { get; set; }
        public virtual ICollection<AssociatedProjectIterations> AssociatedProjectIterations { get; set; }
        public virtual ICollection<AssociatedProjectMemberRights> AssociatedProjectMemberRights { get; set; }
        public virtual ICollection<AssociatedProjectMembers> AssociatedProjectMembers { get; set; }
        public virtual ICollection<AssociatedProjectNotifications> AssociatedProjectNotifications { get; set; }
        public virtual ICollection<AssociatedProjectPublicMessages> AssociatedProjectPublicMessages { get; set; }
        public virtual ICollection<AssociatedWorkItemChangelogs> AssociatedWorkItemChangelogs { get; set; }
        public virtual ICollection<Branches> Branches { get; set; }
    }
}
