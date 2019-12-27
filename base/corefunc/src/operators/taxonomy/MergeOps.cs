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
    /// Characterizes an operator that derives a target value from two heterogeneous operands
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The target operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IMergeOp<A,B,C> : IOp
    {
        C Invoke(A a, B b);
    }

    /// <summary>
    /// Characterizes a merge operator with homogenous source operands
    /// </summary>
    /// <typeparam name="A">The source operand type</typeparam>
    /// <typeparam name="B">The target operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IMergeOp<A,B> : IMergeOp<A,A,B>
    {
        
    }

    /// <summary>
    /// Characterizes an homogenous merge operator
    /// </summary>
    /// <typeparam name="A">The source/target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IMergeOp<A> : IMergeOp<A,A,A>
    {
        
    }

    /// <summary>
    /// Characterizes a merge operator over primal operands
    /// </summary>
    /// <typeparam name="X">The first operand type</typeparam>
    /// <typeparam name="Y">The second operand type</typeparam>
    /// <typeparam name="Z">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalMergeOp<X,Y,Z> : IMergeOp<X,Y,Z>
        where X : unmanaged
        where Y : unmanaged
        where Z : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a merge operator over homogenous primal operands
    /// </summary>
    /// <typeparam name="S">The source operand type</typeparam>
    /// <typeparam name="Y">The target operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalMergeOp<S,T> : IMergeOp<S,S,T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes an homogenous merge operator over primal operands
    /// </summary>
    /// <typeparam name="S">The source operand type</typeparam>
    /// <typeparam name="Y">The target operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalMergeOp<T> : IMergeOp<T,T,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a fully-heterogenous merge operator over vectorized operands
    /// </summary>
    /// <typeparam name="W1">The bit-width of the first operand</typeparam>
    /// <typeparam name="W2">The bit-width of the second operand</typeparam>
    /// <typeparam name="W3">The bit-width of the target type</typeparam>
    /// <typeparam name="V1">The first operand type</typeparam>
    /// <typeparam name="V2">The second operand type</typeparam>
    /// <typeparam name="V3">The target value type</typeparam>
    /// <typeparam name="T1">The component type of the first operand</typeparam>
    /// <typeparam name="T2">The component type of the second operand</typeparam>
    /// <typeparam name="T3">The component type of the target value</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeOp<W1,W2,W3,V1,V2,V3,T1,T2,T3> : IVectorOp, IMergeOp<V1,V2,V3>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where W3 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where V3 : struct
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized merge operator over homogenous operands
    /// </summary>
    /// <typeparam name="W1">The operand bit-width type</typeparam>
    /// <typeparam name="W2">The target bit-width type</typeparam>
    /// <typeparam name="V1">The operand type</typeparam>
    /// <typeparam name="V2">The target type</typeparam>
    /// <typeparam name="T1">The operand component type</typeparam>
    /// <typeparam name="T2">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeOp<W1,W2,V1,V2,T1,T2> : IVMergeOp<W1,W1,W2,V1,V1,V2,T1,T1,T2>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where T1 : unmanaged
        where T2 : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a fully-homogenous vectorized merge operator
    /// </summary>
    /// <typeparam name="W">The operand/target bit-width type</typeparam>
    /// <typeparam name="V">The operand/target type</typeparam>
    /// <typeparam name="T">The operand/target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeOp<W,V,T> : IVMergeOp<W,W,V,V,T,T>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {

    }

    /// <summary>
    /// Defines trait for a fully-heterogeneous vectorized merge operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="X">The first operand component type</typeparam>
    /// <typeparam name="Y">The second operand component type</typeparam>
    /// <typeparam name="Z">The the target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMergeOpD<X,Y,Z> 
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
    public interface IVMergeOpD<S,T> : IVMergeOpD<S,S,T>
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
    public interface IVMergeOp128<X,Y,Z> : IVMergeOp<N128, N128, N128, Vector128<X>, Vector128<Y>, Vector128<Z>, X, Y,Z>
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
    public interface IVMergeOp256<X,Y,Z> : IVMergeOp<N256, N256, N256, Vector256<X>, Vector256<Y>, Vector256<Z>, X, Y,Z>
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
    public interface IVMergeOp2x128x256<X,Y,Z> : IVMergeOp<N128, N128, N256, Vector128<X>, Vector128<Y>, Vector256<Z>, X, Y,Z>
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
    public interface IVMergeOp2x128x256<S,T> : IVMergeOp<N128, N128, N256, Vector128<S>, Vector128<S>, Vector256<T>, S, S, T>
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