using System;
using Common.Dependency;
using Common.Finders;


namespace Common.Reflection
{
    /// <summary>
    /// 定义类型查找行为
    /// </summary>
    [IgnoreDependency]
    public interface ITypeFinder : IFinder<Type>
    { }
}