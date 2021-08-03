//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".test-digit-parser")]
        public Outcome TestDigitParser(CmdArgs args)
        {
            var cases = DigitParserCases.positive();
            var results = DigitParserCases.run(cases).View;
            var count = results.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var result = ref skip(results,i);
                if(result.Passed)
                    Status(result.Format());
                else
                    Error(result.Format());
            }

            var case0 = "34289";
            parse32u(case0, out var _u32);
            Write(string.Format("{0} ?=? {1:x}", case0, _u32));

            return true;
        }

        public bool parse32u(ReadOnlySpan<char> input, out uint dst)
        {
            const byte MaxDigitCount = 8;
            var storage = 0ul;
            var output = recover<uint4>(bytes(storage));
            dst = 0;
            var count = core.min(input.Length, MaxDigitCount);
            var j=0;
            var outcome = true;
            for(var i=count-1; i>=0; i--)
            {
                ref readonly var c = ref skip(input,i);
                if(DigitParser.digit(@base16, c, out var d))
                    seek(output, j++) = d;
                else
                    return false;
            }

            for(var k=0; k<j; k++)
                dst |= ((uint)skip(output, k) << k*4);
            return true;
        }
    }
}