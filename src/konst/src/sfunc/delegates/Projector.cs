//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate T Projector<T>(in T src);

    /// <summary>
    /// Characterizes a parametric projector
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The operand type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Projector<S,T>(in S src);
}
