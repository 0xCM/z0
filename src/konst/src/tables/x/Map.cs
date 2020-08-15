//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;   
    using static z;


    partial class XTend
    {
        [MethodImpl(Inline)]
        public static TableSpan<T> TableSpan<T>(this T[] src)
            where T : struct
                => src;
        
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
                seek(dst,i) = f(z.skip(view,i));
            return buffer;
        }

        [MethodImpl(Inline)]
        public static TableSpan<T> Where<T>(this TableSpan<T> src, Func<T,bool> f)
            where T : struct
                => src.Storage.Where(f);
    }
}