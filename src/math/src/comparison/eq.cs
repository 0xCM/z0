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
        /// Defines the test eq:bit := a == b, succeeding if the first operand is equal to the second
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eq]
        public static bool eq(sbyte a, sbyte b)
            => a == b;

        /// <summary>
        /// Defines the test eq:bit := a == b, succeeding if the first operand is equal to the second
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eq]
        public static bool eq(byte a, byte b)
            => a == b;

        /// <summary>
        /// Defines the test eq:bit := a == b, succeeding if the first operand is equal to the second
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eq]
        public static bool eq(short a, short b)
            => a == b;

        /// <summary>
        /// Defines the test eq:bit := a == b, succeeding if the first operand is equal to the second
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eq]
        public static bool eq(ushort a, ushort b)
            => a == b;

        /// <summary>
        /// Defines the test eq:bit := a == b, succeeding if the first operand is equal to the second
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eq]
        public static bool eq(int a, int b)
            => a == b;

        /// <summary>
        /// Defines the test eq:bit := a == b, succeeding if the first operand is equal to the second
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eq]
        public static bool eq(uint a, uint b)
            => a == b;

        /// <summary>
        /// Defines the test eq:bit := a == b, succeeding if the first operand is equal to the second
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eq]
        public static bool eq(long a, long b)
            => a == b;

        /// <summary>
        /// Defines the test eq:bit := a == b, succeeding if the first operand is equal to the second
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eq]
        public static bool eq(ulong a, ulong b)
            => a == b;  
    }
}