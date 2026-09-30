using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;

namespace RestApiModeloDDD.Application;

public class ApplicationServiceProduto : IApplicationServiceProduto
{
    private readonly IServiceProduto serviceProduto;
    private readonly IMapperProduto mapperProduto;
    
    public void Add(ProdutoDto produtoDto)
    {
        var produto = mapperProduto.MapperDtoToEntity(produtoDto);
        serviceProduto.Add(produto);
    }

    public void Update(ProdutoDto produtoDto)
    {
        var produto = mapperProduto.MapperDtoToEntity(produtoDto);
        serviceProduto.Update(produto);
    }

    public void Remove(ProdutoDto produtoDto)
    {
        var produto = mapperProduto.MapperDtoToEntity(produtoDto);
        serviceProduto.Remove(produto);
    }

    public IEnumerable<ProdutoDto> GetAll()
    {
        var produtos = serviceProduto.GetAll();
        return mapperProduto.MapperListProdutosDto(produtos);
    }

    public ProdutoDto GetById(int id)
    {
        var produto = serviceProduto.GetById(id);
        return mapperProduto.MapperEntityToDto(produto);
    }
}