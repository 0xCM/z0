//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    partial struct WfDelegates
    {
        [SuppressUnmanagedCodeSecurity]
        public delegate ref T Emitter<S,T>(in S src, out T dst);

        [SuppressUnmanagedCodeSecurity]
        public delegate ref T TableEmitter<S,T>(in S src, out T dst)
            where S : struct
            where T : struct;
    }
}