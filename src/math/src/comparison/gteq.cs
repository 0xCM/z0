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
        /// Defines the test gt:bit := a >= b, succeeding if the first operand is larger than or equal to the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="a">The second operand</param>
        [MethodImpl(Inline), GtEq]
        public static bool gteq(sbyte a, sbyte b)
            => a >= b;

        /// <summary>
        /// Defines the test gt:bit := a >= b, succeeding if the first operand is larger than or equal to the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="a">The second operand</param>
        [MethodImpl(Inline), GtEq]
        public static bool gteq(byte a, byte b)
            => a >= b;

        /// <summary>
        /// Defines the test gt:bit := a >= b, succeeding if the first operand is larger than or equal to the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="a">The second operand</param>
        [MethodImpl(Inline), GtEq]
        public static bool gteq(short a, short b)
            => a >= b;

        /// <summary>
        /// Defines the test gt:bit := a >= b, succeeding if the first operand is larger than or equal to the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="a">The second operand</param>
        [MethodImpl(Inline), GtEq]
        public static bool gteq(ushort a, ushort b)
            => a >= b;

        /// <summary>
        /// Defines the test gt:bit := a >= b, succeeding if the first operand is larger than or equal to the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="a">The second operand</param>
        [MethodImpl(Inline), GtEq]
        public static bool gteq(int a, int b)
            => a >= b;

        /// <summary>
        /// Defines the test gt:bit := a >= b, succeeding if the first operand is larger than or equal to the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="a">The second operand</param>
        [MethodImpl(Inline), GtEq]
        public static bool gteq(uint a, uint b)
            => a >= b;

        /// <summary>
        /// Defines the test gt:bit := a >= b, succeeding if the first operand is larger than or equal to the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="a">The second operand</param>
        [MethodImpl(Inline), GtEq]
        public static bool gteq(long a, long b)
            => a >= b;

        /// <summary>
        /// Defines the test gt:bit := a >= b, succeeding if the first operand is larger than or equal to the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="a">The second operand</param>
        [MethodImpl(Inline), GtEq]
        public static bool gteq(ulong a, ulong b)
            => a >= b;
    }
}