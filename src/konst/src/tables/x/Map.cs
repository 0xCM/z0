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

    partial class XTend
    {

        [MethodImpl(Inline)]
        public static TableSpan<Y> Map<T,Y>(this TableSpan<T> src, Func<T,Y> f)
            where T : struct
            where Y : struct
        {
            var count = src.Count;
            var view = src.View;
            var buffer = alloc<Y>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = f(skip(view,i));
            return buffer;
        }
    }
}