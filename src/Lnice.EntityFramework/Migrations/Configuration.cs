using System.Data.Entity.Migrations;

namespace Lnice.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework.LniceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Lnice";
        }

        protected override void Seed(EntityFramework.LniceDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            context.MusicInfo.AddOrUpdate(new Music.MusicInfo() { Title = "—› æ“Ù¿÷", Artist = "demo", Album = "Maid", Url = "~/App_Data/musicurl/jq22com1.mp3" });
            context.UserInfo.AddOrUpdate(
                new User.UserInfo() { Name = "admin", Email = "admin@admin.com", Mobile = "1234567890", Gender = 1 },
                new User.UserInfo() { Name = "mumu", Email = "mumu@qq.com", Mobile = "", Gender = 2 }
                );
            context.UserSecrecy.AddOrUpdate(
                new User.UserSecrecy() { Uid = 1, Pwd = "26FF3DCBAD71BC5279A301A516C46DC7" },
                new User.UserSecrecy() { Uid = 2, Pwd = "26FF3DCBAD71BC5279A301A516C46DC7" }
                );
        }
    }
}
