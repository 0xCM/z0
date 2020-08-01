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
        public static EnumLiterals index(Assembly src)
        {
            var enums = src.GetTypes().Where(t => t.IsEnum);
            var dst = EnumLiterals.Empty;
            for(var i=0; i<enums.Length; i++)
            {
                dst = dst.Append(index(enums[i]));
            }
            return dst;
        }
        
        [MethodImpl(Inline), Op]
        public static EnumLiterals index(Type src)
        {
            var ut = src.GetEnumUnderlyingType();
            var nk = ut.NumericKind();
            
            var fields = span(src.LiteralFields());
            var count = fields.Length;            
            var buffer = sys.alloc<EnumLiteral>(count);
            var index = span(buffer);
            
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var dst = new EnumLiteral();
                dst.Id = field.MetadataToken;
                dst.TypeName = src.Name;
                dst.TypeHandle = src.TypeHandle.Value;
                dst.TypeId = src.MetadataToken;
                dst.DataType = Enums.@base(nk);
                dst.Name = field.Name;
                dst.Position = i;
                dst.Value = Variant.define(field.GetRawConstantValue(), nk);
                seek(index,i) = dst;
            }

            return new EnumLiterals(buffer);
        }

        [Op]
        public static void from(PartId part, Type type, EnumTypeCode ecode, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteralRecord> dst)
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

        public static ReadOnlySpan<EnumLiteralRecord> from(PartId part, Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = span<EnumLiteralRecord>(fields.Length);
            var ecode = Primitive.ecode(src);
            from(part, src, ecode, fields, dst);
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
                    dst[i] = default;
            }
            return dst;
        }       
    }
}