//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    /// <summary>
    /// Describes a reified api member which may be of hosted or located state
    /// </summary>
    public readonly struct ApiMember : IApiMember<ApiMember>
    {
        public OpIdentity Id {get;}

        public OpUri OpUri {get;}

        public MethodInfo Method {get;}

        public ApiClass ApiKind {get;}

        public MemoryAddress BaseAddress {get;}

        public ApiHostUri Host {get;}

        public CilMethod Cil {get;}

        public CliSig CliSig {get;}

        public ApiArtifactUri MetaUri
            => Method;

        public ApiMember Zero
            => Empty;

        [MethodImpl(Inline)]
        public ApiMember(OpUri uri, MethodInfo method, ApiClass kindId, MemoryAddress address, CliSig? sig = null)
        {
            Id = uri.OpId;
            OpUri = uri;
            ApiKind = kindId;
            Method = z.insist(method);
            BaseAddress = address;
            Host = OpUri.Host;
            Cil = ClrDynamic.cil(BaseAddress, uri, method);
            CliSig = sig ?? CliSig.Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(ApiMember src)
        {
            var result = Id.Equals(src.Id);
            result &= OpUri.Equals(src.OpUri);
            result &= Method.Equals(src.Method);
            result &= ApiKind.Equals(src.ApiKind);
            result &= BaseAddress.Equals(src.BaseAddress);
            result &= Host.Equals(src.Host);
            return result;
        }

        [MethodImpl(Inline)]
        public int CompareTo(ApiMember src)
            => BaseAddress.CompareTo(src.BaseAddress);

        public static ApiMember Empty
            => new ApiMember(OpUri.Empty, EmptyVessels.EmptyMethod, 0, 0);
    }
}