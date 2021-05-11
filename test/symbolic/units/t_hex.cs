//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public class t_hex : t_symbolic<t_hex>
    {
        public void hex_hexchars_2()
        {
            const byte Value = 0x3C;
            var @case = UpperCase;
            var x0c = Hex.chars(@case, Value);
            Claim.eq(2,x0c.Length);
            Claim.eq(Hex.hexchar(@case, Value, 0), x0c[0]);
            Claim.eq(Hex.hexchar(@case, Value, 1), x0c[1]);
        }


        public void hex_hexchars_4()
        {
            const ushort Value = 0x4A3C;
            const byte Length = 4;
            var @case = UpperCase;
            var chars = Hex.chars(@case, Value);
            Claim.eq(Length, chars.Length);
            for(byte i=0; i<Length; i++)
                match(@case, chars, Value, i);
        }

        public void hex_hexchars_8()
        {
            const uint Value = 0x10F74A3C;
            const byte Length = 8;
            var @case = UpperCase;
            var chars = Hex.chars(@case, Value);
            Claim.eq(Length, chars.Length);
            for(byte i=0; i<Length; i++)
                match(@case, chars, Value, i);
        }

        public void hex_hexchars_16()
        {
            const ulong Value = 0x33_83_10_78_10_F7_4A_3C;
            const byte Length = 16;
            var @case = UpperCase;
            var data = memory.bytes(Value);
            var value = first(uint64(data));
            Claim.eq(Value,value);

            Claim.eq((byte)0x3C, skip(data,0));
            Claim.eq((byte)0x4A, skip(data,1));
            Claim.eq((byte)0xF7, skip(data,2));
            Claim.eq((byte)0x10, skip(data,3));
            Claim.eq((byte)0x78, skip(data,4));
            Claim.eq((byte)0x10, skip(data,5));

            Span<char> buffer = stackalloc char[Length];
            var count = Hex.chars(@case, data, buffer);
            Claim.eq(count, Length);

            var chars = Hex.chars(@case, Value);
            Claim.eq(Length, chars.Length);
            for(byte i=0; i<Length; i++)
                match(@case, chars, Value, i);

            for(var i=0; i<count; i++)
                Claim.eq(skip(buffer,i), skip(chars,i));
        }

        void match(UpperCased @case, ReadOnlySpan<char> chars, ulong value, byte index)
        {
            Claim.eq(Hex.hexchar(@case, value, index), skip(chars, index));
        }

        public void hexdigits_parse()
        {
            var parser = HexParsers.bytes();
            Claim.eq((byte)0, parser.Parse('0').Value);
            Claim.eq((byte)1, parser.Parse('1').Value);
            Claim.eq((byte)2, parser.Parse('2').Value);
            Claim.eq((byte)3, parser.Parse('3').Value);
            Claim.eq((byte)4, parser.Parse('4').Value);
            Claim.eq((byte)5, parser.Parse('5').Value);
            Claim.eq((byte)6, parser.Parse('6').Value);
            Claim.eq((byte)7, parser.Parse('7').Value);
            Claim.eq((byte)8, parser.Parse('8').Value);
            Claim.eq((byte)9, parser.Parse('9').Value);
            Claim.eq((byte)10, parser.Parse('A').Value);
            Claim.eq((byte)11, parser.Parse('B').Value);
            Claim.eq((byte)12, parser.Parse('C').Value);
            Claim.eq((byte)13, parser.Parse('D').Value);
            Claim.eq((byte)14, parser.Parse('E').Value);
            Claim.eq((byte)15, parser.Parse('F').Value);
        }
    }
}