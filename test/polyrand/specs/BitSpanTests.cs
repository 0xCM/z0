//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct BitSpanTests
    {
        [MethodImpl(Inline), Op]
        public static ref Parse define(out Parse dst, ushort reps = 100, ushort minbits = 18, ushort maxbits = 2058)
        {
            dst.RepCount = reps;
            dst.MinBitCount = minbits;
            dst.MaxBitCount = maxbits;
            return ref dst;
        }

        public struct Parse : IRecord<Parse>
        {
            public ushort MinBitCount;

            public ushort MaxBitCount;

            public ushort RepCount;
        }
    }
}