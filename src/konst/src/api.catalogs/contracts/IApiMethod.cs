//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiMethod : ITextual
    {
        OpIdentity Id {get;}

        /// <summary>
        /// The globally-unique host uri
        /// </summary>
        ApiHostUri Host {get;}

        /// <summary>
        /// The hosted method
        /// </summary>
        MethodInfo Method {get;}

        /// <summary>
        /// The metadata uri
        /// </summary>
        ApiMetadataUri MetaUri => Method;

        /// <summary>
        /// The method's kind identifier if it exists
        /// </summary>
        ApiOpId ApiKind
            => ApiOpId.None;

        /// The globally-unique operation uri
        /// </summary>
        OpUri OpUri
            => OpUri.hex(Host, Method.Name, Id);

        string ITextual.Format()
            => OpUri.Format();
    }
}