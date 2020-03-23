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
    /// Characterizes a vectorized ternary operator
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVTernaryOpApi<V> : ISVFuncApi, ISFTernaryOpApi<V>
        where V : struct
    {
        
    }
 
    /// <summary>
    /// Characterizes a vectorized ternary operator parameterized by operand bit-width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVTernaryOpApi<W,V> : ISVTernaryOpApi<V>
        where W : unmanaged, ITypeWidth
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized ternary operator parameterized by operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVTernaryOpApi<W,V,T> : ISVTernaryOpApi<W,V>
        where W : unmanaged, ITypeWidth
        where V : struct
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized 128-bit ternary operator
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVTernaryOp128Api<T> : ISVTernaryOpApi<W128,Vector128<T>,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized 256-bit ternary operator
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVTernaryOp256Api<T> : ISVTernaryOpApi<W256,Vector256<T>,T>
        where T : unmanaged
    {
                
    }

    /// <summary>
    /// Characterizes a vectorized 128-bit ternary operator that also supports evaluation via scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVTernaryOp128DApi<T> : ISVTernaryOp128Api<T>, IVTernaryOpD<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized 256-bit ternary operator that also supports evaluation via scalar decomposition
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVTernaryOp256DApi<T> : ISVTernaryOp256Api<T>, IVTernaryOpD<T>
        where T : unmanaged
    {
        
    }

}