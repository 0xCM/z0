//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;

    using static SFx;

    [SuppressUnmanagedCodeSecurity]
    public interface ICheckSF128<S,T> : IFunc<S,Vector128<T>,Bit32>
        where S : unmanaged
        where T : unmanaged
    {

    }

    public interface ICheckSF256<S,T> : IFunc<S, Vector256<T>, Bit32>
        where S : unmanaged
        where T : unmanaged
    {

    }
}