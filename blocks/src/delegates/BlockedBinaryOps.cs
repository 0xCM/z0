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


}