using System;
using System.Collections.Generic;
using Common.Core.Options;
using Common.Core.Packs;


namespace Common.Core.Builders
{
    /// <summary>
    /// 定义Common构建器
    /// </summary>
    public interface IOsharpBuilder
    {
        /// <summary>
        /// 获取 加载的模块集合
        /// </summary>
        IEnumerable<Type> AddPacks { get; }

        /// <summary>
        /// 获取 排除的模块集合
        /// </summary>
        IEnumerable<Type> ExceptPacks { get; }

        /// <summary>
        /// 获取 Common选项配置委托
        /// </summary>
        Action<OsharpOptions> OptionsAction { get; }

        /// <summary>
        /// 添加指定模块
        /// </summary>
        /// <typeparam name="TPack">要添加的模块类型</typeparam>
        IOsharpBuilder AddPack<TPack>() where TPack : OsharpPack;

        /// <summary>
        /// 排除指定模块
        /// </summary>
        /// <typeparam name="TPack"></typeparam>
        /// <returns></returns>
        IOsharpBuilder ExceptPack<TPack>() where TPack : OsharpPack;

        /// <summary>
        /// 添加Common选项配置
        /// </summary>
        /// <param name="optionsAction">Common操作选项</param>
        /// <returns>Common构建器</returns>
        IOsharpBuilder AddOptions(Action<OsharpOptions>optionsAction);
    }
}