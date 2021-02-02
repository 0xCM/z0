//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Range
    {
        public long Min {get;}

        public long Max {get;}

        [MethodImpl(Inline)]
        public Range(long min, long max)
        {
            Min = min;
            Max = max;
        }

        [MethodImpl(Inline)]
        public static implicit operator Range((long min, long max) src)
            => new Range(src.min, src.max);
    }
}