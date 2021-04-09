//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Divisors<T>
        where T : unmanaged
    {
        static T One => Numeric.one<T>();

        [MethodImpl(Inline)]
        public T[] divisors(T src)
            => Divisors.compute(src);

        /// <summary>
        /// Computes the divisors for each number in a specified interval
        /// </summary>
        /// <param name="min">The minimum dividend</param>
        /// <param name="max">The maximum dividend</param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        public DivisorIndex<T> index(Interval<T> interval)
        {
            var results = from n in range(interval).AsParallel()
                        let d = Divisors.compute(n)
                        select Divisors.list(n, d);

            return Divisors.index(interval, results.ToArray());
        }

        /// <summary>
        /// Computes a divisor index stream
        /// </summary>
        /// <param name="step"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <typeparam name="T"></typeparam>
        public IEnumerable<DivisorIndex<T>> indices(Interval<T> interval, T step)
        {
            var min = interval.LeftClosed ? interval.Left : gmath.inc(interval.Left);
            var max = interval.RightClosed ? interval.Right : gmath.dec(interval.Right);
            for(var i=min; gmath.lt(i,max); i = gmath.add(i, step))
            {
                var divMin = gmath.add(i, One);
                var divMax = gmath.add(i, step);
                var next = Interval.closed(divMin, divMax);
                yield return index(next);
            }
        }

        public IEnumerable<T> range(Interval<T> src)
        {
            var first = src.LeftClosed ? src.Left : gmath.inc(src.Left);
            var last = src.RightClosed ? src.Right : gmath.dec(src.Right);
            return range(first,last);
        }

        public IEnumerable<T> range(T first, T last)
        {
            var current = first;
            if(gmath.lt(first, last))
            {
                while(gmath.lteq(current, last))
                {
                    yield return current;
                    current = gmath.inc(current);
                }
            }
            else
            {
                while(gmath.gteq(current, last))
                {
                    yield return current;
                    current = gmath.dec(current);
                }
            }
        }
    }
}