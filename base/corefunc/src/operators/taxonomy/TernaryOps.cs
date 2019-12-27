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

    /// <summary>
    /// Characterizes a ternary operator over primal operands
    /// </summary>
    /// <typeparam name="T">The primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalTernaryOp<T> : IPrimalOp<T>, ITernaryOp<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized ternary operator
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp<V> : IVectorOp<V>, ITernaryOp<V>
        where V : struct
    {
        
    }
 
    /// <summary>
    /// Characterizes a vectorized ternary operator parameterized by operand bit-width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp<W,V> : IVTernaryOp<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    /// <summary>
    /// Defines trait for vecorized ternary operators that support evaluation via scalar decomposition
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOpD<T>
        where T : unmanaged
    {
        T InvokeScalar(T a, T b, T c);
    }

    /// <summary>
    /// Characterizes a vectorized ternary operator parameterized by operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp<W,V,T> : IVTernaryOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized 128-bit ternary operator
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp128<T> : IVTernaryOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized 256-bit ternary operator
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp256<T> : IVTernaryOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized 128-bit ternary operator that also supports evaluation via scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp128D<T> : IVTernaryOp128<T>, IVTernaryOpD<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized 256-bit ternary operator that also supports evaluation via scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp256D<T> : IVTernaryOp256<T>, IVTernaryOpD<T>
        where T : unmanaged
    {
        
    }
}