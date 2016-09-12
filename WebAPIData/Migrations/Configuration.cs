namespace WenAPIData.Migrations
{
    using WebAPIData.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPIData.WebAPIContext>
    {
        public Configuration()
        {
            /**
           * 在构造函数中，我们设置AutomaticMigrationsEnabled 属性为true，
           * 那么就意味着EF会为我们自动迁移数据库而不考虑版本问题。
           * 同时我们把AutomaticMigrationDataLossAllowed属性也设为true但这样做在开发环境中是很危险的，
           * 因为如果这个属性设为false时，一旦数据库在自动迁移时发生数据丢失，那么就会抛出一个异常。
           * 
           * */
            AutomaticMigrationsEnabled = true;         
            this.AutomaticMigrationDataLossAllowed = true;            
        }

        protected override void Seed(WebAPIData.WebAPIContext context)
        {
            
        }
    }
}
