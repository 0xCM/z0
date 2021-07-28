//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".cd")]
        Outcome ChangeDir(CmdArgs args)
        {
            var dst = FS.dir(arg(args,0).Value);
            if(!dst.Exists)
                return (false, FS.missing(dst));

            State.CurrentDir(dst);

            Write(dst);
            return true;
        }
    }
}