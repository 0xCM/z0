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
    public delegate ref readonly Block16<T> UnaryBlockedOp16<T>(in Block16<T> src, in Block16<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block32<T> UnaryBlockedOp32<T>(in Block32<T> src, in Block32<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block64<T> UnaryBlockedOp64<T>(in Block64<T> src, in Block64<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block128<T> UnaryBlockedOp128<T>(in Block128<T> src, in Block128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block256<T> UnaryBlockedOp256<T>(in Block256<T> src, in Block256<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block512<T> UnaryBlockedOp512<T>(in Block512<T> src, in Block512<T> dst)
        where T : unmanaged;


    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp16<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        ref readonly Block16<T> Invoke(in Block16<T> src, in Block16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp32<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        ref readonly Block32<T> Invoke(in Block32<T> src, in Block32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp64<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        ref readonly Block64<T> Invoke(in Block64<T> src, in Block64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp128<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        ref readonly Block128<T> Invoke(in Block128<T> src, in Block128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp256<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        ref readonly Block256<T> Invoke(in Block256<T> src, in Block256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp512<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        ref readonly Block512<T> Invoke(in Block512<T> src, in Block512<T> dst);
    }
}