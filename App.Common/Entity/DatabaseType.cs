namespace Common.Entity
{
    /// <summary>
    /// 表示数据库类型，如SqlServer，Sqlite等
    /// </summary>
    public enum DatabaseType
    {
        /// <summary>
        /// SqlServer数据库类型
        /// </summary>
        SqlServer,
        /// <summary>
        /// Sqlite数据库类型
        /// </summary>
        Sqlite,
        /// <summary>
        /// MySql数据库类型
        /// </summary>
        MySql,
        /// <summary>
        /// PostgreSql数据库类型
        /// </summary>
        PostgreSql,
        /// <summary>
        /// Oracle数据库类型
        /// </summary>
        Oracle
    }
}