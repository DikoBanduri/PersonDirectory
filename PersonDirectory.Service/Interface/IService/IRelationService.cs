using PersonDirectory.DTO;

namespace PersonDirectory.Service.Interface.IService;

public interface IRelationService
{
    void UpdateRelation(Relation relation);
    void DeleteRelation(int relationId);
}
