//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static Numeric;

    partial class Numeric
    {
        [MethodImpl(Inline)]
        public static T contract<T>(T src, T max)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(contract(uint8(src),uint8(max)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(contract(uint16(src),(uint16(max))));
            else if(typeof(T) == typeof(uint))
                return generic<T>(contract(uint32(src),(uint32(max))));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(contract(uint64(src),(uint64(max))));
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Evenly projects points from the interval [0,2^8 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        static byte contract(byte src, byte max)
            => (byte)(((ushort)src * (ushort)max) >> 8);

        /// <summary>
        /// Evenly projects points from the interval [0,2^15 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        static ushort contract(ushort src, ushort max)
            => (ushort)(((uint)src * (uint)max) >> 16);

        /// <summary>
        /// Evenly projects points from the interval [0,2^31 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        static uint contract(uint src, uint max)
            => (uint)(((ulong)src * (ulong)max) >> 32);

        /// <summary>
        /// Evenly projects points from the interval [0,2^63 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        static ulong contract(ulong src, ulong max)
            => Numeric.mulhi(src,max);
    }

    partial class XNumeric
    {
        /// <summary>
        /// Evenly projects points from the interval [0,2^31 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static uint Contract(this uint src, uint max)
            => (uint)(((ulong)src * (ulong)max) >> 32);

        /// <summary>
        /// Evenly projects points from the interval [0,2^63 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline)]
        public static ulong Contract(this ulong src, ulong max)
            => Numeric.mulhi(src,max); 

        /// <summary>
        /// Determines whether an interval contains a specified point
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="point">The point to test</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this Interval<T> src, T point)
            where T : unmanaged
        {
            switch(src.Kind)
            {
                case IntervalKind.Closed:
                    return Numeric.gteq(point, src.Left) && Numeric.lteq(point, src.Right);
                case IntervalKind.Open:
                    return Numeric.gt(point, src.Left) && Numeric.lt(point, src.Right);
                case IntervalKind.LeftClosed:
                    return Numeric.gteq(point, src.Left) && Numeric.lt(point, src.Right);
                default:        
                    return Numeric.gt(point, src.Left) && Numeric.lteq(point, src.Right);
            }
        }
    }
}