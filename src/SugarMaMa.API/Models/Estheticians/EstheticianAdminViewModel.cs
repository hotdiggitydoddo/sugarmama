﻿using SugarMaMa.API.Models.SpaServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SugarMaMa.API.Models.Estheticians
{
    public class EstheticianAdminViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<SpaServiceViewModel> Services { get; set; }
    }
}