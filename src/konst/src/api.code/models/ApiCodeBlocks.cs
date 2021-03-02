//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    public class ApiCodeBlocks
    {
        PartCodeAddresses CodeAddresses;

        PartUriAddresses UriLocations;

        PartCodeIndex PartIndex;

        UriCode UriCode;

        [MethodImpl(Inline)]
        public ApiCodeBlocks(PartCodeAddresses memories, PartUriAddresses memuri, PartCodeIndex parts, UriCode code)
        {
            CodeAddresses = memories;
            UriLocations = memuri;
            PartIndex = parts;
            UriCode = code;
        }

        public ApiIndexMetrics CalcMetrics()
        {
            var stats = default(ApiIndexMetrics);
            stats.PartCount = Parts.Count;
            stats.HostCount = Hosts.Count;
            stats.AddressCount = Addresses.Count;
            stats.FunctionCount = Blocks.Count;
            stats.IdentityCount = Identities.Count;
            stats.ByteCount = Blocks.Storage.Sum(x => x.Length);
            return stats;
        }

        public Index<PartId> Parts
            => CodeAddresses.Parts;

        /// <summary>
        /// The number of indexed functions
        /// </summary>
        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => CodeAddresses.Count;
        }

        /// <summary>
        /// The base addresses that identify entries in the index
        /// </summary>
        public Index<MemoryAddress> Addresses
        {
            [MethodImpl(Inline)]
            get => CodeAddresses.Addresses;
        }

        /// <summary>
        /// All indexed code
        /// </summary>
        public Index<ApiCodeBlock> Blocks
        {
            [MethodImpl(Inline)]
            get => CodeAddresses.Code;
        }

        /// <summary>
        /// Operation identifiers, each of which are associated with one or more code blocks
        /// </summary>
        public Index<OpUri> Identities
        {
            [MethodImpl(Inline)]
            get => UriLocations.Identities;
        }

        /// <summary>
        /// Hosts with at least one archived code block
        /// </summary>
        public Index<ApiHostUri> Hosts
        {
            [MethodImpl(Inline)]
            get => PartIndex.Hosts;
        }

        /// <summary>
        /// Hosts with at least one archived code block
        /// </summary>
        public Index<ApiHostUri> NonemptyHosts
        {
            [MethodImpl(Inline)]
            get => PartIndex.Hosts.Where(h => h.IsNonEmpty);
        }

        [MethodImpl(Inline)]
        public ApiCodeBlock Code(MemoryAddress location)
            => CodeAddresses[location];

        [MethodImpl(Inline)]
        public bool Code(OpUri uri, out ApiCodeBlock dst)
        {
            return UriCode.TryGetValue(uri, out dst);
        }

        [MethodImpl(Inline)]
        public ApiHostCode HostCodeBlocks(ApiHostUri host)
        {
            if(PartIndex.HostCode(host, out var code))
                return code;
            else
                return ApiHostCode.Empty;
        }

        [MethodImpl(Inline)]
        public ApiPartCode PartCodeBlocks(PartId id)
            => ApiCode.combine(id, Hosts.Map(HostCodeBlocks));

        public ApiCodeBlock this[MemoryAddress location]
        {
            [MethodImpl(Inline)]
            get => Code(location);
        }

        public ApiHostCode this[ApiHostUri id]
        {
            [MethodImpl(Inline)]
            get => HostCodeBlocks(id);
        }

        public ApiPartCode this[PartId id]
        {
            [MethodImpl(Inline)]
            get => PartCodeBlocks(id);
        }

        public static ApiCodeBlocks Empty
        {
            [MethodImpl(Inline)]
            get => new ApiCodeBlocks(PartCodeAddresses.Empty, PartUriAddresses.Empty, PartCodeIndex.Empty, UriCode.Empty);
        }
    }
}