//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmoc
    {
        public static sbyte parse_d8i(string src, out sbyte dst)
            => math.parse(src,out dst);

        public static sbyte parse_g8i(string src)
            => gmath.parse<sbyte>(src);

        public static byte parse_d8u(string src, out byte dst)
            => math.parse(src,out dst);

        public static byte parse_g8u(string src)
            => gmath.parse<byte>(src);

        public static short parse_d16i(string src, out short dst)
            => math.parse(src,out dst);

        public static short parse_g16i(string src)
            => gmath.parse<short>(src);

        public static ushort parse_d16u(string src, out ushort dst)
            => math.parse(src,out dst);

        public static ushort parse_g16u(string src)
            => gmath.parse<ushort>(src);
        
        public static int parse_d32i(string src, out int dst)
            => math.parse(src,out dst);

        public static int parse_g32i(string src)
            => gmath.parse<int>(src);

        public static uint parse_d32u(string src, out uint dst)
            => math.parse(src,out dst);

        public static uint parse_g32u(string src)
            => gmath.parse<uint>(src);
        
        public static long parse_d64i(string src, out long dst)
            => math.parse(src,out dst);


        public static long parse_g64i(string src)
            => gmath.parse<long>(src);

        public static ulong parse_d64u(string src, out ulong dst)
            => math.parse(src,out dst);

        public static ulong parse_g64u(string src)
            => gmath.parse<ulong>(src);

        public static float parse_d32f(string src, out float dst)
            => math.parse(src,out dst);

        public static float parse_g32f(string src)
            => gmath.parse<float>(src);

        public static double parse_d64f(string src, out double dst)
            => math.parse(src,out dst);

        public static double parse_g64f(string src)
            => gmath.parse<double>(src);

    }

}