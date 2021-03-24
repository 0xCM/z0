//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ProcessImageRow : IRecord<ProcessImageRow>
    {
        public const string TableId = "process.images";

        public MemoryAddress BaseAddress;

        public MemoryAddress EndAddress;

        public ByteSize MemorySize;

        public ByteSize Gap;

        public Name ImageName;
    }
}