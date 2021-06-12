//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    partial struct Intervals
    {
        /// <summary>
        /// Cleaves a closed interval over an intergral domain into manageable disjoint pieces
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="width">The partition width</param>
        /// <typeparam name="T">The integer type, at most 64-bits wide</typeparam>
        public static T[] partition<T>(in ClosedInterval<T> src, T width)
            where T : unmanaged
        {
            var dst = list<T>();
            dst.Add(src.Min);

            var next = left(src) + uint64(width);

            while(next < right(src))
            {
                dst.Add(generic<T>(next));
                next = next + uint64(width);
            }

            dst.Add(src.Max);
            return dst.Array();
        }
    }
}