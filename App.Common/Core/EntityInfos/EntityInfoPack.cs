using System;
using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Common.Core.Packs;


namespace Common.Core.EntityInfos
{
    /// <summary>
    /// 实体信息模块
    /// </summary>
    [Description("数据实体模块")]
    public class EntityInfoPack : OsharpPack
    {
        /// <summary>
        /// 获取 模块级别
        /// </summary>
        public override PackLevel Level => PackLevel.Application;

        /// <summary>
        /// 应用模块服务
        /// </summary>
        /// <param name="provider">服务提供者</param>
        public override void UsePack(IServiceProvider provider)
        {
            IEntityInfoHandler handler = provider.GetService<IEntityInfoHandler>();
            handler.Initialize();
            IsEnabled = true;
        }
    }
}