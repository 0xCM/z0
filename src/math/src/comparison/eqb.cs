//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Memories;

    partial class math
    {
        /// <summary>
        /// Defines a binary operator that returns 1 if the operands are equal 0 otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), EqB]
        public static sbyte eqb(sbyte a, sbyte b)
            => (sbyte)eq(a,b);

        /// <summary>
        /// Defines a binary operator that returns 1 if the operands are equal 0 otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), EqB]
        public static byte eqb(byte a, byte b)
            => (byte)eq(a,b);

        /// <summary>
        /// Defines a binary operator that returns 1 if the operands are equal 0 otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), EqB]
        public static short eqb(short a, short b)
            => (short)eq(a,b);

        /// <summary>
        /// Defines a binary operator that returns 1 if the operands are equal 0 otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), EqB]
        public static ushort eqb(ushort a, ushort b)
            => (ushort)eq(a,b);

        /// <summary>
        /// Defines a binary operator that returns 1 if the operands are equal 0 otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), EqB]
        public static int eqb(int a, int b)
            => (int)eq(a,b);

        /// <summary>
        /// Defines a binary operator that returns 1 if the operands are equal 0 otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), EqB]
        public static uint eqb(uint a, uint b)
            => (uint)eq(a,b);


        /// <summary>
        /// Defines a binary operator that returns 1 if the operands are equal 0 otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), EqB]
        public static long eqb(long a, long b)
            => (long)eq(a,b);

        /// <summary>
        /// Defines a binary operator that returns 1 if the operands are equal 0 otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), EqB]
        public static ulong eqb(ulong a, ulong b)
            => (ulong)eq(a,b);

    }
}