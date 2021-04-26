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
    /// Describes a concrete api
    /// </summary>
    public readonly struct ApiMember : IApiMember<ApiMember>
    {
        public OpIdentity Id {get;}

        public OpUri OpUri {get;}

        public MethodInfo Method {get;}

        public ApiClassKind ApiClass {get;}

        public MemoryAddress BaseAddress {get;}

        public ApiHostUri Host {get;}

        public OpMsil Cil {get;}

        public CliSig CliSig {get;}

        public ClrMethodArtifact Metadata {get;}

        public ApiMember(OpUri uri, MethodInfo method, ApiClassKind kindId, MemoryAddress address)
        {
            Id = uri.OpId;
            OpUri = uri;
            ApiClass = kindId;
            Method = root.require(method != null, method, () => "Unfortunately, the method is null");
            BaseAddress = address;
            Host = OpUri.Host;
            Cil = ClrDynamic.msil(BaseAddress, uri, method);
            CliSig = address.IsNonZero ? method.ResolveSignature() : CliSig.Empty;
            Metadata = method.Artifact();
        }

        public ApiMember Zero
            => Empty;

        public ClrToken Token
        {
            [MethodImpl(Inline)]
            get => Method;
        }

        [MethodImpl(Inline)]
        public bool Equals(ApiMember src)
        {
            var result = Id.Equals(src.Id);
            result &= OpUri.Equals(src.OpUri);
            result &= Method.Equals(src.Method);
            result &= ApiClass.Equals(src.ApiClass);
            result &= BaseAddress.Equals(src.BaseAddress);
            result &= Host.Equals(src.Host);
            return result;
        }

        public ApiMemberInfo Describe()
        {
            var dst = new ApiMemberInfo();
            dst.Address = BaseAddress;
            dst.Host = Host.UriText;
            dst.Member = Metadata.DisplaySig.Format();
            dst.ApiKind = ApiClass;
            dst.Uri = OpUri.UriText;
            return dst;
        }

        [MethodImpl(Inline)]
        public int CompareTo(ApiMember src)
            => BaseAddress.CompareTo(src.BaseAddress);

        public static ApiMember Empty
            => new ApiMember(OpUri.Empty, EmptyVessels.EmptyMethod, 0, 0);
    }
}