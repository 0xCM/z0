//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct Table
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static TableField<F> field<F,T>(F id, TableField spec, ushort? width = null)
            where F : unmanaged
            where T : struct
                => new TableField<F>(id, spec, width ?? (new RenderWidth<ushort>(@as<F,ushort>(id))));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TableField<byte> field<T>(byte id, TableField spec, ushort width)
            where T : struct
                => new TableField<byte>(id, spec, width);

        // [MethodImpl(Inline), Op]
        // static object value(FieldInfo def, TypedReference tr)
        //     => def.GetValueDirect(tr);

        public static void format<F,T>(in TableFields<F> fields, in T src, StringBuilder dst)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
        {
            var count = fields.Count;
            var view = fields.View;
            var tt = typeof(T);
            var tr = __makeref(edit(src));
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(view,i);
                var width = field.Width;
                var type = field.DataType;
                var def = field.Definition;
                var val = value(def,tr);
                var fmt = text.format(val, type, FieldDelimiter, width);
                dst.Append(fmt);
            }
        }

        public static void format<F,T>(in T src, StringBuilder dst)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
        {
            format(index<F,T>(), src, dst);
        }

        public static string format<F,T>(in T src)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
        {
            var dst = text.build();
            format(index<F,T>(), src, dst);
            return dst.ToString();
        }

        [Op]
        public static TableFields index(Type type)
        {
            if(!type.IsStruct() || type.IsPrimitive)
                return TableFields.Empty;

            var declared = type.Fields();
            var count = declared.Length;
            var buffer = alloc<TableField>(count);

            map(declared, buffer);

            return new TableFields(buffer);
        }

        public static TableFields index(Type src, bool recurse)
        {
            var collected = list<TableField>();
            ushort j = 0;
            if(src.IsStruct() && !src.IsPrimitive)
            {
                var defs = @readonly(src.DeclaredInstanceFields());
                var count = defs.Length;
                for(var i=0u; i<count; i++)
                {
                    ref readonly var def = ref skip(defs,i);
                    var dst = new TableField();
                    map(def, j++, ref dst);
                    var ft = def.FieldType;
                    if(ft.IsStruct() && !ft.IsPrimitive && recurse)
                    {
                        var subfields = index(ft, recurse);
                        collected.AddRange(subfields.Storage);
                    }
                }
            }

            var final = collected.ToArray();
            var fCount = final.Length;
            ref var f = ref first(span(final));
            for(ushort index = 0; index<fCount; index++)
                seek(f,index).Index = index;

            return final;
        }

        [Op, Closures(UnsignedInts)]
        public static TableFields index<T>(ReadOnlySpan<byte> widths)
            where T : struct
        {
            var type = typeof(T);
            var declared = @readonly(type.DeclaredInstanceFields());
            var count = declared.Length;
            if(count != widths.Length)
                @throw(AppErrors.LengthMismatch(count, widths.Length));

            var buffer = alloc<TableField>(count);
            var fields = span(buffer);
            for(ushort i=0; i<count; i++)
                map(skip(declared,i), i, skip(widths,i), ref seek(fields,i));

            return new TableFields(buffer);
        }

        [Op, Closures(UnsignedInts)]
        public static TableFields index<T>()
            where T : struct
        {
            var type = typeof(T);
            var declared = @readonly(type.DeclaredInstanceFields());
            var count = declared.Length;
            var buffer = alloc<TableField>(count);
            var fields = span(buffer);
            for(ushort i=0; i<count; i++)
                map(skip(declared,i), i, ref seek(fields,i));

            return new TableFields(buffer);
        }

        public static TableFields<F> index<F,T>()
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
        {
            var t = typeof(T);
            var tFields = index(t);
            var literals = LiteralFields.fields<F>();
            var lFields = literals.Specs;

            var specs = index<T>();
            var dst = list<TableField<F>>(lFields.Length);
            for(var i=0u; i<lFields.Length; i++)
            {
                ref readonly var literal = ref literals[i];
                var name = literals.Name(i);
                var spec = specs[name];
                if(spec.IsSome())
                    dst.Add(Table.field<F,T>(literal, spec.Value));

            }
            return dst.ToArray();
        }


        [MethodImpl(Inline), Op]
        public static void map(ReadOnlySpan<FieldInfo> src, Span<TableField> dst)
        {
            var count = (ushort)src.Length;
            for(var i=z16; i<count; i++)
                map(skip(src, i), i, ref seek(dst, i));
        }

        [MethodImpl(Inline), Op]
        public static ref TableField map(FieldInfo src, ushort index, ref TableField dst)
        {
            dst.Index = index;
            dst.TableType = src.DeclaringType;
            dst.DataType = src.FieldType;
            dst.Offset = Interop.offset(src.DeclaringType, src.Name);
            dst.Id = (Address16)dst.Offset;
            dst.RenderWidth = 16;
            dst.Size = default;
            dst.Definition = src;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref TableField map(FieldInfo src, ushort index, byte width, ref TableField dst)
        {
            dst.Index = index;
            dst.TableType = src.DeclaringType;
            dst.DataType = src.FieldType;
            dst.Offset = Interop.offset(src.DeclaringType, src.Name);
            dst.Id = (Address16)dst.Offset;
            dst.RenderWidth = width;
            dst.Size = default;
            dst.Definition = src;
            return ref dst;
        }
    }
}