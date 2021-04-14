//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    [Record(TableId)]
    public struct BinaryResRow : IRecord<BinaryResRow>
    {
        public const string TableId = "binary.res";

        public Address16 Offset;

        public MemoryAddress Address;

        public ByteSize Size;

        public string Uri;

        public BinaryCode Data;
    }
}