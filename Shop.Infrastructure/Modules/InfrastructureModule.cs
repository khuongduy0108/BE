using Microsoft.Extensions.DependencyInjection;
using Shop.Domain.Repositories;
using Shop.Infrastructure.Repositories;

namespace Shop.Infrastructure.Modules
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<IKhachHangRepo, KhachHangRepo>();
            services.AddScoped<IKhachSanRepo, KhachSanRepo>();
            services.AddScoped<ILoaiPhongRepo, LoaiPhongRepo>();
            services.AddScoped<IPhongRepo, PhongRepo>();
            services.AddScoped<IDatPhongRepo, DatPhongRepo>();


            return services;
        }
    }
}
