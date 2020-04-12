//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static As;
    using static Seed;

    partial class Numeric
    {
        /// <summary>
        /// Evenly projects points from the interval [0,maxval[T]] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T squeeze<T>(T src, T max)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(squeeze(uint8(src), uint8(max)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(squeeze(uint16(src), (uint16(max))));
            else if(typeof(T) == typeof(uint))
                return generic<T>(squeeze(uint32(src), (uint32(max))));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(squeeze(uint64(src), (uint64(max))));
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Evenly projects points from the interval [0,2^8 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline), Op]
        static byte squeeze(byte src, byte max)
            => (byte)(((ushort)src * (ushort)max) >> 8);

        /// <summary>
        /// Evenly projects points from the interval [0,2^15 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline), Op]
        static ushort squeeze(ushort src, ushort max)
            => (ushort)(((uint)src * (uint)max) >> 16);

        /// <summary>
        /// Evenly projects points from the interval [0,2^31 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline), Op]
        static uint squeeze(uint src, uint max)
            => (uint)(((ulong)src * (ulong)max) >> 32);

        /// <summary>
        /// Evenly projects points from the interval [0,2^63 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline), Op]
        static ulong squeeze(ulong src, ulong max)
            => BmiMul.mulhi(src,max);
    }
}