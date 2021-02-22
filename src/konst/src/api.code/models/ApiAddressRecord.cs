//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ApiAddressRecord : IRecord<ApiAddressRecord>
    {
        public const string TableId = "api.address";

        public uint Sequence;

        public MemoryAddress ProcessBase;

        public MemoryAddress MemberBase;

        public MemoryAddress MemberOffset;

        public MemoryAddress MemberRebase;

        public ByteSize MaxSize;

        public Name PartName;

        public Name HostName;

        public OpIdentity Identifier;
    }
}