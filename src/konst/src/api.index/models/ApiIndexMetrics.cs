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
    /// Collects statistics of encoded data known to a <see cref='ApiCodeBlockIndex'/>
    /// </summary>
    public struct ApiIndexMetrics : ITextual
    {
        public uint PartCount;

        public uint HostCount;

        public uint AddressCount;

        public uint FunctionCount;

        public uint IdentityCount;

        public ByteSize ByteCount;

        public static ApiIndexMetrics from(ApiCodeBlockIndex src)
        {
            var stats = default(ApiIndexMetrics);
            stats.PartCount = (uint)src.Parts.Length;
            stats.HostCount = (uint)src.Hosts.Length;
            stats.AddressCount =(uint)src.Locations.Length;
            stats.FunctionCount = (uint)src.MemberCode.Length;
            stats.IdentityCount = (uint)src.Identities.Length;
            stats.ByteCount = src.MemberCode.Sum(x => x.Data.Length);
            return stats;
        }

        public string Format()
            => text.format("{0}", new {PartCount, HostCount, AddressCount, FunctionCount, IdentityCount, ByteCount});

        public override string ToString()
            => Format();
    }
}