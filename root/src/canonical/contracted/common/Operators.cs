//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Security;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the canonical shape of a unary operator
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T UnaryOp<T>(T a);

    /// <summary>
    /// Defines the canonical shape of a binary operator
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T BinaryOp<T>(T a, T b);

     /// <summary>
    /// Defines the canonical shape of a tenary operator
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T TernaryOp<T>(T a, T b, T c);

    /// <summary>
    /// Characterizes a unary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOp<A> : IUnaryFunc<A,A>
    {
        new UnaryOp<A> Operation => (this as IFunc<A,A>).Operation.ToUnaryOp();
    }

    /// <summary>
    /// Characterizes a binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp<A> : IBinaryFunc<A,A,A>
    {
        new BinaryOp<A> Operation => (this as IFunc<A,A,A>).Operation.ToBinaryOp();    
    }

    /// <summary>
    /// Characterizes a ternary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryOp<A> : ITernaryFunc<A,A,A,A>
    {
        new TernaryOp<A> Operation => (this as IFunc<A,A,A,A>).Operation.ToTernaryOp();
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
}