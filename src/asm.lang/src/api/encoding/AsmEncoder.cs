//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static AsmLayoutSegment;

    [ApiHost]
    public readonly partial struct AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static Vsib vsib(byte src)
            => new Vsib(src);

        static ReadOnlySpan<byte> _RexPrefixBytes
            => new byte[16]{0x40,0x41,0x42,0x43,0x44,0x45,0x46,0x47,0x48,0x49,0x4A,0x4B,0x4C,0x4D,0x4E,0x4F};

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RexPrefix> RexPrefixBits()
            => recover<RexPrefix>(_RexPrefixBytes);

        [MethodImpl(Inline), Op]
        public static AsmLayoutSegment segments(in AsmHexLayout src)
        {
            var segs = AsmLayoutSegment.None;
            if(src.Legacy.IsNonEmpty)
                segs |= LegacySeg;
            if(src.Rex.IsNonEmpty)
                segs |= RexSeg;
            if(src.OpCode.IsNonEmpty)
                segs |= OpCodeSeg;
            if(src.ModRm.IsNonEmpty)
                segs |= ModRmSeg;
            if(src.Sib.IsNonEmpty)
                segs |= SibSeg;
            if(src.Dx.IsNonZero)
                segs |= DxSeg;
            if(src.Imm.IsNonZero)
                segs |= ImmSeg;
            return segs;
        }
   }
}