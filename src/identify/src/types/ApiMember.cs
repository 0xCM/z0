//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Seed;

    /// <summary>
    /// Defines a reified api member wich may be of hosted or located state
    /// </summary>
    public readonly struct ApiMember : IApiMember
    {
        public static ApiMember Empty => Define(OpUri.Empty, null, OpKindId.None, null);

        [MethodImpl(Inline)]
        public static ApiMember Define(OpUri uri, MethodInfo method, OpKindId kindId, MemoryAddress? address = null)
            => new ApiMember(uri,method, kindId, address ?? MemoryAddress.Zero);

        [MethodImpl(Inline)]
        ApiMember(OpUri uri, MethodInfo method, OpKindId kindId, MemoryAddress address)
        {
            this.OpUri = uri;
            this.KindId = kindId;
            this.Method = method ?? typeof(object).Methods().First();
            this.Address = address;
            this.HostUri = OpUri.HostPath;
            this.Id = OpUri.OpId;
        }

        public OpUri OpUri {get;}

        public MethodInfo Method {get;}

        public OpKindId? KindId {get;}

        public MemoryAddress Address {get;}

        public ApiHostUri HostUri {get;}
    
        public OpIdentity Id {get;}
    }        
}