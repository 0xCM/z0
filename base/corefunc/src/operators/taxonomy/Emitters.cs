//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Chracterizes an operation that produces a value that does not depend on arguments
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter<A> : IFunc<A>
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized emitter
    /// </summary>
    /// <typeparam name="W">The vector width type</typeparam>
    /// <typeparam name="V">The vector type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVEmitter<W,V,T> : IEmitter<V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVEmitter128<T> : IVEmitter<N128,Vector128<T>,T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVEmitter256<T> : IVEmitter<N256,Vector256<T>,T>
        where T : unmanaged
    {

        
    }    
}