//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Strings;

    using static core;

    partial struct strings
    {
        [Op, Closures(Closure)]
        public static StringBuffer<S> buffer<S>(uint length)
            where S : unmanaged
                => new StringBuffer<S>(length);

        [Op, Closures(Closure)]
        public static StringBuffer<S> buffer<S>(int length)
            where S : unmanaged
                => new StringBuffer<S>(length);

        [Op, Closures(Closure)]
        public static StringBuffer buffer(uint length)
            => new StringBuffer(length);

        [Op, Closures(Closure)]
        public static StringBuffer buffer(int length)
            => new StringBuffer(length);

        /// <summary>
        /// Allocates and populates a <see cref='StringBuffer'/> with capacity and content determined the source operand
        /// </summary>
        /// <param name="src">The source strings</param>
        [Op]
        public static StringBuffer buffer(ReadOnlySpan<string> src)
        {
            var count = (uint)src.Length;
            var dst = buffer(length(src) + count);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(src,i);
                var view = span(s);
                for(var j=0; j<count; j++)
                {
                    dst[counter++] = skip(view,j);
                }
                dst[counter++] = (char)0;
            }
            return dst;
        }
    }
}