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

    public readonly struct PartCodeIndexEntry
    {
        public ApiHostUri Host {get;}

        public ApiHostCodeBlocks Code {get;}

        [MethodImpl(Inline)]
        public PartCodeIndexEntry(ApiHostUri host, in ApiHostCodeBlocks code)
        {
            Host = host;
            Code = code;
        }

    }

    public readonly struct PartCodeIndex
    {
        public static PartCodeIndexEntry[] entries(in PartCodeIndex src)
        {
            var buffer = list<PartCodeIndexEntry>(src.Data.Count);
            foreach(var item in src.Data)
                buffer.Add(new PartCodeIndexEntry(item.Key, item.Value));
            return buffer.ToArray();
        }

        public readonly PartId[] Parts;

        readonly Dictionary<ApiHostUri, ApiHostCodeBlocks> Data;

        [MethodImpl(Inline)]
        public PartCodeIndex(PartId[] parts, Dictionary<ApiHostUri, ApiHostCodeBlocks> src)
        {
            Parts = parts;
            Data = src;
        }

        public PartCodeIndexEntry[] Entries
        {
            get => entries(this);
        }

        public bool HostCode(ApiHostUri host, out ApiHostCodeBlocks code)
        {
            if(Data.TryGetValue(host, out code))
                return true;
            else
            {
                code = default;
                return false;
            }
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