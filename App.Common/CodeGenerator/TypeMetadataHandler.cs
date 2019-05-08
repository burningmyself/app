using System;
using System.Linq;
using Common.Entity;
using Common.Reflection;


namespace Common.CodeGenerator
{
    /// <summary>
    /// ����Ԫ���ݴ�����
    /// </summary>
    public class TypeMetadataHandler : ITypeMetadataHandler
    {
        private readonly IEntityTypeFinder _entityTypeFinder;
        private readonly IInputDtoTypeFinder _inputDtoTypeFinder;
        private readonly IOutputDtoTypeFinder _outputDtoTypeFinder;

        /// <summary>
        /// ��ʼ��һ��<see cref="TypeMetadataHandler"/>���͵���ʵ��
        /// </summary>
        public TypeMetadataHandler(IEntityTypeFinder entityTypeFinder,
            IInputDtoTypeFinder inputDtoTypeFinder,
            IOutputDtoTypeFinder outputDtoTypeFinder)
        {
            _entityTypeFinder = entityTypeFinder;
            _inputDtoTypeFinder = inputDtoTypeFinder;
            _outputDtoTypeFinder = outputDtoTypeFinder;
        }

        /// <summary>
        /// ��ȡʵ�����Ԫ����
        /// </summary>
        /// <returns>Ԫ���ݼ���</returns>
        public TypeMetadata[] GetEntityTypeMetadatas()
        {
            Type[] entityTypes = _entityTypeFinder.Find(m => !m.HasAttribute<IgnoreGenTypeAttribute>());
            return entityTypes.OrderBy(m => m.FullName).Select(m => new TypeMetadata(m)).ToArray();
        }

        /// <summary>
        /// ��ȡ����DTO���͵�Ԫ����
        /// </summary>
        /// <returns>Ԫ���ݼ���</returns>
        public TypeMetadata[] GetInputDtoMetadatas()
        {
            Type[] inputDtoTypes = _inputDtoTypeFinder.Find(m => !m.HasAttribute<IgnoreGenTypeAttribute>());
            return inputDtoTypes.OrderBy(m => m.FullName).Select(m => new TypeMetadata(m)).ToArray();
        }

        /// <summary>
        /// ��ȡ���DTO���͵�Ԫ����
        /// </summary>
        /// <returns>Ԫ���ݼ���</returns>
        public TypeMetadata[] GetOutputDtoMetadata()
        {
            Type[] outDtoTypes = _outputDtoTypeFinder.Find(m => !m.HasAttribute<IgnoreGenTypeAttribute>());
            return outDtoTypes.OrderBy(m => m.FullName).Select(m => new TypeMetadata(m)).ToArray();
        }

        /// <summary>
        /// ��ȡָ�����͵�Ԫ����
        /// </summary>
        /// <param name="type">����</param>
        /// <returns>Ԫ����</returns>
        public TypeMetadata GetTypeMetadata(Type type)
        {
            if (type == null)
            {
                return null;
            }
            return new TypeMetadata(type);
        }
    }
}