﻿using System.Data.Common;
using Abp.EntityFramework;
using System.Data.Entity;
using Lnice.User;
using Lnice.Music;
using System.Data.Entity.Validation;

namespace Lnice.EntityFramework
{
    public class LniceDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public virtual IDbSet<Log_Login> LogLogin { get; set; }
        public virtual IDbSet<UserInfo> UserInfo { get; set; }
        public virtual IDbSet<UserSecrecy> UserSecrecy { get; set; }
        public virtual IDbSet<SheetInfo> SheetInfo { get; set; }
        public virtual IDbSet<MusicInfo> MusicInfo { set; get; }
        public virtual IDbSet<Sheet_Music> Sheet_Music { get; set; }

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public LniceDbContext()
            : base("Default")
        {
        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in LniceDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of LniceDbContext since ABP automatically handles it.
         */
        public LniceDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
    }
}
