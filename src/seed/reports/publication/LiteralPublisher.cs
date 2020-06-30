//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static Konst;
    using static Typed;

    public readonly struct LiteralPublisher : ILiteralPublisher
    {
        public static LiteralPublisher Service => default(LiteralPublisher);

        public LiteralRecord[] LiteralReport<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum
                => LiteralRecords<E>(declarer, descriptor);

        public Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum
        {            
            try
            {
                PublishLiterals<E>(out var dst);
                return dst;
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<FilePath>();
            }
        }

        static string DescribeLiteral<E>(E literal)
            where E : unmanaged, Enum
                => LiteralInfo.from(typeof(E).Field(literal.ToString()).Require()).Text;                            

        public LiteralRecord[] PublishLiterals<E>(out FilePath dst)
            where E : unmanaged, Enum
        {            
            dst = Publications.Archive.DatasetPath(typeof(E).Name);            
            var records = LiteralRecords<E>(typeof(E).Name, DescribeLiteral);
            using var writer = dst.Writer();
            writer.WriteLine(Tabular.HeaderText<E>());
            for(var i=0; i<records.Length; i++)
                writer.WriteLine(records[i].DelimitedText(FieldDelimiter));
            return records;
        }

        public LiteralRecord[] LiteralRecords<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum
        {
            var f = descriptor ?? (x => string.Empty);
            var literals = Enums.index<E>();
            var dst = new LiteralRecord[literals.Length];            
            var primal = typeof(E).GetEnumUnderlyingType();
            var flags = typeof(E).Tagged<FlagsAttribute>();
            var baseTag =typeof(E).Tag<NumericBaseAttribute>(); 
            var @base = baseTag.MapValueOrDefault(x => x.Base, NumericBaseKind.Base10);
            var bitmax = baseTag.MapValueOrDefault(x => x.MaxDigits, (int?)null);
            var hmax = bitmax != null ? bitmax.Value/4 : (int?)null;

            for(var i=0; i<dst.Length; i++)
            {
                var literal = literals[i];
                
                var description = f(literal.LiteralValue);
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.LiteralValue.ToString();

                var bs = @base == NumericBaseKind.Base2 ? MultiFormatter.Service.FormatEnum(literal.LiteralValue, n2, bitmax) : string.Empty;
                var hex = MultiFormatter.Service.FormatEnum(literal.LiteralValue, n16, hmax);
                dst[i] = new LiteralRecord(declarer, literal.Index, literal.Identifier, hex, bs, description);
            }

            return dst;
        }
    }
}