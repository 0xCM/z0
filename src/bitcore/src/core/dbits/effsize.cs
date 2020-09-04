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
        /// Computes the minimum number of bytes required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffSize]
        public static byte effsize(byte src)
            => 1;

        /// <summary>
        /// Computes the minimum number of bytes required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffSize]
        public static byte effsize(ushort src)
        {
            if(src <= Max8u)
                return 1;
            else
                return 2;
        }

        /// <summary>
        /// Computes the minimum number of bytes required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffSize]
        public static byte effsize(uint src)
        {
            if(src <= Max8u)
                return 1;
            else if(src <= Max16u)
                return 2;
            else if(src <= Max24u)
                return 3;
            else
                return 4;
        }

        /// <summary>
        /// Computes the minimum number of bytes required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte effsize_baseline(ulong src)
        {
            if(src <= Max8u)
                return 1;
            else if(src <= Max16u)
                return 2;
            else if(src <= Max24u)
                return 3;
            else if(src <= Max32u)
                return 4;
            else if(src <= Max40u)
                return 5;
            else if(src <= Max48u)
                return 6;
            else if(src <= Max56u)
                return 7;
            else
                return 8;
        }

        /// <summary>
        /// Computes the minimum number of bytes required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffSize]
        public static byte effsize(ulong src)
            => math.sub(math.log2((byte)hipos(src)), One8u);

        /// <summary>
        /// Computes the minimum number of bytes required to represent a value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffSize]
        public static byte effsize(sbyte src)
            => 1;

        /// <summary>
        /// Computes the minimum number of bytes required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffSize]
        public static byte effsize(short src)
            => math.lt(src, Zero16i) ? (byte)2 : effsize((uint)src);

        /// <summary>
        /// Computes the minimum number of bytes required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffSize]
        public static byte effsize(int src)
            => math.lt(src, Zero32i) ? (byte)4 : effsize((uint)src);

        /// <summary>
        /// Computes the minimum number of bytes required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffSize]
        public static byte effsize(long src)
            => math.lt(src, Zero64i) ? (byte)8 : effsize_baseline((ulong)src);
    }
}