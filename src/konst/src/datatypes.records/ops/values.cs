//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    partial struct Records
    {
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

        [Op, Closures(Closure)]
        public static FieldValue<S>[] values<S,T>(S src)
            where S : struct, IRecord<S>
        {
            var fields = z.@readonly(typeof(S).DeclaredInstanceFields());
            var buffer = sys.alloc<FieldValue<S>>(fields.Length);
            var dst = span(buffer);
            ref var target = ref first(dst);
            var tRef = __makeref(src);
            var count = fields.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                seek(target,i) = new FieldValue<S>(f, f.GetValueDirect(tRef));
            }
            return buffer;
        }

        public static FieldValues<T> values<T>(in T src, FieldInfo[] fields)
            where T : struct
        {
            var tr = __makeref(edit(src));
            var count = fields.Length;
            var fv = @readonly(fields);

            var buffer = sys.alloc<FieldValue<T>>(count);
            var dst = span(buffer);
            for(ushort i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fv,i);
                seek(dst,i) = new FieldValue<T>(field,  field.GetValueDirect(tr));
            }

            return new FieldValues<T>(buffer);
        }

        [Op, Closures(Closure)]
        public static void values<T>(in T src, ReadOnlySpan<FieldInfo> fields, Span<FieldValue> dst)
            where T : struct
        {
            ref var target = ref first(dst);
            var tRef = __makeref(edit(src));
            var count = fields.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                seek(target,i) = new FieldValue(f, f.GetValueDirect(tRef));
            }
        }

        [Op, Closures(Closure)]
        public static void values<T>(in T src, ReadOnlySpan<ClrField> fields, Span<FieldValue> dst)
            where T : struct
        {
            ref var target = ref first(dst);
            var tRef = __makeref(edit(src));
            var count = fields.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                seek(target,i) = new FieldValue(f, f.GetValueDirect(tRef));
            }
        }
    }
}