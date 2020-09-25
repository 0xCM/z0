//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate T Projector<T>(in T src);

    /// <summary>
    /// Characterizes a parametric projector
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The operand type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [Free]
    public delegate T Projector<S,T>(in S src);
}
