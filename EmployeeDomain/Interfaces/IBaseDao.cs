using System;
namespace Domain.Models
{
    interface IBaseDao<TEntity, TIdentifier>
        where TEntity : BaseVo<TIdentifier>
        where TIdentifier : new()
    {
        TIdentifier Create(TEntity entity);
        void Delete(TEntity entity);
        void DeleteById(TIdentifier entityIdentifier);
        System.Collections.Generic.IList<TEntity> LoadAll();
        TEntity LoadById(TIdentifier id);
        void SaveOrUpdate(TEntity entity);
        void Update(TEntity entity);
    }
}
