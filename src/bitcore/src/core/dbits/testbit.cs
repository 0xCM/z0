//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Bits
    {
        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(sbyte src, byte pos)
            => BitStates.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(byte src, byte pos)
            => BitStates.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(short src, byte pos)
            => BitStates.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(ushort src, byte pos)
            => BitStates.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(int src, byte pos)
            => BitStates.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(uint src, byte pos)
            => BitStates.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(long src, byte pos)
            => BitStates.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(ulong src, byte pos)
            => BitStates.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(float src, byte pos)
           => BitStates.test(BitConverter.SingleToInt32Bits(src),pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit]
        public static bit testbit(double src, byte pos)
            => BitStates.test(BitConverter.DoubleToInt64Bits(src),pos);
    }
}