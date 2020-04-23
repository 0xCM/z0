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
    public interface ISVFSpanLoad<W,S,V,T> : ISVFunc
        where W : unmanaged, ITypeWidth<W>
        where S : unmanaged
        where V : struct
        where T : unmanaged
    {
        V Invoke(ReadOnlySpan<S> src, int offset);
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVFSpanLoad128<S,T> : ISVFSpanLoad<W128, S, Vector128<T>,T>, ISVFunc128<T> 
        where S : unmanaged
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVFSpanLoad128<T> : ISVFSpanLoad128<T,T>, ISVFunc256<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVFSpanLoad256<S,T> : ISVFSpanLoad<W128, S, Vector256<T>,T>, ISVFunc256<T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVFSpanLoad256<T> : ISVFSpanLoad256<T,T>
        where T : unmanaged
    {

    }
}