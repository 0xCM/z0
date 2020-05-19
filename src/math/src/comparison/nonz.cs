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
        /// Defines the test nonz:bit := src != 0, succeeding if the source operand is nonzero
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Nonz]
        public static bit nonz(sbyte src)
            => src != 0;

        /// <summary>
        /// Defines the test nonz:bit := src != 0, succeeding if the source operand is nonzero
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Nonz]
        public static bit nonz(byte src)
            => src != 0;

        /// <summary>
        /// Defines the test nonz:bit := src != 0, succeeding if the source operand is nonzero
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Nonz]
        public static bit nonz(short src)
            => src != 0;

        /// <summary>
        /// Defines the test nonz:bit := src != 0, succeeding if the source operand is nonzero
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Nonz]
        public static bit nonz(ushort src)
            => src != 0;

        /// <summary>
        /// Defines the test nonz:bit := src != 0, succeeding if the source operand is nonzero
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Nonz]
        public static bit nonz(int src)
            => src != 0;

        /// <summary>
        /// Defines the test nonz:bit := src != 0, succeeding if the source operand is nonzero
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Nonz]
        public static bit nonz(uint src)
            => src != 0;

        /// <summary>
        /// Defines the test nonz:bit := src != 0, succeeding if the source operand is nonzero
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Nonz]
        public static bit nonz(long src)
            => src != 0;

        /// <summary>
        /// Defines the test nonz:bit := src != 0, succeeding if the source operand is nonzero
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Nonz]
        public static bit nonz(ulong src)
            => src != 0;
    }
}