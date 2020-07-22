//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct Timestamp
    {
        readonly ulong Ticks;

        [MethodImpl(Inline)]
        internal Timestamp(ulong ticks)
            => Ticks = ticks;        

        
    }
}