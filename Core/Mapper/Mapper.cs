using Core.DTOs.Filter;
using Core.DTOs.Site;
using Core.DTOs.User;
using Core.Entities.DashBoard;
using Core.Entities.Info;
using Core.Entities.Site;

namespace Core.Mapper
{
    public class Mapper : AutoMapper.Profile
    {
        public Mapper()
        {
            CreateMap<UserLoginDTO, User>();
            CreateMap<MainCategoryDTO, MainCategory>().ReverseMap();
            CreateMap<SubCategoryDTO, SubCategory>().ReverseMap();
            CreateMap<CategoryDTO, Category>().ReverseMap();
            CreateMap<ProductDTO, Product>();
            CreateMap<CreateProductDTO, Product>();
            CreateMap<EditProductDTO, Product>();
            CreateMap<StorageDTO, Storage>().ReverseMap();
            CreateMap<ImageDTO, Image>().ReverseMap();
            CreateMap<ImageForHomeDTO, ImageForHome>();
            CreateMap<CategoryDTO, Category>()
                .ForMember(dest => dest.SubCategory, opt => opt.MapFrom(src => new SubCategory { Id = src.MainCategoryId.GetValueOrDefault() }));


            CreateMap<Product, ProductDTO>().ForMember(dto => dto.ImagesPath, opt => opt.MapFrom(o => o.Images.Select(a => a.ImagePath)));

            CreateMap<Product, ProductDTO>()
                        .ForMember(dest => dest.URLCategoryName, opt => opt.MapFrom(src => src.Category.URLName))
                        .ForMember(dest => dest.URLSubCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.URLName))
                        .ForMember(dest => dest.URLMainCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.MainCategory.URLName));

            CreateMap<OptionsDTO, Options>();
            CreateMap<InfoDTO, Info>();
            CreateMap<UserEditDTO, User>().ReverseMap();
        }
    }
}
