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
    /// Characterizes a vectorized emitter
    /// </summary>
    /// <typeparam name="W">The vector width type</typeparam>
    /// <typeparam name="V">The vector type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVEmitter<W,V,T> : IVFunc, IEmitter<V>
        where W : unmanaged, ITypeWidth<W>
        where V : struct
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVEmitter128<T> : IVEmitter<W128,Vector128<T>,T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVEmitter256<T> : IVEmitter<W256,Vector256<T>,T>
        where T : unmanaged
    {

    }    
}