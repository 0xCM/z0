//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static ApiUriDelimiters;

    [ApiHost]
    public readonly struct ApiUri
    {
        [Op]
        public static string QueryText(ApiUriScheme scheme, PartId catalog, string host, string group)
            => $"{scheme.Format()}{UriEndOfScheme}{catalog.Format()}{UriPathSep}{host}{UriQuery}{group}";

        [Op]
        public static string FullUriText(ApiUriScheme scheme, PartId catalog, string host, string group, OpIdentity opid)
            => $"{scheme.Format()}{UriEndOfScheme}{catalog.Format()}{UriPathSep}{host}{UriQuery}{group}{UriFragment}{opid.Identifier}";

        [Op]
        public static string PathText(string scheme, PartId catalog, string host)
            => $"{scheme}{UriEndOfScheme}{catalog.Format()}{UriPathSep}{host}";

        [Op]
        public static string GroupUriText(ApiUriScheme scheme, ApiHostUri host, string group)
            => QueryText(scheme, host.Owner, host.Name, group);

        /// <summary>
        /// Produces an identifier of the form {owner}/{host} where owner is the formatted identifier of the declaring assembly
        /// and host is the name of the type
        /// </summary>
        /// <param name="host">The source type</param>
        [Op]
        public static string HostUri(Type host)
            => $"{ApiIdentityKinds.OwningPartText(host)}{UriPathSep}{host.Name}";

        /// <summary>
        /// Produces the name of the test case determined by a source method
        /// </summary>
        /// <param name="method">The method that implements the test</param>
        [Op]
        public static string TestCase(MethodInfo method)
            => $"{ApiIdentityKinds.OwningPartText(method.DeclaringType)}{UriPathSep}{method.DeclaringType.Name}{UriPathSep}{method.Name}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, excluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        [Op]
        public static string TestCase(Type host, string fullname)
            => $"{ApiIdentityKinds.OwningPartText(host)}{UriPathSep}{host.Name}{UriPathSep}{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, excluding the host name
        /// </summary>
        /// <param name="id">Identity of the operation under test</param>
        [Op]
        public static string TestCase(Type host, OpIdentity id)
            => $"{ApiIdentityKinds.OwningPartText(host)}{UriPathSep}{host.Name}{UriPathSep}{id}";
    }
}