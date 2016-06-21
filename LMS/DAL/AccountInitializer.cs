using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LMS.DAL
{
    public class AccountInitializer:DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var admins = new List<Models.Admin>
            {
                new Models.Admin { AdminName="管理员",AdminAccount="admin",AdminPwd="admin",AdminIntro="好困",AdminTel="88888888"}
            };
            admins.ForEach(s => context.Admins.Add(s));
            context.SaveChanges();
        }
    }
}