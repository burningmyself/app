﻿using System;
using System.Linq;

using Common.Entity;


namespace Common.Dependency
{
    /// <summary>
    /// Scoped生命周期字典扩展方法
    /// </summary>
    public static class ScopedDictionaryExtensions
    {
        /// <summary>
        /// 获取连接串的UnitOfWork
        /// </summary>
        public static IUnitOfWork GetConnUnitOfWork(this ScopedDictionary dict, string connString)
        {
            string key = $"UnitOfWork_ConnString_{connString}";
            return dict.GetValue<IUnitOfWork>(key);
        }

        /// <summary>
        /// 获取所有连接串的UnitOfWork
        /// </summary>
        public static IUnitOfWork[] GetConnUnitOfWorks(this ScopedDictionary dict)
        {
            return dict.Where(m => m.Key.StartsWith("UnitOfWork_ConnString_")).Select(m => m.Value as IUnitOfWork).ToArray();
        }

        /// <summary>
        /// 设置连接串的UnitOfWork
        /// </summary>
        public static void SetConnUnitOfWork(this ScopedDictionary dict, string connString, IUnitOfWork unitOfWork)
        {
            string key = $"UnitOfWork_ConnString_{connString}";
            dict.TryAdd(key, unitOfWork);
        }

        /// <summary>
        /// 获取指定实体类的UnitOfWork
        /// </summary>
        public static IUnitOfWork GetEntityUnitOfWork(this ScopedDictionary dict, Type entityType)
        {
            string key = $"UnitOfWork_EntityType_{entityType.FullName}";
            return dict.GetValue<IUnitOfWork>(key);
        }

        /// <summary>
        /// 获取所有实体类的UnitOfWork
        /// </summary>
        public static IUnitOfWork[] GetEntityUnitOfWorks(this ScopedDictionary dict)
        {
            return dict.Where(m => m.Key.StartsWith("UnitOfWork_EntityType_")).Select(m => m.Value as IUnitOfWork).ToArray();
        }

        /// <summary>
        /// 设置指定实体类的UnitOfWork
        /// </summary>
        public static void SetEntityUnitOfWork(this ScopedDictionary dict, Type entityType, IUnitOfWork unitOfWork)
        {
            string key = $"UnitOfWork_EntityType_{entityType.FullName}";
            dict.TryAdd(key, unitOfWork);
        }
    }
}