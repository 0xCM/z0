//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Transforms an array via an indexed mapping function
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static T[] Mapi<S,T>(this S[] src, Func<int,S,T> f)
        {
            var dst = new T[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = f(i,src[i]);
            return dst;
        }
    }
}