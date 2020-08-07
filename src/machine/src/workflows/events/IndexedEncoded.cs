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
    using static Flow;

    public struct EncodedIndexStats
    {
        public uint PartCount;

        public uint HostCount;

        public uint AddressCount;
        
        public uint FunctionCount;

        public uint IdentityCount;

        public ByteSize ByteCount;

        public string Format()
            => text.format(Slot0, new {PartCount, HostCount, AddressCount, FunctionCount, IdentityCount, ByteCount});
        
        public static EncodedIndexStats from(EncodedParts src)
        {
            var stats = default(EncodedIndexStats);
            stats.PartCount = (uint)src.Parts.Length;
            stats.HostCount = (uint)src.Hosts.Length;
            stats.AddressCount =(uint)src.Locations.Length;
            stats.FunctionCount = (uint)src.MemberCode.Length;
            stats.IdentityCount = (uint)src.Identities.Length;
            stats.ByteCount = src.MemberCode.Sum(x => x.Data.Length);
            return stats;

        }
    }

    public readonly struct IndexedEncoded : IWfEvent<IndexedEncoded>
    {
        public const string EventName = nameof(IndexedEncoded);
                
        public WfEventId EventId {get;}

        public string ActorName {get;}

        public readonly EncodedParts Index;
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;                                 

        [MethodImpl(Inline)]
        public IndexedEncoded(string worker, EncodedParts index, CorrelationToken ct)
        {
            EventId = wfid(EventName, ct);
            Index = index;
            ActorName = worker;
        }
        
        [MethodImpl(Inline)]        
        public string Format()
            => text.format(SSx3, EventId, ActorName, EncodedIndexStats.from(Index).Format());               
    }        
}