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

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiHexIndex
    {
        ApiPartAddresses Memories;

        ApiUriAddresses UriLocations;

        X86PartCodeIndex PartIndex;

        public readonly PartId[] Parts;

        [MethodImpl(Inline)]
        public ApiHexIndex(PartId[] parts, ApiPartAddresses members, ApiUriAddresses memuri, X86PartCodeIndex code)
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
        public X86HostIndex CodeSet(ApiHostUri id)
        {
            var y = PartIndex[id];
            var x = EncodedX86.index(id, y);
            return new X86HostIndex(id, x.Code);
        }

        [MethodImpl(Inline)]
        public ApiPartCodeIndex CodeSet(PartId id)
            => EncodedX86.index(id, Hosts.Map(CodeSet));

        public ApiCodeBlock this[MemoryAddress location]
        {
            [MethodImpl(Inline)]
            get => Code(location);
        }

        public X86HostIndex this[ApiHostUri id]
        {
            [MethodImpl(Inline)]
            get => CodeSet(id);
        }

        public ApiPartCodeIndex this[PartId id]
        {
            [MethodImpl(Inline)]
            get => CodeSet(id);
        }
    }
}