//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static UriDelimiters;

    public readonly struct ApiUri
    {
        public static string QueryText(ApiUriScheme scheme, PartId catalog, string host, string group)
            => $"{scheme.Format()}{UriEndOfScheme}{catalog.Format()}{UriPathSep}{host}{UriQuery}{group}";

        public static string FullUriText(ApiUriScheme scheme, PartId catalog, string host, string group, OpIdentity opid)
            => $"{scheme.Format()}{UriEndOfScheme}{catalog.Format()}{UriPathSep}{host}{UriQuery}{group}{UriFragment}{opid.Identifier}";

        public static string PathText(string scheme, PartId catalog, string host)
            => $"{scheme}{UriEndOfScheme}{catalog.Format()}{UriPathSep}{host}";

        public static string GroupUriText(ApiUriScheme scheme, ApiHostUri host, string group)
            => QueryText(scheme, host.Owner, host.Name, group);

        /// <summary>
        /// Produces an identifier of the form {owner}/{host} where owner is the formatted identifier of the declaring assembly
        /// and host is the name of the type
        /// </summary>
        /// <param name="host">The source type</param>
        public static string HostUri(Type host)
            => $"{Identify.OwningPartText(host)}{UriPathSep}{host.Name}";

        /// <summary>
        /// Produces the name of the test case determined by a source method
        /// </summary>
        /// <param name="method">The method that implements the test</param>
        public static string TestCase(MethodInfo method)
            => $"{Identify.OwningPartText(method.DeclaringType)}{UriPathSep}{method.DeclaringType.Name}{UriPathSep}{method.Name}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public static string TestCase(Type host, string fullname)
            => $"{Identify.OwningPartText(host)}{UriPathSep}{host.Name}{UriPathSep}{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Identity of the operation under test</param>
        public static string TestCase(Type host, OpIdentity id)
            => $"{Identify.OwningPartText(host)}{UriPathSep}{host.Name}{UriPathSep}{id}";
    }
}