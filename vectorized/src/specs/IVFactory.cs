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
    /// Characterizes a function that produces a vector predicated on a source value
    /// </summary>
    /// <typeparam name="W">The vector width</typeparam>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="V">The target vector type</typeparam>
    /// <typeparam name="T">The target vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFactory<W,S,V,T> : IVFunc, ISFApi<S,V>
        where W : unmanaged, ITypeWidth<W>
        where T : unmanaged
        where V : struct
    {

    }

    /// <summary>
    /// Charcterizes an operator that produces a 128-bit target vector predicated on a source value
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFactory128<S,T> : IVFactory<W128,S,Vector128<T>,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Charcterizes an operator that produces a 256-bit target vector predicated on a source value
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFactory256<S,T> : IVFactory<W256,S,Vector256<T>,T>
        where T : unmanaged
    {

    }
}