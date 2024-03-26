using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.IService;
using PersonDirectory.Service.Interface.Repository;

namespace PersonDirectory.Service.Interface;

public sealed class RelationService : IRelationService
{
    private readonly IUnitOfWork _unitOfWork;

    public RelationService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void UpdateRelation(Relation relation)
    {
        _unitOfWork.RelationRepository.Update(relation);
        _unitOfWork.SaveChanges();
    }

    public void DeleteRelation(int relationId)
    {
        var relation = _unitOfWork.RelationRepository.Get(relationId);
        relation.IsDelete = true;
        _unitOfWork.RelationRepository.Update(relation);
        _unitOfWork.SaveChanges();
    }
}
