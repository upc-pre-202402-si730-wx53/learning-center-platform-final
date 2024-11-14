using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Queries;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Repositories;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Services;

namespace ACME.LearningCenterPlatform.API.Publishing.Application.Internal.QueryServices;

public class CategoryQueryService(ICategoryRepository categoryRepository) : ICategoryQueryService
{
    /**
     * <summary>
     *     This method is responsible for handling GetCategoryByIdQuery
     * </summary>
     * <param name="query">GetCategoryByIdQuery>Contains the Id of the Category</param>
     * <returns>Category - The Category object</returns>
     */
    public async Task<Category?> Handle(GetCategoryByIdQuery query)
    {
        return await categoryRepository.FindByIdAsync(query.Id);
    }

    /**
     * <summary>
     *     This method is responsible for handling GetAllCategoriesQuery
     * </summary>
     * <param name="query">GetAllCategoriesQuery</param>
     * <returns>Category - The Category object</returns>
     */
    public async Task<IEnumerable<Category>> Handle(GetAllCategoriesQuery query)
    {
        return await categoryRepository.ListAsync();
    }
}