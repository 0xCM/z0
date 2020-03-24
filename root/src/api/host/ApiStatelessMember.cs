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
    /// Identifies an operation declared by a static host type
    /// </summary>
    public readonly struct ApiStatelessMember : IApiMember<ApiStatelessMember>
    {
        public static ApiStatelessMember Empty => Define(ApiHostUri.Empty, OpIdentity.Empty, null);
        
        /// <summary>
        /// The declaring host uri
        /// </summary>
        public ApiHostUri Host {get;}
        
        /// <summary>
        /// The host-relative operation identity
        /// </summary>
        public OpIdentity Id {get;}

        /// <summary>
        /// The implementing method
        /// </summary>
        public MethodInfo Method {get;}

        /// <summary>
        /// The operation kind, if known
        /// </summary>
        public OpKindId? KindId {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Host.IsEmpty && Id.IsEmpty && Method == null;
        }

        ApiStatelessMember INullary<ApiStatelessMember>.Zero 
            => Empty;

        /// <summary>
        /// The type member uri
        /// </summary>
        public OpUri Uri => OpUri.type(this);

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