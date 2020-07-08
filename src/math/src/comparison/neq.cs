//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class math
    {    
        /// <summary>
        /// Defines the test neq:bit := a != b, succeeding if the operands are not equal
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Neq]
        public static bool neq(sbyte a, sbyte b)
            => a != b;

        /// <summary>
        /// Defines the test neq:bit := a != b, succeeding if the operands are not equal
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Neq]
        public static bool neq(byte a, byte b)
            => a != b;

        /// <summary>
        /// Defines the test neq:bit := a != b, succeeding if the operands are not equal
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Neq]
        public static bool neq(short a, short b)
            => a != b;

        /// <summary>
        /// Defines the test neq:bit := a != b, succeeding if the operands are not equal
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Neq]
        public static bool neq(ushort a, ushort b)
            => a != b;

        /// <summary>
        /// Defines the test neq:bit := a != b, succeeding if the operands are not equal
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Neq]
        public static bool neq(int a, int b)
            => a != b;

        /// <summary>
        /// Defines the test neq:bit := a != b, succeeding if the operands are not equal
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Neq]
        public static bool neq(uint a, uint b)
            => a != b;

        /// <summary>
        /// Defines the test neq:bit := a != b, succeeding if the operands are not equal
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Neq]
        public static bool neq(long a, long b)
            => a != b;

        /// <summary>
        /// Defines the test neq:bit := a != b, succeeding if the operands are not equal
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Neq]
        public static bool neq(ulong a, ulong b)
            => a != b;
    }
}