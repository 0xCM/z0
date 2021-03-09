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

    partial struct ClrEnums
    {
        public static Index<E> literals<E>()
            where E : unmanaged, Enum
        {
            var src = typeof(E);
            var fields = span(src.LiteralFields());
            var count = fields.Length;
            var buffer = alloc<E>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = (E)skip(fields,i).GetRawConstantValue();
            return buffer;
        }
    }
}