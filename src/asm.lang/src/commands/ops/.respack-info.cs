//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".respack-info")]
        Outcome RespackInfo(CmdArgs args)
        {
            var provider = Wf.ApiResProvider();
            var path = Pipe(provider.ResPackPath());
            var accessors = provider.ResPackAccessors();
            Write(string.Format("Count:{0}", accessors.Length));
            return true;
        }
    }
}