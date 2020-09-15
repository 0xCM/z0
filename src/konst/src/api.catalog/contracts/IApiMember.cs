//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IApiMethod : ITextual
    {
        OpIdentity Id {get;}

        /// <summary>
        /// The globally-unique host uri
        /// </summary>
        ApiHostUri HostUri {get;}

        /// <summary>
        /// The hosted method
        /// </summary>
        MethodInfo Method {get;}

        /// <summary>
        /// The method's kind identifier if it exists
        /// </summary>
        ApiKeyKind KindId
            => ApiKeyKind.None;

        /// The globally-unique operation uri
        /// </summary>
        OpUri OpUri
            => OpUri.hex(HostUri, Method.Name, Id);

        string ITextual.Format()
            => OpUri.Format();
    }

    public interface IHostedApiMethod : IApiMethod
    {
        IApiHost Host {get;}
    }
    public interface IApiMember : IApiMethod
    {

    }

    public interface IApiMember<T> : IApiMember, IEquatable<T>, ITextual<T>, INullary<T>, IComparable<T>
        where T : struct, IApiMember<T>
    {

    }
}