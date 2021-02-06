using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

// CORE KATMANI DİĞER KATMANLARDAN REFERANS ALMAZ
namespace Core.DataAccess
{
    // generic constraint - t yi kısıtlandırarak sadece databese objelerini seçilecek şekilde ayarıyoruz
    // class : referans tip
    // IEntity veya IEntityden implemente olabilir
    // sona new yazdığımızda newlenemez anlamına geliyor. Dolayısı ile IEntitiy interface olduğu için newlenemez ve sadece database objelerini repository de kullanabiliriz
    public interface IEntityRepository <T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> Filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
