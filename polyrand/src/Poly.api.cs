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

    using static Root;


    public static class PolyOps
    {
        [MethodImpl(Inline)]
        public static IRngStream<T> stream<T>(IEnumerable<T> src, RngKind rng)
            where T : struct
                => new RandomStream<T>(rng,src);

        /// <summary>
        /// Presents the polysource as a point source
        /// </summary>
        /// <param name="src">The randon source</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        public static IRngPointSource<T> points<T>(IPolyrand src)
            where T : unmanaged
                => src as IRngPointSource<T>;
    }


    public static partial class Polyfun
    {        

    }
}