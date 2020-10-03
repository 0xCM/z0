//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Resources
    {
        [Op]
        public static TextResource[] textres(Type src)
        {
            var values = span(Literals.values2<string>(src));
            var count = values.Length;
            var buffer = alloc<TextResource>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var fv = ref skip(values,i);
                ref var target = ref seek(dst,i);
                target.Address = address(fv.Value);
                target.Source = fv.Field;
                target.Value = fv.Value;
            }
            return buffer;
        }

        public static Span<TextResource<E>> textres<E>(Type src)
            where E : unmanaged, Enum
        {
            var locations = Resources.addresses(src);
            var count = locations.Length;
            var dst = span<TextResource<E>>(count);
            Resources.read(locations, dst);
            return dst;
        }
    }
}