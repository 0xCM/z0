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
        public static ReadOnlySpan<EnumLiteralRecord> records(PartId part, Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = span<EnumLiteralRecord>(fields.Length);
            var tc = PrimalKinds.ecode(src);
            store(part, src, tc, fields, dst);
            return dst;
        }

        [Op]
        public static Span<EnumLiteralRecord> records(TextDoc src)
        {
            var rc = src.RowCount;
            var dst = z.alloc<EnumLiteralRecord>(rc);
            for(var i=0; i<rc; i++)
            {
                ref readonly var row = ref src[i];
                if(row.CellCount >= 3)
                {
                    var data = row[2];
                    var result = HexByteParser.Service.ParseData(data);
                    if(result.Succeeded)
                    {
                        var bytes = z.span(result.Value);
                        var storage = 0ul;
                        ref var store = ref z.@as<ulong,byte>(storage);
                        var count = z.min(bytes.Length,8);
                        for(var j=0u; j<count; j++)
                            z.seek(store,j) = z.skip(bytes,j);

                        dst[i] = default;
                    }
                }
                else
                    dst[i] = default;
            }
            return dst;
        }
    }
}