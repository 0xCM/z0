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
    public interface IVSvcTernaryOp128<T> : ISBTernaryOp128Api<T>, ISVTernaryOp128DApi<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSvcTernaryOp256<T> : ISBTernaryOp256Api<T>, ISVTernaryOp256DApi<T>
        where T : unmanaged
    {

    }

}