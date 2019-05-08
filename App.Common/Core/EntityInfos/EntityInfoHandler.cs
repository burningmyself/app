using System;
using Microsoft.Extensions.DependencyInjection;
using Common.Dependency;


namespace Common.Core.EntityInfos
{
    /// <summary>
    /// 实体信息处理器
    /// </summary>
    [Dependency(ServiceLifetime.Singleton, TryAdd = true)]
    public class EntityInfoHandler : EntityInfoHandlerBase<EntityInfo, EntityInfoHandler>
    {
        /// <summary>
        /// 初始化一个<see cref="EntityInfoHandlerBase{TEntityInfo,TEntityInfoProvider}"/>类型的新实例
        /// </summary>
        public EntityInfoHandler(IServiceProvider serviceProvider)
            : base(serviceProvider)
        { }
    }
}