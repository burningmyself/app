using System;


//power by https://github.com/andrewlock/NetEscapades.Extensions.Logging
namespace Common.Logging.RollingFile.Internal
{
    /// <summary>
    /// 日志消息项
    /// </summary>
    public class LogMessageEntry
    {
        /// <summary>
        /// 获取或设置 时间戳
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// 获取或设置 消息
        /// </summary>
        public string Message { get; set; }
    }
}