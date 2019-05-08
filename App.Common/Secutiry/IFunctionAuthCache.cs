﻿using System;


namespace Common.Secutiry
{
    /// <summary>
    /// 定义功能权限缓存的功能
    /// </summary>
    public interface IFunctionAuthCache
    {
        /// <summary>
        /// 创建功能角色权限缓存，只创建 功能-角色集合 的映射，用户-功能 的映射，遇到才即时创建并缓存
        /// </summary>
        void BuildRoleCaches();

        /// <summary>
        /// 移除指定功能的缓存
        /// </summary>
        /// <param name="functionIds">功能编号集合</param>
        void RemoveFunctionCaches(params Guid[] functionIds);

        /// <summary>
        /// 移除指定用户的缓存
        /// </summary>
        /// <param name="userNames">用户编号集合</param>
        void RemoveUserCaches(params string[] userNames);

        /// <summary>
        /// 获取能执行指定功能的所有角色
        /// </summary>
        /// <param name="functionId">功能编号</param>
        /// <returns>能执行功能的角色名称集合</returns>
        string[] GetFunctionRoles(Guid functionId);

        /// <summary>
        /// 获取指定用户的所有特权功能
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>用户的所有特权功能</returns>
        Guid[] GetUserFunctions(string userName);
    }
}