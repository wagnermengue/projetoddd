using AutoMapper;
using ProjetoDDD.MVC.ViewModels;

namespace ProjetoDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
                {
                    x.AddProfile<ViewModelToDomainMappingProfile>();
                    x.AddProfile<DomainToViewModelMappingProfile>();
                }
            );
        }
    }
}