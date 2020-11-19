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

   public struct LoopHost<H,I>
        where I : unmanaged
        where H : struct
    {
        public H Host;

        public IntegralLoop<I> Loop;
    }
}