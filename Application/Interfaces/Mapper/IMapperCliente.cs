using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces.Mapper
{
    public interface IMapperCliente
    {
         Cliente MapperDtoToEntity (ClienteDto clienteDto);
         IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
         ClienteDto MapperEntityToDto(Cliente cliente);
    }
}