//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    /// <summary>
    /// Collects statistics of encoded data known to a <see cref='ApiCodeBlocks'/>
    /// </summary>
    public struct ApiIndexMetrics : ITextual
    {
        public uint PartCount;

        public uint HostCount;

        public uint AddressCount;

        public uint FunctionCount;

        public uint IdentityCount;

        public ByteSize ByteCount;

        public static ApiIndexMetrics from(ApiCodeBlocks src)
        {
            var stats = default(ApiIndexMetrics);
            stats.PartCount = src.Parts.Count;
            stats.HostCount = src.Hosts.Count;
            stats.AddressCount = src.Addresses.Count;
            stats.FunctionCount = src.Blocks.Count;
            stats.IdentityCount = src.Identities.Count;
            stats.ByteCount = src.Blocks.Storage.Sum(x => x.Length);
            return stats;
        }

        public string Format()
            => text.format("{0}", new {PartCount, HostCount, AddressCount, FunctionCount, IdentityCount, ByteCount});

        public override string ToString()
            => Format();
    }
}