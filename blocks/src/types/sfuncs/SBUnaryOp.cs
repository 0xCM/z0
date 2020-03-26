//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryOp16Api<T> : ISBOpApi<W16,T>
        where T : unmanaged
    {
        ref readonly Block16<T> Invoke(in Block16<T> src, in Block16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryOp32Api<T> : ISBOpApi<W32,T>
        where T : unmanaged
    {
        ref readonly Block32<T> Invoke(in Block32<T> src, in Block32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryOp64Api<T> : ISBOpApi<W64,T>
        where T : unmanaged
    {
        ref readonly Block64<T> Invoke(in Block64<T> src, in Block64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryOp128Api<T> : ISBOpApi<W128,T>
        where T : unmanaged
    {
        ref readonly Block128<T> Invoke(in Block128<T> src, in Block128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryOp256Api<T> : ISBOpApi<W256,T>
        where T : unmanaged
    {
        ref readonly Block256<T> Invoke(in Block256<T> src, in Block256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryOp512Api<T> : ISBOpApi<W512,T>
        where T : unmanaged
    {
        ref readonly Block512<T> Invoke(in Block512<T> src, in Block512<T> dst);
    }
}