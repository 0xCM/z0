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

        public MemoryAddress Address;

        public Name PartName;

        public Name HostName;

        public Name Identifier;

        public CliSig Signature;
    }
}