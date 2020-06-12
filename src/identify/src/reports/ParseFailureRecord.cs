//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using F = ParseFailureField;
    using R = ParseFailureRecord;

    public enum ParseFailureField : uint
    {
        Sequence = 0 | 10u << 32,

        Address = 1 | 16u << 32,

        Length = 2 | 8u << 32,

        TermCode = 3 | 20u << 32,

        Uri = 4 | 110u << 32,

        Data = 5 | 1u << 32
    }

    public readonly struct ParseFailureRecord : ITabular<F,R>
    {
        public const int FieldCount = 6;

        public static R Empty => new R(0, MemoryAddress.Empty, 0, ExtractTermCode.None, OpUri.Empty, LocatedCode.Empty);

        public static R Parse(string src)
        {
            var fields = src.SplitClean(Tabular.DefaultDelimiter);
            if(fields.Length != FieldCount)
                return Empty;

            var parser = NumericParser.create<int>();
            var seq = parser.Parse(fields[0]).ValueOrDefault();            
            var address = Addresses.address(Parsers.hex().Parse(fields[1]).ValueOrDefault());
            var len = parser.Parse(fields[2]).ValueOrDefault();            
            var term = Enums.Parse<ExtractTermCode>(fields[3]).ValueOrDefault();
            var uri = OpUri.Parse(fields[4]).ValueOrDefault(OpUri.Empty);
            var data = fields[5].SplitClean(HexSpecs.DataDelimiter).Select(Parsers.hex(true).Succeed).ToArray();
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

        public string DelimitedText(char delimiter)
        {
            var dst = Tabular.formatter<F>(delimiter);
            dst.Append(F.Sequence, Sequence);
            dst.Delimit(F.Address, Address);
            dst.Delimit(F.Length, Length);
            dst.Delimit(F.TermCode, TermCode);
            dst.Delimit(F.Uri, Uri);
            dst.Delimit(F.Data, Data);
            return dst.Format();            
        }
    }
}