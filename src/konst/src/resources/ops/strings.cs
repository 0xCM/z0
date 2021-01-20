//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct Resources
    {
        [Op]
        public static StringRes[] strings(Type src)
        {
            var values = span(ClrLiterals.values<string>(src));
            var count = values.Length;
            var buffer = alloc<StringRes>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var fv = ref skip(values,i);
                ref var target = ref seek(dst,i);
                target.Address = address(fv.Right);
                target.Source = fv.Left;
                target.Value = fv.Right;
            }
            return buffer;
        }

        [Op, Closures(Closure)]
        public static StringRes<T>[] strings<T>(Type src)
            where T : unmanaged
        {
            var values = span(ClrLiterals.values<string>(src));
            var count = values.Length;
            var buffer = alloc<StringRes<T>>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var fv = ref skip(values,i);
                seek(dst,i) = define(@as<uint,T>(i),address(fv.Right), (uint)fv.Right.Length);
            }
            return buffer;
        }
    }
}