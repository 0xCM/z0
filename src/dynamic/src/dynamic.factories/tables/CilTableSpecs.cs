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
    public readonly struct CilTableSpecs
    {
        [Op]
        public static string format(in CilTableSpec src)
        {
            var dst = text.build();
            dst.AppendLine(src.TableName.ShortName);
            for(var i=0; i<src.Fields.Length; i++)
                dst.AppendLine(src.Fields[i].ToString());
            return dst.ToString();
        }

        [Op]
        public static string format(in CilFieldSpec src)
            => string.Format(RP.PSx4, src.FieldName, src.Position, src.Offset, src.TypeName);

        [MethodImpl(Inline), Op]
        public static CilTableSpec table(ClrTypeName type, params CilFieldSpec[] Fields)
            => new CilTableSpec(type, Fields);

        [MethodImpl(Inline), Op]
        public static CilFieldSpec field(Name name, ClrTypeName type, ushort position, Address16 offset = default)
            => new CilFieldSpec(name, type, position, offset);

        public static CilFieldSpec clone(FieldInfo src)
        {
            return default;
        }
        [Op]
        public static CilTableSpec clone(Type src)
        {
            var name = ClrTypeName.from(src);
            var declared = src.DeclaredInstanceFields();
            var count = declared.Length;
            var buffer = alloc<CilFieldSpec>(count);
            var fields = @readonly(declared);
            var fieldOffsets = span(Reflex.offsets(src, declared));

            var dst = span(buffer);
            for(ushort i=0; i<count; i++)
            {
                ref readonly var f = ref skip(fields, i);
                var offset = skip(fieldOffsets,i);
                seek(dst,i) = CilTableSpecs.field(f.Name, name, i, skip(fieldOffsets,i));
            }

            return new CilTableSpec(name, buffer);
        }
    }
}