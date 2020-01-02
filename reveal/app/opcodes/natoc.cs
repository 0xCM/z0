//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public static ulong nat_add()
            => NatMath2.add(n12,n16);

        public static ulong nat_sub()
            => NatMath2.sub(n0,n256);

        public static ulong nat_mul()
            => NatMath2.mul(n12,n16);

        public static ulong nat_div()
            => NatMath2.div(n50,n5);

        public static ulong nat_mod()
            => NatMath2.mod(n51,n3);

        // xor(eax,eax) -> eax
        public static ulong digits_encode_1_0()
            => digit('0');            

        // 0x1 -> eax
        public static ulong digits_encode_1()
            => digit('1');            

        // 0x2 -> eax
        public static ulong digits_encode_2()
            => digit('2');            

        // 0x3 -> eax
        public static ulong digits_encode_3()
            => digit('3');            

        // 0x10 -> eax
        public static ulong digits_encode_10()
            => digits('1','0');

        // 0x210 -> eax
        public static ulong digits_encode_210()
            => digits('2','1','0');

        // 0x3210 -> eax
        public static ulong digits_encode_3210()
            => digits('3','2','1','0');

        // 0x43210 -> eax
        public static ulong digits_encode_43210()
            => digits('4','3','2','1','0');

        // 0x76543210h -> eax        
        public static ulong digits_encode_76543210()
            => digits('7','6','5','4','3','2','1','0');

        public static ulong digit_extract_9()
            => digit(0x5849, 0);

        public static ulong digit_extract_4()
            => digit(0x5849, 1);

        public static ulong digit_extract_8()
            => digit(0x5849, 2);

        public static ulong digit_extract_5()
            => digit(0x5849, 3);            

        public static void digits_extract_5849(out byte d3, out byte d2, out byte d1, out byte d0)
            => lo(0x5849, out d3, out d2, out d1, out d0);

        public static void digits_extract_5489_ref(ref byte dst)
        {
            const ulong src = 0x5849;
            digits(src, n4, ref dst);
        }

        public static void digits_extract_80352178(out byte d7, out byte d6, out byte d5, out byte d4, out byte d3, out byte d2, out byte d1, out byte d0)
        {
            const ulong src = 0x80352178;            
            lo(src, out d3, out d2, out d1, out d0);
            hi(src, out d7, out d6, out d5, out d4);
        }

        public static void chars_5489(out char c3, out char c2, out char c1, out char c0)
            => chars(0x5489u, out c3, out c2, out c1, out c0);

        public static void chars_80352178(out char c7, out char c6, out char c5, out char c4, out char c3, out char c2, out char c1, out char c0)
            => chars(0x80352178, out c7, out c6, out c5, out c4, out c3, out c2, out c1, out c0);
            

        public static ReadOnlySpan<char> charspan_5489()
            => chars(0x5489u);

        // 0x30 -> eax
        public static char digit_decode_0()
            => character(0);

        // 0x31 -> eax
        public static char digit_decode_1()
            => character(1);

        // 0x32 -> eax
        public static char digit_decode_2()
            => character(2);

        // 0x33 -> eax
        public static char digit_decode_3()
            => character(3);

        public static char digit_decode_4()
            => character(4);

        public static char digit_decode_n4()
            => character<N4>();

        public static char digit_decode_5()
            => character(5);

        public static char digit_decode_n5()
            => character<N5>();

    }
}