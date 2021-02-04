//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static ApiUriDelimiters;
    using static Konst;
    using static SFx;
    using static z;

    [ApiHost]
    public readonly struct ApiUri
    {
        public static ApiUriScheme scheme(string src)
            => Enum.TryParse(typeof(ApiUriScheme), src, true, out var result) ? (ApiUriScheme)result : ApiUriScheme.None;

        public static ParseResult<ApiHostUri> host(FS.FileName src)
            => host(src.WithoutExtension.Name.Replace(Chars.Dot, ApiUriDelimiters.UriPathSep));

        public static ParseResult<ApiHostUri> host(string src)
        {
            var failure = unparsed<ApiHostUri>(src);
            if(text.blank(src))
                return failure;

            var parts = src.SplitClean(ApiUriDelimiters.UriPathSep);
            var count = parts.Length;
            if(count != 2)
                return failure.WithReason(text.concat("Component count ", count," != ", 2));

            Enum.TryParse(parts[0], true, out PartId owner);
            if(owner == 0)
                return failure.WithReason("Invalid part");

            var host = parts[1];
            if(text.blank(host))
                return failure.WithReason("Host unspecified");

            return parsed(src, new ApiHostUri(owner, host));
        }

        [Op]
        public static OpIdentity operation(string src)
        {
            if(text.empty(src))
                return OpIdentity.Empty;

            var name = src.TakeBefore(IDI.PartSep);
            var suffixed = src.Contains(IDI.SuffixSep);
            var suffix = suffixed ? src.TakeAfter(IDI.SuffixSep) : EmptyString;
            var generic = src.TakeAfter(IDI.PartSep)[0] == IDI.Generic;
            var imm = suffix.Contains(IDI.Imm);
            var components = src.SplitClean(IDI.PartSep);
            var id = new OpIdentity(src, name, suffix, generic, imm, components);
            return id;
        }

        public static ParseResult<OpUri> parse(string src)
        {
            var parts = src.SplitClean(UriEndOfScheme);
            var msg = string.Empty;
            if(parts.Length != 2)
                return unparsed<OpUri>(src, $"Splitting on {UriEndOfScheme} produced {parts.Length} pieces");

            var scheme = ApiUri.scheme(parts[0]);
            var rest = parts[1];
            var pathText = rest.TakeBefore(UriQuery);
            var path = host(pathText);
            if(path.Failed)
                return ParseResult.fail<OpUri>(src, path.Message);

            var id = OpIdentityParser.parse(rest.TakeAfter(UriFragment));
            var group = rest.Between(UriQuery,UriFragment);
            var uri = ApiIdentity.uri(scheme, path.Value, group, id);
            return parsed(src, uri);
        }

        /// <summary>
        /// Defines an 8-bit immediate suffix predicated on an immediate value
        /// </summary>
        /// <param name="imm8">The source immediate</param>
        public static string Imm8Suffix(byte imm8)
            => $"{IDI.SuffixSep}{IDI.Imm}{imm8}";

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        [Op]
        public static string TestCase(Type host, IFunc f)
            => $"{ApiIdentify.part(host).Format()}{UriPathSep}{host.Name}{UriPathSep}{f.Id}";

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
        /// Produces an identifier of the form {owner}/{host} where owner is the formatted identifier of the declaring assembly and host is the name of the type
        /// </summary>
        /// <param name="host">The source type</param>
        [Op]
        public static string HostUri(Type host)
            => $"{ApiIdentify.part(host).Format()}{UriPathSep}{host.Name}";

        /// <summary>
        /// Produces the name of the test case determined by a source method
        /// </summary>
        /// <param name="method">The method that implements the test</param>
        [Op]
        public static string TestCase(MethodInfo method)
            => $"{ApiIdentify.part(method.DeclaringType).Format()}{UriPathSep}{method.DeclaringType.Name}{UriPathSep}{method.Name}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, excluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        [Op]
        public static string TestCase(Type host, string fullname)
            => $"{ApiIdentify.part(host).Format()}{UriPathSep}{host.Name}{UriPathSep}{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, excluding the host name
        /// </summary>
        /// <param name="id">Identity of the operation under test</param>
        [Op]
        public static string TestCase(Type host, OpIdentity id)
            => $"{ApiIdentify.part(host).Format()}{UriPathSep}{host.Name}{UriPathSep}{id.Identifier}";
    }
}