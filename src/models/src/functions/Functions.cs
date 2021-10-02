//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost("models.functions")]
    public readonly partial struct Functions
    {
        public static PointMap<A,B> points<A,B>(A[] a, B[] b)
            => new PointMap<A,B>(a,b);

        public static PointMap<A,B> points<A,B>(Paired<A,B>[] src)
        {
            var count = src.Length;
            var a = alloc<A>(count);
            var b = alloc<B>(count);
            for(var i=0; i<count; i++)
            {
                seek(a,i) = skip(src,i).Left;
                seek(b,i) = skip(src,i).Right;
            }
            return new PointMap<A,B>(a,b);
        }
    }
}