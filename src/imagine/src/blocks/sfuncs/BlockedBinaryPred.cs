//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedBinaryPred8<T> : IBlockedFunc<W8,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block8<T> a, in Block8<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedBinaryPred16<T> : IBlockedFunc<W16,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block16<T> a, in Block16<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedBinaryPred32<T> : IBlockedFunc<W32,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block32<T> a, in Block32<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedBinaryPred64<T> : IBlockedFunc<W64,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block64<T> a, in Block64<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedBinaryPred128<T> : IBlockedFunc<W128,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block128<T> a, in Block128<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedBinaryPred256<T> : IBlockedFunc<W256,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block256<T> a, in Block256<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISBBinaryPred512Api<T> : IBlockedFunc<W512,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block512<T> a, in Block512<T> b, Span<bit> dst);
    }
}