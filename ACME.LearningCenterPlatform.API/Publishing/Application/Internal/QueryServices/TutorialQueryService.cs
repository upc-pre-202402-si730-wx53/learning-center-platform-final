using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Queries;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Repositories;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Services;

namespace ACME.LearningCenterPlatform.API.Publishing.Application.Internal.QueryServices;

public class TutorialQueryService(ITutorialRepository tutorialRepository) : ITutorialQueryService
{
    /**
     * <summary>
     *     This method is responsible for handling GetTutorialByIdentifierQuery
     * </summary>
     * <param name="query">GetTutorialByIdentifierQuery>Contains the Id of the Tutorial</param>
     * <returns>Tutorial - The Tutorial object</returns>
     */
    public async Task<Tutorial?> Handle(GetTutorialByIdQuery query)
    {
        return await tutorialRepository.FindByIdAsync(query.TutorialId);
    }

    /**
     * <summary>
     *     This method is responsible for handling GetAllTutorialsQuery
     * </summary>
     * <param name="query">GetAllTutorialsQuery</param>
     * <returns>IEnumerable of Tutorials - The list of Tutorial objects</returns>
     */
    public async Task<IEnumerable<Tutorial>> Handle(GetAllTutorialsQuery query)
    {
        return await tutorialRepository.ListAsync();
    }
    
    /**
     * <summary>
     *     This method is responsible for handling GetAllTutorialsByCategoryIdQuery
     * </summary>
     * <param name="query">GetAllTutorialsByCategoryIdQuery</param>
     * <returns>IEnumerable of Tutorials - The list of Tutorial objects</returns>
     */
    public async Task<IEnumerable<Tutorial>> Handle(GetAllTutorialsByCategoryIdQuery query)
    {
        return await tutorialRepository.FindByCategoryIdAsync(query.CategoryId);
    }
}