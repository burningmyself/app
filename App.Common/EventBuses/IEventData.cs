using System;


namespace Common.EventBuses
{
    /// <summary>
    /// 定义事件数据，所有事件都要实现该接口
    /// </summary>
    public interface IEventData
    {
        /// <summary>
        /// 获取 事件编号
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// 获取 事件发生的时间
        /// </summary>
        DateTime EventTime { get; }

        /// <summary>
        /// 获取或设置 事件源，触发事件的对象
        /// </summary>
        object EventSource { get; set; }
    }
}