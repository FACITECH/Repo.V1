﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashBoard.Models
{
    public class ParkingSlot
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int CommunityId { get; set; }
        public int BlockId { get; set; }
        public string FloorName { get; set; }
        //public Apartment Apartment { get; set; }
        
    }
}