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


        public static float abs_g32f(float x)
            => gfp.abs(x);

        public static float abs_d32f(float x)
            => fmath.abs(x);

        public static float square_g32f(float x)
            => gfp.square(x);

       public static double abs_d64f(double x)
            => fmath.abs(x);

        public static double abs_g64f(double x)
            => gfp.abs(x);

        public static float add_d32f(float lhs, float rhs)
            => fmath.add(lhs,rhs);
 
        public static float add_g32f(float lhs, float rhs)
            => gfp.add(lhs,rhs);

        public static double add_d64f(double lhs, double rhs)
            => fmath.add(lhs,rhs);

        public static double add_g64f(double lhs, double rhs)
            => gfp.add(lhs,rhs);                                

        public static bool between_d32f(float x, float a, float b)    
            => fmath.between(x,a,b);

        public static bool between_g32f(float x, float a, float b)    
            => gmath.between(x,a,b);

        public static bool between_d64f(double x, double a, double b)    
            => fmath.between(x,a,b);

        public static bool between_g64f(double x, double a, double b)    
            => gmath.between(x,a,b);

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

        public static bool positive_n32f(float x)
            => x > 0;

        public static bool positive_g32f(float x)
            => gmath.positive(x);

        public static bool positive_n64f(double x)
            => x > 0;

        public static bool positive_g64f(double x)
            => gmath.positive(x);

        public static float pow_d32f(float b, uint exp)
            => fmath.pow(b,exp);

        public static float pow_g32f(float b, uint exp)
            => gfp.pow(b,exp);

        public static double pow_d64f(double b, uint exp)
            => fmath.pow(b,exp);

        public static double pow_g64f(double b, uint exp)
            => gfp.pow(b,exp);

        public static float square_d32f(float x)
            => fmath.square(x);

        public static double square_d64f(double x)
            => fmath.square(x);

        public static double square_g64f(double x)
            => gfp.square(x);

         public static Sign signum_g32f(float x)
            => gfp.signum(x);

        public static Sign signum_d32f(float x)
            => fmath.signum(x);

        public static Sign signum_d64f(double x)
            => fmath.signum(x);

        public static Sign signum_g64f(double x)
            => gfp.signum(x);

       public static float sub_d32f(float lhs, float rhs)
            => fmath.sub(lhs,rhs);

        public static float sub_g32f(float lhs, float rhs)
            => gfp.sub(lhs,rhs);

        public static double sub_d64f(double lhs, double rhs)
            => fmath.sub(lhs,rhs);
        
        public static double sub_g64f(double lhs, double rhs)
            => gfp.sub(lhs,rhs);

       public static float xor_d32f(float lhs, float rhs)
            => fmath.xor(lhs,rhs);

        public static float xor_g32f(float lhs, float rhs)
            => gfp.xor(lhs,rhs);

        public static double xor_d64f(double lhs, double rhs)
            => fmath.xor(lhs,rhs);
        
        public static double xor_g64f(double lhs, double rhs)
            => gfp.xor(lhs,rhs);
 


    }

}