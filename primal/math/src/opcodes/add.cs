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
        public static sbyte add_d8i(sbyte lhs, sbyte rhs)
            => math.add(lhs,rhs);

        public static sbyte add_g8i(sbyte lhs, sbyte rhs)
            => gmath.add(lhs,rhs);

        public static byte add_d8u(byte lhs, byte rhs)
            => math.add(lhs,rhs);
        
        public static byte add_g8u(byte lhs, byte rhs)
            => gmath.add(lhs,rhs);

        public static short add_d16i(short lhs, short rhs)
            => math.add(lhs,rhs);
 
        public static short add_g16i(short lhs, short rhs)
            => gmath.add(lhs,rhs);

        public static ushort add_d16u(ushort lhs, ushort rhs)
            => math.add(lhs,rhs);
 
        public static ushort add_g16u(ushort lhs, ushort rhs)
            => gmath.add(lhs,rhs);

        public static int add_d32i(int lhs, int rhs)
            => math.add(lhs,rhs);
  
        public static int add_g32i(int lhs, int rhs)
            => gmath.add(lhs,rhs);

        public static uint add_d32u(uint lhs, uint rhs)
            => math.add(lhs,rhs);
 
        public static uint add_g32u(uint lhs, uint rhs)
            => gmath.add(lhs,rhs);

        public static long add_d64i(long lhs, long rhs)
            => math.add(lhs,rhs);

        public static long add_g64i(long lhs, long rhs)
            => gmath.add(lhs,rhs);

        public static ulong add_d64u(ulong lhs, ulong rhs)
            => math.add(lhs,rhs);
                    
        public static ulong add_g64u(ulong lhs, ulong rhs)
            => gmath.add(lhs,rhs); 
 
         public static float add_d32f(float lhs, float rhs)
            => fmath.add(lhs,rhs);
 
        public static float add_g32f(float lhs, float rhs)
            => gfp.add(lhs,rhs);

        public static double add_d64f(double lhs, double rhs)
            => fmath.add(lhs,rhs);

        public static double add_g64f(double lhs, double rhs)
            => gfp.add(lhs,rhs);                                
    }

}