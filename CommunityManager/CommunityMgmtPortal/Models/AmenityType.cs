﻿using System;
using System.Collections.Generic;

namespace CommunityMgmtPortal.Models
{
    public partial class AmenityType
    {
        public AmenityType()
        {
            Amenity = new HashSet<Amenity>();
        }

        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Guid UpdatedBy { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public string Comments { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public User CreatedByNavigation { get; set; }
        public User UpdatedByNavigation { get; set; }
        public ICollection<Amenity> Amenity { get; set; }
    }
}
