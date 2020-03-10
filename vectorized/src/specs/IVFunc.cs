//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Common base interface for vectorized functions
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFunc : IFunc
    {
        FunctionClass IFunc.Class => FunctionClass.Vectorized;

    }

    /// <summary>
    /// Common base interface vectorized decomposition facets
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IVDecompositionFacet
    {

    }

    /// <summary>
    /// Characterizes a vectorized unary function
    /// </summary>
    /// <typeparam name="W1">The bit width type of the first vector</typeparam>
    /// <typeparam name="W2">The bit width type of the second vector</typeparam>
    /// <typeparam name="V1">The type of the first vector</typeparam>
    /// <typeparam name="V2">The type of the second vector</typeparam>
    /// <typeparam name="T1">The component type of the first vector</typeparam>
    /// <typeparam name="T2">The component type of the second vector</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFunc<W1,W2,V1,V2,T1,T2> : IVFunc, IFunc<V1,V2>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where T1 : unmanaged
        where T2 : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.UnaryFunc | FunctionClass.Vectorized;

    }

    /// <summary>
    /// Characterizes a vectorized binary function
    /// </summary>
    /// <typeparam name="W1">The bit width type of the first vector</typeparam>
    /// <typeparam name="W2">The bit width type of the second vector</typeparam>
    /// <typeparam name="W3">The bit width type of the result vector</typeparam>
    /// <typeparam name="V1">The type of the first vector</typeparam>
    /// <typeparam name="V2">The type of the second vector</typeparam>
    /// <typeparam name="V3">The type of the result vector</typeparam>
    /// <typeparam name="T1">The component type of the first vector</typeparam>
    /// <typeparam name="T2">The component type of the second vector</typeparam>
    /// <typeparam name="T3">The component type of the result vector</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFunc<W1,W2,W3,V1,V2,V3,T1,T2,T3> : IVFunc, IFunc<V1,V2,V3>
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
        FunctionClass IFunc.Class => FunctionClass.BinaryFunc | FunctionClass.Vectorized;

    }

    /// <summary>
    /// Characterizes a vectorized ternary function
    /// </summary>
    /// <typeparam name="W1">The bit width type of the first vector</typeparam>
    /// <typeparam name="W2">The bit width type of the second vector</typeparam>
    /// <typeparam name="W3">The bit width type of the third vector</typeparam>
    /// <typeparam name="W4">The bit width type of the result vector</typeparam>
    /// <typeparam name="V1">The type of the first vector</typeparam>
    /// <typeparam name="V2">The type of the second vector</typeparam>
    /// <typeparam name="V3">The type of the third vector</typeparam>
    /// <typeparam name="V4">The type of the result vector</typeparam>
    /// <typeparam name="T1">The component type of the first vector</typeparam>
    /// <typeparam name="T2">The component type of the second vector</typeparam>
    /// <typeparam name="T3">The component type of the third vector</typeparam>
    /// <typeparam name="T4">The component type of the result vector</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFunc<W1,W2,W3,W4,V1,V2,V3,V4,T1,T2,T3,T4> : IVFunc, IFunc<V1,V2,V3,V4>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where W3 : unmanaged, ITypeNat
        where W4 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where V3 : struct
        where V4 : struct
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.TernaryFunc | FunctionClass.Vectorized;
    }

    /// <summary>
    /// Characterizes a function that produces a 128-bit vector from a 256-bit vector
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVReducer256<T> : IVFunc<N256,N128,Vector256<T>,Vector128<T>,T,T>
        where T : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.V256 | FunctionClass.Converter;
    }

}