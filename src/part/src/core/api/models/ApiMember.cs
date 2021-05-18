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
    public class ApiMember : IApiMember<ApiMember>
    {
        public OpUri OpUri {get;}

        public MethodInfo Method {get;}

        public ApiClassKind ApiClass {get;}

        public ApiMsil Msil {get;}

        public ClrMethodArtifact Metadata {get;}

        public ApiMember(OpUri uri, MethodInfo method, MemoryAddress address)
        {
            //Id = uri.OpId;
            OpUri = uri;
            ApiClass = method.KindId();
            Method = root.require(method != null, method, () => "Unfortunately, the method is null");
            //BaseAddress = address;
            //Host = OpUri.Host;
            Msil = ClrDynamic.msil(address, uri, method);
            //CliSig = address.IsNonZero ? method.ResolveSignature() : CliSig.Empty;
            Metadata = method.Artifact();
        }

        public OpIdentity Id
        {
            [MethodImpl(Inline)]
            get => OpUri.OpId;
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Msil.BaseAddress;
        }

        public ApiHostUri Host
        {
            [MethodImpl(Inline)]
            get => OpUri.Host;
        }

        public CliSig CliSig
        {
             [MethodImpl(Inline)]
             get => Msil.CliSig;
        }

        public CliToken Token
        {
            [MethodImpl(Inline)]
            get => Msil.Token;
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

        [MethodImpl(Inline)]
        public int CompareTo(ApiMember src)
            => BaseAddress.CompareTo(src.BaseAddress);

        public static ApiMember Empty
            => new ApiMember(OpUri.Empty, EmptyVessels.EmptyMethod, 0);
    }
}