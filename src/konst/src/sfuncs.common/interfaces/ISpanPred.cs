//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {


    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [Free, SFx]
    public interface IUnarySpanPred<T> : IFunc
    {
        Span<Bit32> Invoke(ReadOnlySpan<T> src, Span<Bit32> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [Free, SFx]
    public interface IBinarySpanPred<T> : IFunc
    {
        Span<Bit32> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<Bit32> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span of parametric type
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [Free, SFx]
    public interface IBinarySpanPred<T,P> : IFunc
    {
        Span<P> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<P> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts three source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [Free, SFx]
    public interface ITernarySpanPred<T> : IFunc
    {
        Span<Bit32> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<Bit32> dst);
    }
}