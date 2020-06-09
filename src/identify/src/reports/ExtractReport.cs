//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static Seed;
    using static Tabular;

    using F = ExtractField;
    using R = ExtractRecord;
    using Report = ExtractReport;

    public enum ExtractField : int
    {
        Sequence = 0 | 10 << 16,

        Address = 1 | 16 << 16,

        Length = 2 | 8 << 16,

        Uri = 3 | 110 << 16,

        OpSig = 4 | 110 << 16,

        Data = 5 | 1 << 16
    }

    public readonly struct ExtractRecord : ITabular<F,R>
    {
        public const int FieldCount = 6;

        public static R Empty => new R(0, MemoryAddress.Empty, 0, OpUri.Empty, text.blank, LocatedCode.Empty);

        public static R Parse(string src)
        {
            var fields = src.SplitClean(Report.DefaultDelimiter);
            if(fields.Length != FieldCount)
                return Empty;

            var parser = NumericParser.create<int>();
            var seq = parser.Parse(fields[0]).ValueOrDefault();            
            var address = MemoryAddress.define(Parsers.hex().Parse(fields[1]).ValueOrDefault());
            var len = parser.Parse(fields[2]).ValueOrDefault();            
            var uri = OpUri.Parse(fields[3]).ValueOrDefault(OpUri.Empty);
            var sig = fields[4];
            var data = fields[5].SplitClean(HexSpecs.DataDelimiter).Select(Parsers.hex(true).Succeed).ToArray();
            var extract = LocatedCode.Define(address, data);
            return new R(seq, address, len, uri, sig, extract);
        }

        public ExtractRecord(int Sequence, MemoryAddress Address, int Length, OpUri Uri, string OpSig, LocatedCode Data)
        {
            this.Sequence = Sequence;
            this.Address = Address;
            this.Length = Length; 
            this.Uri = Uri;
            this.OpSig = OpSig;
            this.Data = Data;
        }
        
        [TabularField(F.Sequence)]
        public readonly int Sequence;

        [TabularField(F.Address)]
        public readonly MemoryAddress Address;

        [TabularField(F.Length)]
        public readonly int Length;

        [TabularField(F.Uri)]
        public readonly OpUri Uri;
        
        [TabularField(F.OpSig)]
        public readonly string OpSig;

        [TabularField(F.Data)]
        public readonly LocatedCode Data;

        public string DelimitedText(char sep)
        {
            var dst = formatter<F>();
            dst.AppendField(F.Sequence, Sequence);
            dst.DelimitField(F.Address, Address, sep);
            dst.DelimitField(F.Length, Length, sep);
            dst.DelimitField(F.Uri, Uri, sep);
            dst.DelimitField(F.OpSig, OpSig, sep);
            dst.DelimitField(F.Data, Data, sep);
            return dst.Format();            
        }
    }

    public class ExtractReport : Report<Report,F,R>
    {        
        /// <summary>
        /// Loads a saved extract report
        /// </summary>
        /// <param name="src">The report path</param>
        public static ExtractReport Load(FilePath src)
        {
            var lines = src.ReadLines().Skip(1). Select(R.Parse).ToArray();
            if(lines.Length != 0)
                return new ExtractReport(lines[0].Uri.Host, lines);
            else
                return Empty;
        }        

        public ApiHostUri ApiHost {get;}

        public override string ReportName => $"Extract report for {ApiHost.Format()}";

        public static Report Create(ApiHostUri host, ExtractedMember[] extracts)
        {
            var records = new ExtractRecord[extracts.Length];
            for(var i=0; i< extracts.Length; i++)
            {
                var op = extracts[i];
                records[i] = new ExtractRecord(                
                    Sequence : i,
                    Address : op.Member.Address,
                    Length : op.Encoded.Length,
                    Uri : op.Uri,
                    OpSig : op.Member.Method.Signature().Format(),
                    Data : op.Encoded
                    );
            }

            return new Report(host, records);
        }
        
        public ExtractReport(){}

        internal ExtractReport(ApiHostUri host, R[] records)
            : base(records)
        {
            this.ApiHost = host;
        }            
    }     
}