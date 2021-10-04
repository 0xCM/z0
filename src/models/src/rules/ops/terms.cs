//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Rules
    {
        /// <summary>
        /// Defines a scalar range expression
        /// </summary>
        /// <param name="min">The minimum scalar in the range</param>
        /// <param name="max">The maximum scalar in the range</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> terms<T>(Range<T> src)
            where T : unmanaged, IEquatable<T>, IComparable<T>
        {
            var dst = list<T>();
            var first = bw64(src.Min);
            dst.Add(src.Min);
            var next = ++first;
            var last = bw64(src.Max);
            while(next < last)
            {
                dst.Add(@as<ulong,T>(next++));
            }
            dst.Add(src.Max);
            return dst.ViewDeposited();
        }
    }
}