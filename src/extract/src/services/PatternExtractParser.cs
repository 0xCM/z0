//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    using BP = BytePatternParser<EncodingPatternKind>;

    public readonly struct PatternExtractParser : IExtractParser
    {
        /// <summary>
        /// The default length of the segment removed from the tail of the parsed byte array when the term code is Zx7
        /// </summary>
        const int Zx7Cut = 16;

        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        internal PatternExtractParser(byte[] buffer)
            => Buffer = buffer;

        BP Parser
        {
            [MethodImpl(Inline)]
            get => ExtractParsers.pattern(Buffer.Clear());
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

        BasedCodeBlock Locate(MemoryAddress address, byte[] src, int cut = 0)
        {
            if(cut == 0)
                return new BasedCodeBlock(address, src);
            else
            {
                Span<byte> data = src;
                var len = CalcLength(data, cut, 0xC3);
                var keep = data.Slice(0, len);
                return new BasedCodeBlock(address, keep.ToArray());
            }
        }

        // public ExtractParseResult Parse(in X86ApiExtract src, uint seq)
        // {
        //     try
        //     {
        //         var parser = Parser;
        //         var status = parser.Parse(src.Encoded);
        //         var term = status.HasFailed() ? ExtractTermCode.Fail : parser.Result.ToTermCode();
        //         if(term != ExtractTermCode.Fail)
        //         {
        //             var code = Locate(src.Encoded.Base, parser.Parsed, term == ExtractTermCode.CTC_Zx7 ? Zx7Cut : 0);

        //             var data = new X86ApiMember(src.Member, new X86UriHex(code.Base, src.OpUri, code), (uint)seq, term);
        //             return new ExtractParseResult(new X86MemberRefinement(src, (int)seq, term, code));
        //         }
        //         else
        //             return ExtractParseResult.FromFailure(new ExtractParseFailure(src, (int)seq, term));
        //     }
        //     catch(Exception e)
        //     {
        //         var msg = AppMsg.colorize($"{src.Member.OpUri} extract parse FAIL: {e}", FlairKind.Warning);
        //         term.print(msg);
        //         return ExtractParseResult.FromFailure(new ExtractParseFailure(src, (int)seq, ExtractTermCode.Fail));
        //     }
        // }

        public Outcome<ApiMemberHex> ParseMember(in X86ApiExtract src, uint seq)
        {
            try
            {
                var parser = Parser;
                var status = parser.Parse(src.Encoded);
                var term = status.HasFailed() ? ExtractTermCode.Fail : parser.Result.ToTermCode();
                if(term != ExtractTermCode.Fail)
                {
                    var code = Locate(src.Encoded.Base, parser.Parsed, term == ExtractTermCode.CTC_Zx7 ? Zx7Cut : 0);
                    return new ApiMemberHex(src.Member, new ApiHex(code.Base, src.OpUri, code), seq, term);
                }
                else
                    return z.fail<ApiMemberHex>(term.ToString());
            }
            catch(Exception e)
            {
                return e;
            }
        }

        public ApiHexTable ParseMembers(ReadOnlySpan<X86ApiExtract> src)
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var buffer = alloc<ApiMemberHex>(src.Length);
            ref var dst = ref first(span(buffer));
            for(var i=0u; i<count; i++)
            {
                var outcome = ParseMember(skip(src,i),i);
                if(outcome)
                    seek(dst,i) = outcome.Data;
                else
                    seek(dst,i) = ApiMemberHex.Empty;
            }
            return buffer;
        }
    }
}