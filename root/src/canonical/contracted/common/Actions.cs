//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;

    [SuppressUnmanagedCodeSecurity]
    public interface IAction<A> : IFunc
    {
        void Invoke(A a);

        Action<A> Operation => Invoke;
    }
}