//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".toolbase")]
        Outcome SelectToolbase(CmdArgs args)
        {
            var name = arg(args,0).Value;
            var root = FS.dir(arg(args,1).Value);
            var selected = _Toolbase.Configure(name, root);
            Write(string.Format("Toolbase {0} selected", selected.Root));
            return true;
        }
    }
}