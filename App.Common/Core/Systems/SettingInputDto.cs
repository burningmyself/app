using System.ComponentModel.DataAnnotations;


namespace Common.Core.Systems
{
    /// <summary>
    /// 设置信息输入DTO
    /// </summary>
    public class SettingInputDto
    {
        /// <summary>
        /// 获取或设置 设置类型全名
        /// </summary>
        [Required]
        public string SettingTypeName { get; set; }

        /// <summary>
        /// 获取或设置 设置模型JSON
        /// </summary>
        public string SettingJson { get; set; }
    }
}