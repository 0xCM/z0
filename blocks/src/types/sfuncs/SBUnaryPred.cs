//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryPred16Api<T> : ISBOpApi<W16,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block16<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryPred32Api<T> : ISBOpApi<W32,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block32<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryPred64Api<T> : ISBOpApi<W64,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block64<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryPred128Api<T> : ISBOpApi<W128,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block128<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryPred256Api<T> : ISBOpApi<W256,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block256<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBUnaryPred512Api<T> : ISBOpApi<W512,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block512<T> src, Span<bit> dst);
    }
}