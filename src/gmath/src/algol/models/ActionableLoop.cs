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

    public struct ActionableLoop<I>
        where I : unmanaged
    {
        public Loop<I> Loop;

        public ILoopAction<I> Action;
    }
}