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
    using static z;

    /// <summary>
    /// Describes a reified api member which may be of hosted or located state
    /// </summary>
    public struct ApiMember : IApiMember<ApiMember>
    {
        public OpIdentity Id {get;}

        public OpUri OpUri {get;}

        public MethodInfo Method {get;}

        public ApiOpId ApiKind {get;}

        public MemoryAddress Address {get;}

        public ApiHostUri Host {get;}

        public CilMethod Cil {get;}

        public ApiMetadataUri MetaUri
            => Method;

        public ApiMember Zero
            => Empty;

        [MethodImpl(Inline)]
        public ApiMember(OpUri uri, MethodInfo method, ApiOpId kindId, MemoryAddress address)
        {
            Id = uri.OpId;
            OpUri = uri;
            ApiKind = kindId;
            Method = z.insist(method);
            Address = address;
            Host = OpUri.Host;
            Cil = ClrDynamic.cil(method);
        }

        [MethodImpl(Inline)]
        public ApiMember(OpUri uri, LocatedMethod method, ApiOpId kindId)
        {
            Id = uri.OpId;
            OpUri = uri;
            ApiKind = kindId;
            Method = method.Method;
            Address = method.Address;
            Host = OpUri.Host;
            Cil = ClrDynamic.cil(Method);
        }

        [MethodImpl(Inline)]
        public bool Equals(ApiMember src)
        {
            var result = Id.Equals(src.Id);
            result &= OpUri.Equals(src.OpUri);
            result &= Method.Equals(src.Method);
            result &= ApiKind.Equals(src.ApiKind);
            result &= Address.Equals(src.Address);
            result &= Host.Equals(src.Host);
            return result;
        }

        [MethodImpl(Inline)]
        public int CompareTo(ApiMember src)
            => Address.CompareTo(src.Address);

        public static ApiMember Empty
            => new ApiMember(OpUri.Empty, EmptyVessels.EmptyMethod, 0, 0);
    }
}