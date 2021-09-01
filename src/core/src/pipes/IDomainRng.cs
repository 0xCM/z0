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
    public interface IDomainRng<T> : ISource<T>, IDomainSource<T>
        where T : unmanaged
    {
    }

    [Free]
    public interface IDomainRng<G,T> : IDomainRng<T>
        where T : unmanaged
        where G : IDomainRng<G,T>
    {

    }
}