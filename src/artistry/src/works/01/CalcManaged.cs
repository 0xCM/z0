//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct CalcManaged
    {
        /// <summary>
        /// Computes the sum of two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <remarks>Note that plainy idiotic casting required to teach the compiler that
        /// multiplication of unsigned 8-bit integers should not produce a 32-bit signed integer</remarks>
        [MethodImpl(Inline), Op]
        public static byte add(byte x, byte y)
            => (byte)(x+y);

        /// <summary>
        /// Computes the difference between two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <remarks>Note that plainy idiotic casting required to teach the compiler that
        /// multiplication of unsigned 8-bit integers should not produce a 32-bit signed integer</remarks>
        [MethodImpl(Inline), Op]
        public static byte sub(byte x, byte y)
            => (byte)(x-y);

        /// <summary>
        /// Computes the product of two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <remarks>Note that plainy idiotic casting required to teach the compiler that
        /// multiplication of unsigned 8-bit integers should not produce a 32-bit signed integer</remarks>
        [MethodImpl(Inline), Op]
        public static byte mul(byte x, byte y)
            => (byte)(x*y);

        /// <summary>
        /// Computes the quotient between two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <remarks>Note that plainy idiotic casting required to teach the compiler that
        /// multiplication of unsigned 8-bit integers should not produce a 32-bit signed integer</remarks>
        [MethodImpl(Inline), Op]
        public static byte div(byte x, byte y)
            => (byte)(x/y);

        /// <summary>
        /// Computes the bitwise and between two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <remarks>Note that plainy idiotic casting required to teach the compiler that
        /// multiplication of unsigned 8-bit integers should not produce a 32-bit signed integer</remarks>
        [MethodImpl(Inline), Op]
        public static byte and(byte x, byte y)
            => (byte)(x&y);
    }
}