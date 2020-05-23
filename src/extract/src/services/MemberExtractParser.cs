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

        LocatedCode Locate(MemoryAddress address, byte[] src, int trim = 0)
        {
            if(trim == 0)
                return LocatedCode.Define(address, src);
            else
            {
                Span<byte> data = src;
                var len = data.Length - trim;
                if(len == 0)
                    len = data.Length;
                return LocatedCode.Define(address, data.Slice(0, len).ToArray());
            }
        }

        public ExtractParseResult Parse(ExtractedMember src, int seq)
        {
            try
            {
                var parser = Parser;
                var status = parser.Parse(src.Encoded);                
                var term = status.HasFailed() ? ExtractTermCode.Fail : parser.Result.ToTermCode();
                if(term != ExtractTermCode.Fail)
                {
                    var code = Locate(src.Encoded.Address, parser.Parsed, term == ExtractTermCode.CTC_Zx7 ? 18 : 0);
                    return new ExtractParseResult(new ParsedMember(src, seq, term, code));
                }
                else
                    return ExtractParseResult.FromFailure(new ExtractParseFailure(src, seq, term));
            }
            catch(Exception e)
            {
                var msg = AppMsg.Colorize($"{src.Member.OpUri} extract parse FAIL: {e}", AppMsgColor.Yellow);
                term.print(msg);
                //term.errlabel(e, $"{src.Member.OpUri} extract parse FAIL");  
                return ExtractParseResult.FromFailure(new ExtractParseFailure(src, seq, ExtractTermCode.Fail));
            }

        }

        public ExtractParseResults Parse(ExtractedMember[] src)
        {
            var parsed = list<ParsedMember>(src.Length);
            var failed = list<ExtractParseFailure>();
            for(var i=0; i<src.Length; i++)
            {
                Parse(src[i], i).OnResult(f => failed.Add(f), p => parsed.Add(p));                
            }
            return (failed.ToArray(), parsed.ToArray());            
        }
    }
}