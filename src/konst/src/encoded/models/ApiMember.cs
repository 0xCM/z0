//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct CapturedApiMember
    {
        public readonly ApiMember Member;

        public readonly CapturedCode Code;

        public CapturedApiMember(ApiMember member, CapturedCode code)
        {
            Member = member;
            Code = code;
        }
    }

    /// <summary>
    /// Describes a reified api member which may be of hosted or located state
    /// </summary>
    public readonly struct ApiMember : IApiMember<ApiMember>, IComparable<ApiMember>
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
            Method = z.insist(method);
            Address = MemoryAddress.Empty;
            HostUri = OpUri.Host;
        }

        [MethodImpl(Inline)]
        public ApiMember(OpUri uri, MethodInfo method, OpKindId kindId, MemoryAddress address)
        {
            Id = uri.OpId;
            OpUri = uri;
            KindId = kindId;
            Method = z.insist(method);
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

        [MethodImpl(Inline)]
        public int CompareTo(ApiMember src)
            => Address.CompareTo(src.Address);

        public static ApiMember Empty
            => new ApiMember(OpUri.Empty, EmptyVessels.EmptyMethod, 0, 0);
    }
}