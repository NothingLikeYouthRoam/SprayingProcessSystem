using HZY.Framework.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using SqlSugar;
using System.DAL;
using System.Model.Entity;
using System.Reflection;
using DbType = SqlSugar.DbType;

namespace SprayingProcessSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 创建服务容器
            var services = new ServiceCollection();
            //注册服务
            ConfigureService(services);
            //构建服务提供者
            var serviceProvider = services.BuildServiceProvider();
            Globals.serviceProvider = serviceProvider;
            ApplicationConfiguration.Initialize();
            var frmMain = serviceProvider.GetRequiredService<FrmMain>();
            var db = Globals.serviceProvider.GetRequiredService<ISqlSugarClient>();
#if DEBUG
            db.CodeFirst.SetStringDefaultLength(200).InitTables(
                typeof(AuthEntity), typeof(DataEntity), typeof(RecipeEntity), typeof(UserEntity));
#endif
            Application.Run(frmMain);
        }

        private static void ConfigureService(ServiceCollection services)
        {
            //注册依赖注入，通过程序集的某一个类自动注册程序集内的类，条件是该类实现了比如
            //ISingletonDependency之类的接口
            services.AddDependencyInjection(new List<Assembly>()
            {
                typeof(Program).Assembly,
                typeof(System.BLL.UserManager).Assembly,
                typeof(System.DAL.UserServices).Assembly
            });


            //注册json配置
            IConfigurationBuilder cfgBuilder = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json");

            //构建json配置
            IConfiguration configuration = cfgBuilder.Build();
            //注入json单例对象
            services.AddSingleton<IConfiguration>(configuration)
                .AddLogging(loggerBuilder => {
                    loggerBuilder.ClearProviders();//清除其他日志的提供者
                    loggerBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);//设置等级
                    loggerBuilder.AddNLog();
                });

            // 注册sqlsugar
            DbType dbType = Enum.Parse<DbType>(configuration["DbContexts:DbType"]);
            string connectionString = configuration[$"DbContexts:{dbType}:ConnectionString"];
            services.AddSqlSugarSetup(dbType, connectionString);

            //获取NLog配置信息
            var nlogConifg = configuration.GetSection("NLog");

            //设置Nlog配置
            LogManager.Configuration = new NLogLoggingConfiguration(nlogConifg);
        }
    }
}