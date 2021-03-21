using Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente _repositoryCliente;
        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }
    }
}