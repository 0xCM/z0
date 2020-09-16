//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Collects statistics of encoded data known to a <see cref='X86CodeIndex'/>
    /// </summary>
    public struct X86IndexMetrics
    {
        public uint PartCount;

        public uint HostCount;

        public uint AddressCount;

        public uint FunctionCount;

        public uint IdentityCount;

        public ByteSize ByteCount;

        public string Format()
            => text.format("{0}", new {PartCount, HostCount, AddressCount, FunctionCount, IdentityCount, ByteCount});

        public static X86IndexMetrics from(X86CodeIndex src)
        {
            var stats = default(X86IndexMetrics);
            stats.PartCount = (uint)src.Parts.Length;
            stats.HostCount = (uint)src.Hosts.Length;
            stats.AddressCount =(uint)src.Locations.Length;
            stats.FunctionCount = (uint)src.MemberCode.Length;
            stats.IdentityCount = (uint)src.Identities.Length;
            stats.ByteCount = src.MemberCode.Sum(x => x.Data.Length);
            return stats;
        }
    }
}