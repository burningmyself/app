using Common.Reflection;


namespace Common.Entity
{
    /// <summary>
    /// <see cref="IOutputDto"/>类型查找器
    /// </summary>
    public class OutputDtoTypeFinder : BaseTypeFinderBase<IOutputDto>, IOutputDtoTypeFinder
    {
        /// <summary>
        /// 初始化一个<see cref="BaseTypeFinderBase{TBaseType}"/>类型的新实例
        /// </summary>
        public OutputDtoTypeFinder(IAllAssemblyFinder allAssemblyFinder)
            : base(allAssemblyFinder)
        { }
    }
}