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

    public struct Accrue<I> : ILoopHost<Accrue<I>,I>
        where I : unmanaged
    {
        I Total;

        [MethodImpl(Inline)]
        public void Step(I i)
            => Total = gmath.add(Total,i);
    }
}