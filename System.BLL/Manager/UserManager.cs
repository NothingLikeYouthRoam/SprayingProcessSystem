using HZY.Framework.DependencyInjection;
using Mapster;
using System.DAL;
using System.Helper;
using System.Model.Entity;

namespace System.BLL
{
    public class UserManager:IScopedSelfDependency
    {
        private readonly UserServices _userService;

        public UserManager(UserServices userService)
        {
            _userService = userService;
        }

        public async Task<BaseResult<UserEntity>> LoginAsync(UserLoginDto request)
        {
            var entity = request.Adapt<UserEntity>();
            var res = await _userService.LoginAsync(entity);
            if (res.Status == SystemEnums.Result.Fail)
            {
                return new BaseResult<UserEntity>() { Status = SystemEnums.Result.Fail, Msg = res.Msg };
            }
            return res;
        }

        public async Task<BaseResult> IsUserNameExistAsync(UserExistDto request)
        {
            var entity = request.Adapt<UserEntity>();
            var res = await _userService.ExistAsync(e => e.UserName == entity.UserName);
            if (!res)
            {
                return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = "用户名不存在" };
            }
            return new BaseResult() { Status = SystemEnums.Result.Success };
        }

        public async Task<BaseResult> AddUserAsync(UserAddDto request)
        {
            var isExistRes = await IsUserNameExistAsync(new UserExistDto() { UserName = request.UserName });
            if (isExistRes.Status == SystemEnums.Result.Success)
            {
                return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = "用户名已存在！" };
            }
            var entity = request.Adapt<UserEntity>();
            var res = await _userService.InsertAsync(entity);
            if (res == 0)
            {
                return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = $"添加{entity.UserName}失败！" };
            }
            return new BaseResult() { Status = SystemEnums.Result.Success };
        }

        public async Task<BaseResult> UpdateUserAsync(UserUpdateDto request)
        {
            var isExsit = await _userService.ExistAsync(e => e.UserName == request.UserName && e.Id != request.Id);
            if (isExsit)
            {
                return new BaseResult()
                {
                    Status = SystemEnums.Result.Fail,
                    Msg = "用户名已存在"
                };
            }
            var entity = request.Adapt<UserEntity>();
            var res = await _userService.UpdateAsync(entity);
            if (!res)
            {
                return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = $"修改{entity.UserName}失败" };
            }
            return new BaseResult() { Status = SystemEnums.Result.Success };
        }

        public async Task<BaseResult> DeleteUserAsync(UserDeleteDto request)
        {
            var entity = request.Adapt<UserEntity>();
            var res = await _userService.DeletAsync(entity);
            if (!res)
            {
                return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = $"删除用户{entity.UserName}失败" };
            }
            return new BaseResult() { Status = SystemEnums.Result.Success };
        }

        public async Task<BaseResult<QueryUserResultDto>> GetUserListAsync()
        {
            var res = await _userService.GetListAsync(c => true);
            var dtos = res.Adapt<List<QueryUserResultDto>>();
            return new BaseResult<QueryUserResultDto>() { Status = SystemEnums.Result.Success, Data = dtos };
        }

        public async Task<BaseResult<QueryUserResultDto>> GetUserAuthAsync(QueryUserAuthDto request)
        {
            var isExist = await IsUserNameExistAsync(new UserExistDto { UserName = request.UserName });
            if (isExist.Status == SystemEnums.Result.Fail)
            {
                return new BaseResult<QueryUserResultDto>() { Status = SystemEnums.Result.Fail, Msg = "用户不存在" };
            }
            var res = await _userService.GetByOneAsync(c => c.UserName == request.UserName);
            return new BaseResult<QueryUserResultDto>() { 
                Status = SystemEnums.Result.Success, 
                Data = new List<QueryUserResultDto>() { 
                    res.Adapt<QueryUserResultDto>() 
                } 
            };
        }
    }
}
