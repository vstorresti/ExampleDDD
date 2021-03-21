using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;
using Infrastructure.CrossCutting.Interfaces;

namespace Infrastructure.CrossCutting.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        IEnumerable<ClienteDto> clientesDto = new List<ClienteDto>();

        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Email = clienteDto.Email
            }

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            throw new System.NotImplementedException();
        }
    }
}