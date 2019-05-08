using System.Threading;


namespace Common.Threading
{
    /// <summary>
    /// 定义异步任务取消标识提供器
    /// </summary>
    public interface ICancellationTokenProvider
    {
        /// <summary>
        /// 获取 异步任务取消标识
        /// </summary>
        CancellationToken Token { get; }
    }
}