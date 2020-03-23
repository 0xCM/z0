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
    /// Characterizes an operation that accepts a source span and produces a derived target vector
    /// </summary>
    /// <typeparam name="W">The target vector width</typeparam>
    /// <typeparam name="S">The span source cell type</typeparam>
    /// <typeparam name="V">The target vector type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVSpanLoad<W,S,V,T> : IVFunc
        where W : unmanaged, ITypeWidth<W>
        where S : unmanaged
        where V : struct
        where T : unmanaged
    {
        V Invoke(ReadOnlySpan<S> src, int offset);
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSpanLoad128<S,T> : IVSpanLoad<W128, S, Vector128<T>,T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSpanLoad128<T> : IVSpanLoad128<T,T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSpanLoad256<S,T> : IVSpanLoad<W128, S, Vector256<T>,T>
        where S : unmanaged
        where T : unmanaged
    {


    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSpanLoad256<T> : IVSpanLoad256<T,T>
        where T : unmanaged
    {

    }
}