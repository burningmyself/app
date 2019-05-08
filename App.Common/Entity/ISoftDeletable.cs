using System;


namespace Common.Entity
{
    /// <summary>
    /// 定义逻辑删除功能
    /// </summary>
    public interface ISoftDeletable
    {
        /// <summary>
        /// 获取或设置 数据逻辑删除时间，为null表示正常数据，有值表示已逻辑删除，同时删除时间每次不同也能保证索引唯一性
        /// </summary>
        DateTime? DeletedTime { get; set; }
    }
}