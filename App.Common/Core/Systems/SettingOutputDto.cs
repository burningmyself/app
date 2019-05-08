using Common.Reflection;


namespace Common.Core.Systems
{
    /// <summary>
    /// �������DTO
    /// </summary>
    public class SettingOutputDto
    {
        /// <summary>
        /// ��ʼ��һ��<see cref="SettingOutputDto"/>���͵���ʵ��
        /// </summary>
        public SettingOutputDto(ISetting setting)
        {
            Setting = setting;
            SettingTypeName = setting.GetType().GetFullNameWithModule();
        }

        /// <summary>
        /// ��ȡ ��������ȫ��
        /// </summary>
        public string SettingTypeName { get; }

        /// <summary>
        /// ��ȡ ������Ϣ
        /// </summary>
        public ISetting Setting { get; }
    }
}