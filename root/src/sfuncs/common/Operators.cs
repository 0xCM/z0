//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Defines the canonical shape of a unary operator
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T UnaryOp<T>(T a);

    /// <summary>
    /// Characterizes a unary operator with known operand width
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T UnaryOp<W,T>(T a)
        where W : struct, ITypeWidth<W>;

    /// <summary>
    /// Defines the canonical shape of a binary operator
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T BinaryOp<T>(T a, T b);

    /// <summary>
    /// Characterizes a binary operator with known operand width
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T BinaryOp<W,T>(T a, T b)
        where W : struct, ITypeWidth<W>;

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
    /// Characterizes a ternary operator with known operand width
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T TernaryOp<W,T>(T a, T b, T c)
        where W : struct, ITypeWidth<W>;

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
    /// Characterizes a structural unary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOp<W,A> : IUnaryOp<A>, IUnaryFunc<W,A,A>
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp<A> : IBinaryFunc<A,A,A>
    {
        new BinaryOp<A> Operation => (this as IFunc<A,A,A>).Operation.ToBinaryOp();    
    }

    /// <summary>
    /// Characterizes a structural binary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width kind</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp<W,A> : IBinaryOp<A>, IBinaryFunc<W,A,A,A>
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural ternary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryOp<A> : ITernaryFunc<A,A,A,A>
    {
        new TernaryOp<A> Operation => (this as IFunc<A,A,A,A>).Operation.ToTernaryOp();
    } 

    /// <summary>
    /// Characterizes a structural ternary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width kind</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryOp<W,A> : ITernaryOp<A>, ITernaryFunc<W,A,A,A,A>
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural function that accepts sourc span and 
    /// target spans defined over cells of common type
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnarySpanOp<T> : ISpanOp        
    {
        Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a unary span operator that accepts spans with cells of known width
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnarySpanOp<W,T> : ISpanOp<W>        
        where W : struct, ITypeWidth<W>
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
    /// Characterizes a structural binary span operator that accepts 
    /// spans with cells of known width
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinarySpanOp<W,T> : ISpanOp<W>        
        where W : struct, ITypeWidth<W>
    {
        Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a structural function that accepts two source spans and a 
    /// target span defined over cells of common type
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernarySpanOp<T> : ISpanOp        
    {
        Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst);
    }

    /// <summary>
    /// Characterizes a structural ternary span operator that accepts spans with cells of known width
    /// </summary>
    /// <typeparam name="W">The cell width</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernarySpanOp<W,T> : ISpanOp<W>        
         where W : struct, ITypeWidth<W>
   {
        Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst);
    }
}