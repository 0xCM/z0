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
            var buffer = sys.alloc<FieldValue<S>>(fields.Length);
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

        public static RecordFieldValues<T> values<T>(in T src, RecordFields fields)
            where T : struct
        {
            var tr = __makeref(edit(src));
            var count = fields.Length;
            var fv = fields.View;

            var buffer = sys.alloc<RecordFieldValue>(fields.Count);
            var dst = span(buffer);
            for(ushort i=0; i<fields.Count; i++)
                seek(dst,i) = (i, skip(fv, i).Definition.GetValueDirect(tr));

            return new RecordFieldValues<T>(src, fields, buffer);
        }

        [Op]
        public static RecordFieldValues values(object src, RecordFields fields)
        {
            var buffer = sys.alloc<RecordFieldValue>(fields.Length);
            var dst = span(buffer);
            var view = fields.View;
            var count = fields.Length;
            for(ushort i=0; i<count; i++)
            {
                ref readonly var field = ref fields[i];
                var name = field.Name;
                var value = sys.value(src, field.Definition);
                seek(dst,i) = (i, value);
            }
            return new RecordFieldValues(src, fields, buffer);
        }
    }
}