//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Base interface for span-oriented operations
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFSpanApi : ISFApi
    {

    }

    /// <summary>
    /// Characterizes an operator that applies a bitwise shift or rotation to elements in a source span
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFSpanShiftApi : ISFSpanApi
    {

    }

    /// <summary>
    /// Characterizes a structural transformation function defined over parametric spans
    /// </summary>
    /// <typeparam name="A">The source span cell type</typeparam>
    /// <typeparam name="B">The target span cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFSpanMapApi<A,B> : ISFSpanApi
    {
        Span<B> Invoke(Span<A> src);
    }    

    /// <summary>
    /// Characterizes a structural function that accepts sourc span and 
    /// target spans defined over cells of common type
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFUnarySpanOpApi<T> : ISFSpanApi        
    {
        Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a unary span operator that accepts spans with cells of known width
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFWUnarySpanOpApi<W,T> : ISFWSpanApi<W>        
        where W : unmanaged, ITypeWidth
    {
        Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span over a common element type
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFBinarySpanOpApi<T> : ISFSpanApi        
    {
        Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a span operator that shifts each source element by an amount secified in a corresponding count span
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFSpanShiftVarApi<T> : ISFSpanShiftApi
    {
        Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts a source value and produces a span
    /// </summary>
    /// <typeparam name="A">The source span cell type</typeparam>
    /// <typeparam name="B">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFSpanFactoryApi<A,B> : ISFApi
    {
        Span<B> Invoke(A src);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISFWSpanApi<W> : ISFSpanApi, ISFWApi<W>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural binary span operator that accepts 
    /// spans with cells of known width
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFWBinarySpanOpApi<W,T> : ISFWSpanApi<W>        
        where W : unmanaged, ITypeWidth
    {
        Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a structural function that accepts two source spans and a 
    /// target span defined over cells of common type
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFTernarySpanOpApi<T> : ISFSpanApi        
    {
        Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a structural ternary span operator that accepts spans with cells of known width
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFWTernarySpanOpApi<W,T> : ISFWSpanApi<W>        
        where W : unmanaged, ITypeWidth
   {
        Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFUnarySpanPredicateApi<T> : ISFSpanApi        
    {
        Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFBinarySpanPredicateApi<T> : ISFSpanApi        
    {
        Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts three source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFTernarySpanPredicateApi<T> : ISFSpanApi        
    {
        Span<bit> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<bit> dst);
    }    

    /// <summary>
    /// Characterizes a span operator that shifts each source element by the same amount
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFImm8SpanShiftApi<T> : ISFImm8Api, ISFSpanShiftApi
    {
        Span<T> Invoke(ReadOnlySpan<T> src, byte imm8, Span<T> dst);

        Imm8ShiftSpanOp<T> Operation => Invoke;
    }    
}