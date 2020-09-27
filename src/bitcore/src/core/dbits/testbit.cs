//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Bits
    {
        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(sbyte src, byte pos)
            => Bit32.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(byte src, byte pos)
            => Bit32.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(short src, byte pos)
            => Bit32.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(ushort src, byte pos)
            => Bit32.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(int src, byte pos)
            => Bit32.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(uint src, byte pos)
            => Bit32.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(long src, byte pos)
            => Bit32.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, 0 otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(ulong src, byte pos)
            => Bit32.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(float src, byte pos)
           => Bit32.test(BitConverter.SingleToInt32Bits(src),pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), TestBit]
        public static Bit32 testbit(double src, byte pos)
            => Bit32.test(BitConverter.DoubleToInt64Bits(src),pos);
    }
}