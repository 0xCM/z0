//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
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
    public interface IVSpanSourced<W,S,V,T> : IVFunc, ISpanSourced<S,V>
        where W : unmanaged, ITypeNat    
        where S : unmanaged
        where V : struct
        where T : unmanaged
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSpanSourced128<S,T> : IVSpanSourced<N128, S, Vector128<T>,T>
        where S : unmanaged
        where T : unmanaged
    {


    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSpanSourced128<T> : IVSpanSourced128<T,T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSpanSourced256<S,T> : IVSpanSourced<N256, S, Vector256<T>,T>
        where S : unmanaged
        where T : unmanaged
    {


    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSpanSourced256<T> : IVSpanSourced256<T,T>
        where T : unmanaged
    {

    }

}