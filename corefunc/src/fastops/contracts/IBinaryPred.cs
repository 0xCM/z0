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
    /// Chracterizes a heterogenous binary predicate
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryPred<A,B> : IBinaryFunc<A,B,bit>
    {
        
    }

    /// <summary>
    /// Characterizes a binary predicate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryPred<A> : IBinaryPred<A,A>
    {
        
    }

    /// <summary>
    /// Characterizes a natural binary predicate over non-primal operands
    /// </summary>
    /// <typeparam name="W">The natural type</typeparam>
    /// <typeparam name="V">The non-primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryPred<W,V> : IVFunc, IBinaryPred<V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    /// <summary>
    /// Defines trait for a vecorized binary predicate that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryPredD<T>
        where T : unmanaged
    {
        bit InvokeScalar(T x, T y);
    }

    /// <summary>
    /// Characterizes a natural binary predicate over non-primal operands that support scalar application
    /// </summary>
    /// <typeparam name="W">The natural type</typeparam>
    /// <typeparam name="V">The non-primal type</typeparam>
    /// <typeparam name="T">The scalar type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryPred<W,V,T> : IVBinaryPred<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized binary predicate over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinPred128<T> : IVBinaryPred<N128,Vector128<T>,T>
        where T : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.BinaryPred | FunctionKind.V128;

    }

    /// <summary>
    /// Characterizes a vectorized binary predicate over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinPred256<T> : IVBinaryPred<N256,Vector256<T>,T>
        where T : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.BinaryPred | FunctionKind.V256;        
    }

    /// <summary>
    /// Characterizes a vectorized binary predicate over 128-bit operands that 
    /// also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinPred128D<T> : IVBinPred128<T>, IVBinaryPredD<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized binary predicate over 128-bit operands that 
    /// also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinPred256D<T> : IVBinPred256<T>, IVBinaryPredD<T>
        where T : unmanaged
    {
    
    }
}