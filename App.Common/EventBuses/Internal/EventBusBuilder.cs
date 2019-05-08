using System;

using Microsoft.Extensions.DependencyInjection;

using Common.Dependency;


namespace Common.EventBuses.Internal
{
    /// <summary>
    /// EventBus初始化
    /// </summary>
    [Dependency(ServiceLifetime.Singleton, TryAdd = true)]
    internal class EventBusBuilder : IEventBusBuilder
    {
        private readonly IEventHandlerTypeFinder _typeFinder;
        private readonly IEventBus _eventBus;

        /// <summary>
        /// 初始化一个<see cref="EventBusBuilder"/>类型的新实例
        /// </summary>
        public EventBusBuilder(IEventHandlerTypeFinder typeFinder, IEventBus eventBus)
        {
            _typeFinder = typeFinder;
            _eventBus = eventBus;
        }

        /// <summary>
        /// 初始化EventBus
        /// </summary>
        public void Build()
        {
            Type[] types = _typeFinder.FindAll(true);
            if (types.Length == 0)
            {
                return;
            }
            _eventBus.SubscribeAll(types);
        }
    }
}