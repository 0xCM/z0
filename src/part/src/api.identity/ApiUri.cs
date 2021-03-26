//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static ApiUriDelimiters;
    using static Part;

    [ApiHost]
    public readonly struct ApiUri
    {
        /// <summary>
        /// Defines a primal identity if the source type represents a recognized primitive; otherwise,
        /// returns <see cref='PrimalIdentity.Empty'/>
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static PrimalIdentity primal(Type src)
            => src.IsSystemDefined() ?
               (NumericKinds.test(src)
               ? new PrimalIdentity(src.NumericKind(), ClrDisplaySig.keyword(src))
               : new PrimalIdentity(ClrDisplaySig.keyword(src))
               ) : PrimalIdentity.Empty;

        /// <summary>
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        [MethodImpl(Inline), Op]
        public static Option<byte> imm8(OpIdentity src)
        {
            if(src.HasImm && byte.TryParse(src.Identifier.RightOfLast(IDI.Imm), out var immval))
                return immval;
            else
                return root.none<byte>();
        }

        /// <summary>
        /// Builds the *canonical* operation uri
        /// </summary>
        /// <param name="scheme"></param>
        /// <param name="host"></param>
        /// <param name="group"></param>
        /// <param name="opid"></param>
        [Op]
        internal static string BuildUriText(ApiUriScheme scheme, ApiHostUri host, string group, OpIdentity opid)
            => (opid.IsEmpty
                ? QueryText(scheme, host.Owner, host.Name, group)
                : FullUriText(scheme, host.Owner, host.Name, group, opid)).Trim();

        [MethodImpl(Inline), Op]
        public static OpUri define(ApiUriScheme scheme, ApiHostUri host, string group, OpIdentity opid)
            => new OpUri(scheme, host, group, opid);

        [MethodImpl(Inline)]
        public static OpUri hex(ApiHostUri host, string group, OpIdentity opid)
            => new OpUri(ApiUriScheme.Hex, host, group, opid);


        [MethodImpl(Inline), Op]
        public static OpUri located(ApiHostUri host, string group, OpIdentity opid)
            => new OpUri(ApiUriScheme.Located, host, group, opid);

        [Op]
        public static string QueryText(ApiUriScheme scheme, PartId part, string host, string group)
            => $"{scheme.Format()}{UriEndOfScheme}{part.Format()}{UriPathSep}{host}{UriQuery}{group}";

        [Op]
        public static string FullUriText(ApiUriScheme scheme, PartId part, string host, string group, OpIdentity opid)
            => $"{scheme.Format()}{UriEndOfScheme}{part.Format()}{UriPathSep}{host}{UriQuery}{group}{UriFragment}{opid.Identifier}";

        public static ApiUriScheme scheme(string src)
            => Enum.TryParse(typeof(ApiUriScheme), src, true, out var result) ? (ApiUriScheme)result : ApiUriScheme.None;

        public static ParseResult<ApiHostUri> fromFilename(string filename)
            => host(Path.GetFileNameWithoutExtension(filename).Replace(Chars.Dot, ApiUriDelimiters.UriPathSep));


        public static ParseResult<ApiHostUri> host(string src)
        {
            var failure = root.unparsed<ApiHostUri>(src);
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

            return root.parsed(src, new ApiHostUri(owner, host));
        }

        [Op]
        public static OpIdentity opid(string src)
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
                return root.unparsed<OpUri>(src, $"Splitting on {UriEndOfScheme} produced {parts.Length} pieces");

            var uriScheme = scheme(parts[0]);
            var rest = parts[1];
            var pathText = rest.TakeBefore(UriQuery);
            var path = host(pathText);
            if(path.Failed)
                return root.unparsed<OpUri>(src, $"{path.Message}");

            var id = ApiUri.opid(rest.TakeAfter(UriFragment));
            var group = rest.Between(UriQuery,UriFragment);
            var uri = ApiUri.define(uriScheme, path.Value, group, id);
            return root.parsed(src, uri);
        }

        public static Outcome parse(string src, out OpUri dst)
        {
            var result = parse(src);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = OpUri.Empty;
                return (false,result.Message?.ToString() ?? EmptyString);
            }
        }

        /// <summary>
        /// Defines an 8-bit immediate suffix predicated on an immediate value
        /// </summary>
        /// <param name="imm8">The source immediate</param>
        public static string Imm8Suffix(byte imm8)
            => $"{IDI.SuffixSep}{IDI.Imm}{imm8}";



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
            => $"{PartName.from(host)}{UriPathSep}{host.Name}";
    }
}