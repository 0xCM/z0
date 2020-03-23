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
    /// Defines trait for a vectorized unary operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOpD<T>
        where T : unmanaged
    {
        T InvokeScalar(T a);
    }

    /// <summary>
    /// Characterizes a vectorized unary operator
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryOpApi<V> : ISVFuncApi, ISFUnaryOpApi<V>
        where V : struct
    {
   
    }

    /// <summary>
    /// Characterizes a vectorized unary operator parameterized by operand bit width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryOpApi<W,V> : ISVUnaryOpApi<V>
        where W : unmanaged, ITypeWidth
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized binary operator parameterized by operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryOpApi<W,V,T> : ISVUnaryOpApi<W,V>
        where W : unmanaged, ITypeWidth
        where V : struct
        where T : unmanaged
    {

    }


    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryOp128Api<T> : ISVUnaryOpApi<W128,Vector128<T>,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryOp256Api<T> : ISVUnaryOpApi<W256,Vector256<T>,T>
        where T : unmanaged
    {
                
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryOp128DApi<T> : ISVUnaryOp128Api<T>, IVUnaryOpD<T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVUnaryOp256DApi<T> : ISVUnaryOp256Api<T>, IVUnaryOpD<T>
        where T : unmanaged
    {
        
    }

}