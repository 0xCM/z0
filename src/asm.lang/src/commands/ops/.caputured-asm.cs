//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".captured-asm")]
        Outcome ShowAsmCapture(CmdArgs args)
        {
            var part = arg(args,0);
            var outcome = ApiPartIdParser.parse(part.Value, out var id);
            if(outcome.Fail)
                return outcome;
            var pack = Wf.ApiPacks().Current();
            var files = pack.CapturedAsm(id);
            iter(files, file => Write(file.ToUri()));

            var spath = pack.AsmStatementSummary();
            var stats = spath.FileStats();
            var formatter = stats.Formatter();
            Write(formatter.FormatKvp(stats));

            return true;
        }
    }
}