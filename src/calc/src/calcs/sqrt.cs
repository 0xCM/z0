//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Sqrt, Closures(Floats)]
        public static Span<T> fsqrt<T>(Span<T> src)
            where T : unmanaged
        {
            for(var i=0; i<src.Length; i++)
                src[i] = gfp.sqrt(src[i]);
            return src;
        }
    }
}