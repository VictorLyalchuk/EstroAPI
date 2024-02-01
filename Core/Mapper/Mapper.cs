using Core.DTOs.Filter;
using Core.DTOs.Information;
using Core.DTOs.Site;
using Core.DTOs.User;
using Core.Entities.DashBoard;
using Core.Entities.Information;
using Core.Entities.Site;
using System.Linq;

namespace Core.Mapper
{
    public class Mapper : AutoMapper.Profile
    {
        public Mapper()
        {
            CreateMap<UserLoginDTO, User>();
            CreateMap<UserEditDTO, User>().ReverseMap();


            CreateMap<MainCategoryDTO, MainCategory>().ReverseMap();
            CreateMap<SubCategoryDTO, SubCategory>().ReverseMap();
            CreateMap<CategoryDTO, Category>().ReverseMap();
            CreateMap<CategoryDTO, Category>()
                .ForMember(dest => dest.SubCategory, opt => opt.MapFrom(src => new SubCategory { Id = src.MainCategoryId.GetValueOrDefault() }));
            
            CreateMap<ProductDTO, Product>();
            CreateMap<CreateProductDTO, Product>();
            CreateMap<EditProductDTO, Product>();
            CreateMap<Product, ProductDTO>().ForMember(dto => dto.ImagesPath, opt => opt.MapFrom(o => o.Images.Select(a => a.ImagePath)));
            CreateMap<Product, ProductDTO>()
                        .ForMember(dest => dest.URLCategoryName, opt => opt.MapFrom(src => src.Category.URLName))
                        .ForMember(dest => dest.URLSubCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.URLName))
                        .ForMember(dest => dest.SubCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.Name))
                        .ForMember(dest => dest.URLMainCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.MainCategory.URLName))
                        .ForMember(dest => dest.MainCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.MainCategory.Name));
            
            CreateMap<StorageDTO, Storage>().ReverseMap();
            
            CreateMap<ImageDTO, Image>().ReverseMap();
            CreateMap<ImageForHomeDTO, ImageForHome>();

            CreateMap<OptionsDTO, Options>();
            CreateMap<InfoDTO, Info>();
            CreateMap<BagDTO, Bag>().ReverseMap();
            CreateMap<BagUserDTO, Bag>().ReverseMap();
            CreateMap<BagItemsDTO, BagItems>().ReverseMap();

            CreateMap<BagItems, BagItemsDTO>()
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Product.Name))
                        .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Product.Price))
                        .ForMember(dest => dest.Article, opt => opt.MapFrom(src => src.Product.Article))
                        .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Product.Images.FirstOrDefault().ImagePath));

       
        }
    }
}
