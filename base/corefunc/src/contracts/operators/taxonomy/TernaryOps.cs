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
    /// Characterizes a ternary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryOp<A> : IOp
    {
        /// <summary>
        /// Invokes the reified ternary operator over supplied operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        A Invoke(A a, A b, A c);        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp<V> : IVectorOp<V>, ITernaryOp<V>
        where V : struct
    {
        
    }
 
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp<W,V> : IVTernaryOp<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp<W,V,T> : IVTernaryOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        T InvokeScalar(T a, T b, T c);
    }

    /// <summary>
    /// Characterizes a ternary operator over 128-bit intrinsic vectors
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp128<T> : IVTernaryOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a ternary operator over 256-bit intrinsic vectors
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp256<T> : IVTernaryOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }
}