//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static UriDelimiters;
    using static z;

    public readonly struct OpUriParser : ITextParser<OpUri>
    {        
        public static OpUriParser Service => default;
        
        static OpUriScheme ParseScheme(string text)        
            => Enum.TryParse(typeof(OpUriScheme), text, true, out var result) 
               ? (OpUriScheme)result 
               : OpUriScheme.None;

        public ParseResult<OpUri> Parse(string text)
        {
            var parts = text.SplitClean(EOS);
            var msg = string.Empty;
            if(parts.Length != 2)
                return unparsed<OpUri>(text, $"Splitting on {EOS} produced {parts.Length} pieces");

            var scheme = ParseScheme(parts[0]);
            var rest = parts[1];
            var pathText = rest.TakeBefore(QueryMarker);
            var path = ApiHostUri.Parse(pathText);
            if(path.Failed)
                return ParseResult.Fail<OpUri>(text, path.Reason);

            var id = OpIdentityParser.parse(rest.TakeAfter(Fragment));
            var group = rest.Between(QueryMarker,Fragment);
            var uri = OpUri.Define(scheme, path.Value, group, id);
            return parsed(text, uri);
        }               
    }
}