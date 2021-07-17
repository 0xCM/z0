//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".srcfile")]
        Outcome SrcFile(CmdArgs args)
        {
            if(args.Length == 0)
                Write(SrcDir());
            else
                Write(SrcDir(FS.dir(arg(args,0).Value)));
            return true;
        }
    }
}