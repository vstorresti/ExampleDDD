using System.Collections.Generic;
using System.Linq;
using Application.DTOs;
using Domain.Entities;
using Application.Interfaces.Mapper;

namespace Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {

        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Email = clienteDto.Email
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c =>
                new ClienteDto
                {
                    Id = c.Id,
                    Nome = c.Nome,
                    Sobrenome = c.Sobrenome,
                    Email = c.Email
                }
            );

            return dto;
        }
    }
}