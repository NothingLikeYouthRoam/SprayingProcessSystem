using Microsoft.Extensions.DependencyInjection;
using SqlSugar;

namespace System.DAL
{
    public static class DB
    {
        public static ISqlSugarClient sqlSugarClient { get; set; }

        public static void AddSqlSugarSetup(this IServiceCollection services, SqlSugar.DbType dataType, string conn)
        {
            services.AddSingleton<ISqlSugarClient>(s =>
            {
                sqlSugarClient = new SqlSugarScope(new ConnectionConfig()
                {
                    DbType = dataType,
                    ConnectionString = conn,
                    IsAutoCloseConnection = true,
                });
                return sqlSugarClient;
            });
        }
    }
}
