using Core.Interfaces;
using Core.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;


namespace Core
{
    public static class ServiceExtension
    {
        public static void AddCustomService(this IServiceCollection service)
        {
            service.AddScoped<IAccountService, AccountService>(); 
            service.AddScoped<ICategoryService, CategoryService>();
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IImageService, ImageService>();
            service.AddScoped<IFilesService, FilesService>();
            service.AddScoped<IStorageService, StorageService>();
            service.AddScoped<IImageService, ImageService>();
            service.AddScoped<IImageForHomeService, ImageForHomeService>();
            service.AddScoped<IInfoService, InfoService>();
            service.AddScoped<IBagService, BagService>();
            service.AddScoped<IBagItemsService, BagItemsService>();

        }
        public static void AddValidator(this IServiceCollection service)
        {
            service.AddFluentValidationAutoValidation();

            service.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

        }
        public static void AddAutoMapper(this IServiceCollection service)
        {
            service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
