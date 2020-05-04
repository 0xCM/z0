//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static Seed;

    using F = ParseFailureField;
    using R = ParseFailureRecord;
    using Report = ParseFailureReport;

    public enum ParseFailureField : ulong
    {
        Sequence = 0 | 10ul << 32,

        Address = 1 | 16ul << 32,

        Length = 2 | 8ul << 32,

        TermCode = 3 | 20ul << 32,

        Uri = 4 | 110ul << 32,

        Data = 5 | 1ul << 32
    }

    public readonly struct ParseFailureRecord : ITabular<F,R>
    {
        public const int FieldCount = 6;

        public static R Empty => new R(0, MemoryAddress.Zero, 0, ExtractTermCode.None, OpUri.Empty, LocatedCode.Empty);

        public static R Parse(string src)
        {
            var fields = src.SplitClean(Report.DefaultDelimiter);
            if(fields.Length != FieldCount)
                return Empty;

            var parser = NumericParser.create<int>();
            var seq = parser.Parse(fields[0]).ValueOrDefault();            
            var address = MemoryAddress.Define(HexParsers.Numeric.Parse(fields[1]).ValueOrDefault());
            var len = parser.Parse(fields[2]).ValueOrDefault();            
            var term = Enums.parse<ExtractTermCode>(fields[3]).ValueOrDefault();
            var uri = OpUri.Parse(fields[4]).ValueOrDefault(OpUri.Empty);
            var data = fields[5].SplitClean(HexSpecs.DataDelimiter).Select(HexParsers.Bytes.ParseByte).ToArray();
            var extract = LocatedCode.Define(address,data);
            return new R(seq,address,len,term,uri,extract);
        }

        public ParseFailureRecord(int Sequence, MemoryAddress Address, int Length, ExtractTermCode TermCode, OpUri Uri, LocatedCode Data)
        {
            this.Sequence = Sequence;
            this.Address = Address;
            this.Length = Length; 
            this.Uri = Uri;
            this.TermCode = TermCode;
            this.Data = Data;
        }
        
        [TabularField(F.Sequence)]
        public readonly int Sequence;

        [TabularField(F.Address)]
        public readonly MemoryAddress Address;

        [TabularField(F.Length)]
        public readonly int Length;

        [TabularField(F.TermCode)]
        public readonly ExtractTermCode TermCode;

        [TabularField(F.Uri)]
        public readonly OpUri Uri;        

        [TabularField(F.Data)]
        public readonly LocatedCode Data;

        public string DelimitedText(char sep)
        {
            var dst = Model.Formatter.Reset().WithDelimiter(sep);
            dst.AppendField(F.Sequence, Sequence);
            dst.DelimitField(F.Address, Address);
            dst.DelimitField(F.Length, Length);
            dst.DelimitField(F.TermCode, TermCode);
            dst.DelimitField(F.Uri, Uri);
            dst.DelimitField(F.Data, Data);
            return dst.Format();            
        }

        static Report<F,R> Model => Report<F,R>.Empty;
    }

    public class ParseFailureReport : Report<Report,F,R>
    {        
        /// <summary>
        /// Loads a saved failure report
        /// </summary>
        /// <param name="src">The report path</param>
        public static ParseFailureReport Load(FilePath src)
        {
            var lines = src.ReadLines().Skip(1). Select(R.Parse).ToArray();
            if(lines.Length != 0)
                return new ParseFailureReport(lines[0].Uri.HostPath, lines);
            else
                return Empty;
        }        

        public ApiHostUri ApiHost {get;}

        public override string ReportName => $"ParseFailure report for {ApiHost.Format()}";

        public static Report Create(ApiHostUri host, ExtractParseFailure[] failures)
        {
            var records = new ParseFailureRecord[failures.Length];
            for(var i=0; i< failures.Length; i++)
            {
                var failure = failures[i];
                records[i] = new ParseFailureRecord(                
                    Sequence : failure.Sequence,
                    Address : failure.Data.Address,
                    Length : failure.Data.Encoded.Length,
                    TermCode: failure.TermCode,
                    Uri : failure.OpUri,
                    Data : failure.Data.Encoded
                    );
            }

            return new Report(host, records);
        }
        
        public ParseFailureReport(){}

        ParseFailureReport(ApiHostUri host, R[] records)
            : base(records)
        {
            this.ApiHost = host;
        }            
    }     
}