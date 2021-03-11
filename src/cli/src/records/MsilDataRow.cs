//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct MsilDataRow : IRecord<MsilDataRow>
    {
        public const string TableId = "cil.data";

        public ClrToken MemberId;

        public MemoryAddress BaseAddress;

        public OpUri Uri;

        public BinaryCode Encoded;
    }
}