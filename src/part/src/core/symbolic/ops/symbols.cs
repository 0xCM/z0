//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    partial struct Symbols
    {
        public static Symbols<E> symbols<E>()
            where E : unmanaged, Enum
        {
            var src = literals<E>();
            var view = src.View;
            var count = view.Length;
            var buffer = alloc<Sym<E>>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new Sym<E>(i, skip(view,i));
            return buffer;
        }
    }
}