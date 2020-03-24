//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;


    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryOp16Api<T> : ISBOpApi<W16,T>
        where T : unmanaged
    {
        ref readonly Block16<T> Invoke(in Block16<T> a, in Block16<T> b, in Block16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryOp32Api<T> : ISBOpApi<W32,T>
        where T : unmanaged
    {
        ref readonly Block32<T> Invoke(in Block32<T> a, in Block32<T> b, in Block32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryOp64Api<T> : ISBOpApi<W64,T>
        where T : unmanaged
    {
        ref readonly Block64<T> Invoke(in Block64<T> a, in Block64<T> b, in Block64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryOp128Api<T> : ISBOpApi<W128,T>
        where T : unmanaged
    {
        ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryOp256Api<T> : ISBOpApi<W256,T>
        where T : unmanaged
    {
        ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryOp512Api<T> : ISBOpApi<W512,T>
        where T : unmanaged
    {
        ref readonly Block512<T> Invoke(in Block512<T> a, in Block512<T> b, in Block512<T> dst);
    }
}