using System;
using System.Linq.Expressions;


namespace Common.Filter
{
    /// <summary>
    /// ���ݹ�����չ����
    /// </summary>
    public static class FilterExtensions
    {
        /// <summary>
        /// ��������ת��Ϊ��ѯ���ʽ
        /// </summary>
        [Obsolete("ʹ�� IFilterService ������棬���ཫ��1.0�汾���Ƴ�")]
        public static Expression<Func<TEntity, bool>> ToExpression<TEntity>(this FilterGroup group)
        {
            return FilterHelper.GetExpression<TEntity>(group);
        }

        /// <summary>
        /// ������ת��Ϊ��ѯ���ʽ
        /// </summary>
        [Obsolete("ʹ�� IFilterService ������棬���ཫ��1.0�汾���Ƴ�")]
        public static Expression<Func<TEntity, bool>> ToExpression<TEntity>(this FilterRule rule)
        {
            return FilterHelper.GetExpression<TEntity>(rule);
        }
    }
}