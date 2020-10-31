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

    partial struct ClrQuery
    {
        public static ReadOnlySpan<ClrFieldValue> FieldValues<T>(in T src)
            where T : struct
        {
            var fields = span(typeof(T).DeclaredFields());
            var dst = alloc<ClrFieldValue>(fields.Length);
            values(src, fields, dst);
            return dst;
        }

        public static void values<T>(in T src, Span<ClrFieldValue> dst)
            where T : struct
        {
            var fields = span(typeof(T).DeclaredFields());
            values(src, fields, dst);
        }

        [Op, Closures(Closure)]
        public static void values<T>(in T src, ReadOnlySpan<FieldInfo> fields, Span<ClrFieldValue> dst)
            where T : struct
        {
            ref var target = ref first(dst);
            var tRef = __makeref(edit(src));
            var count = fields.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                seek(target,i) = (f,f.GetValueDirect(tRef));
            }
        }

        [Op, Closures(Closure)]
        public static ClrFieldValue<T>[] values<T>(Type src)
        {
            var fields = @readonly(search<T>(src));
            var buffer = alloc<ClrFieldValue<T>>(fields.Length);
            var dst = span(buffer);
            ref var target = ref first(dst);
            var tRef = __makeref(src);
            var count = fields.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                seek(target,i) = (f,(T)f.GetValueDirect(tRef));
            }
            return buffer;
        }

        public static void values<S,T>(Span<ClrFieldValue<T>> dst)
            where S : struct
        {
            var src = typeof(S);
            var fields = @readonly(search<T>(src));
            ref var target = ref first(dst);
            var tRef = __makeref(src);
            var count = fields.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                seek(target,i) = (f,(T)f.GetValueDirect(tRef));
            }
        }
   }
}