using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Ecommerce.Core.Entities.Abstract;

namespace Ecommerce.Core.DataAccess.EntityFramework.Abstract;

public interface IRepositoryBase<TEntity>
    where TEntity : class, IEntity
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter=null);
    TEntity Get(Expression<Func<TEntity, bool>> filter);
}