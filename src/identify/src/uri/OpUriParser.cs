//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static UriDelimiters;

    public readonly struct OpUriParser : IParser<OpUriParser,OpUri>
    {        
        public static IParser<OpUri> The => default(OpUriParser);
        
        static OpUriScheme ParseScheme(string text)        
            => Enum.TryParse(typeof(OpUriScheme), text, true, out var result) 
               ? (OpUriScheme)result 
               : OpUriScheme.None;

        public ParseResult<OpUri> Parse(string text)
        {
            var parts = text.SplitClean(EOS);
            var msg = string.Empty;
            if(parts.Length != 2)
                msg = $"Splitting on {EOS} produced {parts.Length} pieces";
            else
            {
                var scheme = ParseScheme(parts[0]);
                var rest = parts[1];
                var pathText = rest.TakeBefore(QueryMarker);
                var path = ApiHostUri.Parse(pathText);
                if(!path.Succeeded)
                    msg = $"Failed to parse {pathText} as an api host path";
                else
                {
                    var id = Identify.Op(rest.TakeAfter(Fragment));
                    var group = rest.Between(QueryMarker,Fragment);
                    var uri = OpUri.Define(scheme, path.Value, group, id);
                    return ParseResult.Success(text,uri);
                }                
            }
                        
            return ParseResult.Fail<OpUri>(msg);
        }               
    }
}