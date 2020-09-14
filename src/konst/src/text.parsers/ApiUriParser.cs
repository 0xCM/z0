//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static UriDelimiters;
    using static z;

    public readonly struct ApiUriParser : ITextParser<OpUri>
    {
        public static ApiUriParser Service => default;

        public static ApiUriScheme scheme(string src)
            => Enum.TryParse(typeof(ApiUriScheme), src, true, out var result)
               ? (ApiUriScheme)result
               : ApiUriScheme.None;

        public static ParseResult<ApiHostUri> host(FileName src)
        {
            var input = src.WithoutExtension.Name.Replace(Chars.Dot, UriDelimiters.PathSep);
            return host(input);
        }

        public static ParseResult<ApiHostUri> host(string src)
        {
            var failure = unparsed<ApiHostUri>(src);
            if(text.blank(src))
                return failure;

            var parts = src.SplitClean(UriDelimiters.PathSep);
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

        public static ParseResult<OpUri> operation(string src)
        {
            var parts = src.SplitClean(EOS);
            var msg = string.Empty;
            if(parts.Length != 2)
                return unparsed<OpUri>(src, $"Splitting on {EOS} produced {parts.Length} pieces");

            var scheme = ApiUriParser.scheme(parts[0]);
            var rest = parts[1];
            var pathText = rest.TakeBefore(QueryMarker);
            var path = host(pathText);
            if(path.Failed)
                return ParseResult.Fail<OpUri>(src, path.Reason);

            var id = OpIdentityParser.parse(rest.TakeAfter(Fragment));
            var group = rest.Between(QueryMarker,Fragment);
            var uri = OpUri.Define(scheme, path.Value, group, id);
            return parsed(src, uri);
        }

        public ParseResult<OpUri> Parse(string text)
            => operation(text);

    }
}