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

    partial class fpoc
    {
        public static float dec_g32f(float x)
            => gfp.dec(x);

        public static float dec_d32f(float x)
            => fmath.dec(x);

        public static double dec_d64f(double x)
            => fmath.dec(x);

        public static double dec_g64f(double x)
            => gfp.dec(x);

        public static float inc_g32f(float x)
            => gfp.inc(x);

        public static float inc_d32f(float x)
            => fmath.inc(x);

        public static double inc_d64f(double x)
            => fmath.inc(x);

        public static double inc_g64f(double x)
            => gfp.inc(x);
        
        public static bool lt_d32f(float lhs, float rhs)
            => fmath.lt(lhs,rhs);

        public static bool lt_g32f(float lhs, float rhs)
            => gfp.lt(lhs,rhs);

        public static bool lt_d64f(double lhs, double rhs)
            => fmath.lt(lhs,rhs);
        
        public static bool lt_g64f(double lhs, double rhs)
            => gfp.lt(lhs,rhs);

       public static bool lteq_d32f(float lhs, float rhs)
            => fmath.lteq(lhs,rhs);

        public static bool lteq_g32f(float lhs, float rhs)
            => gfp.lteq(lhs,rhs);

        public static bool lteq_d64f(double lhs, double rhs)
            => fmath.lteq(lhs,rhs);
        
        public static bool lteq_g64f(double lhs, double rhs)
            => gfp.lteq(lhs,rhs);
 
         public static float max_d32f(float lhs, float rhs)
            => fmath.max(lhs,rhs);

        public static float max_g32f(float lhs, float rhs)
            => gfp.max(lhs,rhs);

        public static double max_d64f(double lhs, double rhs)
            => fmath.max(lhs,rhs);
        
        public static double max_g64f(double lhs, double rhs)
            => gfp.max(lhs,rhs);

        public static float min_d32f(float lhs, float rhs)
            => fmath.min(lhs,rhs);

        public static float min_g32f(float lhs, float rhs)
            => gfp.min(lhs,rhs);

        public static double min_d64f(double lhs, double rhs)
            => fmath.min(lhs,rhs);
        
        public static double min_g64f(double lhs, double rhs)
            => gfp.min(lhs,rhs);

        public static float mul_d32f(float lhs, float rhs)
            => fmath.mul(lhs,rhs);

        public static float mul_g32f(float lhs, float rhs)
            => gfp.mul(lhs,rhs);

        public static double mul_d64f(double lhs, double rhs)
            => fmath.mul(lhs,rhs);
        
        public static double mul_g64f(double lhs, double rhs)
            => gfp.mul(lhs,rhs);

        public static bool negative_n32f(float x)
            => x < 0;

        public static bool negative_g32f(float x)
            => gmath.negative(x);

        public static bool negative_n64f(double x)
            => x < 0;

        public static bool negative_g64f(double x)
            => gmath.negative(x);

        public static bool nonzero_n32f(float x)
            => x != 0;

        public static bool nonzero_g32f(float x)
            => gmath.nonzero(x);

        public static bool nonzero_n64f(double x)
            => x != 0;

        public static bool nonzero_g64f(double x)
            => gmath.nonzero(x);



    }

}