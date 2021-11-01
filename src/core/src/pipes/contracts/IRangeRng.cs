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
    public interface IRangeRng<T> : IRng, IRangeSource<T>
        where T : unmanaged
    {
    }

    [Free]
    public interface IRangeRng<G,T> : IRangeRng<T>
        where T : unmanaged
        where G : IRangeRng<G,T>
    {

    }
}