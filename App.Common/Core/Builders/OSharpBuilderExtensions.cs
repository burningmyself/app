using Common.Core.Packs;


namespace Common.Core.Builders
{
    /// <summary>
    /// ICommonBuilder扩展方法
    /// </summary>
    public static class OsharpBuilderExtensions
    {
        /// <summary>
        /// 添加CorePack
        /// </summary>
        public static IOsharpBuilder AddCorePack(this IOsharpBuilder builder)
        {
            return builder.AddPack<OsharpCorePack>();
        }
    }
}