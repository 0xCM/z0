//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    partial class BitMask
    {        
        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(sbyte src, int pos)
            => (src & (1 << pos)) != 0;
            
        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(byte src, int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(short src, int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(ushort src, int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(int src, int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(uint src, int pos)
            => (src & (1u << pos)) != 0u;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(long src, int pos)
            => (src & (1L << pos)) != 0L;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(ulong src, int pos)
            => (src & (1ul << pos)) != 0ul;


        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(float src, int pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(double src, int pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(sbyte src, byte pos)
            => (src & (1 << pos)) != 0;
            
        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(byte src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(short src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(ushort src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(int src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(uint src, byte pos)
            => (src & (1u << pos)) != 0u;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(long src, byte pos)
            => (src & (1L << pos)) != 0L;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(ulong src, byte pos)
            => (src & (1ul << pos)) != 0ul;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(float src, byte pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(double src, byte pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

    }

}