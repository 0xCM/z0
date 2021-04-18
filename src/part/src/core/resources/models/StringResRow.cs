//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct StringResRow : IRecord<StringResRow>
    {
        public const string TableId = "stringres";

        public ClrToken Id;

        public MemoryAddress Address;

        public uint Length;
    }
}