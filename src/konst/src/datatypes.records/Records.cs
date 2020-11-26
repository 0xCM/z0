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

    [ApiHost]
    public readonly partial struct Records
    {

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DynamicRow<T> row<T>(uint cells)
            where T : struct
                => new DynamicRow<T>(0, default(T), sys.alloc<dynamic>(cells));

        public static RecordFields fields<T>()
            where T : struct
                => fields(typeof(T));

        [Op]
        public static RecordFields fields(Type src)
        {
            var fields = src.DeclaredInstanceFields();
            var count = fields.Length;
            var dst = alloc<RecordField>(count);
            map(fields,dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void map(ReadOnlySpan<FieldInfo> src, Span<RecordField> dst)
        {
            var count = (ushort)src.Length;
            for(var i=z16; i<count; i++)
                map(skip(src, i), i, ref seek(dst, i));
        }

        [MethodImpl(Inline), Op]
        public static ref RecordField map(FieldInfo src, ushort index, ref RecordField dst)
        {
            dst.FieldIndex = index;
            dst.FieldKey = src.MetadataToken;
            dst.RecordType = src.DeclaringType;
            dst.DataType = src.FieldType;
            dst.RenderWidth = 16;
            dst.Size = default;
            dst.Definition = src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static FieldValue<S,T> value<S,T>(S src, FieldInfo field, T value)
            where S : struct
                => new FieldValue<S,T>(src, field, value);

        public static RecordFieldValues<T> values<T>(in T src, RecordFields fields)
            where T : struct
        {
            var tr = __makeref(edit(src));
            var count = fields.Length;
            var fv = fields.View;

            var buffer = alloc<RecordFieldValue>(fields.Count);
            var dst = span(buffer);
            for(ushort i=0; i<fields.Count; i++)
                seek(dst,i) = (i, skip(fv, i).Definition.GetValueDirect(tr));

            return new RecordFieldValues<T>(src, fields, buffer);
        }

        [Op]
        public static RecordFieldValues values(object src, RecordFields fields)
        {
            var buffer = alloc<RecordFieldValue>(fields.Length);
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

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void load<T>(in RecordFields fields, ReadOnlySpan<T> src, in DynamicRows<T> dst)
            where T : struct
        {
            var count = (uint)src.Length;
            var target = dst.Edit;
            for(var i=0u; i<count; i++)
                load(fields, i, skip(src, i), ref seek(target,i));
        }

        [Op, Closures(UnsignedInts)]
        public static void load<T>(in RecordFields fields, uint index, in T src, ref DynamicRow<T> dst)
            where T : struct
        {
            dst = dst.UpdateSource(index, src);
            var tr = __makeref(edit(src));
            var count = fields.Length;
            var fv = fields.View;
            var target = span(dst.Cells);
            for(var i=0u; i<count; i++)
                seek(target, i) = skip(fv, i).Definition.GetValueDirect(tr);
        }
    }
}