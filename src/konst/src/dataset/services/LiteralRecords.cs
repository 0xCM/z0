//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    using static Konst;
    using static Typed;

    public readonly struct LiteralRecords
    {
        public static EnumLiteral[] emit<E>(out FilePath dst)
            where E : unmanaged, Enum
        {            
            dst = Table.Service.DatasetPath(typeof(E).Name);            
            var records = create<E>();
            using var writer = dst.Writer();
            writer.WriteLine(Tabular.HeaderText<E>());
            for(var i=0; i<records.Length; i++)
                writer.WriteLine(records[i].DelimitedText(FieldDelimiter));
            return records;
        }

        public static EnumLiteral[] create<E>()
            where E : unmanaged, Enum
        {
            var literals = Enums.index<E>();
            var dst = new EnumLiteral[literals.Length];            
            var primal = typeof(E).GetEnumUnderlyingType();
            var flags = typeof(E).Tagged<FlagsAttribute>();
            var baseTag =typeof(E).Tag<NumericBaseAttribute>(); 
            var @base = baseTag.MapValueOrDefault(x => x.Base, NumericBaseKind.Base10);
            var bitmax = baseTag.MapValueOrDefault(x => x.MaxDigits, (int?)null);
            var hmax = bitmax != null ? bitmax.Value/4 : (int?)null;
            var declarer = typeof(E).Name;

            for(var i=0; i<dst.Length; i++)
            {
                var literal = literals[i];
                
                var description = ReflectedLiterals.attributed(typeof(E).Field(literal.ToString()).Require()).Text;
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.LiteralValue.ToString();

                var bs = @base == NumericBaseKind.Base2 ? MultiFormatter.Service.FormatEnum(literal.LiteralValue, n2, bitmax) : string.Empty;
                var hex = MultiFormatter.Service.FormatEnum(literal.LiteralValue, n16, hmax);
                dst[i] = new EnumLiteral(declarer, literal.Position, literal.Name, hex, bs, description);
            }

            return dst;
        }        
    }
}