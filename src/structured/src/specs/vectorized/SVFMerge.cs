//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Defines trait for a fully-heterogeneous vectorized merge operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="X">The first operand component type</typeparam>
    /// <typeparam name="Y">The second operand component type</typeparam>
    /// <typeparam name="Z">The the target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVFMergeApi<X,Y,Z> : ISVFunc
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
    public interface ISVFMergeDApi<S,T> : ISVFMergeApi<S,S,T>
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
    public interface ISVMergeOp128Api<X,Y,Z> : ISVFApi<W128, W128, W128, Vector128<X>, Vector128<Y>, Vector128<Z>, X, Y,Z>
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
    public interface ISVFMergeOp256Api<X,Y,Z> : ISVFApi<W256, W256, W256, Vector256<X>, Vector256<Y>, Vector256<Z>, X, Y,Z>
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
    public interface IVMergeOp2x128x256Api<X,Y,Z> : ISVFApi<W128, W128, W256, Vector128<X>, Vector128<Y>, Vector256<Z>, X, Y,Z>
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
    public interface ISVMergeOp2x128x256Api<S,T> : ISVFApi<W128, W128, W256, Vector128<S>, Vector128<S>, Vector256<T>, S, S, T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a componentwise-homogenous vectorized merge operator that carries 2 128-bit operands to a 256-bit target
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVMergeOp2x128x256Api<T> : ISVMergeOp2x128x256Api<T,T>
        where T : unmanaged
    {

    }    
}