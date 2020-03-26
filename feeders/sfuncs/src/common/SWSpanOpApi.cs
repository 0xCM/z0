//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISWSpanApi<W> : ISSpanApi, ISWFuncApi<W>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a unary span operator that accepts spans with cells of known width
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWUnarySpanOpApi<W,T> : ISWSpanApi<W>        
        where W : unmanaged, ITypeWidth
    {
        Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst);
    }


    /// <summary>
    /// Characterizes a structural binary span operator that accepts 
    /// spans with cells of known width
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWBinarySpanOpApi<W,T> : ISWSpanApi<W>        
        where W : unmanaged, ITypeWidth
    {
        Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a structural ternary span operator that accepts spans with cells of known width
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWTernarySpanOpApi<W,T> : ISWSpanApi<W>        
        where W : unmanaged, ITypeWidth
    {
        Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst);
    }
}