using Core.Interfaces.Repositories;
using Domain.Entities;

namespace Infrastructure.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _sqlContext;
        public RepositoryCliente(SqlContext sqlContext) : base (sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}