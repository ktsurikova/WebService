using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;

namespace DAL.Interface.Repository
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity GetById(Guid key);
        bool Insert(TEntity entity);
        bool Delete(TEntity entity);
        bool Update(TEntity entity);
    }
}
