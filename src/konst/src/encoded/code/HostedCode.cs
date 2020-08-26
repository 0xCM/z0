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

    using KVP = System.Collections.Generic.Dictionary<ApiHostUri,MemberCode[]>;

    public readonly struct HostedCode
    {        
        public readonly PartId[] Parts;

        readonly KVP Data;

        [MethodImpl(Inline)]
        internal HostedCode(PartId[] parts, KVP src)
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

        public MemberCode[] this[ApiHostUri src]
        {
            [MethodImpl(Inline)]
            get => Data[src];
        }

        public IEnumerable<MemberCode> Code
        {
            get
            {
                foreach(var k in Data.Keys)
                {
                    foreach(var c in Data[k])
                    {
                        yield return c;
                    }
                }
            }            
        }
        
        public static HostedCode Empty 
            => new HostedCode(sys.empty<PartId>(), new KVP());        
    }    
}