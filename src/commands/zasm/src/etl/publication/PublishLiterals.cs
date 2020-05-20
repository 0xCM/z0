//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm.Data;

    using static Seed;
    using static Memories;

    using F = LiteralTableField;
    using T = LiteralRecord;

    partial class AsmEtl
    {                
        public static Report<F,T> LiteralReport<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum
                => new Report<F,T>(LiteralRecords<E>(declarer, descriptor));

        public static LiteralRecord[] LiteralRecords<E>(string declarer, Func<E,string> descriptor = null)
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
                
                var description = f(literal.Value);
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.Value.ToString();

                var bs = @base == NumericBaseKind.B ? MultiFormatter.Service.FormatEnum(literal.Value, n2, bitmax) : string.Empty;
                var hex = MultiFormatter.Service.FormatEnum(literal.Value, n16, hmax);
                dst[i] = new LiteralRecord(declarer, literal.Index, literal.Name, hex, bs, description);
            }

            return dst;
        }

        static string DescribeLiteral<E>(E literal)
            where E : unmanaged, Enum
        {            
            var info = CommentAttribute.GetDocumentation(typeof(E).Field(literal.ToString()).Require());
            return info ?? string.Empty;
        }

        public Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum
        {            
            var dst = Config.DatasetPath(typeof(E).Name);            
            var report = LiteralReport<E>(typeof(E).Name, DescribeLiteral);            
            return Records.Save<F,T>(report.Records, dst);
        }
        
        public void PublishLiterals()
        {
            PublishLiterals<OpCodeOperandKind>().OnSome(OnPublished);
            PublishLiterals<CpuidFeature>().OnSome(OnPublished);
            PublishLiterals<EncoderFlags>().OnSome(OnPublished);
            PublishLiterals<EncodingKind>().OnSome(OnPublished);
            PublishLiterals<FlowControl>().OnSome(OnPublished);
            PublishLiterals<LegacyFlags>().OnSome(OnPublished);
            PublishLiterals<LegacyFlags3>().OnSome(OnPublished);
            PublishLiterals<LegacyOpCodeTable>().OnSome(OnPublished);
            PublishLiterals<LegacyOpKind>().OnSome(OnPublished);
            PublishLiterals<MandatoryPrefix>().OnSome(OnPublished);
            PublishLiterals<MemorySize>().OnSome(OnPublished);
            PublishLiterals<OpCodeFlags>().OnSome(OnPublished);
            PublishLiterals<OpCodeHandlerKind>().OnSome(OnPublished);
            PublishLiterals<RegisterFlags>().OnSome(OnPublished);
            PublishLiterals<RflagsBits>().OnSome(OnPublished);
        }

        void OnPublished(FilePath path)
        {
            term.print(path);
        }
    }
}