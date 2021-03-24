//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiMember : IApiMethod
    {
        MemoryAddress BaseAddress
            => MemoryAddress.Zero;

        OpMsil Cil
            => ClrDynamic.cil(BaseAddress, OpUri, Method);

        CliSig CliSig
            => Method.ResolveSignature();

        ApiMemberInfo Describe()
        {
            var dst = new ApiMemberInfo();
            dst.Address = BaseAddress;
            dst.Host = Host.UriText;
            dst.Member = Metadata.DisplaySig.Format();
            dst.ApiKind = ApiClass;
            dst.Uri = OpUri.UriText;
            return dst;
        }
    }

    [Free]
    public interface IApiMember<T> : IApiMember, IEquatable<T>, ITextual<T>, INullary<T>, IComparable<T>
        where T : struct, IApiMember<T>
    {

    }
}