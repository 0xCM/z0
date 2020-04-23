//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISpanOpW<W> : ISpanFunc, IFuncW<W>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a unary span operator that accepts spans with cells of known width
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnarySpanOpW<W,T> : ISpanOpW<W>        
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
    public interface IBinarySpanOpW<W,T> : ISpanOpW<W>        
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
    public interface ITernarySpanOpW<W,T> : ISpanOpW<W>        
        where W : unmanaged, ITypeWidth
    {
        Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst);
    }
}