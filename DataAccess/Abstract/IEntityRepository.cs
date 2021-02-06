using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class: referans type(class demek değil)
    //IEntity: IEntity olabilir veya IEntity'i implemente eden bir nesne olabilir
    //new(): new'lenebilir nesne olmalıdır(IEntity olamaz çünkü interfacedir)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
