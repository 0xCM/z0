//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct BitSpanCases
    {
        [MethodImpl(Inline), Op]
        public static ref ParseCase define(out ParseCase dst, ushort reps = 100, ushort minbits = 18, ushort maxbits = 2058)
        {
            dst.RepCount = reps;
            dst.MinBitCount = minbits;
            dst.MaxBitCount = maxbits;
            return ref dst;
        }

        public struct ParseCase : IRecord<ParseCase>
        {
            public ushort MinBitCount;

            public ushort MaxBitCount;

            public ushort RepCount;
        }
    }
}