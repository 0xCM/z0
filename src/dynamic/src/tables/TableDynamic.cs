//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct TableDynamic
    {
        [MethodImpl(Inline), Op]
        public static FieldSpec field(Name name, ClrTypeName type, ushort position, Address16? offset = null)
            => new FieldSpec(name, type, position, offset);

        [MethodImpl(Inline), Op]
        public static TableSpec table(ClrTypeName type, params FieldSpec[] Fields)
            => new TableSpec(type, Fields);

        [Op]
        public static TableSpec @explicit(Type src)
        {
            ClrTypeName name = src.AssemblyQualifiedName;
            var declared = src.DeclaredInstanceFields();
            var count = declared.Length;
            var fieldOffsets = span(Reflex.offsets(src, declared));
            var buffer = alloc<FieldSpec>(count);
            var fields = @readonly(declared);
            var dst = span(buffer);
            for(ushort i=0; i<count; i++)
            {
                ref readonly var f = ref skip(fields, i);
                var offset = skip(fieldOffsets,i);
                seek(dst,i) = field(f.Name, name, i, skip(fieldOffsets,i));
            }

            return new TableSpec(name, buffer);
        }

        [Op]
        public static TableSpec replicate(Type src)
        {
            ClrTypeName name = src.AssemblyQualifiedName;
            var declared = src.DeclaredInstanceFields();
            var count = declared.Length;
            var buffer = alloc<FieldSpec>(count);
            var fields = @readonly(declared);
            var dst = span(buffer);
            for(ushort i=0; i<count; i++)
            {
                ref readonly var f = ref skip(fields, i);
                seek(dst,i) = field(f.Name, name, i);
            }

            return new TableSpec(name, buffer);
        }
    }
}