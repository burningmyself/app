namespace Common.Core.Modules
{
    /// <summary>
    /// 定义模块信息提取器，从程序集中提取模块信息
    /// </summary>
    public interface IModuleInfoPicker
    {
        /// <summary>
        /// 从程序集收集模块信息
        /// </summary>
        /// <returns></returns>
        ModuleInfo[] Pickup();
    }
}