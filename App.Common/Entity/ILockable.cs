﻿namespace Common.Entity
{
    /// <summary>
    /// 定义可锁定功能
    /// </summary>
    public interface ILockable
    {
        /// <summary>
        /// 获取或设置 是否锁定当前信息
        /// </summary>
        bool IsLocked { get; set; }
    }
}