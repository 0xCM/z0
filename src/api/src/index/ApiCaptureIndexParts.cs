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

    using PC = System.Collections.Generic.Dictionary<ApiHostUri, ApiCodeBlocks>;

    public sealed class ApiHostCodeLookup : Dictionary<ApiHostUri, ApiCodeBlocks>
    {

    }

    public readonly struct PartCodeIndex
    {
        public readonly PartId[] Parts;

        readonly PC Data;

        [MethodImpl(Inline)]
        public PartCodeIndex(PartId[] parts, PC src)
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


    public readonly struct ApiCaptureIndexParts
    {
        public readonly struct UriAddresses
        {
            public readonly PartId[] Parts;

            readonly Dictionary<MemoryAddress, OpUri> Data;

            [MethodImpl(Inline)]
            public UriAddresses(PartId[] parts, Dictionary<MemoryAddress, OpUri> src)
            {
                Parts = parts;
                Data = src;
            }

            public OpUri[] Identities
            {
                [MethodImpl(Inline)]
                get => Data.Values.Array();
            }

            public MemoryAddress[] Addresses
            {
                [MethodImpl(Inline)]
                get => Data.Keys.Array();
            }

            public uint Count
            {
                [MethodImpl(Inline)]
                get => (uint)Data.Count;
            }
        }
    }
}