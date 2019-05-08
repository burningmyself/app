using Common.Core.Functions;


namespace Common.Secutiry
{
    /// <summary>
    /// 功能权限验证类
    /// </summary>
    public class FunctionAuthorization : FunctionAuthorizationBase
    {
        /// <summary>
        /// 初始化一个<see cref="FunctionAuthorizationBase"/>类型的新实例
        /// </summary>
        public FunctionAuthorization(IFunctionAuthCache functionAuthCache)
            : base(functionAuthCache)
        { }
    }
}