//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;

    using F = ApiExtractField;
    using R = ApiExtractBlock;

    public enum ApiExtractField : uint
    {
        Sequence = 0 | 10 << WidthOffset,

        Address = 1 | 16 << WidthOffset,

        Length = 2 | 8 << WidthOffset,

        Uri = 3 | 110 << WidthOffset,

        OpSig = 4 | 110 << WidthOffset,

        Data = 5 | 1 << WidthOffset
    }

    public readonly struct ApiExtractBlock : ITabular<F,R>
    {
        public readonly int Sequence;

        public readonly MemoryAddress Address;

        public readonly int Length;

        public readonly OpUri Uri;

        public readonly string OpSig;

        public readonly CodeBlock Data;

        const int FieldCount = 6;

        public static R Parse(string src)
        {
            var fields = src.SplitClean(FieldDelimiter);
            if(fields.Length != FieldCount)
                return Empty;

            var parser = Parsers.numeric<int>();
            var seq = parser.Parse(fields[0]).ValueOrDefault();
            var address = z.address(Parsers.hex().Parse(fields[1]).ValueOrDefault());
            var len = parser.Parse(fields[2]).ValueOrDefault();
            var uri = ApiUriParser.Service.Parse(fields[3]).ValueOrDefault(OpUri.Empty);
            var sig = fields[4];
            var data = fields[5].SplitClean(HexFormatSpecs.DataDelimiter).Select(Parsers.hex(true).Succeed).ToArray();
            var extract = new CodeBlock(address, data);
            return new R(seq, address, len, uri, sig, extract);
        }

        public ApiExtractBlock(int Sequence, MemoryAddress Address, int Length, OpUri Uri, string OpSig, CodeBlock Data)
        {
            this.Sequence = Sequence;
            this.Address = Address;
            this.Length = Length;
            this.Uri = Uri;
            this.OpSig = OpSig;
            this.Data = Data;
        }

        public string DelimitedText(char delimiter)
        {
            var dst = Table.formatter<F>(delimiter);
            dst.Delimit(F.Sequence, Sequence);
            dst.Delimit(F.Address, Address);
            dst.Delimit(F.Length, Length);
            dst.Delimit(F.Uri, Uri);
            dst.Delimit(F.OpSig, OpSig);
            dst.Delimit(F.Data, Data);
            return dst.Format();
        }

        public static R Empty
            => new R(0, MemoryAddress.Empty, 0, OpUri.Empty, EmptyString, CodeBlock.Empty);
    }
}