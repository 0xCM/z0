//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
    /// Defines trait for a fully-heterogeneous vectorized merge operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="X">The first operand component type</typeparam>
    /// <typeparam name="Y">The second operand component type</typeparam>
    /// <typeparam name="Z">The the target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeFunc<X,Y,Z> : IVFunc
        where X : unmanaged
        where Y : unmanaged
        where Z : unmanaged
    {
        Z InvokeScalar(X a, Y b);
    }

    /// <summary>
    /// Defines trait for a vectorized merge operator over homogenous operands that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="S">The operand component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeOpD<S,T> : IVMergeFunc<S,S,T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized merge operator homogenous in bit-width 128
    /// </summary>
    /// <typeparam name="X">The first operand component type</typeparam>
    /// <typeparam name="Y">The second operand component type</typeparam>
    /// <typeparam name="Z">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeOp128<X,Y,Z> : IVFunc<N128, N128, N128, Vector128<X>, Vector128<Y>, Vector128<Z>, X, Y,Z>
        where X : unmanaged
        where Y : unmanaged
        where Z : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized merge operator homogenous in bit-width 256
    /// </summary>
    /// <typeparam name="X">The first operand component type</typeparam>
    /// <typeparam name="Y">The second operand component type</typeparam>
    /// <typeparam name="Z">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeOp256<X,Y,Z> : IVFunc<N256, N256, N256, Vector256<X>, Vector256<Y>, Vector256<Z>, X, Y,Z>
        where X : unmanaged
        where Y : unmanaged
        where Z : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a componentwise-heterogenous vectorized merge operator that carries 2 128-bit operands to a 256-bit target
    /// </summary>
    /// <typeparam name="X">The first operand component type</typeparam>
    /// <typeparam name="Y">The second operand component type</typeparam>
    /// <typeparam name="Z">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeOp2x128x256<X,Y,Z> : IVFunc<N128, N128, N256, Vector128<X>, Vector128<Y>, Vector256<Z>, X, Y,Z>
        where X : unmanaged
        where Y : unmanaged
        where Z : unmanaged
    {

    }

    /// <summary>
    /// Characterizes an operand-homogenous vectorized merge operator that carries 2 128-bit operands to a 256-bit target
    /// </summary>
    /// <typeparam name="S">The operand component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeOp2x128x256<S,T> : IVFunc<N128, N128, N256, Vector128<S>, Vector128<S>, Vector256<T>, S, S, T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a componentwise-homogenous vectorized merge operator that carries 2 128-bit operands to a 256-bit target
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeOp2x128x256<T> : IVMergeOp2x128x256<T,T>
        where T : unmanaged
    {

    }    
}