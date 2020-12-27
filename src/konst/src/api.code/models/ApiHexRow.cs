//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using F = ApiHexField;
    using W = ApiHexFieldWidth;
    using I = ApiHexFieldIndex;

    public enum ApiHexField : uint
    {
        Seq = 0 | 12 << 16,

        SourceSeq = 1 | 12 << 16,

        Address = 2 | 16 << 16,

        Length = 3 | 8 << 16,

        TermCode = 4 | 20 << 16,

        Uri = 5 | 110 << 16,

        Data = 7 | 1 << 16
    }

    public enum ApiHexFieldIndex : byte
    {
        Seq = 0,

        SourceSeq = 1,

        Address = 2,

        Length = 3,

        TermCode = 4,

        Uri = 5,

        Data = 6
    }

    public enum ApiHexFieldWidth : byte
    {
        Seq = 12,

        SourceSeq = 12,

        Address = 16,

        Length = 8,

        TermCode = 20,

        Uri = 110,

        Data = 110
    }

    [Record(TableId)]
    public struct ApiHexRow : IRecord<ApiHexRow>
    {
        public const string TableId = "api.hex";

        public int Seq;

        public int SourceSeq;

        public MemoryAddress Address;

        public int Length;

        public ExtractTermCode TermCode;

        public OpUri Uri;

        public BinaryCode Data;
    }

    public readonly struct ApiHexRowSpec
    {
        public const byte FieldCount = 7;

        ReadOnlySpan<ApiHexFieldWidth> _Widths
            => new ApiHexFieldWidth[FieldCount]{W.Seq, W.SourceSeq, W.Address, W.Length, W.TermCode, W.Uri, W.Data};

        public ReadOnlySpan<byte> Widths
            => _Widths.AsUInt8();
    }
}