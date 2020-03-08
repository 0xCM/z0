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
        const uint Float32SignMask = 0x7fffffff;
        const ulong Float64SignMask = 0x7fffffffffffffff;

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
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
        [MethodImpl(Inline), Op]
        public static double abs(double a)
            => Float64Bits.Abs(a);

        [MethodImpl(Inline), Op]
        public static float add(float lhs, float rhs)
            => lhs + rhs;

        [MethodImpl(Inline), Op]
        public static double add(double lhs, double rhs)
            => lhs + rhs;

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
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Op]
        public static float clamp(float src, float max)
            => src > max ? max : src;

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline), Op]
        public static double clamp(double src, double max)
            => src > max ? max : src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float dec(float src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double dec(double src)
            => --src;

        /// <summary>
        /// Computes the nonnegative distance between two values
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        [MethodImpl(Inline), Op]
        public static ulong dist(double a, double b)
            => a >= b ? (ulong)(a - b) : (ulong)(b - a);

        [MethodImpl(Inline), Op]
        public static float div(float a, float b)
            => a / b;

        [MethodImpl(Inline), Op]
        public static double div(double a, double b)
            => a / b;

        [MethodImpl(Inline), Op]
        public static bit divides(float a, float b)
            => b % a == 0;

        [MethodImpl(Inline), Op]
        public static bit divides(double a, double b)
            => b % a == 0;
 
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

        [MethodImpl(Inline), Op]
        public static float fma(float x, float y, float z)
            => MathF.FusedMultiplyAdd(x,y,z);

        [MethodImpl(Inline), Op]
        public static double fma(double x, double y, double z)
            => Math.FusedMultiplyAdd(x, y, z);

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float inc(float src)
            => src + 1;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double inc(double src)
            => src + 1;

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
        public static float mod(float a, float b)
            => a % b;

        [MethodImpl(Inline), Op]
        public static double mod(double a, double b)
            => a % b;

        [MethodImpl(Inline), Op]
        public static float mul(float lhs, float rhs)
            => lhs * rhs;

        [MethodImpl(Inline), Op]
        public static double mul(double lhs, double rhs)
            => lhs * rhs;

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float negate(float src)
            => -src;

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double negate(double src)
            => -src;

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

        [MethodImpl(Inline), Op]
        public static float sub(float a, float b)
            => a - b;

        [MethodImpl(Inline), Op]
        public static double sub(double a, double b)
            => a - b;

        [MethodImpl(Inline), Op]
        public static float square(float src)
            => fmath.mul(src,src);

        [MethodImpl(Inline), Op]
        public static double square(double src)
            => fmath.mul(src,src);

        /// <summary>
        /// Computes the square root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float sqrt(float src)
            => MathF.Sqrt(src);

        /// <summary>
        /// Computes the square root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double sqrt(double src)
            => Math.Sqrt(src); 
    }        
}