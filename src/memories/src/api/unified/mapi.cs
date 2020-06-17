//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    partial class Memories
    {
        /// <summary>
        /// Applies the supplied function to each element in the input sequence to produce a list
        /// </summary>
        /// <typeparam name="X">The input sequence item type</typeparam>
        /// <typeparam name="S">The output sequence item type</typeparam>
        /// <param name="seq">The sequence to transform</param>
        /// <param name="f">The transformation function</param>
        public static Y[] mapi<X,Y>(IEnumerable<X> seq, Func<int,X,Y> f)
        {
            var src = seq.ToArray();
            var dst = new Y[src.Length];
            for (var i = 0; i < src.Length; i++)
                dst[i] = f(i, src[i]);
            return dst;
        }
    }
}