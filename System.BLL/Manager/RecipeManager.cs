using HZY.Framework.DependencyInjection;
using Mapster;
using System.DAL;
using System.Helper;
using System.Model.Entity;

namespace System.BLL.Manager
{

    public class RecipeManager : IScopedSelfDependency
    {
        private readonly RecipeService _recipeService;

        public RecipeManager(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public async Task<BaseResult> AddRecipeAsync(AddRecipeDto request)
        {
            var isExist = await _recipeService.ExistAsync(e => e.产品类型 == request.产品类型);
            if (isExist)
            {
                return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = "产品类型已存在" };
            }
            var entity = request.Adapt<RecipeEntity>();
            var res = await _recipeService.InsertAsync(entity);
            if (res>0)
            {
                return new BaseResult() { Status = SystemEnums.Result.Success };
            }
            return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = "添加失败" };
        }

        public async Task<BaseResult> UpdateRecipeAsync(UpdateRecipeDto request)
        {
            var result = await _recipeService.ExistAsync(e => e.Id != request.Id && e.产品类型 == request.产品类型);
            if (result){
                return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = "该配方已存在！" };
            }
            var entity = request.Adapt<RecipeEntity>();
            var res = await _recipeService.UpdateAsync(entity);
            if (res)
            {
                return new BaseResult() { Status = SystemEnums.Result.Success };
            }
            return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = "修改失败" };
        }

        public async Task<BaseResult> DeleteRecipeAsync(DelRecipeDto request)
        {
            var entity = request.Adapt<RecipeEntity>();
            var res = await _recipeService.DeletAsync(entity);
            if (res)
            {
                return new BaseResult() { Status = SystemEnums.Result.Success };
            }
            return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = "删除失败" };
        }

        public async Task<BaseResult<QueryRecipeResultDto>> GetRecipeListAsync()
        {
            var res = await _recipeService.GetListAsync(c => true);
            var dtos = res.Adapt<List<QueryRecipeResultDto>>();
            return new BaseResult<QueryRecipeResultDto>() { Status = SystemEnums.Result.Success, Data = dtos };
        }

        public async Task<BaseResult<QueryRecipeResultDto>> GetRecipeAsyncById(GetRecipeByIdDto request)
        {
            var res = await _recipeService.GetByOneAsync(c => c.Id == request.Id);
            var dtos = res.Adapt<QueryRecipeResultDto>();
            return new BaseResult<QueryRecipeResultDto>() { Status = SystemEnums.Result.Success, Data = new List<QueryRecipeResultDto>() { dtos } };
        }
    }
}
