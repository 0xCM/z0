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
    /// Characterizes a unary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOp<A> : IOp
    {
        /// <summary>
        /// Invokes the reified unary operator
        /// </summary>
        /// <param name="a">The operand</param>
        A Invoke(A a);        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOp<F,A> : IUnaryOp<A>
        where F : IUnaryOp<A>
    {

    }

    /// <summary>
    /// Characterizes a unary operator that accepts two integral values that define a range
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    /// <typeparam name="K">The integral value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryRangeOp<A,K> : IOp
        where K : unmanaged
    {
        /// <summary>
        /// Invokes the reified unary operator
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="k1">The first integral value</param>
        /// <param name="k2">The second integral value</param>
        A Invoke(A a, K k1, K k2);
    }

    /// <summary>
    /// Characterizes a unary operator over a primal operand
    /// </summary>
    /// <typeparam name="T">The primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalUnaryOp<T> : IPrimalOp<T>, IUnaryOp<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a class of unary operators over a primal operands where
    /// membership within a specific class is discriminated by a natural number
    /// </summary>
    /// <typeparam name="T">The primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalUnaryOp<N,T> : IPrimalOp<T>, IUnaryOp<T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        N Discrimintator => default(N);
    }

    /// <summary>
    /// Characterizes a primal unary operator that accepts two integral values that define a range
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="K">The integral value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalUnaryRangeOp<T,K> : IPrimalOp<T>, IUnaryRangeOp<T,K>
        where K : unmanaged, ITypeNat
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a primal unary operator that accepts two unsigned 8-bit values that define a range
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalUnaryRange8Op<T> : IPrimalOp<T>, IUnaryRangeOp<T,byte>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a primal unary operator that accepts two signed 32-bit values that define a range
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalUnaryRange32Op<T> : IPrimalOp<T>, IUnaryRangeOp<T,int>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized unary operator
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp<V> : IVectorOp<V>, IUnaryOp<V>
        where V : struct
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator parameterized by operand bit width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp<W,V> : IVUnaryOp<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized binary operator parameterized by operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp<W,V,T> : IVUnaryOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {

    }

    /// <summary>
    /// Defines trait for a vecorized unuary operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOpD<T>
        where T : unmanaged
    {
        T InvokeScalar(T a);
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128<T> : IVUnaryOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256<T> : IVUnaryOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128D<T> : IVUnaryOp128<T>, IVUnaryOpD<T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256D<T> : IVUnaryOp256<T>, IVUnaryOpD<T>
        where T : unmanaged
    {
        
    }
}