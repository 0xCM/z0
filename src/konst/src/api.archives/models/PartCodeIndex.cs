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

    public readonly struct PartCodeIndex
    {
        public readonly PartId[] Parts;

        readonly Dictionary<ApiHostUri, ApiHostCodeBlocks> Data;

        [MethodImpl(Inline)]
        public PartCodeIndex(PartId[] parts, Dictionary<ApiHostUri, ApiHostCodeBlocks> src)
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
}