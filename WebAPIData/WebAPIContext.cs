using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.Entities;
using WebAPIData.Mappers;
using System.Data.Entity;
using WenAPIData.Migrations;


namespace WebAPIData
{
    /*
     * 1.把我们定义的POCO类作为DBSet的属性对外公开，这意味着每一个POCO类都将被转化为数据库中的表
       2.重写OnModelCreating方法将我们为POCO类自定义的映射规则添加到DbModelBuilder配置中
     * 
     */
    public class WebAPIContext : DbContext
    {
        public WebAPIContext()
            : base("WebAPIConnection")       
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;       //延时加载

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WebAPIContext, Configuration>());
            //为数据库配置初始化和迁移策略，如果模型的属性被改变（添加了新的属性），就把数据库迁移到最新版本。
        }

        public IDbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentMapper());

            base.OnModelCreating(modelBuilder);
        }
           
    }
}
