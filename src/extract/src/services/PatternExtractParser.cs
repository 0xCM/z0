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

    [ApiHost]
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
            get => ApiCodeExtractors.patterns(Buffer.Clear());
        }

        [Op]
        CodeBlock Locate(MemoryAddress address, byte[] src, int cut)
        {
            if(cut == 0)
                return new CodeBlock(address, src);
            else
            {
                Span<byte> data = src;
                var len = data.ExtractLength(cut, 0xC3);
                var keep = data.Slice(0, len);
                return new CodeBlock(address, keep.ToArray());
            }
        }

        [Op]
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

        [Op]
        public Index<ApiMemberCode> ParseMembers(ReadOnlySpan<ApiMemberExtract> src)
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var buffer = alloc<ApiMemberCode>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
            {
                var outcome = ParseMember(skip(src,i), i);
                if(outcome)
                    seek(dst, i) = outcome.Data;
                else
                    seek(dst, i) = ApiMemberCode.Empty;
            }
            return buffer;
        }
    }
}