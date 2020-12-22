//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using F = ApiHexField;
    using R = ApiHexRow;

    public enum ApiHexField : uint
    {
        Seq = 0 | 12 << 16,

        SourceSeq = 1 | 12 << 16,

        Address = 2 | 16 << 16,

        Length = 3 | 8 << 16,

        TermCode = 4 | 20 << 16,

        Uri = 5 | 110 << 16,

        OpSig = 6 | 110 << 16,

        Data = 7 | 1 << 16
    }

    public struct ApiHexRow
    {
        public const int FieldCount = 8;

        public int Seq;

        public int SourceSeq;

        public MemoryAddress Address;

        public int Length;

        public ExtractTermCode TermCode;

        public OpUri Uri;

        public CliSig ApiSig;

        public CodeBlock Data;

        public string DelimitedText(char delimiter = Chars.Pipe)
        {
            var dst = Table.formatter<F>(delimiter);
            dst.Delimit(F.Seq, Seq);
            dst.Delimit(F.SourceSeq, SourceSeq);
            dst.Delimit(F.Address, Address);
            dst.Delimit(F.Length, Length);
            dst.Delimit(F.TermCode, TermCode);
            dst.Delimit(F.Uri, Uri);
            dst.Delimit(F.OpSig, ApiSig.Format());
            dst.Delimit(F.Data, Data.Format());
            return dst.Format();
        }
    }
}