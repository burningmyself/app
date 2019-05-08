using System.Threading;
using System.Threading.Tasks;


namespace Common.Audits
{
    /// <summary>
    /// 定义Audit数据存储功能
    /// 注意：审计操作的记录不能和业务数据操作在同一事务中
    /// </summary>
    public interface IAuditStore
    {
        /// <summary>
        /// 设置保存审计数据
        /// </summary>
        /// <param name="operationEntry">操作审计数据</param>
        void Save(AuditOperationEntry operationEntry);

        /// <summary>
        /// 异步保存实体审计数据
        /// </summary>
        /// <param name="operationEntry">操作审计数据</param>
        /// <param name="cancelToken">异步取消标识</param>
        /// <returns></returns>
        Task SaveAsync(AuditOperationEntry operationEntry, CancellationToken cancelToken = default(CancellationToken));
    }
}