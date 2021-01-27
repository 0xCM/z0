//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using BP = BytePatternParser<EncodingPatternKind>;

    public readonly struct PatternExtractParser
    {
        /// <summary>
        /// The default length of the segment removed from the tail of the parsed byte array when the term code is Zx7
        /// </summary>
        const int Zx7Cut = 7;

        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        internal PatternExtractParser(byte[] buffer)
            => Buffer = buffer;

        BP Parser
        {
            [MethodImpl(Inline)]
            get => ApiExtractParsers.pattern(Buffer.Clear());
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

        CodeBlock Locate(MemoryAddress address, byte[] src, int cut = 0)
        {
            if(cut == 0)
                return new CodeBlock(address, src);
            else
            {
                Span<byte> data = src;
                var len = CalcLength(data, cut, 0xC3);
                var keep = data.Slice(0, len);
                return new CodeBlock(address, keep.ToArray());
            }
        }

        public Outcome<ApiMemberCode> ParseMember(in ApiMemberExtract src, uint seq)
        {
            try
            {
                var parser = Parser;
                var status = parser.Parse(src.Encoded);
                var term = status.HasFailed() ? ExtractTermCode.Fail : parser.Result.ToTermCode();
                if(term != ExtractTermCode.Fail)
                {
                    var code = Locate(src.Encoded.BaseAddress, parser.Parsed, term == ExtractTermCode.CTC_Zx7 ? Zx7Cut : 0);
                    return new ApiMemberCode(src.Member, new ApiCodeBlock(code.BaseAddress, src.OpUri, code), seq, term);
                }
                else
                    return Outcomes.fail<ApiMemberCode>(term.ToString());
            }
            catch(Exception e)
            {
                return e;
            }
        }

        public Index<ApiMemberCode> ParseMembers(ReadOnlySpan<ApiMemberExtract> src)
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var buffer = alloc<ApiMemberCode>(count);
            ref var dst = ref first(span(buffer));
            for(var i=0u; i<count; i++)
            {
                var outcome = ParseMember(skip(src,i),i);
                if(outcome)
                    seek(dst,i) = outcome.Data;
                else
                    seek(dst,i) = ApiMemberCode.Empty;
            }
            return buffer;
        }
    }
}