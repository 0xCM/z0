//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    public readonly partial struct WfDelegates
    {
        [SuppressUnmanagedCodeSecurity]
        public delegate ref T Editor<S,T>(in S src, ref T dst);

        [SuppressUnmanagedCodeSecurity]
        public delegate ref T TableEditor<S,T>(ref S src, ref T dst)
            where S : struct
            where T : struct;
    }
}