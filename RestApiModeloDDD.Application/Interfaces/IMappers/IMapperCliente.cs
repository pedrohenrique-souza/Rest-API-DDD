using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;

public interface IMapperCliente
{
    Cliente MapperDtoToEntity(ClienteDto  clienteDto);
    IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
    
    ClienteDto MapperEntityToDto(Cliente cliente);
}