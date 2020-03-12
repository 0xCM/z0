//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    

    [SuppressUnmanagedCodeSecurity]
    public interface ISpanFunc : IFunc
    {
        
    }

    /// <summary>
    /// Base interface for span-oriented operations
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanOp : ISpanFunc
    {

    }

    /// <summary>
    /// Characterizes an operator that applies a bitwise shift or rotation to elements in a source span
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IShiftSpanOp : ISpanOp
    {

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


    /// <summary>
    /// Characterizes a function that accepts a source span and produces a target
    /// </summary>
    /// <typeparam name="A">The source span cell type</typeparam>
    /// <typeparam name="B">The target type</typeparam>
    public interface ISpanSourced<A,B> : IFunc
    {
        B Invoke(ReadOnlySpan<A> src, int offset);
    }

    /// <summary>
    /// Characterizes a function that accepts a source value and produces a span
    /// </summary>
    /// <typeparam name="A">The source span cell type</typeparam>
    /// <typeparam name="B">The target type</typeparam>
    public interface ISpanFactory<A,B> : IFunc
    {
        Span<B> Invoke(A src);
    }
}