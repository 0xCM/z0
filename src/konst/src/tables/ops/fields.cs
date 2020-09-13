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

    partial struct Table
    {
        [Op]
        public static TableFields fields(Type type)
        {
            if(!type.IsStruct() || type.IsPrimitive)
                return TableFields.Empty;

            var declared = type.SequentialFields();
            var src = span(declared);
            var count = declared.Length;
            var buffer = alloc<TableField>(declared.Length);
            var dst = span(buffer);

            for(ushort i=0; i<count; i++)
                map(skip(src,i), i, ref seek(dst,i));

            return new TableFields(buffer);
        }

        public static TableFields fields(Type src, bool recurse)
        {
            var collected = list<TableField>();
            ushort j = 0;
            if(src.IsStruct() && !src.IsPrimitive)
            {
                var defs = @readonly(src.SequentialFields());
                var count = defs.Length;
                for(var i=0u; i<count; i++)
                {
                    ref readonly var def = ref skip(defs,i);
                    var dst = new TableField();
                    map(def, j++, ref dst);
                    var ft = def.FieldType;
                    if(ft.IsStruct() && !ft.IsPrimitive && recurse)
                    {
                        var subfields = fields(ft,recurse);
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

        public static TableFields fields<T>()
            where T : struct
        {
            var type = typeof(T);
            var declared = @readonly(type.SequentialFields());
            var count = declared.Length;
            var buffer = alloc<TableField>(count);
            var fields = span(buffer);
            for(ushort i=0; i<count; i++)
                map(skip(declared,i), i, ref seek(fields,i));

            return new TableFields(buffer);
        }

        public static TableFields fields<T>(ReadOnlySpan<byte> widths)
            where T : struct
        {
            var type = typeof(T);
            var declared = @readonly(type.SequentialFields());
            var count = declared.Length;
            var buffer = alloc<TableField>(count);
            var fields = span(buffer);
            for(ushort i=0; i<count; i++)
            {
                map(skip(declared,i), i, skip(widths,i), ref seek(fields,i));
            }

            return new TableFields(buffer);
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

        [Op]
        public static TableFields<F> fields<F,T>()
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
        {
            var t = typeof(T);
            var tFields = fields(t);
            var literals = Literals.fields<F>();
            var lFields = literals.Specs;

            var specs = fields<T>();
            var dst = list<TableField<F>>(lFields.Length);
            for(var i=0u; i<lFields.Length; i++)
            {
                ref readonly var literal = ref literals[i];
                var name = literals.Name(i);
                var spec = specs[name];
                if(spec.IsSome())
                    dst.Add(field<F,T>(literal, spec.Value));

            }
            return dst.ToArray();
        }
    }
}