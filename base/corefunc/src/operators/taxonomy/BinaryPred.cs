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

    /// <summary>
    /// Characterizes a binary predicate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryPred<A> : IOp
    {
        bit Invoke(A a, A b);        
    }

    /// <summary>
    /// Characterizes a binary predicate over primal operands
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalBinaryPred<T> : IPrimalOp<T>, IBinaryPred<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a binary predicate over non-primal operands
    /// </summary>
    /// <typeparam name="V">The non-primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryPred<V> : IVectorOp<V>, IBinaryPred<V>
        where V : struct
    {
        
    }

    /// <summary>
    /// Characterizes a natural binary predicate over non-primal operands
    /// </summary>
    /// <typeparam name="W">The natural type</typeparam>
    /// <typeparam name="V">The non-primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryPred<W,V> : IBinaryPred<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a natural binary predicate over non-primal operands that support scalar application
    /// </summary>
    /// <typeparam name="W">The natural type</typeparam>
    /// <typeparam name="V">The non-primal type</typeparam>
    /// <typeparam name="T">The scalar type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryPred<W,V,T> : IVBinaryPred<W,V>, IVectorOp<W,V,T>    
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        bit InvokeScalar(T a, T b);           
    }

    /// <summary>
    /// Characterizes a binary predicate over 128-bit intrinsic vectors
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryPred128<T> : IVBinaryPred<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a binary predicate over 256-bit intrinsic vectors
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryPred256<T> : IVBinaryPred<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

}