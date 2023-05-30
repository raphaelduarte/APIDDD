using APIDDD.Domain.Core.Interfaces;
using APIDDD.Domain.Entities;

namespace APIDDD.Infrastructure.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer> , ICustomerRepository
    {
        private readonly SqlContext _sqlContext;

        public CustomerRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
