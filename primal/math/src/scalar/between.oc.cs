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

    partial class soc
    {

        public static bool between_d8i(sbyte x, sbyte a, sbyte b)    
            => math.between(x,a,b);

        public static bool between_g8i(sbyte x, sbyte a, sbyte b)    
            => gmath.between(x,a,b);

        public static bool between_d8u(byte x, byte a, byte b)    
            => math.between(x,a,b);

        public static bool between_g8u(byte x, byte a, byte b)    
            => gmath.between(x,a,b);

        public static bool between_d16i(short x, short a, short b)    
            => math.between(x,a,b);

        public static bool between_g16i(short x, short a, short b)    
            => gmath.between(x,a,b);

        public static bool between_d16u(ushort x, ushort a, ushort b)    
            => math.between(x,a,b);

        public static bool between_g16u(ushort x, ushort a, ushort b)    
            => gmath.between(x,a,b);

        public static bool between_d32i(int x, int a, int b)    
            => math.between(x,a,b);

        public static bool between_g32i(int x, int a, int b)    
            => gmath.between(x,a,b);

        public static bool between_d32u(uint x, uint a, uint b)    
            => math.between(x,a,b);
 
        public static bool between_g32u(uint x, uint a, uint b)    
            => gmath.between(x,a,b);
        
        public static bool between_d64i(long x, long a, long b)    
            => math.between(x,a,b);
        public static bool between_g64i(long x, long a, long b)    
            => gmath.between(x,a,b);

        public static bool between_d64u(ulong x, ulong a, ulong b)    
            => math.between(x,a,b);

        public static bool between_g64u(ulong x, ulong a, ulong b)    
            => gmath.between(x,a,b);

        public static bool between_d32f(float x, float a, float b)    
            => fmath.between(x,a,b);

        public static bool between_g32f(float x, float a, float b)    
            => gmath.between(x,a,b);

        public static bool between_d64f(double x, double a, double b)    
            => fmath.between(x,a,b);

        public static bool between_g64f(double x, double a, double b)    
            => gmath.between(x,a,b);
    }

}