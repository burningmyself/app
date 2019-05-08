using System;

using Common.Data;


namespace Common.Mapping
{
    /// <summary>
    /// 标注当前类型从源类型的Mapping映射关系
    /// </summary>
    public class MapFromAttribute : Attribute
    {
        /// <summary>
        /// 初始化一个<see cref="MapFromAttribute"/>类型的新实例
        /// </summary>
        public MapFromAttribute(params Type[] sourceTypes)
        {
            Check.NotNull(sourceTypes, nameof(sourceTypes));
            SourceTypes = sourceTypes;
        }

        /// <summary>
        /// 源类型
        /// </summary>
        public Type[] SourceTypes { get; }
    }
}