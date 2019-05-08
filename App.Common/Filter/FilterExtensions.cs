using System;
using System.Linq.Expressions;


namespace Common.Filter
{
    /// <summary>
    /// 数据过滤扩展方法
    /// </summary>
    public static class FilterExtensions
    {
        /// <summary>
        /// 将条件组转换为查询表达式
        /// </summary>
        [Obsolete("使用 IFilterService 服务代替，此类将在1.0版本中移除")]
        public static Expression<Func<TEntity, bool>> ToExpression<TEntity>(this FilterGroup group)
        {
            return FilterHelper.GetExpression<TEntity>(group);
        }

        /// <summary>
        /// 将条件转换为查询表达式
        /// </summary>
        [Obsolete("使用 IFilterService 服务代替，此类将在1.0版本中移除")]
        public static Expression<Func<TEntity, bool>> ToExpression<TEntity>(this FilterRule rule)
        {
            return FilterHelper.GetExpression<TEntity>(rule);
        }
    }
}