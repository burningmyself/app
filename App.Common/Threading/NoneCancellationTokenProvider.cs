using System.Threading;

using Microsoft.Extensions.DependencyInjection;

using Common.Dependency;


namespace Common.Threading
{
    /// <summary>
    /// 默认的异步任务取消标识提供者空实现
    /// </summary>
    [Dependency(ServiceLifetime.Singleton, TryAdd = true)]
    public class NoneCancellationTokenProvider : ICancellationTokenProvider
    {
        /// <summary>
        /// 获取 异步任务取消标识
        /// </summary>
        public CancellationToken Token { get; } = CancellationToken.None;
    }
}