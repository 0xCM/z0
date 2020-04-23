//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using static Seed;

    [SuppressUnmanagedCodeSecurity]
    public interface IVSvcUnaryOp128<T> : ISVUnaryOp128D<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSvcUnaryOp256<T> : ISVUnaryOp256D<T>
        where T : unmanaged
    {

    }
}