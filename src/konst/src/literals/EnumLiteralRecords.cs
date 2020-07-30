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
    public readonly struct EnumLiteralRecords
    {
        [Op]
        public static void from(PartId part, ArtifactIdentity type, EnumTypeCode ecode, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteralRecord> dst)
        {            
            var count = fields.Length;            
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref z.skip(fields,i);
                seek(dst,i) = new EnumLiteralRecord(part, type, (ushort)i, f.Name, (EnumScalarKind)ecode, Enums.unbox(ecode, f.GetRawConstantValue()));
            }            
        }

        public static ReadOnlySpan<EnumLiteralRecord> from(PartId part, Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = span<EnumLiteralRecord>(fields.Length);
            var ecode = Primitive.ecode(src);
            from(part, src.MetadataToken, ecode, fields, dst);
            return dst;
        }

        public static Span<EnumLiteralRecord> parse(TextDoc src)
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
                    dst[i] = EnumLiteralRecord.Empty;
            }
            return dst;
        }       
    }
}