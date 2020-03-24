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
    /// Characterizes a unary function that accepts a vector argument and an 8-bit immediate and returns a scalar value
    /// </summary>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="V">The vector type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVFImm8ScalarApi<W,V,T,K> : ISVFuncApi, ISFApi<V,byte,K>
        where W : unmanaged, ITypeWidth
        where V : struct
        where T : unmanaged
        where K : unmanaged
    {

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
    public interface ISVFImm8ScalarApi<W1,W2,V1,V2,T1,T2,K> : ISVFuncApi, ISFApi<V1,V2,byte,K>
        where W1 : unmanaged, ITypeWidth
        where W2 : unmanaged, ITypeWidth
        where V1 : struct
        where V2 : struct
        where T1 : unmanaged
        where T2 : unmanaged
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
    public interface ISVFImm8Scalar128DApi<T,K> : ISVFImm8ScalarApi<W128,Vector128<T>,T,K>, IVUnaryScalarFuncD<T,K>, ISVFunc128Api<T>
        where T : unmanaged
        where K : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a unary function that accepts a 128-bit vector and an 8-bit immediate and returns a scalar value
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryScalar128Api<T,K> : ISVFImm8ScalarApi<W128,Vector128<T>,T,K>, ISVFunc128Api<T>
        where T : unmanaged
        where K : unmanaged
    {

    }


    /// <summary>
    /// Characterizes a unary function that accepts a 128-bit vector argument and returns a scalar value
    /// that supports scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryScalar128DApi<T,K> : ISVScalarApi<W128,Vector128<T>,T,K>, IVUnaryScalarFuncD<T,K>, ISVFunc128Api<T>
        where T : unmanaged
        where K : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a unary function that accepts a 256-bit vector argument along with an 8-bit immediate and returns a scalar value
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="K">The scalar result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryScalar256Api<T,K> : ISVFImm8ScalarApi<W256,Vector256<T>,T,K>, ISVFunc256Api<T>
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
    public interface ISVImm8UnaryScalar256DApi<T,K> : ISVFImm8ScalarApi<W256,Vector256<T>,T,K>, IVUnaryScalarFuncD<T,K>, ISVFunc256Api<T>
        where K : unmanaged
        where T : unmanaged
    {

    }


}