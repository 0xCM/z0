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

    [ApiHost]
    public partial class AsmBits
    {
        const NumericKind Closure = UnsignedInts;

        const string FieldSep = " | ";

        const char Open = Chars.LBracket;

        const char Close = Chars.RBracket;

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

        [Op]
        public static string format(Register src)
        {
            const string Pattern = "[{0,-12} | {1,-8} | {2}]";
            var index = Bitfields.format<RegIndexCode,byte>(src.Code, src.Name, 5);
            var @class = Bitfields.format<RegClassCode,byte>(src.Class, src.Class.ToString(), 4);
            var width = Enums.field<RegWidthCode,ushort>(src.Width, base10, "Width");
            return string.Format(Pattern, index, @class, width);
        }

        [MethodImpl(Inline), Op]
        public static uint render8x3x3x2(in AsmHexCode src, ref uint i, Span<char> dst)
            => BitRender.render8x3x3x2(slice(src.Bytes, src.Size), ref i, dst);

        [MethodImpl(Inline), Op]
        public static uint render8x4(in AsmHexCode src, Span<char> dst)
        {
            var i=0u;
            return BitRender.renderNx8x4(slice(src.Bytes, 0, src.Size), ref i, dst);
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
        public static ReadOnlySpan<char> render<T>(in NamedRegValue<T> src, char sep = Chars.Space)
            where T : unmanaged
        {
            if(size<T>() == 1)
                return BitRender.render8(u8(src.Value));
            else if(size<T>() == 2)
                return BitRender.render16x8(u16(src.Value), sep);
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
            => BitRender.renderNx8x4(slice(src.Bytes, 0, src.Size), ref i, dst);
    }
}