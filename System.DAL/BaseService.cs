using System.Linq.Expressions;
using System.Model;

namespace System.DAL
{
    public class BaseService<T> where T:BaseEntity, new()
    {
        public virtual async Task<int> InsertAsync(T model)
        {
            var runsql = DB.sqlSugarClient.Insertable<T>(model);
            var rows = await runsql.ExecuteCommandAsync();
            return rows;
        }

        public virtual async Task<bool> UpdateAsync(T model)
        {
            var runsql = DB.sqlSugarClient.Updateable(model);
            var rows = await runsql.ExecuteCommandAsync();
            return rows > 0;
        }

        public virtual async Task<bool> DeletAsync(T model)
        {
            var runsql = DB.sqlSugarClient.Deleteable(model);
            var rows = await runsql.ExecuteCommandAsync();
            return rows > 0;
        }

        public virtual async Task<T> GetByOneAsync(Expression<Func<T, bool>> where)
        {
            var runsql = DB.sqlSugarClient.Queryable<T>().Where(where);
            return await runsql.FirstAsync();
        }

        public virtual async Task<List<T>> GetListAsync(Expression<Func<T, bool>> where)
        {
            var runsql = DB.sqlSugarClient.Queryable<T>().Where(where);
            return await runsql.ToListAsync();
        }

        public virtual async Task<bool> ExistAsync(Expression<Func<T, bool>> where)
        {
            return await DB.sqlSugarClient.Queryable<T>()
                .Where(where)
                .AnyAsync();
        }
    }
}
