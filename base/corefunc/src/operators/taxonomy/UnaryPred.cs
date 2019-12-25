//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static zfunc;

    /// <summary>
    /// Characterizes a unary predicate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryPred<A> : IOp
    {
        bit Invoke(A a);        
    }

    /// <summary>
    /// Characterizes a unary predicate over a primal operand
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalUnaryPred<T> : IPrimalOp<T>, IUnaryPred<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a unary predicate over a non-primal operand
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPred<V> : IVectorOp<V>, IUnaryPred<V>
        where V : struct
    {
        
    }

    /// <summary>
    /// Characterizes a unary predicate over a naturally-sized non-primal operand 
    /// </summary>
    /// <typeparam name="W">The natural width type</typeparam>
    /// <typeparam name="V">The non-primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPred<W,V> : IUnaryPred<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a unary predicate over naturally-sized non-primal operands with attendant scalar computation
    /// </summary>
    /// <typeparam name="W">The natural width type</typeparam>
    /// <typeparam name="V">The non-primal type</typeparam>
    /// <typeparam name="T">The scalar type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPred<W,V,T> : IVUnaryPred<W,V>, IVectorOp<W,V,T>    
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        bit InvokeScalar(T a);           
    }

    /// <summary>
    /// Characterizes a unary predicate over 128-bit intrinsic vectors
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPred128<T> : IVUnaryPred<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a unary predicate over 256-bit intrinsic vectors
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPred256<T> : IVUnaryPred<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

}