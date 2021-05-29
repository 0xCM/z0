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
    using static Typed;
    using static AsmLayoutSegment;

    [ApiHost]
    public partial class AsmEncoder : AppService<AsmEncoder>
    {
        /// <summary>
        /// ModRM = [Mod:[7:6] | Reg:[5:3] | Rm:[2:0]]
        /// </summary>
        public void ShowModRmBits()
        {
            void emit(ShowLog dst)
            {
                var f0 = BitSeq.bits(n3);
                var f1 = BitSeq.bits(n3);
                var f2 = BitSeq.bits(n2);
                var i=0;

                for(var c=0u; c<f2.Length; c++)
                for(var b=0u; b<f1.Length; b++)
                for(var a=0u; a<f0.Length; a++,i++)
                {
                    var m1 = modrm(skip(f0, a), skip(f1, b), skip(f2, c));
                    var m2 = modrm((byte)i);
                    render(m1, dst.Buffer);
                    dst.Buffer.Append(" ^ ");
                    render(m2, dst.Buffer);
                    dst.Buffer.Append(" = ");
                    dst.Buffer.Append((m1^m2).Encoded.FormatBits());
                    dst.ShowBuffer();
                }
           }

            Show("modrm", FS.Log, emit);
        }

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