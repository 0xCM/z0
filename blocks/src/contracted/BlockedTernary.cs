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
    public interface ITernaryBlockedOp16<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        ref readonly Block16<T> Invoke(in Block16<T> a, in Block16<T> b, in Block16<T> c, in Block16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp32<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        ref readonly Block32<T> Invoke(in Block32<T> a, in Block32<T> b, in Block32<T> c, in Block32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp64<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        ref readonly Block64<T> Invoke(in Block64<T> a, in Block64<T> b, in Block64<T> c, in Block64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp128<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c, in Block128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp256<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c,in Block256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp512<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        ref readonly Block512<T> Invoke(in Block512<T> a, in Block512<T> b, in Block512<T> c, in Block512<T> dst);
    }
}