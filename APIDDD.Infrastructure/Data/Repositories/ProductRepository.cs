using APIDDD.Domain.Core.Interfaces;
using APIDDD.Domain.Entities;

namespace APIDDD.Infrastructure.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product> , IProductRepository
    {
        private readonly SqlContext _sqlContext;
        public ProductRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
