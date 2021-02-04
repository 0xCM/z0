//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Collects statistics of encoded data known to a <see cref='ApiCodeBlocks'/>
    /// </summary>
    [Record]
    public struct ApiIndexMetrics : ITextual, IRecord<ApiIndexMetrics>
    {
        public const string TableId = "api.index.metrics";

        public uint PartCount;

        public uint HostCount;

        public uint AddressCount;

        public uint FunctionCount;

        public uint IdentityCount;

        public ByteSize ByteCount;
        public string Format()
            => text.format("{0}", new {PartCount, HostCount, AddressCount, FunctionCount, IdentityCount, ByteCount});

        public override string ToString()
            => Format();
    }
}