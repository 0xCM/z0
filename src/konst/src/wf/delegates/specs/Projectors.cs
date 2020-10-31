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
        public delegate T Projector<S,T>(in S src);

        [Free]
        public delegate T TableProjector<S,T>(in S src)
            where S : struct;
    }
}