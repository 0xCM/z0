//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

   public struct LoopHost<H,I>
        where I : unmanaged
        where H : struct
    {
        public H Host;

        public Loop<I> Loop;
    }
}