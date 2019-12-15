//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Digital;
    using static zfunc;

    [OpCodeProvider]
    public static class natoc
    {
        // xor(eax,eax) -> eax
        public static ulong digits_encode_1_0()
            => digit('0');            

        // 0x1 -> eax
        public static ulong digits_encode_1_1()
            => digit('1');            

        // 0x2 -> eax
        public static ulong digits_encode_1_2()
            => digit('2');            

        // 0x3 -> eax
        public static ulong digits_encode_1_3()
            => digit('3');            

        // 0x10 -> eax
        public static ulong digits_encode_2_10()
            => digits('1','0');

        // 0x210 -> eax
        public static ulong digits_encode_3_210()
            => digits('2','1','0');

        // 0x3210 -> eax
        public static ulong digits_encode_4_3210()
            => digits('3','2','1','0');

        // 0x43210 -> eax
        public static ulong digits_encode_5_43210()
            => digits('4','3','2','1','0');

        // 0x76543210h -> eax        
        public static ulong digits_encode_8_76543210()
            => digits('7','6','5','4','3','2','1','0');

        public static ulong digit_extract_1_0_9()
            => digit(0x5849, 0);

        public static ulong digit_extract_1_1_4()
            => digit(0x5849, 1);

        public static ulong digit_extract_1_2_8()
            => digit(0x5849, 2);

        public static ulong digit_extract_1_3_5()
            => digit(0x5849, 3);

        public static void digits_extract_4_5849(out byte d3, out byte d2, out byte d1, out byte d0)
            => digits(0x5849, out d3, out d2, out d1, out d0);

        public static unsafe Span<byte> digits_extract_lo(ulong src)
        {
            var data = 0ul;
            Span<byte> dst = new Span<byte>(&data,8);
            digits(src, dst);
            return dst;
        }

        public static unsafe Span<byte> digits_extract_hi(ulong src)
        {
            var data = 0ul;
            Span<byte> dst = new Span<byte>(&data,8);
            digits(src >> 32, dst);
            return dst;
        }

        // 0x30 -> eax
        public static char digit_decode_1_0()
            => character(0);

        // 0x31 -> eax
        public static char digit_decode_1_1()
            => character(1);

        // 0x32 -> eax
        public static char digit_decode_1_2()
            => character(2);

        // 0x33 -> eax
        public static char digit_decode_1_3()
            => character(3);
    }
}