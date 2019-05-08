using System;
using System.ComponentModel;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using Common.Core.Packs;
using Common.Dependency;


namespace Common.EventBuses
{
    /// <summary>
    /// 事件总线模块
    /// </summary>
    [Description("事件总线模块")]
    public class EventBusPack : OsharpPack
    {
        /// <summary>
        /// 获取 模块级别
        /// </summary>
        public override PackLevel Level => PackLevel.Core;

        /// <summary>
        /// 获取 模块启动顺序，模块启动的顺序先按级别启动，级别内部再按此顺序启动
        /// </summary>
        public override int Order => 2;

        /// <summary>
        /// 将模块服务添加到依赖注入服务容器中
        /// </summary>
        /// <param name="services">依赖注入服务容器</param>
        /// <returns></returns>
        public override IServiceCollection AddServices(IServiceCollection services)
        {
            IEventHandlerTypeFinder handlerTypeFinder =
                services.GetOrAddTypeFinder<IEventHandlerTypeFinder>(assemblyFinder => new EventHandlerTypeFinder(assemblyFinder));
            //向服务窗口注册所有事件处理器类型
            Type[] eventHandlerTypes = handlerTypeFinder.FindAll();
            foreach (Type handlerType in eventHandlerTypes)
            {
                services.TryAddTransient(handlerType);
            }

            return services;
        }

        /// <summary>
        /// 应用模块服务
        /// </summary>
        /// <param name="provider">服务提供者</param>
        public override void UsePack(IServiceProvider provider)
        {
            IEventBusBuilder builder = provider.GetService<IEventBusBuilder>();
            builder.Build();
            IsEnabled = true;
        }
    }
}