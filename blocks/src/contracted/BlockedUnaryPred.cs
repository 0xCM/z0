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
    public interface IUnaryBlockedPred16<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block16<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred32<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block32<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred64<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block64<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred128<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block128<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred256<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block256<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred512<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block512<T> src, Span<bit> dst);
    }
}