using System.ComponentModel.DataAnnotations;


namespace Common.Core.Systems
{
    /// <summary>
    /// ������Ϣ����DTO
    /// </summary>
    public class SettingInputDto
    {
        /// <summary>
        /// ��ȡ������ ��������ȫ��
        /// </summary>
        [Required]
        public string SettingTypeName { get; set; }

        /// <summary>
        /// ��ȡ������ ����ģ��JSON
        /// </summary>
        public string SettingJson { get; set; }
    }
}