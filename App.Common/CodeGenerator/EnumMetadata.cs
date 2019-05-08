using System;

using Common.Extensions;


namespace Common.CodeGenerator
{
    /// <summary>
    /// ö������Ԫ����
    /// </summary>
    public class EnumMetadata
    {
        /// <summary>
        /// ��ʼ��һ��<see cref="EnumMetadata"/>���͵���ʵ��
        /// </summary>
        public EnumMetadata()
        { }

        /// <summary>
        /// ��ʼ��һ��<see cref="EnumMetadata"/>���͵���ʵ��
        /// </summary>
        public EnumMetadata(Enum enumItem)
        {
            if (enumItem == null)
            {
                return;
            }
            Value = enumItem.CastTo<int>();
            Name = enumItem.ToString();
            Display = enumItem.ToDescription();
        }

        /// <summary>
        /// ��ȡ������ ö��ֵ
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// ��ȡ������ ö����
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ��ȡ������ ��ʾ����
        /// </summary>
        public string Display { get; set; }
    }
}