//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;

    using static Root;


    /// <summary>
    /// Identifies a host-defined operation 
    /// </summary>
    public readonly struct ApiStatelessMember : IApiMember<ApiStatelessMember>, INullary<ApiStatelessMember>, IMethodSource<ApiStatelessMember>
    {
        public static ApiStatelessMember Empty => Define(ApiHostUri.Empty, OpIdentity.Empty, null);
        
        public ApiHostUri Host {get;}
        
        public OpIdentity Id {get;}

        public MethodInfo Method {get;}

        public OpKindId? KindId {get;}

        public OpUri Uri => OpUri.hosted(this);

        [MethodImpl(Inline)]
        public static ApiStatelessMember Define(ApiHostUri host, OpIdentity id, MethodInfo src)
            => new ApiStatelessMember(host,id, src);

        [MethodImpl(Inline)]
        public static bool operator==(ApiStatelessMember a, ApiStatelessMember b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiStatelessMember a, ApiStatelessMember b)
            => !a.Equals(b);
        
        [MethodImpl(Inline)]
        ApiStatelessMember(ApiHostUri host, OpIdentity id, MethodInfo src)
        {
            this.Host = host;
            this.Id = id;
            this.Method = src;
            this.KindId = src.KindId();
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Host.IsEmpty && Id.IsEmpty && Method == null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        ApiStatelessMember INullary<ApiStatelessMember>.Zero 
            => Empty;

        [MethodImpl(Inline)]
        public bool Equals(ApiStatelessMember src)
            => Host == src.Host && Id == src.Id && Method == src.Method;
        
        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is ApiStatelessMember m && Equals(m);

        public override string ToString()
            => ((ICustomFormattable)this).Format();       
    }
}