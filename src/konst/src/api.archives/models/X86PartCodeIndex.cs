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

    using KVP = System.Collections.Generic.Dictionary<ApiHostUri, X86HostCode>;

    public readonly struct X86PartCodeIndex
    {
        public readonly PartId[] Parts;

        readonly KVP Data;

        [MethodImpl(Inline)]
        public X86PartCodeIndex(PartId[] parts, KVP src)
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

        public TableSpan<ApiHex> this[ApiHostUri src]
        {
            [MethodImpl(Inline)]
            get => Data[src].Code;
        }
    }
}