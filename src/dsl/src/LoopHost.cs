//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

   public struct LoopHost<H,I>
        where I : unmanaged
        where H : struct
    {
        public H Host;

        public Loop<I> Loop;
    }
}