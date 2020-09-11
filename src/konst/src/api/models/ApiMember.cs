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

        public ApiOpId KindId {get;}

        public MemoryAddress Address {get;}

        public ApiHostUri HostUri {get;}

        public CilCode Cil {get;}

        public ApiMember Zero
            => Empty;

        [MethodImpl(Inline)]
        public ApiMember(OpUri uri, MethodInfo method, ApiOpId kindId, MemoryAddress address)
        {
            Id = uri.OpId;
            OpUri = uri;
            KindId = kindId;
            Method = z.insist(method);
            Address = address;
            HostUri = OpUri.Host;
            Cil = FunctionDynamic.cil(method);
        }

        [MethodImpl(Inline)]
        public ApiMember(OpUri uri, LocatedMethod method, ApiOpId kindId)
        {
            Id = uri.OpId;
            OpUri = uri;
            KindId = kindId;
            Method = method.Method;
            Address = method.Address;
            HostUri = OpUri.Host;
            Cil = FunctionDynamic.cil(Method);
        }

        [MethodImpl(Inline)]
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