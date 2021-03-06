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
    using static SFx;

    public readonly struct SpanCalcs
    {
        /// <summary>
        /// Computes the total number of elements produced by a supplied factory operating over a supplied source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="f">The factory operator</param>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op]
        public static uint count<S,T>(ReadOnlySpan<S> src, IReadOnlySpanFactory<S,T> f)
        {
            var total = 0u;
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                var output = f.Invoke(input);
                count += (uint)output.Length;
            }
            return total;
        }

        /// <summary>
        /// Computes the maximum number of elements produced by a supplied factory operating over a supplied source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="f">The factory operator</param>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op]
        public static uint max<S,T>(ReadOnlySpan<S> src, IReadOnlySpanFactory<S,T> f)
        {
            var max = 0u;
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                var output = f.Invoke(input);
                if(output.Length > max)
                    max = (uint)output.Length;
            }
            return max;
        }
    }
}