using System;


namespace Common.Core.Packs
{
    /// <summary>
    /// 定义Common模块依赖
    /// </summary>
    public class DependsOnPacksAttribute : Attribute
    {
        /// <summary>
        /// 初始化一个 Common模块依赖<see cref="DependsOnPacksAttribute"/>类型的新实例
        /// </summary>
        public DependsOnPacksAttribute(params Type[] dependedPackTypes)
        {
            DependedPackTypes = dependedPackTypes;
        }

        /// <summary>
        /// 获取 当前模块的依赖模块类型集合
        /// </summary>
        public Type[] DependedPackTypes { get; }
    }
}