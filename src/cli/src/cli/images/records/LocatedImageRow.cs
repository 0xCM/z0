//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct LocatedImageRow : IRecord<LocatedImageRow>
    {
        public const string TableId = "images.located";

        public MemoryAddress BaseAddress;

        public MemoryAddress EndAddress;

        public ByteSize MemorySize;

        public PartId PartId;

        public ByteSize Gap;

        public Name ImageName;
    }
}