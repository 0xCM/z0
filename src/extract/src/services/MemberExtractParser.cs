//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static Seed;
    using static Memories;
    
    using BP = ByteParser<EncodingPatternKind>;

    public readonly struct MemberExtractParser : IExtractParser
    {
        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public static IExtractParser Create(byte[] buffer)
            => new MemberExtractParser(buffer);

        [MethodImpl(Inline)]
        internal MemberExtractParser(byte[] buffer)
        {
            Buffer = buffer;
        }

        BP Parser 
        {        
            [MethodImpl(Inline)]
            get => Extract.Services.PatternParser(Buffer.Clear());
        }

        public ExtractParseResult Parse(ExtractedMember src, int seq)
        {
            var parser = Parser;
            var address = src.Encoded.Address;
            var status = parser.Parse(src.Encoded);                
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success(); 
            var term = matched.ToTermCode();

            if(succeeded)
                return new ParsedMember(src, seq, term, LocatedCode.Define(address, parser.Parsed));
            else
                return new ExtractParseFailure(src, seq, term);
        }

        public ExtractParseResults Parse(ExtractedMember[] src)
        {
            var parsed = list<ParsedMember>(src.Length);
            var failed = list<ExtractParseFailure>();
            for(var i=0; i< src.Length; i++)
                Parse(src[i], i).OnResult(f => failed.Add(f), p => parsed.Add(p));
            return (failed.ToArray(), parsed.ToArray());            
        }
    }
}