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

    using static Konst;
    using static Memories;

    /// <summary>
    /// Describes a reified api member wich may be of hosted or located state
    /// </summary>
    public readonly struct ApiMember : IApiMember<ApiMember>
    {
        public OpIdentity Id {get;}
        
        public OpUri OpUri {get;}

        public MethodInfo Method {get;}

        public OpKindId KindId {get;}

        public MemoryAddress Address {get;}

        public ApiHostUri HostUri {get;}   

        public ApiMember Zero 
            => Empty;

        [MethodImpl(Inline)]
        public ApiMember(OpUri uri, MethodInfo method, OpKindId kindId)
        {
            Id = uri.OpId;
            OpUri = uri;
            KindId = kindId;
            Method = insist(method);
            Address = MemoryAddress.Empty;
            HostUri = OpUri.Host;
        }

        [MethodImpl(Inline)]
        public ApiMember(OpUri uri, MethodInfo method, OpKindId kindId, MemoryAddress address)
        {
            Id = uri.OpId;
            OpUri = uri;
            KindId = kindId;
            Method = insist(method);
            Address = address;
            HostUri = OpUri.Host;
        }        

        public bool Equals(ApiMember src)
        {
            var result = Id.Equals(src.Id);
            result &= OpUri.Equals(src.OpUri);
            result &= Method.Equals(src.Method);
            result &= KindId.Equals(src.KindId);
            result &= Address.Equals(src.Address);
            result &= HostUri.Equals(src.HostUri);
            return result;
        }
        
        public static ApiMember Empty 
            => new ApiMember(OpUri.Empty, EmptyMethod, 0, 0);
    }        
}