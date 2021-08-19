﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using uygulama.Entity;

namespace uygulama.Identitiy
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //roller
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() {Name= "admin", Description = "yönetici rolü" };
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };
                manager.Create(role);


            }
            if (!context.Users.Any(i => i.UserName == "ozgeterzi"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "Özge ",Surname="Terzi", UserName = "ozgeterzi", Email = "terziozge@hotmail.com" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.UserName == "yagmurgazez"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "Yağmur",Surname="Gazezoğlu", UserName = "yagmurgazez", Email = "yagmurgazez@hotmail.com" };
                manager.Create(user, "yamur1234");

                manager.AddToRole(user.Id, "user");
            }
            base.Seed(context);
        }
    }
}