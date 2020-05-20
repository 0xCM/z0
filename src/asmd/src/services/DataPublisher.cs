//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;   
    using static Memories;
    using F = LiteralTableField;
    using T = LiteralRecord;

    using RW = AsmFieldWidths;

    public readonly struct DataPublisher : IDataPublisher, IAsmArchiveConfig
    {
        public static DataPublisher Service => default(DataPublisher);
        
        IAsmArchiveConfig Config => this;        

        const int SeqPad = 8;
        
        const string SpacePipe = " | ";

        public string DescribeLiteral<E>(E literal)
            where E : unmanaged, Enum
        {            
            var info = CommentAttribute.GetDocumentation(typeof(E).Field(literal.ToString()).Require());
            return info ?? string.Empty;
        }

        public Report<F,T> LiteralReport<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum
                => new Report<F,T>(LiteralRecords<E>(declarer, descriptor));

        public Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum
        {            
            var dst = Config.DatasetPath(typeof(E).Name);            
            var report = LiteralReport<E>(typeof(E).Name, DescribeLiteral);            
            return AsmRecords.Save<F,T>(report.Records, dst);
        }

        public LiteralRecord[] PublishLiterals<E>(out FilePath dst)
            where E : unmanaged, Enum
        {            
            dst = Config.DatasetPath(typeof(E).Name);            
            var report = LiteralReport<E>(typeof(E).Name, DescribeLiteral);            
            AsmRecords.Save<F,T>(report.Records, dst);
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
                
                var description = f(literal.Value);
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.Value.ToString();

                var bs = @base == NumericBaseKind.B ? MultiFormatter.Service.FormatEnum(literal.Value, n2, bitmax) : string.Empty;
                var hex = MultiFormatter.Service.FormatEnum(literal.Value, n16, hmax);
                dst[i] = new LiteralRecord(declarer, literal.Index, literal.Name, hex, bs, description);
            }

            return dst;
        }

        public void PublishList<E>(Dictionary<string,E> src, string name)
            where E : unmanaged, Enum
        {
            var dst = Config.DatasetPath(name);            
            var header = text.concat("Seq". PadRight(SeqPad), SpacePipe,  typeof(E).Name);
            
            using var writer = dst.Writer();
            writer.WriteLine(header);
        
            var keys = src.Keys.ToArray();
            Array.Sort(keys);
            for(var i=0; i<keys.Length; i++)
                writer.WriteLine(FormatSequential(i, src[keys[i]]));
        }

        public void PublishList<E>()
            where E : unmanaged, Enum
        {
            var name = typeof(E).Name;
            var dst = Config.DatasetPath(name);
            var header = text.concat("Sequence". PadRight((int)RW.Sequence), SpacePipe, typeof(E).Name);
            var literals = Enums.literals<E>();

            using var writer = dst.Writer();
            writer.WriteLine(header);

            for(var i=0; i<literals.Length; i++)
            {
                var literal = literals[i];
                writer.WriteLine(FormatSequential(literal.Index, literal.Value));
            }
        }

        public void Save<M,F,R>(M model, F rep, R[] src, char delimiter)
            where M : IAsmDataModel
            where R : IRecord
            where F : unmanaged, Enum
        {
            var dst = Config.DatasetPath(model.Name);
            var header = AsmRecords.Header<F>(delimiter);
            using var writer = dst.Writer();
            writer.WriteLine(header);
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(src[i].DelimitedText(delimiter));                
        }

        string FormatSequential<E>(int seq, E value)
            => text.concat(seq.ToString().PadRight((int)RW.Sequence), SpacePipe, value.ToString());
    }
}