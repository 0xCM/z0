//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static byte regcount(RegClassCode @class, bit hi = default)
            => Bytes.add(skip(RegClassCounts, (byte)@class), Bytes.mul((byte)hi,4));

        static ReadOnlySpan<byte> RegClassCounts
            => new byte[16]{
                0,      // None
                64,     // GP (no hi)
                6,      // SEG
                3,      // FLAG
                8,      // CR
                8,      // DB
                3,      // IPTR
                3,      // SPTR
                32,     // XMM
                32,     // YMM
                32,     // ZMM
                8,      // MASK
                4,      // BND
                8,      // ST
                8,      // MMX
                68      // GP (with hi)
            };
    }
}