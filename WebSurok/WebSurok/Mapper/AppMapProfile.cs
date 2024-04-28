using AutoMapper;
using WebSurok.Data.Entities;
using WebSurok.Models.Categories;

namespace WebSurok.Mapper
{
    public class AppMapProfile : Profile
    {
        public AppMapProfile()
        {
            CreateMap<CategoryEntity, CategoryItemViewModel>();
        }
    }
}
