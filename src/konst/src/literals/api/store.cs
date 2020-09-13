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

    partial struct Literals
    {
        [Op]
        public static void store(PartId part, Type src, Span<EnumLiteralRecord> dst)
        {
            var fields = span(src.LiteralFields());
            var tc = PrimalKinds.ecode(src);
            store(part, src, tc, fields, dst);
        }

        [Op]
        public static void store(PartId part, Type type, EnumTypeCode tc, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteralRecord> dst)
        {
            var count = fields.Length;
            var address = type.TypeHandle.Value;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref z.skip(fields,i);
                var nameAddress = z.address(f.Name);
                seek(dst,i) = new EnumLiteralRecord(part, type, address, (ushort)i, f.Name, nameAddress, (EnumScalarKind)tc, Enums.unbox(tc, f.GetRawConstantValue()));
            }
        }
    }
}