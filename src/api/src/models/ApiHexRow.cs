//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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
    }
}