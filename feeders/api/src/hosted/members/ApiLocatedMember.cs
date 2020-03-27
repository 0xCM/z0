//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Api;
        
    /// <summary>
    /// Identifies a host-defined operation and the memory address that leads the member's executable code
    /// </summary>
    public readonly struct ApiLocatedMember :  IApiMember<ApiLocatedMember>, IAddressable
    {
        public static ApiLocatedMember Empty => Define(ApiHostUri.Empty, OpIdentity.Empty, null, MemoryAddress.Zero);

        public ApiHostUri HostUri {get;}
        
        public OpIdentity Id {get;}

        public MethodInfo Method {get;}

        public OpKindId? KindId {get;}

        public MemoryAddress Address {get;}

        public OpUri Uri => Api.MemberUri(this);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => HostUri.IsEmpty && Id.IsEmpty && Method == null && !Address.NonZero;
        }

        ApiLocatedMember INullary<ApiLocatedMember>.Zero 
            => Empty;

        [MethodImpl(Inline)]
        public static ApiLocatedMember Define(ApiHostUri host, OpIdentity id, MethodInfo src, MemoryAddress address)
            => new ApiLocatedMember(host,id, src, address);
        
        [MethodImpl(Inline)]
        public static bool operator==(ApiLocatedMember a, ApiLocatedMember b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiLocatedMember a, ApiLocatedMember b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        ApiLocatedMember(ApiHostUri host, OpIdentity id, MethodInfo src, MemoryAddress address)
        {
            this.HostUri = host;
            this.Id = id;
            this.Method = src;
            this.KindId = src.KindId();
            this.Address = address;
        }
 

        [MethodImpl(Inline)]
        public bool Equals(ApiLocatedMember src)
            => HostUri == src.HostUri && Id == src.Id && Method == src.Method && Address == src.Address;

         public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is ApiLocatedMember m && Equals(m);        

        public override string ToString()
            => ((ICustomFormattable)this).Format();
    }
}