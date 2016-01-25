using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.MVC.ViewModels;

namespace ProjetoDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>().ReverseMap();
            Mapper.CreateMap<ProdutoViewModel, Produto>().ReverseMap();
        }
    }
}