//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedTernaryOp8<T> : IBlockedFunc<W8,T>
        where T : unmanaged
    {
        ref readonly SpanBlock8<T> Invoke(in SpanBlock8<T> a, in SpanBlock8<T> b, in SpanBlock8<T> c, in SpanBlock8<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedTernaryOp16<T> : IBlockedFunc<W16,T>
        where T : unmanaged
    {
        ref readonly SpanBlock16<T> Invoke(in SpanBlock16<T> a, in SpanBlock16<T> b, in SpanBlock16<T> c, in SpanBlock16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedTernaryOp32<T> : IBlockedFunc<W32,T>
        where T : unmanaged
    {
        ref readonly SpanBlock32<T> Invoke(in SpanBlock32<T> a, in SpanBlock32<T> b, in SpanBlock32<T> c, in SpanBlock32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedTernaryOp64<T> : IBlockedFunc<W64,T>
        where T : unmanaged
    {
        ref readonly SpanBlock64<T> Invoke(in SpanBlock64<T> a, in SpanBlock64<T> b, in SpanBlock64<T> c, in SpanBlock64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedTernaryOp128<T> : IBlockedFunc<W128,T>
        where T : unmanaged
    {
        ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> c, in SpanBlock128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedTernaryOp256<T> : IBlockedFunc<W256,T>
        where T : unmanaged
    {
        ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> c,in SpanBlock256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedTernaryOp512<T> : IBlockedFunc<W512,T>
        where T : unmanaged
    {
        ref readonly SpanBlock512<T> Invoke(in SpanBlock512<T> a, in SpanBlock512<T> b, in SpanBlock512<T> c, in SpanBlock512<T> dst);
    }
}