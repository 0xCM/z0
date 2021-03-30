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

    partial struct Symbols
    {
        public static Symbols<E> index<E>()
            where E : unmanaged, Enum
        {
            var literals = ClrEnums.symbolic<E>();
            var view = literals.View;
            var count = view.Length;
            var buffer = alloc<Sym<E>>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new Sym<E>(i, skip(view,i));
            return buffer;
        }
    }
}