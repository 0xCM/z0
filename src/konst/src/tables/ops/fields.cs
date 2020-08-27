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

            var declared = type.DeclaredInstanceFields();
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
            where T : struct, ITable
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

        [MethodImpl(Inline), Op]
        public static ref TableField map(FieldInfo src, ushort index, ref TableField dst)
        {
            dst.Index = index;
            dst.TableType = src.DeclaringType;
            dst.DataType = src.FieldType;
            dst.FieldName = src.Name;
            dst.FieldOffset = Interop.offset(src.DeclaringType, src.Name);
            dst.FieldId = (Address16)dst.FieldOffset;
            dst.RenderWidth = default;
            dst.FieldSize = default;
            dst.Definition = src;
            return ref dst;
        }

        [Op]
        public static TableFields<F> fields<F,T>()
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
        {
            var t = typeof(T);
            var f = fields(t);
            var l = Literals.fields<F>();
            var v = l.View;
            var buffer = alloc<TableField<F>>(v.Length);
            var dst = span(buffer);
            for(var i=0u; i<dst.Length; i++)
            {
                ref readonly var litVal = ref l[i];
                var litName = l.Name(i);
                var ff = f[l.Name(i)];
                if(ff.IsSome())
                    seek(dst,i) = field<F,T>(litVal,ff.Value.Definition);
            }
            return buffer;
        }
    }
}