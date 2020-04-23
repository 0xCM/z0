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
    /// Base interface for span-oriented operations
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanFunc : ISFunc
    {

    }

    /// <summary>
    /// Characterizes an operator that applies a bitwise shift or rotation to elements in a source span
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanShift : ISpanFunc
    {

    }

    /// <summary>
    /// Characterizes a structural transformation function defined over parametric spans
    /// </summary>
    /// <typeparam name="A">The source span cell type</typeparam>
    /// <typeparam name="B">The target span cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanMap<A,B> : ISpanFunc
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
    public interface IUnarySpanOp<T> : ISpanFunc        
    {
        Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span over a common element type
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinarySpanOp<T> : ISpanFunc        
    {
        Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a span operator that shifts each source element by an amount secified in a corresponding count span
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVarSpanShift<T> : ISpanShift
    {
        Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts a source value and produces a span
    /// </summary>
    /// <typeparam name="A">The source span cell type</typeparam>
    /// <typeparam name="B">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanFactory<A,B> : ISFunc
    {
        Span<B> Invoke(A src);
    }

    /// <summary>
    /// Characterizes a structural function that accepts two source spans and a 
    /// target span defined over cells of common type
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernarySpanOp<T> : ISpanFunc        
    {
        Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnarySpanPred<T> : ISpanFunc        
    {
        Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts two source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinarySpanPred<T> : ISpanFunc        
    {
        Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst);
    }

    /// <summary>
    /// Characterizes a function that accepts three source spans and a target span of bits
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernarySpanPred<T> : ISpanFunc        
    {
        Span<bit> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<bit> dst);
    }    

    /// <summary>
    /// Characterizes a span operator that shifts each source element by the same amount
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanShiftImm8<T> : ISpanShift
    {
        Span<T> Invoke(ReadOnlySpan<T> src, byte imm8, Span<T> dst);

        Imm8ShiftSpanOp<T> Operation => Invoke;
    }    


    /// <summary>
    /// Characterizes an emitter that shoots out spans
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanEmitter<T> : ISpanFunc
    {
        Span<T> Invoke();
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IReceiver : ISink
    {
        
    }

    /// <summary>
    /// Characterizes a structural receiver that accepts a span
    /// </summary>
    /// <typeparam name="T">The apn element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanReceiver<T> : IReceiver
    {
        void Accept(Span<T> src);

        SpanReceiver<T> Operation
        {                    
            [MethodImpl(Inline)]
            get => Accept;
        }
    }    
}