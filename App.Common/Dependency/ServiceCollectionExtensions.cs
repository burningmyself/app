﻿using Microsoft.Extensions.DependencyInjection;
using Common.Reflection;
using System;
using System.Linq;


namespace Common.Dependency
{
    /// <summary>
    /// <see cref="IServiceCollection"/>扩展方法
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 如果指定服务不存在，添加指定服务
        /// </summary>
        public static ServiceDescriptor GetOrAdd(this IServiceCollection services, ServiceDescriptor toAdDescriptor)
        {
            ServiceDescriptor descriptor = services.FirstOrDefault(m => m.ServiceType == toAdDescriptor.ServiceType);
            if (descriptor != null)
            {
                return descriptor;
            }

            services.Add(toAdDescriptor);
            return toAdDescriptor;
        }

        /// <summary>
        /// 获取或添加指定类型查找器
        /// </summary>
        public static TTypeFinder GetOrAddTypeFinder<TTypeFinder>(this IServiceCollection services, Func<IAllAssemblyFinder, TTypeFinder> factory)
            where TTypeFinder : class
        {
            return services.GetOrAddSingletonInstance<TTypeFinder>(() =>
            {
                IAllAssemblyFinder allAssemblyFinder =
                    services.GetOrAddSingletonInstance<IAllAssemblyFinder>(() => new AppDomainAllAssemblyFinder(true));
                return factory(allAssemblyFinder);
            });
        }

        /// <summary>
        /// 如果指定服务不存在，创建实例并添加
        /// </summary>
        public static TServiceType GetOrAddSingletonInstance<TServiceType>(this IServiceCollection services, Func<TServiceType> factory) where TServiceType : class
        {
            TServiceType item = (TServiceType)services.FirstOrDefault(m => m.ServiceType == typeof(TServiceType) && m.Lifetime == ServiceLifetime.Singleton)?.ImplementationInstance;
            if (item == null)
            {
                item = factory();
                services.AddSingleton<TServiceType>(item);
            }
            return item;
        }

        /// <summary>
        /// 获取单例注册服务对象
        /// </summary>
        public static T GetSingletonInstanceOrNull<T>(this IServiceCollection services)
        {
            return (T)services.FirstOrDefault(d => d.ServiceType == typeof(T))?.ImplementationInstance;
        }

        /// <summary>
        /// 获取单例注册服务对象
        /// </summary>
        public static T GetSingletonInstance<T>(this IServiceCollection services)
        {
            var instance = services.GetSingletonInstanceOrNull<T>();
            if (instance == null)
            {
                throw new InvalidOperationException($"无法找到已注册的单例服务：{typeof(T).AssemblyQualifiedName}");
            }

            return instance;
        }

        /// <summary>
        /// 从Scoped字典中获取指定类型的值
        /// </summary>
        public static T GetValue<T>(this ScopedDictionary dict, string key) where T : class
        {
            if (dict.TryGetValue(key, out object obj))
            {
                return obj as T;
            }

            return default(T);
        }
    }
}