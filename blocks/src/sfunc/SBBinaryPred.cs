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
    public interface ISBBinaryPred16Api<T> : ISBOpApi<W16,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block16<T> a, in Block16<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryPred32Api<T> : ISBOpApi<W32,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block32<T> a, in Block32<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryPred64Api<T> : ISBOpApi<W64,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block64<T> a, in Block64<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryPred128Api<T> : ISBOpApi<W128,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block128<T> a, in Block128<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryPred256Api<T> : ISBOpApi<W256,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block256<T> a, in Block256<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryPred512Api<T> : ISBOpApi<W512,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block512<T> a, in Block512<T> b, Span<bit> dst);
    }

}