//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Flow
    {
        [MethodImpl(Inline)]
        public static WfHost<H> host<H>(H h = default)
            where H : WfHost<H>, new()
                => new H();

        [MethodImpl(Inline)]
        public static WfHost<H,C> host<H,C>(C config, H h = default)
            where H : WfHost<H,C>, new()
            where C : struct
        {
            var host = new H();
            host.Configure(config);
            return host;
        }
    }
}