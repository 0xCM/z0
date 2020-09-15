//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct GlobalCodeIndex
    {
        EncodedMemoryIndex Memories;

        OpUriAddresses UriLocations;

        X86PartCodeIndex CodeIndex;

        public readonly PartId[] Parts;

        public GlobalCodeIndex(PartId[] parts, EncodedMemoryIndex members, OpUriAddresses memuri, X86PartCodeIndex code)
        {
            Parts = parts;
            Memories = members;
            UriLocations = memuri;
            CodeIndex = code;
        }

        /// <summary>
        /// The number of indexed functions
        /// </summary>
        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => Memories.Count;
        }

        /// <summary>
        /// The base addresses that identify entries in the index
        /// </summary>
        public MemoryAddress[] Locations
        {
            [MethodImpl(Inline)]
            get => Memories.Locations;
        }

        /// <summary>
        /// All indexed code
        /// </summary>
        public X86ApiCode[] MemberCode
        {
            [MethodImpl(Inline)]
            get => Memories.Encoded;
        }

        /// <summary>
        /// Operation identifiers, each of which are associated with one or more code blocks
        /// </summary>
        public OpUri[] Identities
        {
            [MethodImpl(Inline)]
            get => UriLocations.Identities;
        }

        /// <summary>
        /// Hosts with at least one archived code block
        /// </summary>
        public ApiHostUri[] Hosts
        {
            [MethodImpl(Inline)]
            get => CodeIndex.Hosts;
        }

        [MethodImpl(Inline)]
        public X86ApiCode Code(MemoryAddress location)
            => Memories[location];

        [MethodImpl(Inline)]
        public X86HostIndex CodeSet(ApiHostUri id)
            => Encoded.index(id, CodeIndex[id]);

        [MethodImpl(Inline)]
        public X86PartHosts CodeSet(PartId id)
            => Encoded.index(id, Hosts.Map(CodeSet));

        public X86ApiCode this[MemoryAddress location]
        {
            [MethodImpl(Inline)]
            get => Code(location);
        }

        public X86HostIndex this[ApiHostUri id]
        {
            [MethodImpl(Inline)]
            get => CodeSet(id);
        }

        public X86PartHosts this[PartId id]
        {
            [MethodImpl(Inline)]
            get => CodeSet(id);
        }
    }
}