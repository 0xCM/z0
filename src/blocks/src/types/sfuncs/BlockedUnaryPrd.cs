//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

   [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryPred8<T> : IBlockedFunc<W8,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block8<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryPred16<T> : IBlockedFunc<W16,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block16<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryPred32<T> : IBlockedFunc<W32,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block32<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryPred64<T> : IBlockedFunc<W64,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block64<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryPred128<T> : IBlockedFunc<W128,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block128<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryPred256<T> : IBlockedFunc<W256,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block256<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryPred512<T> : IBlockedFunc<W512,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block512<T> src, Span<bit> dst);
    }
}