//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using K = ApiSystemClass;
    using I = ISystemApiKind;

    /// <summary>
    /// Characterizes a system operation classifier
    /// </summary>
    [Free]
    public interface ISystemApiKind : IApiKey, IApiKind<K>
    {
        ApiClass IApiKey.Id
            => (ApiClass)Kind;
    }

    /// <summary>
    /// Characterizes a reified system operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    [Free]
    public interface ISystemApiKind<F> : I, IApiKind<F,K>
        where F : unmanaged, I
    {

    }
}