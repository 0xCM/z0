//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

   public struct LoopHost<H,I>
        where I : unmanaged, IComparable<I>
        where H : struct
    {
        public H Host;

        public Loop<I> Loop;
    }
}