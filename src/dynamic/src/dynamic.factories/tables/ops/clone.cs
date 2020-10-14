//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Emit;

    using static System.Reflection.TypeAttributes;

    using static Konst;
    using static z;

    partial struct TableBuilder
    {
        [Op]
        public static TableSpec clone(Type src)
        {
            var name = ClrTypeName.from(src);
            var declared = src.DeclaredInstanceFields();
            var count = declared.Length;
            var buffer = alloc<FieldSpec>(count);
            var fields = @readonly(declared);
            var fieldOffsets = span(Reflex.offsets(src, declared));

            var dst = span(buffer);
            for(ushort i=0; i<count; i++)
            {
                ref readonly var f = ref skip(fields, i);
                var offset = skip(fieldOffsets,i);
                seek(dst,i) = field(f.Name, name, i, skip(fieldOffsets,i));
            }

            return new TableSpec(name, buffer);
        }

    }
}