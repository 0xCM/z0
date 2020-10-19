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
        public static StringResource[] strings(Type src)
        {
            var values = span(Literals.values2<string>(src));
            var count = values.Length;
            var buffer = alloc<StringResource>(count);
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

        [Op, Closures(UnsignedInts)]
        public static StringResource<T>[] strings<T>(Type src)
            where T : unmanaged
        {
            var values = span(Literals.values2<string>(src));
            var count = values.Length;
            var buffer = alloc<StringResource<T>>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var fv = ref skip(values,i);
                seek(dst,i) = define(@as<uint,T>(i),address(fv.Value), (uint)fv.Value.Length);
            }
            return buffer;
        }
    }
}