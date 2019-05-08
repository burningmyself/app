using Common.Core.Packs;
using Common.EventBuses;


namespace Common.Audits
{
    /// <summary>
    /// 审计模块基类
    /// </summary>
    [DependsOnPacks(typeof(EventBusPack))]
    public abstract class AuditPackBase : OsharpPack
    {
        /// <summary>
        /// 获取 模块级别
        /// </summary>
        public override PackLevel Level => PackLevel.Application;
    }
}