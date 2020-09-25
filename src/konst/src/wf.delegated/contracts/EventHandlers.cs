//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    partial struct WfDelegates
    {
        [Free]
        public delegate void EventHandler(IWfEvent src);

        [Free]
        public delegate void EventHandler<E>(in E src)
            where E : struct, IWfEvent<E>;
    }
}