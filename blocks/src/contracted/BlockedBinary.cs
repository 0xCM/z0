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
    public delegate ref readonly Block16<T> BinaryBlockedOp16<T>(in Block16<T> a, in Block16<T> b, in Block16<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block32<T> BinaryBlockedOp32<T>(in Block32<T> a, in Block32<T> b, in Block32<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block64<T> BinaryBlockedOp64<T>(in Block64<T> a, in Block64<T> b, in Block64<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block128<T> BinaryBlockedOp128<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block256<T> BinaryBlockedOp256<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block512<T> BinaryBlockedOp512<T>(in Block512<T> a, in Block512<T> b, in Block512<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp16<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        ref readonly Block16<T> Invoke(in Block16<T> a, in Block16<T> b, in Block16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp32<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        ref readonly Block32<T> Invoke(in Block32<T> a, in Block32<T> b, in Block32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp64<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        ref readonly Block64<T> Invoke(in Block64<T> a, in Block64<T> b, in Block64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp128<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp256<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp512<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        ref readonly Block512<T> Invoke(in Block512<T> a, in Block512<T> b, in Block512<T> dst);
    }

}