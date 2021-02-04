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
        /// The apiset to which the method belongs, if any
        /// </summary>
        ApiSetKind ApiSet
            => Method.Tag<ApiHostAttribute>().MapValueOrDefault(x => x.ApiSet, ApiSetKind.None);

        /// <summary>
        /// Specifies whether the method is closed generic
        /// </summary>
        bool IsClosedGeneric
            => Method.IsClosedGeneric();

        /// <summary>
        /// Specifies whether the method is open generic
        /// </summary>
        bool IsOpenGeneric
            => Method.IsOpenGeneric();

        /// <summary>
        /// Specifies whether the method either open or clsed generic
        /// </summary>
        bool IsGeneric
            => IsOpenGeneric || IsClosedGeneric;

        /// <summary>
        /// Specifies whether the method is nongeneric
        /// </summary>
        bool IsNonGeneric
            => Method.IsNonGeneric();

        /// <summary>
        /// The metadata uri
        /// </summary>
        ApiArtifactKey MetaUri => Method;

        /// <summary>
        /// The method's kind identifier if it exists
        /// </summary>
        ApiClass ApiKind
            => ApiClass.None;

        /// The globally-unique operation uri
        /// </summary>
        OpUri OpUri
            => OpUri.hex(Host, Method.Name, Id);

        string ITextual.Format()
            => OpUri.Format();
    }
}