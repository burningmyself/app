﻿namespace Common.Audits
{
    /// <summary>
    /// 表示实体审计操作类型
    /// </summary>
    public enum OperateType
    {
        /// <summary>
        /// 查询
        /// </summary>
        Query = 0,
        /// <summary>
        /// 新增
        /// </summary>
        Insert = 1,
        /// <summary>
        /// 更新
        /// </summary>
        Update = 2,
        /// <summary>
        /// 删除
        /// </summary>
        Delete = 3
    }
}