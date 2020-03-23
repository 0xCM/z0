//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate<T>(T a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate<W,T>(T a)
         where W : unmanaged, ITypeWidth<W>;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate<T>(T a, T b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate<W,T>(T a, T b)
         where W : unmanaged, ITypeWidth<W>;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPredicate<T>(T a, T b, T c);        

    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPredicate<W,T>(T a, T b, T c)
         where W : unmanaged, ITypeWidth<W>;

    /// <summary>
    /// Characterizes a unary predicate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryPredicate<A> : IUnaryFunc<A,bit>
    {
         new UnaryPredicate<A> Operation => (this as IFunc<A,bit>).Operation.ToUnaryPredicate();
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryPredicate<W,A> : IUnaryPredicate<A>, IUnaryFunc<W,A,bit>
         where W : unmanaged, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Chracterizes a heterogenous binary predicate
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryPredicate<A,B> : IBinaryFunc<A,B,bit>
    {
        
    }


    /// <summary>
    /// Characterizes a binary predicate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryPredicate<A> : IBinaryPredicate<A,A>
    {
         new BinaryPredicate<A> Operation => (this as IFunc<A,A,bit>).Operation.ToBinaryPredicate();        
    }
    
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryPredicate<W,A,B> : IBinaryPredicate<A,B>, IBinaryFunc<W,A,B,bit>
         where W : unmanaged, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a ternary predicate 
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryPredicate<A> : IFunc<A,A,A,bit>
    {
        
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
}