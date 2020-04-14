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
    public interface IVSvcBinaryOp128<T> : ISBBinaryOp128Api<T>, ISVBinaryOp128DApi<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSvcBinaryOp256<T> : ISBBinaryOp256Api<T>, ISVBinaryOp256DApi<T>
        where T : unmanaged
    {

    }

}