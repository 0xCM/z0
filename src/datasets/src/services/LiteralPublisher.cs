//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct LiteralPublisher : ILiteralPublisher
    {
        public static LiteralPublisher Service => default(LiteralPublisher);

        IPublicationArchive Archive => Publications.Archive;

        public Report<LiteralTableField,LiteralRecord> LiteralReport<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum
                => new Report<LiteralTableField, LiteralRecord>(LiteralRecords<E>(declarer, descriptor));

        public Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum
        {            
            var dst = Archive.DatasetPath(typeof(E).Name);            
            var report = LiteralReport<E>(typeof(E).Name, DescribeLiteral);   
            return Records.Writer.Save<LiteralTableField,LiteralRecord>(report.Records, dst);
        }

        static string DescribeLiteral<E>(E literal)
            where E : unmanaged, Enum
        {            
            var field = typeof(E).Field(literal.ToString()).Require();
            return LiteralAttribute.Describe(field);
        }

        public LiteralRecord[] PublishLiterals<E>(out FilePath dst)
            where E : unmanaged, Enum
        {            
            dst = Archive.DatasetPath(typeof(E).Name);            
            var report = LiteralReport<E>(typeof(E).Name, DescribeLiteral);            
            Records.Writer.Save<LiteralTableField,LiteralRecord>(report.Records, dst);
            return report.Records;
        }

        public LiteralRecord[] LiteralRecords<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum
        {
            var f = descriptor ?? (x => string.Empty);
            var literals = Enums.literals<E>();
            var dst = new LiteralRecord[literals.Length];            
            var primal = typeof(E).GetEnumUnderlyingType();
            var flags = typeof(E).Tagged<FlagsAttribute>();
            var baseTag =typeof(E).Tag<NumericBaseAttribute>(); 
            var @base = baseTag.MapValueOrDefault(x => x.Base, NumericBaseKind.D);
            var bitmax = baseTag.MapValueOrDefault(x => x.MaxDigits, (int?)null);
            var hmax = bitmax != null ? bitmax.Value/4 : (int?)null;

            for(var i=0; i<dst.Length; i++)
            {
                var literal = literals[i];
                
                var description = f(literal.LiteralValue);
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.LiteralValue.ToString();

                var bs = @base == NumericBaseKind.B ? MultiFormatter.Service.FormatEnum(literal.LiteralValue, n2, bitmax) : string.Empty;
                var hex = MultiFormatter.Service.FormatEnum(literal.LiteralValue, n16, hmax);
                dst[i] = new LiteralRecord(declarer, literal.Index, literal.Identifier, hex, bs, description);
            }

            return dst;
        }
    }
}