namespace Common.Core.Modules
{
    /// <summary>
    /// 定义模块信息处理器
    /// </summary>
    public interface IModuleHandler
    {
        /// <summary>
        /// 从程序集中获取模块信息
        /// </summary>
        void Initialize();
    }
}