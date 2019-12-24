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
    /// Characterizes a unary predicate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryPred<A> : IOp
    {
        bit Invoke(A a);        
    }


    /// <summary>
    /// Characterizes a ternary predicate 
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryPred<A> : IOp
    {
        bit Invoke(A a, A b, A c);        
    }

    /// <summary>
    /// Characterizes a unary predicate over a primal operand
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPUnaryPred<T> : IPrimalOp<T>, IUnaryPred<T>
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
    /// Characterizes a natural unary predicate over a naturally-sized non-primal operand that supports scalar deconstruction
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
    public interface IPBinaryPred<T> : IPrimalOp<T>, IBinaryPred<T>
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
    /// Characterizes a natural binary predicate over non-primal operands that support scalar deconstruction
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