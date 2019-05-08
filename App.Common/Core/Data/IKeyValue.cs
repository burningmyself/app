namespace Common.Core.Data
{
    /// <summary>
    /// 定义键值对数据
    /// </summary>
    public interface IKeyValue
    {
        /// <summary>
        /// 获取或设置 数据键
        /// </summary>
        string Key { get; set; }

        /// <summary>
        /// 获取或设置 数据值
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// 获取强类型数据值
        /// </summary>
        /// <typeparam name="T">要转换的目标类型</typeparam>
        /// <returns>目标类型值</returns>
        T GetValue<T>();
    }
}