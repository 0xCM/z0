//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Defines trait for a vecorized unary predicate that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPredD<T>
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
    public interface IVUnaryPred<W,V> : IVFunc, IUnaryPredicate<V>
        where W : unmanaged, ITypeNat
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
    public interface IVUnaryPred<W,V,T> : IVUnaryPred<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
           
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPred128<T> : IVUnaryPred<N128,Vector128<T>,T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPred256<T> : IVUnaryPred<N256,Vector256<T>,T>
        where T : unmanaged
    {        
        
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPred128D<T> : IVUnaryPred128<T>, IVUnaryPredD<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPred256D<T> : IVUnaryPred256<T>, IVUnaryPredD<T>
        where T : unmanaged
    {
    
    }
}