using APIDDD.Domain.Core.Interfaces;
using APIDDD.Domain.Core.Services;

namespace APIDDD.Domain.Services
{
    public class BaseService<TEntity>   : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();

        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
