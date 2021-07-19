//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".clear-captured")]
        public Outcome ClearCaptured(CmdArgs args)
        {
            var outcome = Arg(args, 0, out var part);
            if(PartNames.FindId(part.Value, out var id))
            {
                Wf.ApiCaptureArchive().Clear(id);
            }
            else
                return (false, string.Format("{0} not found", part.Value));
            return outcome;
        }
    }
}