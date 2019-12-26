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
    /// Characterizes a bitwise shift operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IShiftOp<A> : IOp
    {
        /// <summary>
        /// Invokes the reified shift operator over supplied operands
        /// </summary>
        /// <param name="a">The source operand</param>
        /// <param name="offset">The shift amount</param>
        A Invoke(A a, byte offset);        
    }

    /// <summary>
    /// Characterizes a non-variable bitwise shift operator over a primal operand
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalShiftOp<T> : IPrimalOp<T>, IShiftOp<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized shift operator
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp<V> : IVectorOp<V>, IShiftOp<V>
        where V : struct
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized shift operator parameterized by operand bit-width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp<W,V> : IVShiftOp<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized shift operator parameterized by operand bit-width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp<W,V,T> : IVShiftOp<W,V>, IVectorOp<W,V,T>    
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized shift operator that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOpD<T>
        where T : unmanaged
    {
        T InvokeScalar(T a, byte offset);           
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp128<T> : IVShiftOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp256<T> : IVShiftOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp128D<T> : IVShiftOp128<T>, IVShiftOpD<T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 256-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp256D<T> : IVShiftOp256<T>, IVShiftOpD<T>
        where T : unmanaged
    {
        
    }

}