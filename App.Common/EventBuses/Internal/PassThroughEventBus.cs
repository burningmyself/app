using System;

using Microsoft.Extensions.DependencyInjection;

using Common.Dependency;


namespace Common.EventBuses.Internal
{
    /// <summary>
    /// 一个事件总线，当有消息被派发到消息总线时，消息总线将不做任何处理与路由，而是直接将消息推送到订阅方
    /// </summary>
    [Dependency(ServiceLifetime.Singleton, TryAdd = true)]
    internal class PassThroughEventBus : EventBusBase
    {
        /// <summary>
        /// 初始化一个<see cref="PassThroughEventBus"/>类型的新实例
        /// </summary>
        public PassThroughEventBus(IHybridServiceScopeFactory serviceScopeFactory, IServiceProvider serviceProvider)
            : base(serviceScopeFactory, serviceProvider)
        { }
    }
}