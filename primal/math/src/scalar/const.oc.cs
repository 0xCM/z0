//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class pmoc
    {
        public static sbyte one_n8i()
            => 1;

        public static sbyte one_g8i()
            => gmath.one<sbyte>();

        public static byte one_n8u()
            => 1;

        public static byte one_g8u()
            => gmath.one<byte>();

        public static short one_n16i()
            => 1;

        public static short one_g16i()
            => gmath.one<short>();

        public static ushort one_n16u()
            => 1;

        public static ushort one_g16u()
            => gmath.one<ushort>();

        public static int one_n32i()
            => 1;

        public static int one_g32i()
            => gmath.one<int>();

        public static uint one_n32u()
            => 1;

        public static uint one_g32u()
            => gmath.one<uint>();

        public static long one_n64i()
            => 1;

        public static long one_g64i()
            => gmath.one<long>();

        public static ulong one_n64u()
            => 1;

        public static ulong one_g64u()
            => gmath.one<ulong>();

        public static float one_n32f()
            => 1;

        public static float one_g32f()
            => gmath.one<float>();

        public static double one_n64f()
            => 1;
        
        public static double one_g64f()
            => gmath.one<double>();
 
         public static sbyte zero_g8i()
            => gmath.zero<sbyte>();

        public static byte zero_g8u()
            => gmath.zero<byte>();

        public static short zero_g16i()
            => gmath.zero<short>();

        public static ushort zero_g16u()
            => gmath.zero<ushort>();

        public static int zero_g32i()
            => gmath.zero<int>();

        public static uint zero_g32u()
            => gmath.zero<uint>();

        public static long zero_g64i()
            => gmath.zero<long>();

        public static ulong zero_g64u()
            => gmath.zero<ulong>();

        public static float zero_g32f()
            => gmath.zero<float>();

        public static double zero_g64f()
            => gmath.one<double>();

        public static sbyte minval_n8i()
            => sbyte.MinValue;

        public static sbyte minval_g8i()
            => gmath.minval<sbyte>();

        public static byte minval_n8u()
            => byte.MinValue;

        public static byte minval_g8u()
            => gmath.minval<byte>();

        public static short minval_n16i()
            => short.MinValue;

        public static short minval_g16i()
            => gmath.minval<short>();

        public static ushort minval_g16u()
            => gmath.minval<ushort>();

        public static int minval_32i()
            => int.MinValue;

        public static int minval_g32i()
            => gmath.minval<int>();

        public static uint minval_32u()
            => uint.MinValue;

        public static uint minval_g32u()
            => gmath.minval<uint>();

        public static long minval_g64i()
            => gmath.minval<long>();

        public static ulong minval_g64u()
            => gmath.minval<ulong>();

        public static float minval_g32f()
            => gmath.minval<float>();

        public static double minval_g64f()
            => gmath.minval<double>();
 
        public static sbyte maxval_g8i()
            => gmath.maxval<sbyte>();

        public static byte maxval_g8u()
            => gmath.maxval<byte>();

        public static short maxval_g16i()
            => gmath.maxval<short>();

        public static ushort maxval_g16u()
            => gmath.maxval<ushort>();

        public static int maxval_n32i()
            => int.MaxValue;

        public static int maxval_g32i()
            => gmath.maxval<int>();

        public static uint maxval_n32u()
            => uint.MaxValue;

        public static uint maxval_g32u()
            => gmath.maxval<uint>();

        public static long maxval_g64i()
            => gmath.maxval<long>();

        public static ulong maxval_g64u()
            => gmath.maxval<ulong>();

        public static float maxval_g32f()
            => gmath.maxval<float>();

        public static double maxval_n64f()
            => double.MaxValue;

        public static double maxval_g64f()
            => gmath.maxval<double>();
 
    }

}