//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        const string Scope1 = "intel.sdm";

        [CmdOp(".check-digit-parser")]
        public Outcome CheckDigitParser(CmdArgs args)
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
            return true;
        }
    }
}