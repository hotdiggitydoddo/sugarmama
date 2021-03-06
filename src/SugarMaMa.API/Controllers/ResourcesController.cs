﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SugarMaMa.API.DAL.Entities;
using SugarMaMa.API.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SugarMaMa.API.Controllers
{
    [Route("api/[controller]")]
    public class ResourcesController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly IRepository<Esthetician> _estheticians;

        public ResourcesController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IRepository<Esthetician> estheticians)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _estheticians = estheticians;
        }

        [HttpGet]
        public IEnumerable<Esthetician> Get()
        {
            var a = _estheticians.GetAsync(x => x.User).Result;
            return a;
        }

        [HttpPost]
        public Esthetician Add()
        {
            var user = _userManager.FindByEmailAsync("rcd1214@hotmail.com").Result;
            var esth = new Esthetician
            {
                ApplicationUserId = user.Id
            };
            var a = _estheticians.AddAsync(esth).Result;
            return a;
        }


        //[Authorize(Roles ="Admin")]
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //            var user = _userManager.FindByEmailAsync(User.FindFirst(x => x.Type == "username").Value).Result;
        //    var res = _userManager.RemoveFromRoleAsync(user, "admin").Result;

        //    if (User.IsInRole("Admin"))
        //            return new string[] { "adminvalue1", "adminvalue2" };
        //        //else
        //        //{
        //        //    var user = _userManager.FindByEmailAsync(User.FindFirst(x => x.Type == "username").Value).Result;
                    
        //        //    //var adminRole = _roleManager.FindByNameAsync("Admin").Result;

        //        //    //if (adminRole == null)
        //        //    //{
        //        //    //    adminRole = new ApplicationRole("Admin");
        //        //    //    var roleRes = _roleManager.CreateAsync(adminRole).Result;

        //        //    //    var add = _userManager.AddToRoleAsync(user, "Admin").Result;

        //        //    //}
                    
        //        //    var res = _userManager.RemoveFromRoleAsync(user, "admin").Result;
        //        //    return new string[] { "value1", "value2" };
        //        //}
        //    return new string[1];
        //}
    }
}
