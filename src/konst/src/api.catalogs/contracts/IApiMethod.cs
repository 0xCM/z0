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
        /// The clr metadata token
        /// </summary>
        ClrToken Token
            => Method;

        /// <summary>
        /// The method's kind identifier if it exists
        /// </summary>
        ApiClass ApiClass
            => ApiClass.None;

        /// The globally-unique operation uri
        /// </summary>
        OpUri OpUri
            => OpUri.hex(Host, Method.Name, Id);

        ClrMethodMetadata Metadata
            => Method.Metadata();

        string ITextual.Format()
            => OpUri.Format();
    }
}