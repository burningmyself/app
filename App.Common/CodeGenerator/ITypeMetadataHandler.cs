
using System;


namespace Common.CodeGenerator
{
    /// <summary>
    /// 类型元数据处理器
    /// </summary>
    public interface ITypeMetadataHandler
    {
        /// <summary>
        /// 获取实体类的元数据
        /// </summary>
        /// <returns>元数据集合</returns>
        TypeMetadata[] GetEntityTypeMetadatas();

        /// <summary>
        /// 获取输入DTO类型的元数据
        /// </summary>
        /// <returns>元数据集合</returns>
        TypeMetadata[] GetInputDtoMetadatas();

        /// <summary>
        /// 获取输出DTO类型的元数据
        /// </summary>
        /// <returns>元数据集合</returns>
        TypeMetadata[] GetOutputDtoMetadata();

        /// <summary>
        /// 获取指定类型的元数据
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns>元数据</returns>
        TypeMetadata GetTypeMetadata(Type type);
    }
}