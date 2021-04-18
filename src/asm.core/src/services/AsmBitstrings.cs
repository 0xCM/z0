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

    [ApiHost]
    public readonly struct AsmBitstrings
    {
        [Op]
        public static uint render(AsmHexCode src, Span<char> dst)
        {
            var input = src.Bytes;
            var size = (int)src.Size;
            var j = 0u;
            for(var i=size; i>=0; i--)
            {
                ref readonly var b = ref skip(input,i);

                seek(dst,j++) = bit.test(b,0).ToChar();
                seek(dst,j++) = bit.test(b,1).ToChar();
                seek(dst,j++) = bit.test(b,2).ToChar();
                seek(dst,j++) = bit.test(b,3).ToChar();
                seek(dst,j++) = Chars.Space;

                seek(dst,j++) = bit.test(b,4).ToChar();
                seek(dst,j++) = bit.test(b,5).ToChar();
                seek(dst,j++) = bit.test(b,6).ToChar();
                seek(dst,j++) = bit.test(b,7).ToChar();
                seek(dst,j++) = Chars.Space;
            }

            return j - 1;
        }

        [Op]
        public static uint render(uint src, Span<char> dst)
        {
            var input = bytes(src);
            var size = 4;
            var j = 0u;
            for(var i=size; i>=0; i--)
            {
                ref readonly var b = ref skip(input,i);

                seek(dst,j++) = bit.test(b,0).ToChar();
                seek(dst,j++) = bit.test(b,1).ToChar();
                seek(dst,j++) = bit.test(b,2).ToChar();
                seek(dst,j++) = bit.test(b,3).ToChar();
                seek(dst,j++) = Chars.Space;

                seek(dst,j++) = bit.test(b,4).ToChar();
                seek(dst,j++) = bit.test(b,5).ToChar();
                seek(dst,j++) = bit.test(b,6).ToChar();
                seek(dst,j++) = bit.test(b,7).ToChar();
                seek(dst,j++) = Chars.Space;
            }

            return j - 1;
        }

        public static AsmBitstrings service()
            => new AsmBitstrings(_Formatter);

        readonly BitFormatter<byte> Formatter;

        [MethodImpl(Inline)]
        AsmBitstrings(BitFormatter<byte> formatter)
        {
            Formatter = formatter;
        }

        public string Format(AsmHexCode src)
        {
            var bytes = src.Bytes.Replicate();
            bytes.Reverse();
            return Formatter.Format(bytes);
        }

        static AsmBitstrings()
        {
            _Formatter = BitFormatter.create<byte>(BitFormatter.blocked(4));
        }

        [FixedAddressValueType]
        static BitFormatter<byte> _Formatter;
    }
}