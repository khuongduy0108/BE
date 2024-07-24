using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Shop.Application.Mapping;
using Shop.Application.Services;
using Shop.Infrastructure.Modules;

namespace Shop.Application.Modules
{
    public static class ApplicationModules
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddInfrastructureModule();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IKhachHangService, KhachHangService>();
            services.AddScoped<IKhachSanService, KhachSanService>();
            services.AddScoped<ILoaiPhongService, LoaiPhongService>();
            services.AddScoped<IPhongService, PhongService>();
            services.AddScoped<IDatPhongService, DatPhongService>();

            // Thêm các services khác tại đây...

            return services;
        }
    }
}
