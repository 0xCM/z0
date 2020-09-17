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

    partial class Enums
    {
        [Op]
        public static void store(PartId part, Type src, Span<EnumLiteralRow> dst)
        {
            var fields = span(src.LiteralFields());
            var tc = PrimalKinds.ecode(src);
            store(part, src, tc, fields, dst);
        }

        [Op]
        public static void store(PartId part, Type type, EnumTypeCode tc, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteralRow> dst)
        {
            var count = fields.Length;
            var address = type.TypeHandle.Value;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref z.skip(fields,i);
                var nameAddress = z.address(f.Name);
                seek(dst,i) = new EnumLiteralRow(part, type, address, (ushort)i, f.Name, nameAddress, (EnumScalarKind)tc, Enums.unbox(tc, f.GetRawConstantValue()));
            }
        }
    }
}