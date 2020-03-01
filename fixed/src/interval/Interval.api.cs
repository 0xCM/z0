//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static As;
    using static AsIn;     

    using static Root;    

    /// <summary>
    /// Implements Leimire's algorithm for sampling a uniformly distribute random number
    /// in an interval [0,..,max)
    /// </summary>
    /// <param name="random">A random source</param>
    /// <param name="max">The upper bound for the sample</param>
    /// <remarks>Reference: Fast Random Integer Generation in an Interval, Daniel Lemire 2018</remarks>
    /// <remarks>Reference: https://github.com/lemire/fastrange</reference>
    public static class Interval
    {
        /// <summary>
        /// Defines an open interval (min,max)
        /// </summary>
        /// <param name="min">The exclusive left endpoint</param>
        /// <param name="max">The exclusive right endpoint</param>
        /// <typeparam name="T">The numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Interval<T> open<T>(T min, T max)
            where T : unmanaged
                => new Interval<T>(min,max, IntervalKind.Open);

        /// <summary>
        /// Defines a closed interval [min,max]
        /// </summary>
        /// <param name="min">The inclusive left endpoint</param>
        /// <param name="max">The inclusive right endpoint</param>
        /// <typeparam name="T">The numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Interval<T> closed<T>(T min, T max)
            where T : unmanaged
                => new Interval<T>(min,max, IntervalKind.Closed);

        /// <summary>
        /// Defines an interval of specified sort
        /// </summary>
        /// <param name="min">The left endpoint</param>
        /// <param name="max">The right endpoint</param>
        /// <param name="kind">The interval kind</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Interval<T> define<T>(T min, T max, IntervalKind kind)
            where T : unmanaged
                => new Interval<T>(min,max, kind);


        /// <summary>
        /// Evenly projects points from the interval [0,2^8 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static byte contract(this byte src, byte max)
            => (byte)(((ushort)src * (ushort)max) >> 8);

        /// <summary>
        /// Evenly projects points from the interval [0,2^15 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static ushort contract(this ushort src, ushort max)
            => (ushort)(((uint)src * (uint)max) >> 16);

        /// <summary>
        /// Evenly projects points from the interval [0,2^31 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static uint contract(this uint src, uint max)
            => (uint)(((ulong)src * (ulong)max) >> 32);

        /// <summary>
        /// Evenly projects points from the interval [0,2^63 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static ulong contract(this ulong src, ulong max)
            => Math128.mulhi(src,max);  //src.MulHi(max); 

        [MethodImpl(Inline)]
        public static T contract<T>(T src, T max)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(uint8(src).contract(uint8(max)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(uint16(src).contract(uint16(max)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src).contract(uint32(max)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src).contract(uint64(max)));
            else
                throw unsupported<T>();
        }
    }
}