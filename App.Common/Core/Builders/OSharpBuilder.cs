using System;
using System.Collections.Generic;
using System.Linq;
using Common.Collections;
using Common.Core.Options;
using Common.Core.Packs;
using Common.Data;


namespace Common.Core.Builders
{
    /// <summary>
    /// Common构建器
    /// </summary>
    public class OsharpBuilder : IOsharpBuilder
    {
        /// <summary>
        /// 初始化一个<see cref="OsharpBuilder"/>类型的新实例
        /// </summary>
        public OsharpBuilder()
        {
            AddPacks = new List<Type>();
            ExceptPacks = new List<Type>();
        }

        /// <summary>
        /// 获取 加载的模块集合
        /// </summary>
        public IEnumerable<Type> AddPacks { get; private set; }

        /// <summary>
        /// 获取 排除的模块集合
        /// </summary>
        public IEnumerable<Type> ExceptPacks { get; private set; }

        /// <summary>
        /// 获取 Common选项配置委托
        /// </summary>
        public Action<OsharpOptions> OptionsAction { get; private set; }

        /// <summary>
        /// 添加指定模块，执行此功能后将仅加载指定的模块
        /// </summary>
        /// <typeparam name="TPack">要添加的模块类型</typeparam>
        public IOsharpBuilder AddPack<TPack>() where TPack : OsharpPack
        {
            List<Type> list = AddPacks.ToList();
            list.AddIfNotExist(typeof(TPack));
            AddPacks = list;
            return this;
        }

        /// <summary>
        /// 移除指定模块，执行此功能以从自动加载的模块中排除指定模块
        /// </summary>
        /// <typeparam name="TPack"></typeparam>
        /// <returns></returns>
        public IOsharpBuilder ExceptPack<TPack>() where TPack : OsharpPack
        {
            List<Type> list = ExceptPacks.ToList();
            list.AddIfNotExist(typeof(TPack));
            ExceptPacks = list;
            return this;
        }

        /// <summary>
        /// 添加Common选项配置
        /// </summary>
        /// <param name="optionsAction">Common操作选项</param>
        /// <returns>Common构建器</returns>
        public IOsharpBuilder AddOptions(Action<OsharpOptions> optionsAction)
        {
            Check.NotNull(optionsAction, nameof(optionsAction));
            OptionsAction = optionsAction;
            return this;
        }
    }
}