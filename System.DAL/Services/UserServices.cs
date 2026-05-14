using HZY.Framework.DependencyInjection;
using System.Helper;
using System.Model.Entity;

namespace System.DAL
{
    public class UserServices:BaseService<UserEntity>, IScopedSelfDependency
    {
        public async Task<BaseResult<UserEntity>> LoginAsync(UserEntity entity)
        {
            BaseResult<UserEntity> result = new BaseResult<UserEntity>();
            var res = await DB.sqlSugarClient.Queryable<UserEntity>().Where(e => e.UserName == entity.UserName && e.UserPassword == entity.UserPassword).FirstAsync();
            if (res == null)
            {
                result.Status = SystemEnums.Result.Fail;
                result.Msg = "用户名或密码错误";
                return result;
            }
            result.Data = new List<UserEntity>() { res };
            return result;
        }
    }
}
