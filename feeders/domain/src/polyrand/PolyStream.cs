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

        /// <summary>
        /// Presents the polysource as a point source
        /// </summary>
        /// <param name="src">The randon source</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        public static IRngPointSource<T> points<T>(IPolyrand src)
            where T : unmanaged
                => src as IRngPointSource<T>;

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