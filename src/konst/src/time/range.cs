//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Time
    {
        [MethodImpl(Inline), Op]
        public static DateRange range(Date min, Date max)
            => new DateRange(min,max);

        /// <summary>
        /// Determines whether the test value is within the range
        /// </summary>
        /// <param name="test">The date to test</param>
        [MethodImpl(Inline), Op]
        public static bool contains(in DateRange src, Date test)
            => test >= src.Min && test <= src.Max;

        /// <summary>
        /// Determines whether the test value is outside the range
        /// </summary>
        /// <param name="test">The date to test</param>
        [MethodImpl(Inline), Op]
        public static bool external(in DateRange src, Date test)
            => test < src.Min || test > src.Max;
    }
}