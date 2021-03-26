//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ImageContent : IRecord<ImageContent>
    {
        public const string TableId = "image.content";

        public const byte RowDataSize = 64;

        public MemoryAddress Address;

        public BinaryCode Data;
    }
}