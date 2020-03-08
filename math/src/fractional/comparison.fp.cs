//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Root;    

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static bit eq(float a, float b)
            => a == b;

        [MethodImpl(Inline)]
        public static bit eq(double a, double b)
            => a == b;

        [MethodImpl(Inline)]
        public static bit neq(float a, float b)
            => a != b;

        [MethodImpl(Inline)]
        public static bit neq(double a, double b)
            => a != b;

        [MethodImpl(Inline)]
        public static bit gt(float a, float b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(double a, double b)
            => a > b;        

        [MethodImpl(Inline)]
        public static bit gteq(float a, float b)
            => a >= b;

        [MethodImpl(Inline)]
        public static bit gteq(double a, double b)
            => a >= b;        

        [MethodImpl(Inline)]
        public static bit lt(float lhs, float rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bit lt(double lhs, double rhs)
            => lhs < rhs;        

        [MethodImpl(Inline)]
        public static bit lteq(float lhs, float rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bit lteq(double lhs, double rhs)
            => lhs <= rhs;        

        [MethodImpl(Inline)]
        public static float max(float a, float b)
            => a > b ? a : b;

        [MethodImpl(Inline)]
        public static double max(double a, double b)
            => a > b ? a : b;

        [MethodImpl(Inline)]
        public static float min(float a, float b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static double min(double a, double b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static double width(float lhs, float rhs)
            => abs((double)rhs - (double)lhs);

        [MethodImpl(Inline)]
        public static double width(double lhs, double rhs)
            => abs(rhs - lhs);

        [MethodImpl(Inline)]
        public static bit within(float a, float b, float delta)
            => a > b ? a - b <= delta 
              : b - a <= delta;

        [MethodImpl(Inline)]
        public static bit within(double a, double b, double delta)
            => a > b ? a - b <= delta 
              : b - a <= delta;
        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline), Op]
        public static bit between(float x, float a, float b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline), Op]
        public static bit between(double x, double a, double b)    
            => x >= a && x <= b;

        [Op]
        public static bool fcmp(float x, float y, FpCmpMode mode)
        {
            var result = mode switch
            {
                FpCmpMode.EQ_OQ => x == y,
                FpCmpMode.EQ_OS => x == y,
                FpCmpMode.EQ_UQ => x == y,
                FpCmpMode.EQ_US => x == y,

                FpCmpMode.NEQ_OQ => x != y,
                FpCmpMode.NEQ_OS => x != y,
                FpCmpMode.NEQ_UQ => x != y,
                FpCmpMode.NEQ_US => x != y,

                FpCmpMode.LT_OQ => x < y,
                FpCmpMode.LT_OS => x < y,

                FpCmpMode.GT_OQ =>  x > y,
                FpCmpMode.GT_OS =>  x > y,

                FpCmpMode.LE_OQ =>  x <= y,
                FpCmpMode.LE_OS =>  x <= y,
                
                FpCmpMode.GE_OQ => x >= y,
                FpCmpMode.GE_OS => x >= y,

                FpCmpMode.NGE_UQ => !(x >= y),                    
                FpCmpMode.NGE_US => !(x >= y),                    
                
                FpCmpMode.NGT_UQ => !(x > y),                    
                FpCmpMode.NGT_US => !(x > y),

                FpCmpMode.NLE_UQ => !(x <= y),
                FpCmpMode.NLE_US => !(x <= y),
                
                FpCmpMode.NLT_UQ => !(x < y),
                FpCmpMode.NLT_US => !(x < y),

                _ => throw new NotSupportedException()
            };
                            
            return result; 
        }

        [Op]
        public static bool fcmp(double x, double y, FpCmpMode mode)
        {
            var result = mode switch
            {
                FpCmpMode.EQ_OQ => x == y,
                FpCmpMode.EQ_OS => x == y,
                FpCmpMode.EQ_UQ => x == y,
                FpCmpMode.EQ_US => x == y,

                FpCmpMode.NEQ_OQ => x != y,
                FpCmpMode.NEQ_OS => x != y,
                FpCmpMode.NEQ_UQ => x != y,
                FpCmpMode.NEQ_US => x != y,

                FpCmpMode.LT_OQ => x < y,
                FpCmpMode.LT_OS => x < y,

                FpCmpMode.GT_OQ =>  x > y,
                FpCmpMode.GT_OS =>  x > y,

                FpCmpMode.LE_OQ =>  x <= y,
                FpCmpMode.LE_OS =>  x <= y,
                
                FpCmpMode.GE_OQ => x >= y,
                FpCmpMode.GE_OS => x >= y,

                FpCmpMode.NGE_UQ => !(x >= y),                    
                FpCmpMode.NGE_US => !(x >= y),                    
                
                FpCmpMode.NGT_UQ => !(x > y),                    
                FpCmpMode.NGT_US => !(x > y),

                FpCmpMode.NLE_UQ => !(x <= y),
                FpCmpMode.NLE_US => !(x <= y),
                
                FpCmpMode.NLT_UQ => !(x < y),
                FpCmpMode.NLT_US => !(x < y),

                _ => throw new NotSupportedException()
            };
                            
            return result; 
        }

        public static bool[] fcmp(Span<float> lhs, Span<float> rhs, FpCmpMode kind)
        {
            var len =  Checks.length(lhs,rhs);
            var result = Arrays.alloc<bool>(len);
            for(var i = 0; i< len; i++)
                result[i] = fmath.fcmp(lhs[i], rhs[i], kind);
            return result;
        }

        public static bool[] fcmp(Span<double> lhs, Span<double> rhs, FpCmpMode kind)
        {
            var len = Checks.length(lhs,rhs);
            var result = Arrays.alloc<bool>(len);
            for(var i = 0; i< len; i++)
                result[i] = fmath.fcmp(lhs[i], rhs[i], kind);
            return result;
        }
    }
}