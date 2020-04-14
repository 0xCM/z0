//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static Seed;

    [SuppressUnmanagedCodeSecurity]
    public interface IVSvcUnaryOp128<T> : ISBUnaryOp128Api<T>, ISVUnaryOp128DApi<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSvcUnaryOp256<T> : ISBUnaryOp256Api<T>, ISVUnaryOp256DApi<T>
        where T : unmanaged
    {

    }


}