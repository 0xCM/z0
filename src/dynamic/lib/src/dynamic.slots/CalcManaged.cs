//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static ApiClasses;

    [ApiHost]
    public readonly struct CalcManaged
    {
        /// <summary>
        /// Computes the sum of two unsigned 8-bit integers
        /// </summary>
        /// <param name="f">The operation selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static byte eval(Add f, byte x, byte y)
            => (byte)(x+y);

        /// <summary>
        /// Computes the difference between two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static byte eval(Sub f, byte x, byte y)
            => (byte)(x-y);

        /// <summary>
        /// Computes the product of two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static byte eval(Mul f, byte x, byte y)
            => (byte)(x*y);

        /// <summary>
        /// Computes the quotient between two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static byte eval(Div f, byte x, byte y)
            => (byte)(x/y);

        /// <summary>
        /// Computes the bitwise and between two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static byte eval(And f, byte x, byte y)
            => (byte)(x&y);
    }
}