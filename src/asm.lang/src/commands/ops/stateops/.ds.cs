//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".ds")]
        Outcome Ds(CmdArgs args)
        {
            if(args.Count != 0)
                DataSource(Workspace.DataSources() + FS.file(arg(args,0).Value));
            Write(DataSource());
            return true;
        }
    }
}