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

    partial struct Reflex
    {
        public static ReadOnlySpan<FieldValue> FieldValues<T>(in T src)
            where T : struct
        {
            var fields = span(typeof(T).DeclaredFields());
            var dst = alloc<FieldValue>(fields.Length);
            values(src, fields, dst);
            return dst;
        }

        public static void values<T>(in T src, Span<FieldValue> dst)
            where T : struct
        {
            var fields = span(typeof(T).DeclaredFields());
            values(src, fields, dst);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void values<T>(in T src, ReadOnlySpan<FieldInfo> fields, Span<FieldValue> dst)
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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static FieldInfo[] search<T>(Type src)
            => src.Fields().Where(f => f.FieldType == typeof(T));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static FieldValue<T>[] values<T>(Type src)
        {
            var fields = @readonly(search<T>(src));
            var buffer = alloc<FieldValue<T>>(fields.Length);
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

        public static void values<S,T>(Span<FieldValue<T>> dst)
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