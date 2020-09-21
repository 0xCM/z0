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
    public interface IRngBoundPointSource<T> : IRngPointSource<T>, IBoundValueSource<T>
        where T : struct
    {
    }
}