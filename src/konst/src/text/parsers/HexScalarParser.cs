//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct HexScalarParser : ITextParser<ulong>
    {               
        public static ParseResult<ulong> parse(string src)  
            => HexFormatSpecs.ParseHex(src);

        public static HexScalarParser Service 
            => default(HexScalarParser);
        
        public ParseResult<ulong> Parse(string src)  
            => HexFormatSpecs.ParseHex(src);           
    }
}