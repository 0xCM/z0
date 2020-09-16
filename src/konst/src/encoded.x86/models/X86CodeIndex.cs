//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct X86CodeIndex
    {
        X86MemoryIndex Memories;

        X86UriAddresses UriLocations;

        X86PartCodeIndex PartIndex;

        public readonly PartId[] Parts;

        public X86CodeIndex(PartId[] parts, X86MemoryIndex members, X86UriAddresses memuri, X86PartCodeIndex code)
        {
            Parts = parts;
            Memories = members;
            UriLocations = memuri;
            PartIndex = code;
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
            get => PartIndex.Hosts;
        }

        [MethodImpl(Inline)]
        public X86ApiCode Code(MemoryAddress location)
            => Memories[location];

        [MethodImpl(Inline)]
        public X86HostIndex CodeSet(ApiHostUri id)
            => EncodedX86.index(id, PartIndex[id]);

        [MethodImpl(Inline)]
        public X86PartHosts CodeSet(PartId id)
            => EncodedX86.index(id, Hosts.Map(CodeSet));

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