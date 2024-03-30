

using System.Linq.Expressions;

namespace DAS.Application.Interfaces.IRepositories.General
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<R>> GetAll<R>(Expression<Func<T, R>> selector, Expression<Func<T, bool>> expression);
        Task<IEnumerable<R>> GetAllOther<R>(Expression<Func<R, bool>> expression) where R : class;
        Task<IEnumerable<R>> GetAllOther<R>() where R : class;
        Task<IEnumerable<T>> GetAll(int skip, int take);
        Task<IEnumerable<R>> GetAll<R>(Expression<Func<T, R>> selector);
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> MyGetAll();
        Task<IEnumerable<R>> GetAll<R>(Expression<Func<T, R>> selector, int skip, int take);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
        Task<IEnumerable<R>> Find<R>(Expression<Func<T, R>> selector, Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression, int skip, int take);
        Task<IEnumerable<R>> Find<R>(Expression<Func<T, R>> selector, Expression<Func<T, bool>> expression, int skip, int take);
        Task Add(T entity);
        Task<T> AddAndReturn(T entity);
        T RemoveAndReturn(T entitiy);
        void Remove(T entitiy);
        void Update(T entitiy);
        Task<T?> GetById(int Id);
        Task<T?> GetById(long Id);
        public List<T> Addlist(List<T> entity);


        Task BeginTransactionAsync(CancellationToken cancellationToken = default);
        Task CommitTransactionAsync(CancellationToken cancellationToken = default);
        Task<int> SaveChanges(CancellationToken cancellationToken = default);


        Task<(IEnumerable<T>, int Count)> GetAllWithPagination(Expression<Func<T, bool>> expression, string[] includes, int skip, int take);
        Task<T?> GetById(Expression<Func<T, bool>> expression, string[] includes);


    }

}
