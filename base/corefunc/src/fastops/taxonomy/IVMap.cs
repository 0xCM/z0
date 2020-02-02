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
    /// Characterizes a vectorized transformation
    /// </summary>
    /// <typeparam name="U">The source operand type</typeparam>
    /// <typeparam name="T">The target operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap<U,V> : IVFunc, IMap<U,V>
        where U : struct
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized transformation parameterized by operand source/target bit widths and source/target component types
    /// </summary>
    /// <typeparam name="W1">The bit-width type of the source operand</typeparam>
    /// <typeparam name="W2">The bit-width type of the target operand</typeparam>
    /// <typeparam name="V1">The source operand type</typeparam>
    /// <typeparam name="V2">The target operand type</typeparam>
    /// <typeparam name="T1">The source component type</typeparam>
    /// <typeparam name="T2">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap<W1,W2,V1,V2,T1,T2> : IVMap<V1,V2>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where T1 : unmanaged
        where T2 : unmanaged
    {
        HKFunctionKind IFunc.Kind => HKFunctionKind.UnaryConverter | HKFunctionKind.Vectorized;

    }

    /// <summary>
    /// Characterizes a 128-bit vectorized transformation parameterized by source/target component types
    /// </summary>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap128<S,T> : IVMap<N128,N128,Vector128<S>,Vector128<T>,S,T>
        where S : unmanaged
        where T : unmanaged
    {
        HKFunctionKind IFunc.Kind => HKFunctionKind.UnaryConverter | HKFunctionKind.V128;

    }

    /// <summary>
    /// Characterizes a 128-bit vectorized transformation parameterized by a common component type
    /// </summary>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap128<T> : IVMap128<T,T>
        where T : unmanaged
    {
        HKFunctionKind IFunc.Kind => HKFunctionKind.UnaryOp | HKFunctionKind.V128;

    }

    /// <summary>
    /// Characterizes a 256-bit vectorized transformation parameterized by source/target component types
    /// </summary>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap256<S,T> : IVMap<N256,N256,Vector256<S>,Vector256<T>,S,T>
        where S : unmanaged
        where T : unmanaged
    {
        HKFunctionKind IFunc.Kind => HKFunctionKind.UnaryConverter | HKFunctionKind.V256;

    }

    /// <summary>
    /// Characterizes a 256-bit vectorized transformation parameterized by a common component type
    /// </summary>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap256<T> : IVMap256<T,T>
        where T : unmanaged
    {

        HKFunctionKind IFunc.Kind => HKFunctionKind.UnaryOp | HKFunctionKind.V256;

    }

}