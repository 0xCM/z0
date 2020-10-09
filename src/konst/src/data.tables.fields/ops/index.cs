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

    partial struct TableFields
    {
        [Op]
        public static TableFieldIndex index(Type type)
        {
            if(!type.IsStruct() || type.IsPrimitive)
                return TableFieldIndex.Empty;

            var declared = type.Fields();
            var count = declared.Length;
            var buffer = alloc<TableField>(count);

            map(declared, buffer);

            return new TableFieldIndex(buffer);
        }

        public static TableFieldIndex index(Type src, bool recurse)
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
        public static TableFieldIndex index<T>(ReadOnlySpan<byte> widths)
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

            return new TableFieldIndex(buffer);
        }


        [Op, Closures(UnsignedInts)]
        public static TableFieldIndex index<T>()
            where T : struct
        {
            var type = typeof(T);
            var declared = @readonly(type.DeclaredInstanceFields());
            var count = declared.Length;
            var buffer = alloc<TableField>(count);
            var fields = span(buffer);
            for(ushort i=0; i<count; i++)
                map(skip(declared,i), i, ref seek(fields,i));

            return new TableFieldIndex(buffer);
        }

        public static TableFieldIndex<F> index<F,T>()
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
        {
            var t = typeof(T);
            var tFields = TableFields.index(t);
            var literals = Literals.fields<F>();
            var lFields = literals.Specs;

            var specs = index<T>();
            var dst = list<TableField<F>>(lFields.Length);
            for(var i=0u; i<lFields.Length; i++)
            {
                ref readonly var literal = ref literals[i];
                var name = literals.Name(i);
                var spec = specs[name];
                if(spec.IsSome())
                    dst.Add(define<F,T>(literal, spec.Value));

            }
            return dst.ToArray();
        }
    }
}
