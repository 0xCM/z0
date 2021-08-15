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
    using static AsmLayouts;

    [ApiHost]
    public class AsmBits
    {
        const NumericKind Closure = UnsignedInts;

        const char Open = Chars.LBracket;

        const char Delimit = Chars.Pipe;

        const char Sep = Chars.Space;

        const char Close = Chars.RBracket;

        const char Assign = Chars.Eq;

        public static AsmBits service()
            => The;

        OpCodes _OpCodes;

        static AsmBits The;

        public IAsmBitfield OpCodeField()
            => _OpCodes;

        AsmBits()
        {
            _OpCodes = new OpCodes();
        }

        static AsmBits()
        {
            The = new AsmBits();
        }

        sealed class OpCodes : AsmBitfield<AsmTokens.OpCodes>
        {
            public OpCodes()
                : base("OpCodeBits")
            {

            }
        }

        [Op]
        public static uint bitfield3x3x2(Span<char> dst)
        {
            var f0 = BitSeq.bits(n3);
            var f1 = BitSeq.bits(n3);
            var f2 = BitSeq.bits(n2);
            var m=0u;
            for(var k=0; k<f2.Length; k++)
            {
                for(var j=0; j<f1.Length; j++)
                {
                    for(var i=0; i<f0.Length; i++)
                    {
                        var b0 = skip(f0, i);
                        var b1 = skip(f1, j);
                        var b2 = skip(f2, k);
                        var bits = BitNumbers.join(b0,b1,b2);
                        BitRender.render8(bits, ref m, dst);
                        seek(dst,m++) = (char)AsciControlSym.CR;
                        seek(dst,m++) = (char)AsciControlSym.LF;
                    }
                }
            }
            return m;
        }

        [Op]
        public static uint render(in LayoutCore src, Span<char> dst)
        {
            var i=0u;
            seek(dst,i++) = Chars.LBracket;
            AsmBits.rex(src.Rex, ref i, dst);
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Chars.Pipe;
            seek(dst,i++) = Chars.Space;
            AsmBits.opcode(src.OpCode, ref i, dst);
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Chars.Pipe;
            seek(dst,i++) = Chars.Space;
            AsmBits.modrm(src.ModRm, ref i, dst);
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Chars.Pipe;
            seek(dst,i++) = Chars.Space;
            AsmBits.sib(src.Sib, ref i, dst);
            seek(dst,i++) = Chars.RBracket;
            return i;
        }

        [MethodImpl(Inline), Op]
        public static uint vsib(Vsib src, Span<char> dst)
        {
            var i=0u;
            seek(dst,i++) = Open;
            BitNumbers.render(src.SS(), ref i, dst);
            seek(dst,i++) = Chars.Space;
            BitNumbers.render(src.Index(), ref i, dst);
            seek(dst,i++) = Chars.Space;
            BitNumbers.render(src.Base(), ref i, dst);
            seek(dst,i++) = Close;
            return i;
        }

        [MethodImpl(Inline), Op]
        public static uint opcode(Hex8 src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            BitRender.render8(src, ref  i, dst);
            return i-i0;
        }

        [MethodImpl(Inline), Op]
        public static uint rex(RexPrefix src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            BitRender.render8x4(src.Encoded, ref  i, dst);
            return i-i0;
        }

        [Op]
        public static string format(Register src)
        {
            const string Pattern = "[{0,-12} | {1,-8} | {2}]";
            var index = Bitfields.format<RegIndexCode,byte>(src.Code, src.Name, 5);
            var @class = Bitfields.format<RegClassCode,byte>(src.Class, src.Class.ToString(), 4);
            var width = Enums.field<RegWidthCode,ushort>(src.Width, base10, "Width");
            return string.Format(Pattern, index, @class, width);
        }

        const string RexFieldPattern = "[W:{0} | R:{1} | X:{2} | B:{3}]";

        [Op]
        public static string bitfield(RexPrefix src)
            => string.Format(RexFieldPattern, src.W(), src.R(), src.X(), src.B());

        [MethodImpl(Inline), Op]
        public static uint modrm(byte src, ref uint i, Span<char> dst)
            => BitRender.render8x2x3x3(src, ref i, dst);

        [MethodImpl(Inline), Op]
        public static uint modrm(ModRm src, ref uint i, Span<char> dst)
        {
            var i0=i;
            BitRender.render2(src.Mod(), ref i, dst);
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Chars.Pipe;
            seek(dst,i++) = Chars.Space;
            BitRender.render3(src.Reg(), ref i, dst);
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Chars.Pipe;
            seek(dst,i++) = Chars.Space;
            BitRender.render3(src.Reg(), ref i, dst);
            return i-i0;
        }

        [MethodImpl(Inline), Op]
        public static uint sib(Sib src, ref uint i, Span<char> dst)
        {
            var i0=i;
            BitRender.render2(src.Scale(), ref i, dst);
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Chars.Pipe;
            seek(dst,i++) = Chars.Space;
            BitRender.render3(src.Index(), ref i, dst);
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Chars.Pipe;
            seek(dst,i++) = Chars.Space;
            BitRender.render3(src.Base(), ref i, dst);
            return i-i0;
        }

        [MethodImpl(Inline), Op]
        public static uint render8x3x3x2(in AsmHexCode src, ref uint i, Span<char> dst)
            => BitRender.render8x3x3x2(slice(src.Bytes, src.Size), ref i, dst);

        [MethodImpl(Inline), Op]
        public static uint render8x4(in AsmHexCode src, Span<char> dst)
        {
            var i=0u;
            return BitRender.render8x4(slice(src.Bytes, 0, src.Size), ref i, dst);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render8x4(in AsmHexCode src)
        {
            if(src.IsEmpty)
                return default;

            CharBlocks.alloc(n256, out var block);
            var dst = block.Data;
            var count = render8x4(src, dst);
            if(count == 0)
                return EmptyString;

            return slice(dst, 0, count);
        }

        [Op,Closures(Closure)]
        public static ReadOnlySpan<char> render<T>(in NamedRegValue<T> src)
            where T : unmanaged
        {
            if(size<T>() == 1)
                return BitRender.render8(u8(src.Value));
            else if(size<T>() == 2)
                return BitRender.render16x8(u16(src.Value));
            else if(size<T>() == 4)
                return BitRender.render32x8(u32(src.Value));
            else if(size<T>() == 8)
                return BitRender.render64x8(u64(src.Value));
            else
                return EmptyString;
        }

        [Op]
        public static string format8x4(AsmHexCode src)
            => src.IsEmpty ? EmptyString : text.format(render8x4(src));

        [Op]
        public static AsmBitstring bitstring(in AsmHexCode src)
            => new AsmBitstring(format8x4(src));

        [Op]
        public static string format8x4(in AsmHexCode src, Span<char> buffer)
        {
            if(src.IsEmpty)
                return EmptyString;
            else
            {
                var count = render8x4(src, buffer);
                var chars = slice(buffer,0,count);
                return text.format(chars);
            }
        }

        [MethodImpl(Inline), Op]
        public static uint render8x4(in AsmHexCode src, ref uint i, Span<char> dst)
            => BitRender.render8x4(slice(src.Bytes, 0, src.Size), ref i, dst);

        [Op]
        public static uint ModRmTable(Span<char> dst)
        {
            var f0 = BitSeq.bits(n3);
            var f1 = BitSeq.bits(n3);
            var f2 = BitSeq.bits(n2);
            var k=0u;
            for(var c=0u; c<f2.Length; c++)
            for(var b=0u; b<f1.Length; b++)
            for(var a=0u; a<f0.Length; a++)
            {
                var modrm = AsmEncoder.modrm(skip(f0, a), skip(f1, b), skip(f2, c));
                ModRmTableEntry(modrm, ref k, dst);
                seek(dst, k++) = Sep;
                seek(dst, k++) = Assign;
                seek(dst, k++) = Sep;

                var bits = modrm.Encoded.FormatBits() + "b";
                text.copy(bits, ref k, dst);

                seek(dst, k++) = Sep;
                seek(dst, k++) = Assign;
                seek(dst, k++) = Sep;

                var hex = modrm.Encoded.FormatAsmHex(2);
                text.copy(hex, ref k, dst);

                seek(dst,k++) = (char)AsciControlSym.CR;
                seek(dst,k++) = (char)AsciControlSym.LF;
            }
            return k;
        }

        [Op]
        public static uint ModRmTableEntry(ModRm src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            const string ModRM = "ModRM";
            const string Mod = "mod";
            const string Reg = "reg";
            const string Rm = "r/m";
            text.copy(ModRM, ref i, dst);
            seek(dst, i++) = Open;

            text.copy(Mod, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render8x2(src.Mod(), ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Sep;
            seek(dst, i++) = Delimit;
            seek(dst, i++) = Sep;

            text.copy(Reg, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render3(src.Reg(), ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Sep;
            seek(dst, i++) = Delimit;
            seek(dst, i++) = Sep;

            text.copy(Rm, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render3(src.Rm(), ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Close;
            return i - i0;
        }
    }
}