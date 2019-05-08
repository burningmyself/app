using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Common.Caching;
using Common.Core.Options;
using Common.Entity;
using Common.Filter;


namespace Common.Core.Packs
{
    /// <summary>
    /// Common核心模块
    /// </summary>
    [Description("Common核心模块")]
    public class OsharpCorePack : OsharpPack
    {
        /// <summary>
        /// 获取 模块级别
        /// </summary>
        public override PackLevel Level => PackLevel.Core;

        /// <summary>
        /// 将模块服务添加到依赖注入服务容器中
        /// </summary>
        /// <param name="services">依赖注入服务容器</param>
        /// <returns></returns>
        public override IServiceCollection AddServices(IServiceCollection services)
        {
            services.TryAddSingleton<IConfigureOptions<OsharpOptions>, OsharpOptionsSetup>();
            services.TryAddSingleton<IEntityTypeFinder, EntityTypeFinder>();
            services.TryAddSingleton<IInputDtoTypeFinder, InputDtoTypeFinder>();
            services.TryAddSingleton<IOutputDtoTypeFinder, OutputDtoTypeFinder>();

            services.TryAddSingleton<ICacheService, CacheService>();
            services.TryAddScoped<IFilterService, FilterService>();

            return services;
        }
    }
}