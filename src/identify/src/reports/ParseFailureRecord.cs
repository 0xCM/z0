//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;

    using F = ParseFailureField;
    using R = ParseFailureRecord;

    public enum ParseFailureField : uint
    {
        Sequence = 0 | 10u << WidthOffset,

        Address = 1 | 16u << WidthOffset,

        Length = 2 | 8u << WidthOffset,

        TermCode = 3 | 20u << WidthOffset,

        Uri = 4 | 110u << WidthOffset,

        Data = 5 | 1u << WidthOffset
    }

    public readonly struct ParseFailureRecord : ITabular<F,R>
    {
        public readonly int Sequence;

        public readonly MemoryAddress Address;

        public readonly int Length;

        public readonly ExtractTermCode TermCode;

        public readonly OpUri Uri;

        public readonly X86Code Data;

        public const int FieldCount = 6;

        public static R Parse(string src)
        {
            var fields = src.SplitClean(FieldDelimiter);
            if(fields.Length != FieldCount)
                return Empty;

            var parser = Parsers.numeric<int>();
            var seq = parser.Parse(fields[0]).ValueOrDefault();
            var address = z.address(Parsers.hex().Parse(fields[1]).ValueOrDefault());
            var len = parser.Parse(fields[2]).ValueOrDefault();
            var term = Enums.Parse<ExtractTermCode>(fields[3]).ValueOrDefault();
            var uri = OpUriParser.Service.Parse(fields[4]);
            if(uri.Failed)
                sys.@throw($"{uri.Reason}");

            var data = fields[5].SplitClean(HexFormatSpecs.DataDelimiter).Select(Parsers.hex(true).Succeed);
            var extract = new X86Code(address, data);
            return new R(seq, address, len, term, uri.Value, extract);
        }

        public ParseFailureRecord(int Sequence, MemoryAddress Address, int Length, ExtractTermCode TermCode, OpUri Uri, X86Code Data)
        {
            this.Sequence = Sequence;
            this.Address = Address;
            this.Length = Length;
            this.Uri = Uri;
            this.TermCode = TermCode;
            this.Data = Data;
        }

        public string DelimitedText(char delimiter)
        {
            var dst = TableFormat.formatter<F>(delimiter);
            dst.Delimit(F.Sequence, Sequence);
            dst.Delimit(F.Address, Address);
            dst.Delimit(F.Length, Length);
            dst.Delimit(F.TermCode, TermCode);
            dst.Delimit(F.Uri, Uri);
            dst.Delimit(F.Data, Data);
            return dst.Format();
        }

        public static R Empty
            => new R(0, MemoryAddress.Empty, 0, ExtractTermCode.None, OpUri.Empty, X86Code.Empty);
    }
}