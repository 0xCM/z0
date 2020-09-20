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
        public static WfHost<H> host<H>()
            where H : WfHost<H>, new()
                => new H();

        [MethodImpl(Inline)]
        public static WfHost<H,S> host<H,S>()
            where H : WfHost<H,S>, new()
            where S : struct
                => new H();
    }
}