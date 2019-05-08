using System;
using System.Collections.Generic;
using System.Reflection;

using Common.Reflection;


namespace Common.CodeGenerator
{
    /// <summary>
    /// ����Ԫ����
    /// </summary>
    public class TypeMetadata
    {
        /// <summary>
        /// ��ʼ��һ��<see cref="TypeMetadata"/>���͵���ʵ��
        /// </summary>
        public TypeMetadata()
        { }

        /// <summary>
        /// ��ʼ��һ��<see cref="TypeMetadata"/>���͵���ʵ��
        /// </summary>
        public TypeMetadata(Type type)
        {
            if (type == null)
            {
                return;
            }

            Name = type.Name;
            FullName = type.FullName;
            Namespace = type.Namespace;
            Display = type.GetDescription().Replace("��Ϣ", "");
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                if (property.HasAttribute<IgnoreGenPropertyAttribute>())
                {
                    continue;
                }
                if (property.GetMethod.IsVirtual && !property.GetMethod.IsFinal)
                {
                    continue;
                }
                if (PropertyMetadatas == null)
                {
                    PropertyMetadatas = new List<PropertyMetadata>();
                }
                PropertyMetadatas.Add(new PropertyMetadata(property));
            }
        }

        /// <summary>
        /// ��ȡ������ ������
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ��ȡ������ ����ȫ��
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// ��ȡ������ �����ռ�
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// ��ȡ������ ������ʾ��
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// ��ȡ������ ����Ԫ���ݼ���
        /// </summary>
        public IList<PropertyMetadata> PropertyMetadatas { get; set; }
    }
}