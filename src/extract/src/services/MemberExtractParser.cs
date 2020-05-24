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
        /// <summary>
        /// The default length of the segment removed from the tail of the parsed byte array when the term code is Zx7
        /// </summary>
        const int Zx7Cut = 16;

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

        [MethodImpl(Inline)]
        static int CalcLength(ReadOnlySpan<byte> src, int maxcut, byte code)
        {
            var srcLen = src.Length;
            var cut = 0;
            if(srcLen > maxcut)
            {
                var start = srcLen - maxcut - 1;
                ref readonly var lead = ref skip(src, maxcut);
                ref readonly var current = ref lead;

                for(var i=start; i<srcLen && cut < maxcut; i++, cut++)
                {
                    current = ref skip(lead, i);
                    if(current == code)
                        break;
                }
            }
            var dstLen = src.Length - cut;
            return dstLen <= 0 ? src.Length : dstLen;
        }

        LocatedCode Locate(MemoryAddress address, byte[] src, int cut = 0)
        {
            if(cut == 0)
                return LocatedCode.Define(address, src);
            else
            {
                Span<byte> data = src;
                var len = CalcLength(data, cut, 0xC3);
                var keep = data.Slice(0, len);
                return LocatedCode.Define(address, keep.ToArray());
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
                    var code = Locate(src.Encoded.Address, parser.Parsed, term == ExtractTermCode.CTC_Zx7 ? Zx7Cut : 0);
                    return new ExtractParseResult(new ParsedMember(src, seq, term, code));
                }
                else
                    return ExtractParseResult.FromFailure(new ExtractParseFailure(src, seq, term));
            }
            catch(Exception e)
            {
                var msg = AppMsg.Colorize($"{src.Member.OpUri} extract parse FAIL: {e}", AppMsgColor.Yellow);
                term.print(msg);
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