using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperCliente
    {
         Cliente MapperDtoToEntity (ClienteDto clienteDto);
         IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
         ClienteDto MapperEntityToDto(Cliente cliente);
    }
}