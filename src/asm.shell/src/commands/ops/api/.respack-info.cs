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
            var result = Outcome.Success;
            // var respack = OpenResPack();
            // var segment = respack.ResourceSegment;
            // Write(string.Format("Address:{0}", segment.BaseAddress));
            // Write(string.Format("Size:{0}", segment.Size));

            //Cli.ReaderProvider(segment);

            var provider = Wf.ApiResProvider();
            var path = provider.ResPackPath();
            var accessors = provider.ResPackAccessors();
            Write(string.Format("Count:{0}", accessors.Length));
            return result;
        }
    }
}