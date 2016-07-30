using System.Collections.Generic;

namespace NetCoreShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        //void Update(T entity);
        //void Delete(T entity);
        //void Delete(Expression<Func<T, bool>> where);
        //T GetById(long id);
        //T GetById(string id);
        //T GetById(Guid id);
        //T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        //IQueryable<T> GetMany(Expression<Func<T, bool>> where);
        ////IPagedList<T> GetPage<TOrder>(Page page, Expression<Func<T, bool>> where, Expression<Func<T, TOrder>> order);
        //NetCoreShopContext GetDataContext();
        //bool CheckIfRecordExists(Expression<Func<T, bool>> where);
        //TResult Max<TResult>(Expression<Func<T, TResult>> where);
        //TResult Min<TResult>(Expression<Func<T, TResult>> where);
        //bool Any(Expression<Func<T, bool>> where);
        //int Count(Expression<Func<T, bool>> where);
        //T GetFirst(Expression<Func<T, bool>> where);
        //T GetFirstOrDefault(Expression<Func<T, bool>> where);
        //T GetSingle(Expression<Func<T, bool>> where);
        //T GetSingleOrDefault(Expression<Func<T, bool>> where);
        //IQueryable<T> GetWhere(Expression<Func<T, bool>> where);
        //void Detach(T entity);
        //T Create();
        //void ReLoad(T entity);
        //void ResetContext();
    }
}
