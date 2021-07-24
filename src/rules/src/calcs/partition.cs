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
    using static Rules;

    partial struct RuleCalcs
    {
        [Op, Closures(Closure)]
        public static uint partition<T>(ReadOnlySpan<T> src, uint width, SpanVecs<T> dst)
            where T : IEquatable<T>
        {
            var dim = min(dst.Dim,width);
            var counter = 0u;
            var i=0u;
            var cells = src.Length;
            while(i < cells)
            {
                var vector = dst[counter++];
                for(var j=0; j<dim && i<cells; j++)
                    vector[j] = skip(src,i++);
            }

            return counter;
        }
    }
}