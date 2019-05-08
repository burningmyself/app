
using System;


namespace Common.CodeGenerator
{
    /// <summary>
    /// ����Ԫ���ݴ�����
    /// </summary>
    public interface ITypeMetadataHandler
    {
        /// <summary>
        /// ��ȡʵ�����Ԫ����
        /// </summary>
        /// <returns>Ԫ���ݼ���</returns>
        TypeMetadata[] GetEntityTypeMetadatas();

        /// <summary>
        /// ��ȡ����DTO���͵�Ԫ����
        /// </summary>
        /// <returns>Ԫ���ݼ���</returns>
        TypeMetadata[] GetInputDtoMetadatas();

        /// <summary>
        /// ��ȡ���DTO���͵�Ԫ����
        /// </summary>
        /// <returns>Ԫ���ݼ���</returns>
        TypeMetadata[] GetOutputDtoMetadata();

        /// <summary>
        /// ��ȡָ�����͵�Ԫ����
        /// </summary>
        /// <param name="type">����</param>
        /// <returns>Ԫ����</returns>
        TypeMetadata GetTypeMetadata(Type type);
    }
}