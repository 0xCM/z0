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
        public static sbyte fma_d8i(sbyte x, sbyte a, sbyte b)    
            => math.fma(x,a,b);

        public static sbyte fma_g8i(sbyte x, sbyte a, sbyte b)    
            => gmath.fma(x,a,b);

        public static byte fma_d8u(byte x, byte a, byte b)    
            => math.fma(x,a,b);

        public static byte fma_g8u(byte x, byte a, byte b)    
            => gmath.fma(x,a,b);

        public static short fma_d16i(short x, short a, short b)    
            => math.fma(x,a,b);

        public static short fma_g16i(short x, short a, short b)    
            => gmath.fma(x,a,b);

        public static ushort fma_d16u(ushort x, ushort a, ushort b)    
            => math.fma(x,a,b);

        public static ushort fma_g16u(ushort x, ushort a, ushort b)    
            => gmath.fma(x,a,b);

        public static int fma_d32i(int x, int a, int b)    
            => math.fma(x,a,b);

        public static int fma_g32i(int x, int a, int b)    
            => gmath.fma(x,a,b);

        public static uint fma_d32u(uint x, uint a, uint b)    
            => math.fma(x,a,b);
 
        public static uint fma_g32u(uint x, uint a, uint b)    
            => gmath.fma(x,a,b);
        
        public static long fma_d64i(long x, long a, long b)    
            => math.fma(x,a,b);
        public static long fma_g64i(long x, long a, long b)    
            => gmath.fma(x,a,b);

        public static ulong fma_d64u(ulong x, ulong a, ulong b)    
            => math.fma(x,a,b);

        public static ulong fma_g64u(ulong x, ulong a, ulong b)    
            => gmath.fma(x,a,b);

        public static float fma_d32f(float x, float a, float b)    
            => fmath.fma(x,a,b);

        public static float fma_g32f(float x, float a, float b)    
            => gmath.fma(x,a,b);

        public static double fma_d64f(double x, double a, double b)    
            => fmath.fma(x,a,b);

        public static double fma_g64f(double x, double a, double b)    
            => gmath.fma(x,a,b);
    }

}