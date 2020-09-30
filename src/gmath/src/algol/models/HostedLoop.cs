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

   public struct HostedLoop<H,I>
        where I : unmanaged
        where H : struct, ILoopHost<H,I>
    {
        public H Host;

        public Loop<I> Loop;
    }
}