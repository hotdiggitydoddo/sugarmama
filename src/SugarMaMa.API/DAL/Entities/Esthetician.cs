﻿using System;
using System.Collections.Generic;

namespace SugarMaMa.API.DAL.Entities
{
    public class Esthetician : SMEntity
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }
        public List<SpaService> Services { get; set; }
        public List<Shift> Shifts { get; set; }
        public string Color { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
