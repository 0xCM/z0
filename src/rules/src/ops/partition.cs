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
                {
                    vector[j] = skip(src,i++);
                }
            }

            return counter;
            // var count = src.Length;
            // var i=0u;
            // var j=0u;
            // var current = dst[j];
            // var collecting = false;
            // while(i < count)
            // {
            //     ref readonly var cell = ref skip(src,i++);
            //     if(rule.Test(cell))
            //     {
            //         if(collecting)
            //         {
            //             current = dst[++j];
            //             collecting = false;
            //         }

            //         continue;
            //     }
            //     else
            //     {
            //         current[j] = cell;
            //         if(!collecting)
            //             collecting = true;
            //     }
            // }
            // return j;
        }
    }
}