//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a reified nonempty set
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    [Free]
    public interface INonEmptySet<F> : INonEmpty<F>
        where F : INonEmptySet<F>, new()
    {

    }

    /// <summary>
    /// Characterizes a reified nonempty set with evidence of non-absence
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    [Free]
    public interface INonEmptySet<F,T> : INonEmptySet<F>, INonEmpty<F,T>
        where F : INonEmptySet<F,T>, new()
    {

    }
}