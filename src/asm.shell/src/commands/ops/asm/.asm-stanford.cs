//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-stanford")]
        Outcome Stanford(CmdArgs args)
        {
            var result = Outcome.Success;

            var forms = LoadStanfordForms();

            return result;
        }
    }
}