//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    using HC = KeyValuePairs<MemoryAddress,ApiCodeBlock>;
    using PC = System.Collections.Generic.Dictionary<ApiHostUri, ApiCaptureIndexParts.CodeBlocks>;

    public readonly struct ApiCaptureIndexParts
    {
        public struct CaptureIndexStatus : ITextual
        {
            public PartId[] Parts;

            public ApiHostUri[] Hosts;

            public MemoryAddress[] Addresses;

            public Count MemberCount;

            public PartAddresses Encoded;

            [MethodImpl(Inline)]
            public string Format()
                => text.format(RP.PSx5, Parts.Length, Hosts.Length, MemberCount, Addresses.Length, Encoded.Count);

            public override string ToString()
                => Format();
        }

        public readonly struct UriAddresses
        {
            public readonly PartId[] Parts;

            readonly KeyValuePairs<MemoryAddress, OpUri> Data;

            [MethodImpl(Inline)]
            public UriAddresses(PartId[] parts, KeyValuePairs<MemoryAddress, OpUri> src)
            {
                Parts = parts;
                Data = src;
            }

            public OpUri[] Identities
            {
                [MethodImpl(Inline)]
                get => Data.Values;
            }

            public MemoryAddress[] Addresses
            {
                [MethodImpl(Inline)]
                get => Data.Keys;
            }

            public uint Count
            {
                [MethodImpl(Inline)]
                get => (uint)Data.Count;
            }
        }

        public readonly struct PartCode
        {
            public readonly PartId[] Parts;

            readonly PC Data;

            [MethodImpl(Inline)]
            public PartCode(PartId[] parts, PC src)
            {
                Parts = parts;
                Data = src;
            }

            public int HostCount
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }

            public ApiHostUri[] Hosts
            {
                [MethodImpl(Inline)]
                get => Data.Keys.ToArray();
            }

            public TableSpan<ApiCodeBlock> this[ApiHostUri src]
            {
                [MethodImpl(Inline)]
                get => Data[src].Code;
            }
        }

        public readonly struct CodeBlocks
        {
            public readonly ApiHostUri Host;

            public readonly TableSpan<ApiCodeBlock> Code;

            [MethodImpl(Inline)]
            public CodeBlocks(ApiHostUri host, ApiCodeBlock[] code)
            {
                Host = host;
                Code = code;
            }
        }

        public readonly struct PartAddresses
        {
            public readonly PartId[] Parts;

            readonly HC Data;

            [MethodImpl(Inline)]
            public PartAddresses(PartId[] parts, HC src)
            {
                Data = src;
                Parts = parts;
            }

            public MemoryAddress[] Locations
            {
                [MethodImpl(Inline)]
                get => Data.Keys;
            }

            public ApiCodeBlock[] Encoded
            {
                [MethodImpl(Inline)]
                get => Data.Values;
            }

            public uint Count
            {
                [MethodImpl(Inline)]
                get => (uint)Data.Count;
            }

            public ApiCodeBlock this[MemoryAddress src]
            {
                [MethodImpl(Inline)]
                get => Data[src];
            }
        }
    }
}