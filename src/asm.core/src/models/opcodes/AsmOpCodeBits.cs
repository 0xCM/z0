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

    [ApiComplete]
    public struct AsmOpCodeBits
    {
        const ulong KindSeg = 0x00_00_00_00_00_00_FF_FF;

        const ulong CountSeg = 0x00_00_00_00_00_FF_00_00;

        const ulong CountSegClear = 0xFF_FF_FF_FF_FF_00_FF_FF;

        const ulong ValSegs = 0xFF_FF_FF_FF_FF_00_00_00;

        ulong Storage;

        [MethodImpl(Inline)]
        internal AsmOpCodeBits(ulong src)
        {
            Storage = src;
        }

        // AsmOcTokenKind [0..15]
        // TokenCount [16..23]
        // Token1Value [24..31]
        // Token2Value [32..39]
        // Token3Value [40..47]

        public byte TokenCount
        {
            [MethodImpl(Inline)]
            get => (byte)((Storage >> 16) & 0xFF);
        }

        [MethodImpl(Inline)]
        public AsmOpCodeBits Include(AsmOcToken src)
        {
            IncTokenCount(out var pos);
            Enable(src.Kind);
            Value(pos) = src.Value;
            return this;
        }

        Span<byte> Values
        {
            [MethodImpl(Inline)]
            get => slice(bytes(this),3);
        }

        [MethodImpl(Inline)]
        ref byte Value(byte pos)
            => ref seek(Values, pos);

        [MethodImpl(Inline)]
        byte IncTokenCount(out byte pos)
        {
            pos = TokenCount;
            var count = (byte)(pos + 1);
            Storage &= CountSegClear;
            Storage |= ((ulong)count << 16);
            return count;
        }

        [MethodImpl(Inline)]
        void Enable(AsmOcTokenKind kind)
        {
            Storage |= bit.enable((ushort)Storage, (byte)((byte)kind - 1));
        }
    }
}