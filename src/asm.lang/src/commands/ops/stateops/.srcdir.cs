//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".srcdir")]
        Outcome SrcDir(CmdArgs args)
        {
            if(args.Length == 0)
            {
                var dir = SrcDir();
                if(dir.IsNonEmpty)
                    Write(dir);
                else
                    Write("! Source directory unspecified");
            }
            else
                Write(SrcDir(FS.dir(arg(args,0).Value)));
            return true;
        }
    }
}