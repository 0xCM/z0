//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    using KVP = System.Collections.Generic.Dictionary<ApiHostUri, EncodedHost>;

    public readonly struct EncodedHost
    {
        public readonly ApiHostUri Host;

        public readonly TableSpan<X86ApiCode> Code;

        [MethodImpl(Inline)]
        public EncodedHost(ApiHostUri host, X86ApiCode[] code)
        {
            Host = host;
            Code = code;
        }
    }

    public readonly struct HostedCodeIndex
    {
        public readonly PartId[] Parts;

        readonly KVP Data;

        [MethodImpl(Inline)]
        internal HostedCodeIndex(PartId[] parts, KVP src)
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

        public TableSpan<X86ApiCode> this[ApiHostUri src]
        {
            [MethodImpl(Inline)]
            get => Data[src].Code;
        }

        public IEnumerable<X86ApiCode> Code
        {
            get
            {
                foreach(var k in Data.Keys)
                {
                    foreach(var c in Data[k].Code.Storage)
                    {
                        yield return c;
                    }
                }
            }
        }
    }
}