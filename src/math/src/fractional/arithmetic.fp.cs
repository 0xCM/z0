//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static refs;
    
    partial class fmath
    {
        const uint Float32SignMask = 0x7fffffff;
        const ulong Float64SignMask = 0x7fffffffffffffff;

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Abs]
        public static float abs(float a)
        {
            var bits =  Float32Bits.Define(a);
            bits.Integral &= Float32SignMask;
            return bits.Fractional;
        }

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Abs]
        public static double abs(double a)
            => Float64Bits.Abs(a);

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Dec]
        public static float dec(float src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Dec]
        public static double dec(double src)
            => --src;

        /// <summary>
        /// Increments the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static float inc(float src)
            => src + 1;

        /// <summary>
        /// Increments the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Inc]
        public static double inc(double src)
            => src + 1;

        /// <summary>
        /// Negates the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Negate]
        public static float negate(float src)
            => -src;

        /// <summary>
        /// Negates the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Negate]
        public static double negate(double src)
            => -src;

        /// <summary>
        /// Computes the arithmetic sum of the source operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Add]
        public static float add(float a, float b)
            => a + b;

        /// <summary>
        /// Computes the arithmetic sum of the source operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Add]
        public static double add(double a, double b)
            => a + b;

        /// <summary>
        /// Computes the arithmetic difference between the first operand and the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Sub]
        public static float sub(float a, float b)
            => a - b;

        /// <summary>
        /// Computes the arithmetic difference between the first operand and the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Sub]
        public static double sub(double a, double b)
            => a - b;

        /// <summary>
        /// Computes the arithmetic product of the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Mul]
        public static float mul(float a, float b)
            => a * b;

        /// <summary>
        /// Computes the arithmetic product of the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Mul]
        public static double mul(double a, double b)
            => a * b;

        /// <summary>
        /// Computes the arithmetic quotient of the first operand over the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Div]
        public static float div(float a, float b)
            => a / b;

        /// <summary>
        /// Computes the arithmetic quotient of the first operand over the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Div]
        public static double div(double a, double b)
            => a / b;

        /// <summary>
        /// Computes the modulus of the first operand over the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Mod]
        public static float mod(float a, float b)
            => a % b;

        /// <summary>
        /// Computes the modulus of the first operand over the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Mod]
        public static double mod(double a, double b)
            => a % b;

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), ModMul]
        public static float modmul(float a, float b, float m)
            => (a*b) % m;

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), ModMul]
        public static double modmul(double a, double b, double m)
            => (a*b) % m;

        /// <summary>
        /// Computes the smallest integral value greater than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float ceil(float src)
            => MathF.Ceiling(src);

        /// <summary>
        /// Computes the smallest integral value greater than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double ceil(double src)
            => Math.Ceiling(src);

       /// <summary>
        /// Computes the largest integral value less than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float floor(float src)
            => MathF.Floor(src);

        /// <summary>
        /// Computes the largest integral value less than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double floor(double src)
            => Math.Floor(src); 

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Clamp]
        public static float clamp(float src, float max)
            => src > max ? max : src;

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Clamp]
        public static double clamp(double src, double max)
            => src > max ? max : src;

        /// <summary>
        /// Computes the nonnegative distance between two values
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        [MethodImpl(Inline), Dist]
        public static ulong dist(double a, double b)
            => a >= b ? (ulong)(a - b) : (ulong)(b - a);

        [MethodImpl(Inline), Divides]
        public static bit divides(float a, float b)
            => b % a == 0;

        [MethodImpl(Inline), Divides]
        public static bit divides(double a, double b)
            => b % a == 0;
 
        [MethodImpl(Inline), Fma]
        public static float fma(float x, float y, float z)
            => MathF.FusedMultiplyAdd(x,y,z);

        [MethodImpl(Inline), Fma]
        public static double fma(double x, double y, double z)
            => Math.FusedMultiplyAdd(x, y, z);

        /// <summary>
        /// Computes the remainder of the quotient of the operands
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), Op]
        public static float fmod(float a, float b)
            => MathF.IEEERemainder(a,b);

        /// <summary>
        /// Computes the remainder of the quotient of the operands
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), Op]
        public static double fmod(double a, double b)
            => Math.IEEERemainder(a,b);

        [MethodImpl(Inline), Op]
        public static float round(float src, int scale)
            => MathF.Round(src, scale);

        [MethodImpl(Inline), Op]
        public static double round(double src, int scale)
            => Math.Round(src, scale);

        /// <summary>
        /// Computes the sign of the operand
        /// </summary>
        /// <param name="src">The operand</param>
        [MethodImpl(Inline), Op]
        public static Sign signum(float src)
            => (Sign)MathF.Sign(src);

        /// <summary>
        /// Computes the sign of the operand
        /// </summary>
        /// <param name="src">The operand</param>
        [MethodImpl(Inline), Op]
        public static Sign signum(double src)
            => (Sign)Math.Sign(src);            

        [MethodImpl(Inline), Square]
        public static float square(float src)
            => fmath.mul(src,src);

        [MethodImpl(Inline), Square]
        public static double square(double src)
            => fmath.mul(src,src);

        /// <summary>
        /// Computes the square root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Sqrt]
        public static float sqrt(float src)
            => MathF.Sqrt(src);

        /// <summary>
        /// Computes the square root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Sqrt]
        public static double sqrt(double src)
            => Math.Sqrt(src); 

        [MethodImpl(Inline), Avg]
        public static float avg(ReadOnlySpan<float> src, bool @checked)
            => @checked? avg_checked(src) : avg_unchecked(src);

        [MethodImpl(Inline), Avg]
        public static double avg(ReadOnlySpan<double> src, bool @checked)
            => @checked? avg_checked(src) : avg_unchecked(src);

        [MethodImpl(Inline), Avg]
        public static float avg(ReadOnlySpan<float> src)
            => avg(src,true);

        [MethodImpl(Inline), Avg]
        public static double avg(ReadOnlySpan<double> src)
            => avg(src,true);

        [MethodImpl(Inline), Op]
        static float avg_checked(ReadOnlySpan<float> src)
            {checked{ return avg_unchecked(src);}}

        [MethodImpl(Inline), Op]
        static double avg_checked(ReadOnlySpan<double> src)
            {checked{ return avg_unchecked(src);}}

        [MethodImpl(Inline), Op]
        static float avg_unchecked(ReadOnlySpan<float> src)
        {
            unchecked
            {
                var sum = default(double);                
                
                ref readonly var current = ref head(src);                
                for(var i=0; i<src.Length; i++)
                    sum += skip(current,i);
                
                return (float)(sum/(float)src.Length);
            }
        }

        [MethodImpl(Inline), Op]
        static double avg_unchecked(ReadOnlySpan<double> src)
        {
            unchecked
            {
                var sum = default(double);

                ref readonly var current = ref head(src);                
                for(var i=0; i<src.Length; i++)
                    sum += skip(current,i);

                return sum/(double)src.Length;
            }
        }
    }        
}