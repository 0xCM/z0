//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes a structural transformation function defined over parametric spans
    /// </summary>
    /// <typeparam name="A">The source span cell type</typeparam>
    /// <typeparam name="B">The target span cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanMap<A,B> : IFunc
    {
        Span<B> Invoke(Span<A> src);
    }    
}