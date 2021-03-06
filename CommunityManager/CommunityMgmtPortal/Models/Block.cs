﻿using System;
using System.Collections.Generic;

namespace CommunityMgmtPortal.Models
{
    public partial class Block
    {
        public Block()
        {
            Unit = new HashSet<Unit>();
        }

        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Guid UpdatedBy { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public string Comments { get; set; }
        public Guid CommunityId { get; set; }
        public string Name { get; set; }

        public Community Community { get; set; }
        public User CreatedByNavigation { get; set; }
        public User UpdatedByNavigation { get; set; }
        public ICollection<Unit> Unit { get; set; }
    }
}
