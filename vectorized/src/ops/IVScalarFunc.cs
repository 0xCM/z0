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
    /// Characterizes a unary function that accepts a vector argument and returns a scalar value
    /// </summary>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="V">The vector type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVScalarFunc<W,V,T,K> : IVFunc, IFunc<V,K>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
        where K : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.UnaryMeasure | FunctionKind.Vectorized;
    }

    /// <summary>
    /// Characterizes a unary function that accepts a vector argument and an 8-bit immediate and returns a scalar value
    /// </summary>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="V">The vector type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVScalarFuncImm8<W,V,T,K> : IVFunc, IFunc<V,byte,K>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
        where K : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.BinaryMeasure | FunctionKind.Vectorized;
    }

    /// <summary>
    /// Characterizes a binary function that accepts two vector arguments and returns a scalar value
    /// </summary>
    /// <typeparam name="W1">The bit width type of the first vector</typeparam>
    /// <typeparam name="W2">The bit width type of the second vector</typeparam>
    /// <typeparam name="V1">The type of the first vector</typeparam>
    /// <typeparam name="V2">The type of the second vector</typeparam>
    /// <typeparam name="T1">The component type of the first vector</typeparam>
    /// <typeparam name="T2">The component type of the second vector</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVScalarFunc<W1,W2,V1,V2,T1,T2,K> : IVFunc, IFunc<V1,V2,K>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where T1 : unmanaged
        where T2 : unmanaged
        where K : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.BinaryMeasure | FunctionKind.Vectorized;

    }

    /// <summary>
    /// Characterizes a binary function that accepts two vector arguments and an immediate and returns a scalar value
    /// </summary>
    /// <typeparam name="W1">The bit width type of the first vector</typeparam>
    /// <typeparam name="W2">The bit width type of the second vector</typeparam>
    /// <typeparam name="V1">The type of the first vector</typeparam>
    /// <typeparam name="V2">The type of the second vector</typeparam>
    /// <typeparam name="T1">The component type of the first vector</typeparam>
    /// <typeparam name="T2">The component type of the second vector</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVScalarFuncImm8<W1,W2,V1,V2,T1,T2,K> : IVFunc, IFunc<V1,V2,byte,K>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where T1 : unmanaged
        where T2 : unmanaged
        where K : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.TernaryMeasure | FunctionKind.Vectorized;

    }

    /// <summary>
    /// Characterizes a ternary function that accepts three vector arguments and returns a scalar value
    /// </summary>
    /// <typeparam name="W1">The bit width type of the first vector</typeparam>
    /// <typeparam name="W2">The bit width type of the second vector</typeparam>
    /// <typeparam name="W3">The bit width type of the second vector</typeparam>
    /// <typeparam name="V1">The type of the first vector</typeparam>
    /// <typeparam name="V2">The type of the second vector</typeparam>
    /// <typeparam name="V3">The type of the third vector</typeparam>
    /// <typeparam name="T1">The component type of the first vector</typeparam>
    /// <typeparam name="T2">The component type of the second vector</typeparam>
    /// <typeparam name="T3">The component type of the third vector</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVScalarFunc<W1,W2,W3,V1,V2,V3,T1,T2,T3,K> : IVFunc, IFunc<V1,V2,V3,K>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where T1 : unmanaged
        where T2 : unmanaged
        where K : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.TernaryMeasure | FunctionKind.Vectorized;

    }

    /// <summary>
    /// Characterizes a unary function that accepts a 128-bit vector argument and returns a scalar value
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryScalar128<T,K> : IVScalarFunc<N128,Vector128<T>,T,K>
        where T : unmanaged
        where K : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.UnaryMeasure | FunctionKind.V128;
    }

    /// <summary>
    /// Characterizes a unary function that accepts a 128-bit vector and an 8-bit immediate and returns a scalar value
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryScalar128Imm8<T,K> : IVScalarFuncImm8<N128,Vector128<T>,T,K>
        where T : unmanaged
        where K : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.BinaryMeasure | FunctionKind.V128;

    }

    /// <summary>
    /// Defines trait for a vecorized unary scalar funnction that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryScalarFuncD<T,K>
        where T : unmanaged
        where K : unmanaged
    {
        K InvokeScalar(T a);
    }

    /// <summary>
    /// Defines trait for a vecorized binary scalar funnction that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryScalarFuncD<T,K>
        where T : unmanaged
        where K : unmanaged
    {
        K InvokeScalar(T a, T b);
    }

    /// <summary>
    /// Defines trait for a vecorized binary scalar funnction that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryScalarFuncD<T,K>
        where T : unmanaged
        where K : unmanaged
    {
        K InvokeScalar(T a, T b, T c);
    }


    /// <summary>
    /// Characterizes a unary function that accepts a 128-bit vector argument and returns a scalar value
    /// that supports scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryScalar128D<T,K> : IVScalarFunc<N128,Vector128<T>,T,K>, IVUnaryScalarFuncD<T,K>
        where T : unmanaged
        where K : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a unary function that accepts a 128-bit vector argument and an 8-bit immedate and 
    /// returns a scalar value that supports scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryScalar128Imm8D<T,K> : IVScalarFuncImm8<N128,Vector128<T>,T,K>, IVUnaryScalarFuncD<T,K>
        where T : unmanaged
        where K : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a binary function that accepts homogenous 128-bit vector arguments and returns a scalar value
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryScalar128<T,K> : IVScalarFunc<N128, N128, Vector128<T>,Vector128<T>,T,T,K>
        where T : unmanaged
        where K : unmanaged
    {

    }    

    /// <summary>
    /// Characterizes a binary function that accepts homogenous 128-bit vector arguments and returns a scalar value
    /// that supports scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryScalar128D<T,K> : IVScalarFunc<N128, N128, Vector128<T>,Vector128<T>,T,T,K>, IVBinaryScalarFuncD<T,K>
        where T : unmanaged
        where K : unmanaged
    {

    }    

    /// <summary>
    /// Characterizes a ternary function that accepts homogenous 128-bit vector arguments and returns a scalar value
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryScalar128<T,K> : IVScalarFunc<N128, N128, N128, Vector128<T>, Vector128<T>, Vector128<T>, T,T,T,K>
        where K : unmanaged
        where T : unmanaged
    {

    }    

    /// <summary>
    /// Characterizes a ternary function that accepts homogenous 128-bit vector arguments and returns a scalar value
    /// that supports scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryScalar128D<T,K> : IVScalarFunc<N128, N128, N128, Vector128<T>, Vector128<T>, Vector128<T>, T,T,T,K>, IVTernaryScalarFuncD<T,K>
        where K : unmanaged
        where T : unmanaged
    {

    }    

    /// <summary>
    /// Characterizes a unary function that accepts a 256-bit vector argument and returns a scalar value
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryScalar256<T,K> : IVScalarFunc<N256,Vector256<T>,T,K>
        where K : unmanaged
        where T : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.UnaryMeasure | FunctionKind.V256;

    }

    /// <summary>
    /// Characterizes a unary function that accepts a 256-bit vector argument along with an 8-bit immediate and returns a scalar value
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryScalar256Imm8<T,K> : IVScalarFuncImm8<N256,Vector256<T>,T,K>
        where K : unmanaged
        where T : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.BinaryMeasure | FunctionKind.V256;

    }

    /// <summary>
    /// Characterizes a unary function that accepts a 256-bit vector argument and returns a scalar value
    /// that supports scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryScalar256D<T,K> : IVScalarFunc<N256,Vector256<T>,T,K>, IVUnaryScalarFuncD<T,K>
        where K : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a unary function that accepts a 256-bit vector argument along with an 8-bit immediate and returns a scalar value
    /// that supports scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryScalar256Imm8D<T,K> : IVScalarFuncImm8<N256,Vector256<T>,T,K>, IVUnaryScalarFuncD<T,K>
        where K : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a binary function that accepts homogenous 256-bit vector arguments and returns a scalar value
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryScalar256<T,K> : IVScalarFunc<N256, N256, Vector256<T>,Vector256<T>, T,T,K>
        where T : unmanaged
        where K : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.BinaryMeasure | FunctionKind.V256;
    }    

    /// <summary>
    /// Characterizes a binary function that accepts homogenous 256-bit vector arguments and returns a scalar value
    /// that supports scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryScalar256D<T,K> : IVScalarFunc<N256, N256, Vector256<T>,Vector256<T>, T,T,K>, IVBinaryScalarFuncD<T,K>
        where T : unmanaged
        where K : unmanaged
    {

    }    

    /// <summary>
    /// Characterizes a ternary function that accepts homogenous 256-bit vector arguments and returns a scalar value
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryScalar256<T,K> : IVScalarFunc<N256, N256, N256, Vector256<T>, Vector256<T>, Vector256<T>, T,T,T,K>
        where T : unmanaged
        where K : unmanaged
    {
        FunctionKind IFunc.Kind => FunctionKind.TernaryMeasure | FunctionKind.V256;
    }    

    /// <summary>
    /// Characterizes a ternary function that accepts homogenous 256-bit vector arguments that returns a scalar value 
    /// that supports scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryScalar256D<T,K> : IVScalarFunc<N256, N256, N256, Vector256<T>, Vector256<T>, Vector256<T>, T,T,T,K>, IVTernaryScalarFuncD<T,K>
        where T : unmanaged
        where K : unmanaged
    {

    }    

}