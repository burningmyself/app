
namespace Common.Caching
{
    /// <summary>
    /// 定义缓存键生成功能
    /// </summary>
    public interface ICacheKeyGenerator
    {
        /// <summary>
        /// 生成缓存键
        /// </summary>
        /// <param name="args">参数</param>
        /// <returns></returns>
        string GetKey(params object[] args);
    }
}