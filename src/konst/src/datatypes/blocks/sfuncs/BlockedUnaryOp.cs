//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryOp8<T> : IBlockedFunc<W8,T>
        where T : unmanaged
    {
        ref readonly Block8<T> Invoke(in Block8<T> src, in Block8<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryOp16<T> : IBlockedFunc<W16,T>
        where T : unmanaged
    {
        ref readonly Block16<T> Invoke(in Block16<T> src, in Block16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryOp32<T> : IBlockedFunc<W32,T>
        where T : unmanaged
    {
        ref readonly Block32<T> Invoke(in Block32<T> src, in Block32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryOp64<T> : IBlockedFunc<W64,T>
        where T : unmanaged
    {
        ref readonly Block64<T> Invoke(in Block64<T> src, in Block64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryOp128<T> : IBlockedFunc<W128,T>
        where T : unmanaged
    {
        ref readonly Block128<T> Invoke(in Block128<T> src, in Block128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryOp256<T> : IBlockedFunc<W256,T>
        where T : unmanaged
    {
        ref readonly Block256<T> Invoke(in Block256<T> src, in Block256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedUnaryOp512<T> : IBlockedFunc<W512,T>
        where T : unmanaged
    {
        ref readonly Block512<T> Invoke(in Block512<T> src, in Block512<T> dst);
    }
}