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
    public interface IVSvcBinaryOp128<T> : IBlockedBinaryOp128<T>, ISVBinaryOp128D<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVSvcBinaryOp256<T> : IBlockedBinaryOp256<T>, ISVBinaryOp256D<T>
        where T : unmanaged
    {

    }
}