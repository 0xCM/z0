//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using K = MemoryApiClass;

    /// <summary>
    /// Characterizes a system operation classifier
    /// </summary>
    [Free]
    public interface IMemoryApiKey : IApiKey, IApiKind<K>
    {
        K Kind {get;}

        ApiClass IApiKey.Id
            => (ApiClass)Kind;
    }
}