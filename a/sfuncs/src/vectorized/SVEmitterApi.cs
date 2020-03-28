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
    public interface ISVEmitterApi<W,V,T> : ISVFuncApi, ISEmitter<V>
        where W : unmanaged, ITypeWidth<W>
        where V : struct
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVEmitter128Api<T> : ISVEmitterApi<W128,Vector128<T>,T>, ISVFunc128Api<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVEmitter256Api<T> : ISVEmitterApi<W256,Vector256<T>,T>, ISVFunc256Api<T>
        where T : unmanaged
    {

    }    
}