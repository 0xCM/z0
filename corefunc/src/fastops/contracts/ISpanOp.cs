//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    using static zfunc;

    /// <summary>
    /// Base interface for span-oriented operations
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanOp : IFunc
    {

    }

    /// <summary>
    /// Characterizes a function that accepts a source span and a target span over a common element type
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnarySpanOp<T> : ISpanOp        
    {
        Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span over a common element type
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinarySpanOp<T> : ISpanOp        
    {
        Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span over a common element type
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernarySpanOp<T> : ISpanOp        
    {
        Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnarySpanPred<T> : ISpanOp        
    {
        Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinarySpanPred<T> : ISpanOp        
    {
        Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts three source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernarySpanPred<T> : ISpanOp        
    {
        Span<bit> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<bit> dst);
    }

    /// <summary>
    /// Characterizes an operator that applies a bitwise shift or rotation to elements in a source span
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IShiftSpanOp : ISpanOp
    {

    }

    /// <summary>
    /// Characterizes a span operator that shifts each source element by the same amount
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IShiftSpanOp<T> : IShiftSpanOp
    {
        Span<T> Invoke(ReadOnlySpan<T> src, byte imm8, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a span operator that shifts each source element by an amount secified in a corresponding count span
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVarShiftSpanOp<T> : IShiftSpanOp
    {
        Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst);
    }

}