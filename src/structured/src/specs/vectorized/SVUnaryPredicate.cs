//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Defines trait for a vecorized unary predicate that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPredicateD<T>
        where T : unmanaged
    {
        bit InvokeScalar(T x);
    }

    /// <summary>
    /// Characterizes a unary predicate parameterized by operand bit width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryPredicate<W,V> : ISVFunc, ISFunc<V,bit>
        where W : unmanaged, ITypeWidth
        where V : struct
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate parameterized by operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryPredicate<W,V,T> : ISVUnaryPredicate<W,V>
        where W : unmanaged, ITypeWidth
        where V : struct
        where T : unmanaged
    {
           
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryPredicate128<T> : ISVUnaryPredicate<W128,Vector128<T>,T>, ISVFunc128<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryPredicate256<T> : ISVUnaryPredicate<W256,Vector256<T>,T>, ISVFunc256<T>
        where T : unmanaged
    {        
        
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryPredicate128D<T> : ISVUnaryPredicate128<T>, IVUnaryPredicateD<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryPredicate256D<T> : ISVUnaryPredicate256<T>, IVUnaryPredicateD<T>
        where T : unmanaged
    {
    
    }
}