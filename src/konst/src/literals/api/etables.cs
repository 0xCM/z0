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
        [MethodImpl(Inline), Op]
        public static LiteralFields fields(Type src)
            => new LiteralFields(src.LiteralFields());


        [MethodImpl(Inline)]
        public static LiteralFields<F> fields<F>()
            where F : unmanaged, Enum
                => new LiteralFields<F>(typeof(F).LiteralFields());
        [Op]
        public static void etables(PartId part, Type type, EnumTypeCode ecode, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteralRecord> dst)
        {
            var count = fields.Length;
            var address = type.TypeHandle.Value;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref z.skip(fields,i);
                var nameAddress = z.address(f.Name);
                seek(dst,i) = new EnumLiteralRecord(part, type, address, (ushort)i, f.Name, nameAddress, (EnumScalarKind)ecode, Enums.unbox(ecode, f.GetRawConstantValue()));
            }
        }

        [Op]
        public static ReadOnlySpan<EnumLiteralRecord> etables(PartId part, Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = span<EnumLiteralRecord>(fields.Length);
            var ecode = Primitive.ecode(src);
            etables(part, src, ecode, fields, dst);
            return dst;
        }
    }
}