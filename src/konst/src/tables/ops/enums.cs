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

    partial struct Table
    {
        [Op]
        public static ReadOnlySpan<EnumLiteralRecord> enums(PartId part, Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = span<EnumLiteralRecord>(fields.Length);
            var tc = Primitive.ecode(src);
            store(part, src, tc, fields, dst);
            return dst;
        }

        [Op]
        public static Span<EnumLiteralRecord> enums(TextDoc src)
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
        
        [Op]
        public static EnumLiterals enums(Type src)
        {
            var ut = src.GetEnumUnderlyingType();
            var nk = ut.NumericKind();
            
            var fields = span(src.LiteralFields());
            var count = fields.Length;            
            var buffer = sys.alloc<EnumLiteralDetail>(count);
            var index = span(buffer);
            
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var dst = new EnumLiteralDetail();
                dst.Id = field.MetadataToken;
                dst.TypeName = src.Name;
                dst.TypeHandle = src.TypeHandle.Value;
                dst.TypeId = src.MetadataToken;
                dst.PrimalKind = Enums.@base(nk);
                dst.Name = field.Name;
                dst.Position = i;
                dst.Value = Variant.define(field.GetRawConstantValue(), nk);
                seek(index,i) = dst;
            }

            return new EnumLiterals(buffer);
        }

        [Op]
        public static EnumLiterals enums(Assembly src)
        {
            var enums = src.GetTypes().Where(t => t.IsEnum);
            var dst = EnumLiterals.Empty;
            for(var i=0; i<enums.Length; i++)
                dst = dst.Append(Table.enums(enums[i]));
            return dst;
        }

        public static Data.EnumLiteral[] enums<E>()
            where E : unmanaged, Enum
        {
            var literals = Enums.index<E>();
            var dst = new Data.EnumLiteral[literals.Length];            
            var primal = typeof(E).GetEnumUnderlyingType();
            var flags = typeof(E).Tagged<FlagsAttribute>();
            var baseTag =typeof(E).Tag<NumericBaseAttribute>(); 
            var @base = baseTag.MapValueOrDefault(x => x.Base, NumericBaseKind.Base10);
            var bitmax = baseTag.MapValueOrDefault(x => x.MaxDigits, (int?)null);
            var hexmax = bitmax != null ? bitmax.Value/4 : (int?)null;
            var declarer = typeof(E).Name;

            for(var i=0; i<dst.Length; i++)
            {
                var literal = literals[i];
                
                var description = ReflectedLiterals.attributed(typeof(E).Field(literal.ToString()).Require()).Text;
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.LiteralValue.ToString();

                var bs = @base == NumericBaseKind.Base2 ? MultiFormatter.Service.FormatEnum(literal.LiteralValue, n2, bitmax) : string.Empty;
                var hex = MultiFormatter.Service.FormatEnum(literal.LiteralValue, n16, hexmax);
                dst[i] = new Data.EnumLiteral(declarer, literal.Position, literal.Name, hex, bs, description);
            }

            return dst;
        }        

        public static Data.EnumLiteral[] enums<E>(FilePath dst)
            where E : unmanaged, Enum
        {            
            var records = Table.enums<E>();
            using var writer = dst.Writer();
            writer.WriteLine(Tabular.HeaderText<E>());
            for(var i=0; i<records.Length; i++)
                writer.WriteLine(records[i].DelimitedText(FieldDelimiter));
            return records;
        }
    }
}