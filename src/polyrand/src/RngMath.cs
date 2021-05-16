//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Numeric;

    [ApiHost]
    public readonly struct RngMath
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T recip<T>(T value)
            where T : unmanaged
        {
            var x = force<T,double>(value);
            var r = 1.0/x;
            return force<T>(r);
        }

        /// <summary>
        /// Evenly projects points from the interval [0,2^31 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline), Op]
        public static uint contract(uint src, uint max)
            => (uint)(((ulong)src * (ulong)max) >> 32);

        /// <summary>
        /// Evenly projects points from the interval [0,2^63 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline), Op]
        public static ulong contract(ulong src, ulong max)
            => Math128.mulhi(src,max);
    }
}