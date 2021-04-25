//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static ExtractTermCode;

    using EP = EncodingParser;

    partial struct ApiExtracts
    {
        [Op]
        internal static Outcome<ApiMemberCode> parse(EP parser, in ApiMemberExtract src, uint seq)
        {
            const int Zx7Cut = 7;

            try
            {
                var status = parser.Parse(src.Block.Encoded.View);
                var term = failed(status) ? Fail : termcode(parser.Result);
                if(term != Fail)
                {
                    var code = locate(src.Block.BaseAddress, parser.Parsed, term == CTC_Zx7 ? Zx7Cut : 0);
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
        internal static Index<ApiMemberCode> parse(EP parser, ReadOnlySpan<ApiMemberExtract> src)
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var buffer = alloc<ApiMemberCode>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
            {
                var outcome = parse(parser, skip(src,i), i);
                if(outcome)
                    seek(dst, i) = outcome.Data;
                else
                    seek(dst, i) = ApiMemberCode.Empty;
            }
            return buffer;
        }
    }
}