//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    /// <summary>
    /// Identifies a host-defined operation 
    /// </summary>
    public readonly struct ApiServiceMember : IApiMember<ApiServiceMember>
    {
        public static ApiServiceMember Empty => Define(ApiHostUri.Empty, OpIdentity.Empty, null);
        
        public ApiHostUri HostUri {get;}
        
        public OpIdentity Id {get;}

        public MethodInfo Method {get;}

        public OpKindId? KindId {get;}

        public OpUri Uri => Api.MemberUri(this);

        [MethodImpl(Inline)]
        public static ApiServiceMember Define(ApiHostUri host, OpIdentity id, MethodInfo src)
            => new ApiServiceMember(host,id, src);

        [MethodImpl(Inline)]
        public static bool operator==(ApiServiceMember a, ApiServiceMember b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiServiceMember a, ApiServiceMember b)
            => !a.Equals(b);
        
        [MethodImpl(Inline)]
        ApiServiceMember(ApiHostUri host, OpIdentity id, MethodInfo src)
        {
            this.HostUri = host;
            this.Id = id;
            this.Method = src;
            this.KindId = src.KindId();
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => HostUri.IsEmpty && Id.IsEmpty && Method == null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        ApiServiceMember INullary<ApiServiceMember>.Zero 
            => Empty;

        [MethodImpl(Inline)]
        public bool Equals(ApiServiceMember src)
            => HostUri == src.HostUri && Id == src.Id && Method == src.Method;
        
        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is ApiServiceMember m && Equals(m);

        public override string ToString()
            => ((ICustomFormattable)this).Format();       
    }
}