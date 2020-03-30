//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Memories;

    public static class PolyStream
    {
        [MethodImpl(Inline)]
        public static IRngStream<T> create<T>(IEnumerable<T> src, RngKind rng)
            where T : struct
                => new RngStream<T>(rng,src);

        internal static IRngStream<T> create<T>(IPolyrand src, T min, T max)
            where T : unmanaged
                => create(unfiltered(src,min,max), src.RngKind);

        internal static IRngStream<T> create<T>(IPolyrand src, Interval<T> domain)
            where T : unmanaged
                => create(unfiltered(src,domain), src.RngKind);

        internal static IEnumerable<T> points<T>(IPolyrand src, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
        {
            if(filter != null)
                return filtered(src,domain, filter);
            else
                return unfiltered(src,domain);
        }

        /// <summary>
        /// Creates a stream predicated on a specified source over which a filter is applied
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The source domain</param>
        /// <param name="filter">The filter predicate</param>
        /// <typeparam name="T">The production type</typeparam>
        static IEnumerable<T> filtered<T>(IPolyrand src, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
        {
            var next = default(T);    
            var tries = 0;
            var tryMax = 10;
            while(true)            
            {
                next = src.Next<T>(domain);
                if(filter(next))
                {
                    tries = 0;
                    yield return next;
                }
                else
                {
                    ++tries;
                    if(tries > tryMax)
                        throw new Exception($"Filter too rigid over {domain}; last failed value: {next}");
                }
            }
        }

        static IEnumerable<T> unfiltered<T>(IPolyrand src, Interval<T> domain)
            where T : unmanaged
        {
            if(domain.Empty)
            {
                while(true)
                    yield return src.Next<T>();    
            }
            else
            {
                while(true)
                    yield return src.Next<T>(domain.Left, domain.Right);
            }
        }

        static IEnumerable<T> unfiltered<T>(IPolyrand src, T min, T max)
            where T : unmanaged
        {
            while(true)
                yield return src.Next<T>(min, max);
        }

        /// <summary>
        /// Captures a random stream along with the generator classification
        /// </summary>
        readonly struct RngStream<T> : IRngStream<T>
            where T : struct
        {
            [MethodImpl(Inline)]
            public RngStream(RngKind rng, IEnumerable<T> src)
            {
                this.src = src;
                this.RngKind = rng;
            }

            readonly IEnumerable<T> src;

            public RngKind RngKind {get;}

            [MethodImpl(Inline)]
            public IEnumerator<T> GetEnumerator()
                => src.GetEnumerator();

            public IEnumerable<T> Next(int count)
                => src.Take(count);

            [MethodImpl(Inline)]
            public T Next()
                => src.First();
                
            IEnumerator IEnumerable.GetEnumerator()
                => src.GetEnumerator();
        }
    }
}