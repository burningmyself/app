using Common.Reflection;


namespace Common.Core.Systems
{
    /// <summary>
    /// 设置输出DTO
    /// </summary>
    public class SettingOutputDto
    {
        /// <summary>
        /// 初始化一个<see cref="SettingOutputDto"/>类型的新实例
        /// </summary>
        public SettingOutputDto(ISetting setting)
        {
            Setting = setting;
            SettingTypeName = setting.GetType().GetFullNameWithModule();
        }

        /// <summary>
        /// 获取 设置类型全名
        /// </summary>
        public string SettingTypeName { get; }

        /// <summary>
        /// 获取 设置信息
        /// </summary>
        public ISetting Setting { get; }
    }
}