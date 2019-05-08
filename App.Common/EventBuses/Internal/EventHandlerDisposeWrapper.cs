using System;


namespace Common.EventBuses.Internal
{
    /// <summary>
    /// <see cref="IEventHandler"/>事件处理器的可释放包装
    /// </summary>
    public class EventHandlerDisposeWrapper : IDisposable
    {
        private readonly Action _disposeAction;

        /// <summary>
        /// 初始化一个<see cref="EventHandlerDisposeWrapper"/>类型的新实例
        /// </summary>
        public EventHandlerDisposeWrapper(IEventHandler eventHandler, Action disposeAction = null)
        {
            _disposeAction = disposeAction;
            EventHandler = eventHandler;
        }

        /// <summary>
        /// 获取或设置 事件处理器对象
        /// </summary>
        public IEventHandler EventHandler { get; set; }

        /// <summary>释放资源.</summary>
        public void Dispose()
        {
            _disposeAction?.Invoke();
        }
    }
}