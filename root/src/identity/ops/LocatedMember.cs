//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
        
    /// <summary>
    /// Identifies a member that defines an operation and its location in memory
    /// </summary>
    public readonly struct LocatedMember : IAddressable
    {
        public readonly ApiHostUri Host;
        
        public readonly OpIdentity Id;

        public readonly MethodInfo Member;

        public MemoryAddress Address {get;}

        public OpUri Uri
            => OpUri.Hex(Host, Member.Name, Id);


        [MethodImpl(Inline)]
        public static LocatedMember Define(ApiHostUri host, OpIdentity id, MethodInfo src, MemoryAddress address)
            => new LocatedMember(host,id, src, address);
        
        [MethodImpl(Inline)]
        LocatedMember(ApiHostUri host, OpIdentity id, MethodInfo src, MemoryAddress address)
        {
            this.Host = host;
            this.Id = id;
            this.Member = src;
            this.Address = address;
        }
    }
}