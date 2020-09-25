//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct WfDelegates
    {
        [Free]
        public delegate ref T DataEmitter<S,T>(in S src, out T dst)
            where S : struct
            where T : struct;
    }
}