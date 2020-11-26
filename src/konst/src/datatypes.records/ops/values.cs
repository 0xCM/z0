//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Records
    {

        [Op, Closures(UnsignedInts)]
        public static void values<T>(in T src, ReadOnlySpan<FieldInfo> fields, Span<FieldValue> dst)
            where T : struct
        {
            ref var target = ref first(dst);
            var tRef = __makeref(edit(src));
            var count = fields.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                seek(target,i) = new FieldValue(src, f, f.GetValueDirect(tRef));
            }
        }

        public static ReadOnlySpan<FieldValue> values<T>(in T src)
            where T : struct
        {
            var fields = span(typeof(T).DeclaredFields());
            var dst = sys.alloc<FieldValue>(fields.Length);
            values(src, fields, dst);
            return dst;
        }

        public static void values<T>(in T src, Span<FieldValue> dst)
            where T : struct
        {
            var fields = span(typeof(T).DeclaredFields());
            values(src, fields, dst);
        }

        [Op, Closures(UnsignedInts)]
        public static FieldValue<S>[] values<S,T>(S src)
            where S : struct
        {
            var fields = z.@readonly(typeof(S).DeclaredInstanceFields());
            var buffer = z.alloc<FieldValue<S>>(fields.Length);
            var dst = span(buffer);
            ref var target = ref first(dst);
            var tRef = __makeref(src);
            var count = fields.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                seek(target,i) = new FieldValue<S>(src, f, f.GetValueDirect(tRef));
            }
            return buffer;
        }
    }
}