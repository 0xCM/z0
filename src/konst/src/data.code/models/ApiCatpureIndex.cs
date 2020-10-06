//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static ApiCaptureIndexParts;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCaptureIndex
    {
        PartAddresses Memories;

        UriAddresses UriLocations;

        PartCode PartIndex;

        public readonly PartId[] Parts;

        [MethodImpl(Inline)]
        public ApiCaptureIndex(PartId[] parts, PartAddresses members, UriAddresses memuri, PartCode code)
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
        public ApiCodeBlock[] MemberCode
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
        public ApiCodeBlock Code(MemoryAddress location)
            => Memories[location];

        [MethodImpl(Inline)]
        public ApiHostCodeIndex HostCodeIndex(ApiHostUri host)
            => Archives.index(host, PartIndex[host]);

        [MethodImpl(Inline)]
        public ApiHostCodeBlocks HostCodeBlocks(ApiHostUri host)
            => new ApiHostCodeBlocks(host, HostCodeIndex(host).Code);

        [MethodImpl(Inline)]
        public ApiPartCodeBlocks PartCodeBlocks(PartId id)
            => ApiHexArchives.combine(id, Hosts.Map(HostCodeBlocks));

        public ApiCodeBlock this[MemoryAddress location]
        {
            [MethodImpl(Inline)]
            get => Code(location);
        }

        public ApiHostCodeBlocks this[ApiHostUri id]
        {
            [MethodImpl(Inline)]
            get => HostCodeBlocks(id);
        }

        public ApiPartCodeBlocks this[PartId id]
        {
            [MethodImpl(Inline)]
            get => PartCodeBlocks(id);
        }
    }
}