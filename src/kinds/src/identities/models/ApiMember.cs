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
    /// Describes a reified api member wich may be of hosted or located state
    /// </summary>
    public readonly struct Member : IApiMember, IEquatable<Member>
    {
        public static Member Empty => Define(OpUri.Empty, null, OpKindId.None, null);

        [MethodImpl(Inline)]
        public static Member Define(OpUri uri, MethodInfo method, OpKindId kindId, MemoryAddress? address = null)
            => new Member(uri,method, kindId, address ?? MemoryAddress.Zero);

        [MethodImpl(Inline)]
        internal Member(OpUri uri, MethodInfo method, OpKindId kindId, MemoryAddress address)
        {
            this.Id = uri.OpId;
            this.OpUri = uri;
            this.KindId = kindId;
            this.Method = method ?? typeof(object).Methods().First();
            this.Address = address;
            this.HostUri = OpUri.HostPath;
        }
        
        public OpIdentity Id {get;}
        
        public OpUri OpUri {get;}

        public MethodInfo Method {get;}

        public OpKindId? KindId {get;}

        public MemoryAddress Address {get;}

        public ApiHostUri HostUri {get;}   

        public bool Equals(Member src)
        {
            var result = Id.Equals(src.Id);
            result &= OpUri.Equals(src.OpUri);
            result &= Method.Equals(src.Method);
            result &= KindId.Equals(src.KindId);
            result &= Address.Equals(src.Address);
            result &= HostUri.Equals(src.HostUri);
            return result;
        }
    }        
}