//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a random source that can produce points bounded by a range
    /// </summary>
    /// <typeparam name="T">The primal type</typeparam>
    [Free]
    public interface IRngDomainValues<T> : IRngSource, IDataSource<T>, IDomainSource<T>
        where T : unmanaged
    {
    }
}