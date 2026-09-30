using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Mapper;

public class MapperCliente : IMapperCliente
{
    IEnumerable<ClienteDto> ClientesDto = new List<ClienteDto>();

    public Cliente MapperDtoToEntity(ClienteDto clienteDto)
    {
        var cliente = new Cliente()
        {
            Id = clienteDto.Id, Nome = clienteDto.Nome, Sobrenome = clienteDto.Sobrenome, Email = clienteDto.Email
        };
        return cliente;
    }

    public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
    {
        var dto = clientes.Select(c => new ClienteDto
            { Id = c.Id, Nome = c.Nome, Sobrenome = c.Sobrenome, Email = c.Email });
        
        return dto;
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
}