using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Generic Constraint --jenerik kısıt
    //aşağıda yazan class referans tip olabilir demek  
    //IEntity:IEntitiy veya IEntity yi implemente eden bir nesne olabilir
    public interface IEntityRepository<T>where T:class,IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
