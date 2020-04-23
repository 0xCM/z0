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
    public interface IVSvcTernaryOp128<T> : ISVTernaryOp128D<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSvcTernaryOp256<T> : ISVTernaryOp256D<T>
        where T : unmanaged
    {

    }
}