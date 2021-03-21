using Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;
        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }
    }
}