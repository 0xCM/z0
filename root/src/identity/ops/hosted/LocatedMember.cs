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
    /// Identifies a host-defined operation and the memory address that leads the member's executable code
    /// </summary>
    public readonly struct LocatedMember :  IHostedMember<LocatedMember>, IAddressable
    {
        public static LocatedMember Empty => Define(ApiHostUri.Empty, OpIdentity.Empty, null, MemoryAddress.Zero);

        public ApiHostUri Host {get;}
        
        public OpIdentity Id {get;}

        public MethodInfo Method {get;}

        public MemoryAddress Address {get;}

        public OpUri Uri
            => OpUri.Hex(Host, Method.Name, Id);

        [MethodImpl(Inline)]
        public static LocatedMember Define(ApiHostUri host, OpIdentity id, MethodInfo src, MemoryAddress address)
            => new LocatedMember(host,id, src, address);
        
        [MethodImpl(Inline)]
        public static bool operator==(LocatedMember a, LocatedMember b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(LocatedMember a, LocatedMember b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        LocatedMember(ApiHostUri host, OpIdentity id, MethodInfo src, MemoryAddress address)
        {
            this.Host = host;
            this.Id = id;
            this.Method = src;
            this.Address = address;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Host.IsEmpty && Id.IsEmpty && Method == null && !Address.NonZero;
        }
 
        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        [MethodImpl(Inline)]
        public bool Equals(LocatedMember src)
            => Host == src.Host && Id == src.Id && Method == src.Method && Address == src.Address;

         public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is LocatedMember m && Equals(m);        

        public override string ToString()
            => ((ICustomFormattable)this).Format();
    }
}